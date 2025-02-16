// WishlistLogic.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class WishlistManager : IWishlistManager
    {
        private readonly List<IWishlistObserver> r_Observers;
        public List<CategoryListWrapper> WishlistValues { get; set; }
        public WishlistManager()
        {
            WishlistValues = new List<CategoryListWrapper>();
            r_Observers = new List<IWishlistObserver>();
        }
        public WishlistItem AddWishToWishlistValues(string i_Category, string i_ItemName, string i_PhotoUrl)
        {
            WishlistItem newItem = createWishListItem(i_ItemName, i_PhotoUrl);
            CategoryListWrapper existingCategoryList = WishlistValues.FirstOrDefault(kvp => kvp.KeyCategory == i_Category);

            if (existingCategoryList == null)
            {
                WishlistValues.Add(new CategoryListWrapper(i_Category, new List<WishlistItem> { newItem }));
            }
            else
            {
                if (!existingCategoryList.ListOfWishlists.Contains(newItem))
                {
                    existingCategoryList.ListOfWishlists.Add(newItem);
                }
                else
                {
                    throw new Exception("You can't add two items with the same name to the same list!");
                }
            }

            NotifyObservers();

            return newItem;
        }
        private WishlistItem createWishListItem(string i_Text, string i_PhotoUrl)
        {
            WishlistItem newItem;

            if (!string.IsNullOrEmpty(i_PhotoUrl))
            {
                newItem = new WishlistItem(i_Text, i_PhotoUrl);
            }
            else
            {
                newItem = new WishlistItem(i_Text);
            }

            return newItem;
        }
        public void RemoveWishFromWishlistValues(string i_Category, WishlistItem i_ItemToRemove)
        {
            CategoryListWrapper existingCategory = WishlistValues.FirstOrDefault(kvp => kvp.KeyCategory == i_Category);

            if (existingCategory != null)
            {
                existingCategory.ListOfWishlists.Remove(i_ItemToRemove);
                if (existingCategory.ListOfWishlists.Count == 0)
                {
                    WishlistValues.Remove(existingCategory);
                }
            }

            NotifyObservers();
        }
        public List<WishlistItem> GetItemsByCategory(string i_Category)
        {
            List<WishlistItem> items;

            if (WishlistValues == null)
            {
                items = null;
            }

            items = WishlistValues.FirstOrDefault(kvp => kvp.KeyCategory == i_Category)?.ListOfWishlists ?? new List<WishlistItem>();

            return items;
        }
        public WishlistItem FindWishListItemByName(string i_Category, string i_ItemName)
        {
            return WishlistValues
                .FirstOrDefault(kvp => kvp.KeyCategory.Equals(i_Category, StringComparison.OrdinalIgnoreCase))
                ?.ListOfWishlists
                .FirstOrDefault(item => item.Text.Equals(i_ItemName, StringComparison.OrdinalIgnoreCase));
        }
        public void AddObserver(IWishlistObserver i_Observer)
        {
            r_Observers.Add(i_Observer);
        }
        public void RemoveObserver(IWishlistObserver i_Observer)
        {
            r_Observers.Remove(i_Observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in r_Observers)
            {
                observer.Update(WishlistValues);
            }
        }
        public void MarkItem(EWishlistCategories i_Category, string i_ItemName, bool i_Checked)
        {
            CategoryListWrapper foundCategory = findCategory(i_Category);

            if (foundCategory != null)
            {
                WishlistItem foundItem = findItemInCategory(foundCategory, i_ItemName);

                if (foundItem != null)
                {
                    markItemAndNotify(foundItem, i_Checked);
                }
            }

            NotifyObservers();
        }
        private CategoryListWrapper findCategory(EWishlistCategories i_Category)
        {
            string categoryName = i_Category.ToString();

            foreach (var category in WishlistValues)
            {
                if (category.KeyCategory.ToLower() == categoryName)
                {
                    return category;
                }
            }

            return null;
        }
        private WishlistItem findItemInCategory(CategoryListWrapper i_Category, string i_ItemName)
        {
            foreach (var item in i_Category.ListOfWishlists)
            {
                if (item.Text == i_ItemName)
                {
                    return item;
                }
            }

            return null;
        }
        private void markItemAndNotify(WishlistItem i_Item, bool i_Checked)
        {
            i_Item.Checked = i_Checked;
            NotifyObservers();
        }
    }
}