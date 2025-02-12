using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class WishListItem
    {
        public string Text { get; set; }
        public string PhotoUrl { get; set; }
        public bool Checked { get; set; }
        public WishListItem() { }
        public WishListItem(string i_Text, string i_PhotoUrl)
        {
            Text = i_Text;
            PhotoUrl = i_PhotoUrl;
        }
        public WishListItem(string i_Text)
        {
            Text = i_Text;
            PhotoUrl = null;
        }
        public override bool Equals(object i_Obj)
        {
            if (i_Obj == null || i_Obj.GetType() != this.GetType())
            {
                return false;
            }

            WishListItem other = (WishListItem)i_Obj;

            return Text == other.Text;
        }
        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
    }
}