using CefSharp.DevTools.IndexedDB;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FacebookManagerUI
    {
        private const int k_AlbumFormWidth = 450;
        private const int k_AlbumFormHeight = 600;
        private const int k_PictureInAlbumSize = 200;
        private readonly FacebookManager r_FacebookLogic;
        private readonly object r_FetchLock = new object();
        private readonly object r_PostLock = new object();
        private readonly Dictionary<string, string> r_SavedMessages = new Dictionary<string, string>();

        public FacebookManagerUI(FacebookManager i_FacebookLogic)
        {
            r_FacebookLogic = i_FacebookLogic;
        }
        public void FetchGroups(ListBox i_DataListBox)
        {
            Thread fetchGroupsThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<Group> groups = r_FacebookLogic.FetchGroups();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "Name";
                            foreach (var group in groups)
                            {
                                i_DataListBox.Items.Add(group);
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No groups to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching groups: {ex.Message}")));
                }
            });

            fetchGroupsThread.Start();
        }
        public void FetchAlbums(ListBox i_DataListBox)
        {
            Thread fetchAlbumsThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<Album> albums = r_FacebookLogic.FetchAlbums();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "Name";
                            foreach (var album in albums)
                            {
                                i_DataListBox.Items.Add(album);
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No albums to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching albums: {ex.Message}")));
                }
            });

            fetchAlbumsThread.Start();
        }
        public void FetchFriends(ListBox i_DataListBox)
        {
            Thread fetchFriendsThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<User> friends = r_FacebookLogic.FetchFriends();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "Name";
                            foreach (var friend in friends)
                            {
                                i_DataListBox.Items.Add(friend);
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No friends to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching friends: {ex.Message}")));
                }
            });

            fetchFriendsThread.Start();
        }
        public void FetchPosts(ListBox i_DataListBox)
        {
            Thread fetchPostsThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<Post> posts = r_FacebookLogic.FetchPosts();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "UpdateTime";
                            foreach (var post in posts)
                            {
                                if (post.Message != null || post.PictureURL != null)
                                {
                                    i_DataListBox.Items.Add(post);
                                }
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No posts to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching posts: {ex.Message}")));
                }
            });

            fetchPostsThread.Start();
        }
        public void FetchLikedPages(ListBox i_DataListBox)
        {
            Thread fetchLikedPagesThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<Page> likedPages = r_FacebookLogic.FetchLikedPages();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "Name";
                            foreach (var page in likedPages)
                            {
                                i_DataListBox.Items.Add(page);
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No liked pages to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching liked pages: {ex.Message}")));
                }
            });

            fetchLikedPagesThread.Start();
        }
        public void FetchEvents(ListBox i_DataListBox)
        {
            Thread fetchEventsThread = new Thread(() =>
            {
                try
                {
                    lock (r_FetchLock)
                    {
                        FacebookObjectCollection<Event> events = r_FacebookLogic.FetchEvents();

                        i_DataListBox.Invoke(new Action(() =>
                        {
                            i_DataListBox.DataSource = null;
                            i_DataListBox.Items.Clear();
                            i_DataListBox.DisplayMember = "Name";
                            foreach (var fbEvent in events)
                            {
                                i_DataListBox.Items.Add(fbEvent);
                            }

                            if (i_DataListBox.Items.Count == 0)
                            {
                                MessageBox.Show("No events to retrieve :(");
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    i_DataListBox.Invoke(new Action(() => MessageBox.Show($"Error fetching events: {ex.Message}")));
                }
            });

            fetchEventsThread.Start();
        }
        public void PostStatus(string i_Message, TextBox i_StatusTextBox)
        {
            Thread postThread = new Thread(() =>
            {
                lock (r_PostLock)
                {
                    try
                    {
                        Status postedStatus = r_FacebookLogic.PostStatus(i_Message);

                        i_StatusTextBox.Invoke(new Action(() => MessageBox.Show($"Status posted! ID: {postedStatus.Id}")));
                    }
                    catch (Exception ex)
                    {
                        i_StatusTextBox.Invoke(new Action(() => MessageBox.Show(ex.ToString())));
                    }
                    finally
                    {
                        i_StatusTextBox.Invoke(new Action(() => i_StatusTextBox.Clear()));
                    }
                }
            });

            postThread.Start();
        }
        public void PostPhoto(string i_FilePath)
        {
            try
            {
                Post post = r_FacebookLogic.PostPhoto(i_FilePath);

                MessageBox.Show("Photo posted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error posting photo: {ex.Message}");
            }
        }
        public void PostVideo(string i_FilePath)
        {
            try
            {
                r_FacebookLogic.PostVideo(i_FilePath);
                MessageBox.Show("Video posted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error posting video: {ex.Message}");
            }
        }
        public string SelectPhotoFile()
        {
            string selectedFilePath = null;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Select a Picture to Upload";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFilePath = openFileDialog.FileName;
                    }
                }

                return selectedFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
        public string SelectVideoFile()
        {
            string selectedFilePath = null;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv;*.flv";
                    openFileDialog.Title = "Select a Video File to Upload";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFilePath = openFileDialog.FileName;
                    }
                }

                return selectedFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
        public void MakeFriendsPanel(ref TableLayoutPanel io_DataPanel, User i_User, PictureBox i_PictureBoxProfile)
        {
            try
            {
                Label nameLabel = new Label
                {
                    Text = $"Name: {i_User.Name}",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5)
                };
                Label birthdayLabel = new Label
                {
                    Text = $"Birthday: {i_User.Birthday}",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Padding = new Padding(5)
                };
                PictureBox userPictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (!string.IsNullOrEmpty(i_User.PictureNormalURL))
                {
                    userPictureBox.ImageLocation = i_User.PictureNormalURL;
                }
                else
                {
                    userPictureBox.Image = i_PictureBoxProfile.ErrorImage;
                }

                io_DataPanel.Controls.Add(nameLabel);
                io_DataPanel.Controls.Add(birthdayLabel);
                io_DataPanel.Controls.Add(userPictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying friend details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakeGroupsPanel(ref TableLayoutPanel io_DataPanel, Group i_Group, PictureBox i_PictureBoxProfile)
        {
            try
            {
                if (i_Group != null)
                {
                    Label nameLabel = new Label
                    {
                        Text = $"Group Name: {i_Group.Name}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5)
                    };
                    Label membersLabel = new Label
                    {
                        Text = $"Members: {i_Group.Members.Count}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    Label privacyLabel = new Label
                    {
                        Text = $"Privacy: {i_Group.Privacy}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    PictureBox groupPicture = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(100, 100),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    if (!string.IsNullOrEmpty(i_Group.PictureNormalURL))
                    {
                        groupPicture.ImageLocation = i_Group.PictureNormalURL;
                    }
                    else
                    {
                        groupPicture.Image = i_PictureBoxProfile.ErrorImage;
                    }

                    io_DataPanel.Controls.Add(nameLabel);
                    io_DataPanel.Controls.Add(membersLabel);
                    io_DataPanel.Controls.Add(privacyLabel);
                    io_DataPanel.Controls.Add(groupPicture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying group details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakePagePanel(ref TableLayoutPanel io_DataPanel, Page i_Page, PictureBox i_PictureBoxProfile)
        {
            try
            {
                if (i_Page != null)
                {
                    Label nameLabel = new Label
                    {
                        Text = $"Page Name: {i_Page.Name}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5)
                    };
                    Label categoryLabel = new Label
                    {
                        Text = $"Category: {i_Page.Category}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    Label likesLabel = new Label
                    {
                        Text = $"Likes: {i_Page.LikesCount}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    PictureBox pagePicture = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(100, 100),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    if (!string.IsNullOrEmpty(i_Page.PictureURL))
                    {
                        pagePicture.ImageLocation = i_Page.PictureURL;
                    }
                    else
                    {
                        pagePicture.Image = i_PictureBoxProfile.ErrorImage;
                    }

                    io_DataPanel.Controls.Add(nameLabel);
                    io_DataPanel.Controls.Add(categoryLabel);
                    io_DataPanel.Controls.Add(likesLabel);
                    io_DataPanel.Controls.Add(pagePicture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying page details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakeEventPanel(ref TableLayoutPanel io_DataPanel, Event i_FbEvent)
        {
            try
            {
                if (i_FbEvent != null)
                {
                    Label nameLabel = new Label
                    {
                        Text = $"Event Name: {i_FbEvent.Name}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Padding = new Padding(5)
                    };
                    Label descriptionLabel = new Label
                    {
                        Text = $"Description: {i_FbEvent.Description}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    Label startTimeLabel = new Label
                    {
                        Text = $"Start Time: {i_FbEvent.StartTime}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    Label endTimeLabel = new Label
                    {
                        Text = $"End Time: {i_FbEvent.EndTime}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };
                    Label locationLabel = new Label
                    {
                        Text = $"Location: {i_FbEvent.Location}",
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Padding = new Padding(5)
                    };

                    io_DataPanel.Controls.Add(nameLabel);
                    io_DataPanel.Controls.Add(descriptionLabel);
                    io_DataPanel.Controls.Add(startTimeLabel);
                    io_DataPanel.Controls.Add(endTimeLabel);
                    io_DataPanel.Controls.Add(locationLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying event details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakePostPanel(ref TableLayoutPanel io_DataPanel, Post i_Post)
        {
            try
            {
                if (i_Post == null)
                {
                    MessageBox.Show("Post cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Label messageLabel = new Label
                {
                    AutoSize = true,
                    Text = r_SavedMessages.ContainsKey(i_Post.Id) ? r_SavedMessages[i_Post.Id] : i_Post.Message,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5)
                };

                io_DataPanel.Controls.Add(new Label
                {
                    Text = "Message:",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Padding = new Padding(5)
                });
                io_DataPanel.Controls.Add(messageLabel);
                Button editPostButton = new Button
                {
                    Text = "Edit Post",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.LightGreen,
                    Margin = new Padding(5)
                };

                editPostButton.Click += (sender, e) =>
                {
                    Form editForm = new Form
                    {
                        Text = "Edit Post",
                        Width = 400,
                        Height = 300,
                        StartPosition = FormStartPosition.CenterScreen,
                        BackColor = Color.White
                    };
                    TextBox messageTextBox = new TextBox
                    {
                        Multiline = true,
                        Width = 350,
                        Height = 150,
                        Text = r_SavedMessages.ContainsKey(i_Post.Id) ? r_SavedMessages[i_Post.Id] : i_Post.Message,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Margin = new Padding(10)
                    };

                    messageTextBox.TextChanged += (s, args) =>
                    {
                        messageLabel.Text = messageTextBox.Text;
                    };
                    Button saveButton = new Button
                    {
                        Text = "Save",
                        AutoSize = true,
                        BackColor = Color.LightGreen,
                        ForeColor = Color.DarkGreen,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Dock = DockStyle.Bottom
                    };

                    saveButton.Click += (s, args) =>
                    {
                        string updatedMessage = messageTextBox.Text;

                        if (!string.IsNullOrEmpty(updatedMessage))
                        {
                            if (!string.IsNullOrEmpty(i_Post.Id))
                            {
                                r_SavedMessages[i_Post.Id] = updatedMessage;
                                messageLabel.Text = updatedMessage;
                                MessageBox.Show("Message saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                editForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("Post ID is missing. Cannot save the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Message cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    };

                    editForm.Controls.Add(messageTextBox);
                    editForm.Controls.Add(saveButton);
                    editForm.ShowDialog();
                };

                io_DataPanel.Controls.Add(editPostButton);
                PictureBox thisPostPicture = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(150, 150),
                    Margin = new Padding(10),
                    BackColor = Color.LightGray,
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (!string.IsNullOrEmpty(i_Post.PictureURL))
                {
                    thisPostPicture.ImageLocation = i_Post.PictureURL;
                }

                io_DataPanel.Controls.Add(thisPostPicture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying post details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakeAlbumPanel(ref TableLayoutPanel io_DataPanel, Album i_Album,
                                   ListBox i_DataListBox, PictureBox i_PictureBoxProfile,
                                   BindingSource i_AlbumBindingSource)
        {
            try
            {
                int albumIndex = i_AlbumBindingSource.List.IndexOf(i_Album);

                if (albumIndex != i_AlbumBindingSource.Position)
                {
                    i_AlbumBindingSource.Position = albumIndex;
                }

                io_DataPanel.Controls.Clear();
                Label albumNameLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                    Text = i_Album.Name
                };
                TextBox albumNameTextBox = new TextBox
                {
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Margin = new Padding(5),
                    Text = i_Album.Name
                };

                albumNameTextBox.TextChanged += (sender, e) =>
                {
                    albumNameLabel.Text = albumNameTextBox.Text;
                };
                albumNameTextBox.Leave += (sender, e) =>
                {
                    if (!string.Equals(i_Album.Name, albumNameTextBox.Text))
                    {
                        i_Album.Name = albumNameTextBox.Text;
                        RefreshListBox(i_DataListBox, i_Album);
                    }
                };
                Label countLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Padding = new Padding(5),
                    Text = $"Photos: {i_Album.Count}"
                };
                PictureBox albumPicture = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (!string.IsNullOrEmpty(i_Album.PictureAlbumURL))
                {
                    albumPicture.ImageLocation = i_Album.PictureAlbumURL;
                }
                else
                {
                    albumPicture.Image = i_PictureBoxProfile.ErrorImage;
                }

                Button openAlbumButton = new Button
                {
                    Text = "Open Album",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.LightBlue,
                    Margin = new Padding(5),
                };

                openAlbumButton.Click += (sender, e) =>
                {
                    Thread openAlbumThread = new Thread(() => OpenAlbumPhotos(i_Album, i_PictureBoxProfile));

                    openAlbumThread.SetApartmentState(ApartmentState.STA);
                    openAlbumThread.Start();
                };
                io_DataPanel.Controls.Add(new Label
                {
                    Text = "Album Name:",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Padding = new Padding(5),
                });
                io_DataPanel.Controls.Add(albumNameLabel);
                io_DataPanel.Controls.Add(new Label
                {
                    Text = "Edit Album Name:",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Padding = new Padding(5),
                });
                io_DataPanel.Controls.Add(albumNameTextBox);
                io_DataPanel.Controls.Add(countLabel);
                io_DataPanel.Controls.Add(albumPicture);
                io_DataPanel.Controls.Add(openAlbumButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying album details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshListBox(ListBox i_ListBox, Album i_Album)
        {
            int index = i_ListBox.Items.IndexOf(i_Album);

            if (index >= 0)
            {
                i_ListBox.Items[index] = i_Album;
            }
        }
        private void OpenAlbumPhotos(Album i_Album, PictureBox i_PictureBoxProfile)
        {
            Form albumForm = new Form
            {
                Text = i_Album.Name,
                Width = k_AlbumFormWidth,
                Height = k_AlbumFormHeight
            };

            albumForm.StartPosition = FormStartPosition.CenterScreen;
            FlowLayoutPanel photoPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill
            };

            foreach (Photo photo in i_Album.Photos)
            {
                PictureBox photoPicture = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(k_PictureInAlbumSize, k_PictureInAlbumSize)
                };

                if (!string.IsNullOrEmpty(photo.PictureNormalURL))
                {
                    photoPicture.ImageLocation = photo.PictureNormalURL;
                }
                else
                {
                    photoPicture.Image = i_PictureBoxProfile.ErrorImage;
                }

                photoPanel.Controls.Add(photoPicture);
            }

            albumForm.Controls.Add(photoPanel);
            albumForm.ShowDialog();
        }
    }
}