using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class WishlistProgressTracker : IWishlistObserver
    {
        private ProgressBar m_ProgressBar;

        public WishlistProgressTracker(ProgressBar i_ProgressBar)
        {
            m_ProgressBar = i_ProgressBar;
        }

        public void Update(List<CategoryListWrapper> i_WishlistValues)
        {
            int totalItems = i_WishlistValues.Sum(category => category.ListOfWishlists.Count);
            int completedItems = i_WishlistValues.Sum(category => category.ListOfWishlists.Count(item => item.Checked));
            int progress = totalItems > 0 ? (completedItems * 100 / totalItems) : 0;

            m_ProgressBar.Value = progress;
        }
    }
}
