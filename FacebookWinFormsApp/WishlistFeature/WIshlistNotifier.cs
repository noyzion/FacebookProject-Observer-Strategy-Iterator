using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class WishlistNotifier : IWishlistObserver
    {
        private bool m_CompletionMessageShown = false;

        public void Update(List<CategoryListWrapper> i_WishlistValues)
        {
            int totalItems = countTotalItems(i_WishlistValues);
            int completedItems = countCompletedItems(i_WishlistValues);

            handleCompletionMessage(totalItems, completedItems);
        }
        private int countTotalItems(List<CategoryListWrapper> i_Categories)
        {
            int count = 0;

            foreach (var category in i_Categories)
            {
                count += category.ListOfWishlists.Count;
            }

            return count;
        }
        private int countCompletedItems(List<CategoryListWrapper> i_Categories)
        {
            int count = 0;

            foreach (var category in i_Categories)
            {
                foreach (var item in category.ListOfWishlists)
                {
                    if (item.Checked)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        private void handleCompletionMessage(int i_TotalItems, int i_CompletedItems)
        {
            if (i_TotalItems > 0 && i_CompletedItems == i_TotalItems && !m_CompletionMessageShown)
            {
                MessageBox.Show("Congratulations! You've completed your entire wishlist!", "Wishlist Complete",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_CompletionMessageShown = true;
            }
            else if (i_CompletedItems < i_TotalItems)
            {
                m_CompletionMessageShown = false;
            }
        }
    }
}