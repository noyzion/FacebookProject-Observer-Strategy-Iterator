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
            int totalItems = i_WishlistValues.Sum(category => category.ListOfWishlists.Count);
            int completedItems = i_WishlistValues.Sum(category => category.ListOfWishlists.Count(item => item.Checked));

            if (totalItems > 0 && completedItems == totalItems && !m_CompletionMessageShown)
            {
                MessageBox.Show("Congratulations! You've completed your entire wishlist!", "Wishlist Complete",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_CompletionMessageShown = true; 
            }
            else if (completedItems < totalItems)
            {
                m_CompletionMessageShown = false;
            }
        }
    }
}
