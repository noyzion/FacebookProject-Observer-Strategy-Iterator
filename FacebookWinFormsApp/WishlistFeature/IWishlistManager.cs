using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IWishlistManager
    {
        WishListItem AddWishToWishlistValues(string i_Category, string i_ItemName, string i_PhotoUrl);
        void RemoveWishFromWishlistValues(string i_Category, WishListItem i_ItemToRemove);
        List<WishListItem> GetItemsByCategory(string i_Category);
        WishListItem FindWishListItemByName(string i_Category, string i_ItemName);
    }
}