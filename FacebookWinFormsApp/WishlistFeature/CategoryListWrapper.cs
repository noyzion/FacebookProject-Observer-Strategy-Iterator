﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class CategoryListWrapper
    {
        public string KeyCategory { get; set; }
        public List<WishlistItem> ListOfWishlists { get; set; }
        public CategoryListWrapper() { }
        public CategoryListWrapper(string i_Key, List<WishlistItem> i_Value)
        {
            KeyCategory = i_Key;
            ListOfWishlists = i_Value;
        }
    }
}