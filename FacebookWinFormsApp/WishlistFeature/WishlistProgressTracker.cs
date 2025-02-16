using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class WishlistProgressTracker : IWishlistObserver
    {
        private readonly ProgressBar r_ProgressBar;

        public WishlistProgressTracker(ProgressBar i_ProgressBar)
        {
            r_ProgressBar = i_ProgressBar;
        }
        public void Update(List<CategoryListWrapper> i_WishlistValues)
        {
            int totalItems = countTotalItems(i_WishlistValues);
            int completedItems = countCompletedItems(i_WishlistValues);
            int progress = calculateProgress(totalItems, completedItems);

            updateProgressBar(progress);
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
        private int calculateProgress(int i_TotalItems, int i_CompletedItems)
        {
            return i_TotalItems > 0 ? (i_CompletedItems * 100 / i_TotalItems) : 0;
        }
        private void updateProgressBar(int i_Progress)
        {
            r_ProgressBar.Value = i_Progress;
        }
    }
}