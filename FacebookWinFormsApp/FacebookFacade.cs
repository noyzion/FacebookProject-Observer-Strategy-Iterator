using Facebook;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FacebookFacade
    {
        private readonly FacebookManager r_FacebookLogic;
        private readonly FacebookManagerUI r_FacebookUI;

        public FacebookFacade(FacebookWrapper.LoginResult i_LoginResult)
        {
            r_FacebookLogic = new FacebookManager(i_LoginResult);
            r_FacebookUI = new FacebookManagerUI(r_FacebookLogic);
        }
        public void FetchGroups(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchGroups(i_DataListBox);
        }
        public void FetchAlbums(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchAlbums(i_DataListBox);
        }
        public void FetchFriends(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchFriends(i_DataListBox);
        }
        public void FetchPosts(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchPosts(i_DataListBox);
        }
        public void FetchLikedPages(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchLikedPages(i_DataListBox);
        }
        public void FetchEvents(ListBox i_DataListBox)
        {
            r_FacebookUI.FetchEvents(i_DataListBox);
        }
        public void PostStatus(string i_Message, TextBox i_StatusTextBox)
        {
            r_FacebookUI.PostStatus(i_Message, i_StatusTextBox);
        }
        public void PostPhoto(string i_FilePath)
        {
            r_FacebookUI.PostPhoto(i_FilePath);
        }
        public void PostVideo(string i_FilePath)
        {
            r_FacebookUI.PostVideo(i_FilePath);
        }
        public string SelectPhotoFile()
        {
            return r_FacebookUI.SelectPhotoFile();
        }
        public string SelectVideoFile()
        {
            return r_FacebookUI.SelectVideoFile();
        }
        public void MakeFriendsPanel(ref TableLayoutPanel io_DataPanel, User i_User, PictureBox i_PictureBoxProfile)
        {
            r_FacebookUI.MakeFriendsPanel(ref io_DataPanel, i_User, i_PictureBoxProfile);
        }
        public void MakeGroupsPanel(ref TableLayoutPanel io_DataPanel, Group i_Group, PictureBox i_PictureBoxProfile)
        {
            r_FacebookUI.MakeGroupsPanel(ref io_DataPanel, i_Group, i_PictureBoxProfile);
        }
        public void MakePagePanel(ref TableLayoutPanel io_DataPanel, Page i_Page, PictureBox i_PictureBoxProfile)
        {
            r_FacebookUI.MakePagePanel(ref io_DataPanel, i_Page, i_PictureBoxProfile);
        }
        public void MakeEventPanel(ref TableLayoutPanel io_DataPanel, Event i_FbEvent)
        {
            r_FacebookUI.MakeEventPanel(ref io_DataPanel, i_FbEvent);
        }
        public void MakeAlbumPanel(ref TableLayoutPanel io_DataPanel, ListBox i_DataListBox,
                                    Album i_Album, PictureBox i_PictureBoxProfile, BindingSource i_AlbumBindingSource)
        {
            r_FacebookUI.MakeAlbumPanel(ref io_DataPanel, i_Album,
                                        i_DataListBox, i_PictureBoxProfile, i_AlbumBindingSource);
        }
        public void MakePostPanel(ref TableLayoutPanel io_DataPanel, Post i_Post)
        {
            r_FacebookUI.MakePostPanel(ref io_DataPanel, i_Post);
        }
        public void InviteFriends(FacebookObjectCollection<User> i_Friends)
        {
            r_FacebookLogic.InviteFriendsForWorkout(i_Friends);
        }
    }
}
