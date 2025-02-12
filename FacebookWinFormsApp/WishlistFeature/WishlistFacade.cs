using BasicFacebookFeatures;
using System.Linq;
using System.Text;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
namespace BasicFacebookFeatures
{
    public class WishlistFacade
    {
        public WishlistManager WishlistManager { get; set; }
        private readonly WishlistManagerUI r_WishlistUIManager;

        public WishlistFacade()
        {
            WishlistManager = new WishlistManager();
            r_WishlistUIManager = new WishlistManagerUI();
        }
        public WishListItem AddWish(string i_Category, string i_ItemName, string i_PhotoUrl)
        {
            return WishlistManager.AddWishToWishlistValues(i_Category, i_ItemName, i_PhotoUrl);
        }
        public void RemoveWish(string i_Category, WishListItem i_ItemToRemove)
        {
            WishlistManager.RemoveWishFromWishlistValues(i_Category, i_ItemToRemove);
        }
        public void UpdateUI(CheckedListBox i_FoodListBox, CheckedListBox i_PetsListBox,
                             CheckedListBox i_ActivitiesListBox, CheckedListBox i_ShoppingListBox,
                             string i_Category, WishListItem i_WishListItem)
        {
            r_WishlistUIManager.UpdateCheckedListBox(i_FoodListBox, i_PetsListBox, i_ActivitiesListBox, i_ShoppingListBox, i_Category, i_WishListItem);
        }
        public void ResetUI(CheckedListBox i_FoodListBox, CheckedListBox i_PetsListBox,
                            CheckedListBox i_ActivitiesListBox, CheckedListBox i_ShoppingListBox)
        {
            r_WishlistUIManager.ResetWishlistUI(i_FoodListBox, i_PetsListBox, i_ActivitiesListBox, i_ShoppingListBox);
        }
        public WishListItem FindWishListItemByName(string i_Category, string i_ItemName)
        {
            return WishlistManager.GetItemsByCategory(i_Category).FirstOrDefault(item => item.Text == i_ItemName);
        }
        public void LoadImageForPictureBoxInList(WishListItem i_WishListItem, PictureBox i_PictureBox)
        {
            if (!string.IsNullOrEmpty(i_WishListItem?.PhotoUrl))
            {
                try
                {
                    i_PictureBox.Image = Image.FromFile(i_WishListItem.PhotoUrl);
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
        }
        public string ShareWishlist(CheckedListBox i_FoodListBox, CheckedListBox i_ActivitiesListBox,
                                    CheckedListBox i_PetsListBox, CheckedListBox i_ShoppingListBox)
        {
            var wishlistSummary = new StringBuilder("My Wishlist:\n");

            wishlistSummary.AppendLine($"Food: {getCheckedItems(i_FoodListBox)}");
            wishlistSummary.AppendLine($"Activities: {getCheckedItems(i_ActivitiesListBox)}");
            wishlistSummary.AppendLine($"Pets: {getCheckedItems(i_PetsListBox)}");
            wishlistSummary.AppendLine($"Shopping: {getCheckedItems(i_ShoppingListBox)}");
            r_WishlistUIManager.DisplayCombinedWishlistPopup(i_FoodListBox, i_ActivitiesListBox, i_PetsListBox, i_ShoppingListBox);

            return wishlistSummary.ToString();
        }
        private string getCheckedItems(CheckedListBox i_ListBox)
        {
            return string.Join(", ", i_ListBox.Items.Cast<WishListItem>().Where(item => item.Checked).Select(item => item.Text));
        }
        public WishListItem FindAndHighlightItem(string i_Category, string i_ItemName, PictureBox i_PictureBox, Button i_DeleteButton)
        {
            WishListItem item = WishlistManager.FindWishListItemByName(i_Category, i_ItemName);

            r_WishlistUIManager.HighlightItemInList(item, i_PictureBox, i_DeleteButton);

            return item;
        }
        public List<WishListItem> GetItemsByCategory(string i_Category)
        {
            return WishlistManager.GetItemsByCategory(i_Category);
        }
    }
}