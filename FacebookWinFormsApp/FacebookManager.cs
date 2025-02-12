using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FacebookManager
    {
        private readonly FacebookWrapper.LoginResult r_LoginResult;

        public FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            r_LoginResult = i_LoginResult;
        }
        public FacebookObjectCollection<Group> FetchGroups()
        {
            return r_LoginResult.LoggedInUser.Groups;
        }
        public FacebookObjectCollection<Album> FetchAlbums()
        {
            return r_LoginResult.LoggedInUser.Albums;
        }
        public FacebookObjectCollection<User> FetchFriends()
        {
            return r_LoginResult.LoggedInUser.Friends;
        }
        public FacebookObjectCollection<Post> FetchPosts()
        {
            return r_LoginResult.LoggedInUser.Posts;
        }
        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            return r_LoginResult.LoggedInUser.LikedPages;
        }
        public FacebookObjectCollection<Event> FetchEvents()
        {
            return r_LoginResult.LoggedInUser.Events;
        }
        public Status PostStatus(string i_Message)
        {
            return r_LoginResult.LoggedInUser.PostStatus(i_Message);
        }
        public Post PostPhoto(string i_FilePath)
        {
            return r_LoginResult.LoggedInUser.PostPhoto(i_FilePath);
        }
        public void PostVideo(string i_FilePath)
        {
            r_LoginResult.LoggedInUser.PostPhoto(i_FilePath);
        }
        public void InviteFriendsForWorkout(FacebookObjectCollection<User> i_Friends)
        {
            if (i_Friends == null || i_Friends.Count == 0)
            {
                throw new ArgumentException("No friends selected for the invitation.");
            }

            foreach (var friend in i_Friends)
            {
                try
                {
                    PostStatus($"Hi {friend.Name}, join me for a workout session!");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error inviting {friend.Name}: {ex.Message}", ex);
                }
            }
        }
    }
}
