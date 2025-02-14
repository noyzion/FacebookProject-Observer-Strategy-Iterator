using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IWishlistManager
    {
        WishlistItem AddWishToWishlistValues(string i_Category, string i_ItemName, string i_PhotoUrl);
        void RemoveWishFromWishlistValues(string i_Category, WishlistItem i_ItemToRemove);
        List<WishlistItem> GetItemsByCategory(string i_Category);
        WishlistItem FindWishListItemByName(string i_Category, string i_ItemName);
        void AddObserver(IWishlistObserver i_Observer);
        void RemoveObserver(IWishlistObserver i_Observer);
        void MarkItemAsCompleted(EWishlistCategories i_Category, string i_ItemName);
    }
}