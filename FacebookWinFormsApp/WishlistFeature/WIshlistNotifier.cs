using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.WishlistFeature
{
    public class WishlistNotifier : IWishlistObserver
    {
        public void Update(List<WishListItem> i_Wishlist)
        {
            var completedItems = i_Wishlist.Where(item => item.Checked).ToList();
            var totalItems = i_Wishlist.Count;

            string message = $"Wishlist updated: {completedItems.Count} of {totalItems} items completed.";
            MessageBox.Show(message, "Wishlist Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
