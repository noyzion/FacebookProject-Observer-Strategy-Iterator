using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.WishlistFeature
{
    public class WishlistProgressTracker : IWishlistObserver
    {
        private ProgressBar m_ProgressBar;

        public WishlistProgressTracker(ProgressBar i_ProgressBar)
        {
            m_ProgressBar = i_ProgressBar;
        }

        public void Update(List<WishListItem> i_Wishlist)
        {
            int totalItems = i_Wishlist.Count;
            int completedItems = i_Wishlist.Count(item => item.Checked);

            int progress = totalItems > 0 ? (completedItems * 100 / totalItems) : 0;
            m_ProgressBar.Value = progress;
            Console.WriteLine($"Wishlist Progress Updated: {progress}%");
        }
    }

}
