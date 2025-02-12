using BasicFacebookFeatures;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;

namespace BasicFacebookFeatures
{
    public class WishlistManagerUI
    {
        private const int k_PopUpWidthSize = 870;
        private const int k_PopUpHeightSize = 580;
        private const int k_WidthPanelSize = 200;
        private const int k_HeightPanelSize = 500;
        private const int k_Padding = 5;
        private const int k_ItemHeight = 100;
        private const int k_ItemWidth = 180;
        private const int k_PictureBoxItemSize = 60;
        private const int k_PictureBoxLocationX = 5;
        private const int k_PictureBoxLocationY = 30;

        public void UpdateCheckedListBox(CheckedListBox i_FoodListBox, CheckedListBox i_PetsListBox,
                                         CheckedListBox i_ActivitiesListBox, CheckedListBox i_ShoppingListBox,
                                         string i_Category, WishListItem i_WishlistItem)
        {
            switch (i_Category)
            {
                case nameof(EWishlistCategories.Food):
                    i_FoodListBox.Items.Add(i_WishlistItem);
                    break;
                case nameof(EWishlistCategories.Shopping):
                    i_ShoppingListBox.Items.Add(i_WishlistItem);
                    break;
                case nameof(EWishlistCategories.Activities):
                    i_ActivitiesListBox.Items.Add(i_WishlistItem);
                    break;
                case nameof(EWishlistCategories.Pets):
                    i_PetsListBox.Items.Add(i_WishlistItem);
                    break;
                default:
                    throw new ArgumentException("Invalid category.");
            }
        }

        public void ResetWishlistUI(CheckedListBox i_FoodListBox, CheckedListBox i_PetsListBox,
                                     CheckedListBox i_ActivitiesListBox, CheckedListBox i_ShoppingListBox)
        {
            i_FoodListBox.Items.Clear();
            i_PetsListBox.Items.Clear();
            i_ActivitiesListBox.Items.Clear();
            i_ShoppingListBox.Items.Clear();
        }
        public void HighlightItemInList(WishListItem i_Item, PictureBox i_PictureBox, Button i_DeleteButton)
        {
            if (i_Item != null)
            {
                if (!string.IsNullOrEmpty(i_Item.PhotoUrl))
                {
                    try
                    {
                        i_PictureBox.Image = Image.FromFile(i_Item.PhotoUrl);
                        i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load image: {ex.Message}");
                    }
                }
                else
                {
                    i_PictureBox.Image = null;
                }

                i_DeleteButton.Enabled = true;
            }
            else
            {
                i_PictureBox.Image = null;
                i_DeleteButton.Enabled = false;
            }
        }
        public void DisplayCombinedWishlistPopup(CheckedListBox i_FoodListBox, CheckedListBox i_ActivitiesListBox,
                                              CheckedListBox i_PetsListBox, CheckedListBox i_ShoppingListBox)
        {
            Form popupForm = new Form
            {
                Text = "My Wishlist",
                Size = new Size(k_PopUpWidthSize, k_PopUpHeightSize),
                StartPosition = FormStartPosition.CenterScreen,
                AutoScroll = true
            };
            FlowLayoutPanel mainPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(10)
            };

            mainPanel.Controls.Add(createCategoryPanel("Food", i_FoodListBox));
            mainPanel.Controls.Add(createCategoryPanel("Activities", i_ActivitiesListBox));
            mainPanel.Controls.Add(createCategoryPanel("Pets", i_PetsListBox));
            mainPanel.Controls.Add(createCategoryPanel("Shopping", i_ShoppingListBox));
            popupForm.Controls.Add(mainPanel);
            popupForm.ShowDialog();
        }
        private Panel createCategoryPanel(string i_Category, CheckedListBox i_CheckedListBox)
        {
            FlowLayoutPanel categoryPanel = createCategoryPanelLayout();
            Label categoryLabel = createCategoryLabel(i_Category);

            categoryPanel.Controls.Add(categoryLabel);
            if (i_CheckedListBox.Items.Count > 0)
            {
                foreach (WishListItem item in i_CheckedListBox.Items)
                {
                    Panel itemPanel = createItemPanel(item);

                    categoryPanel.Controls.Add(itemPanel);
                }
            }
            else
            {
                Label emptyMessage = createEmptyMessageLabel();

                categoryPanel.Controls.Add(emptyMessage);
            }

            return categoryPanel;
        }
        private FlowLayoutPanel createCategoryPanelLayout()
        {
            return new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Size = new Size(k_WidthPanelSize, k_HeightPanelSize),
                Padding = new Padding(k_Padding),
                BorderStyle = BorderStyle.FixedSingle
            };
        }
        private Label createCategoryLabel(string i_Category)
        {
            return new Label
            {
                Text = i_Category,
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Margin = new Padding(k_Padding)
            };
        }
        private Panel createItemPanel(WishListItem i_WishlistItem)
        {
            Panel itemPanel = new Panel
            {
                Size = new Size(k_ItemWidth, k_ItemHeight),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(k_Padding)
            };
            Label labelWishlistItem = createItemLabel(i_WishlistItem);
            PictureBox pictureBoxWishlistItem = createItemPictureBox(i_WishlistItem);

            itemPanel.Controls.Add(labelWishlistItem);
            itemPanel.Controls.Add(pictureBoxWishlistItem);

            return itemPanel;
        }
        private Label createItemLabel(WishListItem i_WishlistItem)
        {
            return new Label
            {
                Text = $"{i_WishlistItem.Text}" + (i_WishlistItem.Checked ? " (Achieved ✅)" : ""),
                AutoSize = true,
                Location = new Point(k_Padding, k_Padding),
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
        }
        private PictureBox createItemPictureBox(WishListItem i_WishlistItem)
        {
            PictureBox pictureBoxItem = new PictureBox
            {
                Size = new Size(k_PictureBoxItemSize, k_PictureBoxItemSize),
                Location = new Point(k_PictureBoxLocationX, k_PictureBoxLocationY),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (!string.IsNullOrEmpty(i_WishlistItem.PhotoUrl) && File.Exists(i_WishlistItem.PhotoUrl))
            {
                pictureBoxItem.Image = Image.FromFile(i_WishlistItem.PhotoUrl);
            }
            else
            {
                pictureBoxItem.Image = null;
            }

            return pictureBoxItem;
        }
        private Label createEmptyMessageLabel()
        {
            return new Label
            {
                Text = "No items in this category.",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Italic),
                ForeColor = Color.Gray,
                Margin = new Padding(k_Padding)
            };
        }
    }
}
