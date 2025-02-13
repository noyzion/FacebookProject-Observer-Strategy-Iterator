using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.WishlistFeature
{
    public interface IWishlistObserver
    {
        void Update(List<WishListItem> i_Wishlist);
    }

}
