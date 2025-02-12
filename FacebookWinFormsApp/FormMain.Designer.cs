using System;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.labelWorkoutsHeader = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelAddStatus = new System.Windows.Forms.Label();
            this.buttonAddVideo = new System.Windows.Forms.Button();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.eventesPicture = new System.Windows.Forms.PictureBox();
            this.dataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonLikesPages = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.photosPicture = new System.Windows.Forms.PictureBox();
            this.postsPicture = new System.Windows.Forms.PictureBox();
            this.friendsPicture = new System.Windows.Forms.PictureBox();
            this.likedPagesPicture = new System.Windows.Forms.PictureBox();
            this.groupsPicture = new System.Windows.Forms.PictureBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.panelWorkoutFeature = new System.Windows.Forms.Panel();
            this.buttonInviteFriends = new System.Windows.Forms.Button();
            this.buttonShareWorkout = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.panelWorkouts = new System.Windows.Forms.Panel();
            this.buttonAddWorkout = new System.Windows.Forms.Button();
            this.tabWishlist = new System.Windows.Forms.TabPage();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.labelNameOfWish = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonShareWishlist = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelActivities = new System.Windows.Forms.Label();
            this.labelPets = new System.Windows.Forms.Label();
            this.labelShopping = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.pictureBoxPets = new System.Windows.Forms.PictureBox();
            this.pictureBoxShopping = new System.Windows.Forms.PictureBox();
            this.pictureBoxActivities = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.checkedListBoxShopping = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPets = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxActivities = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxFood = new System.Windows.Forms.CheckedListBox();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelWishlistHeader = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlMainForm.SuspendLayout();
            this.tabFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsPicture)).BeginInit();
            this.panelWorkoutFeature.SuspendLayout();
            this.tabWishlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Navy;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonLogin.Location = new System.Drawing.Point(7, 55);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(230, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login with Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLogout.Enabled = false;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(7, 94);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(230, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Controls.Add(this.tabFeed);
            this.tabControlMainForm.Controls.Add(this.tabWishlist);
            this.tabControlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(1243, 697);
            this.tabControlMainForm.TabIndex = 54;
            this.tabControlMainForm.Tag = "";
            // 
            // tabFeed
            // 
            this.tabFeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFeed.Controls.Add(this.labelWorkoutsHeader);
            this.tabFeed.Controls.Add(this.buttonSettings);
            this.tabFeed.Controls.Add(this.pictureBoxProfile);
            this.tabFeed.Controls.Add(this.panelStatus);
            this.tabFeed.Controls.Add(this.labelEmail);
            this.tabFeed.Controls.Add(this.labelBirthday);
            this.tabFeed.Controls.Add(this.buttonEvents);
            this.tabFeed.Controls.Add(this.eventesPicture);
            this.tabFeed.Controls.Add(this.dataPanel);
            this.tabFeed.Controls.Add(this.dataListBox);
            this.tabFeed.Controls.Add(this.buttonAlbums);
            this.tabFeed.Controls.Add(this.buttonPosts);
            this.tabFeed.Controls.Add(this.buttonFriends);
            this.tabFeed.Controls.Add(this.buttonLikesPages);
            this.tabFeed.Controls.Add(this.buttonGroups);
            this.tabFeed.Controls.Add(this.photosPicture);
            this.tabFeed.Controls.Add(this.postsPicture);
            this.tabFeed.Controls.Add(this.friendsPicture);
            this.tabFeed.Controls.Add(this.likedPagesPicture);
            this.tabFeed.Controls.Add(this.groupsPicture);
            this.tabFeed.Controls.Add(this.rememberMeCheckBox);
            this.tabFeed.Controls.Add(this.buttonLogout);
            this.tabFeed.Controls.Add(this.buttonLogin);
            this.tabFeed.Controls.Add(this.panelWorkoutFeature);
            this.tabFeed.Location = new System.Drawing.Point(4, 31);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeed.Size = new System.Drawing.Size(1235, 662);
            this.tabFeed.TabIndex = 0;
            this.tabFeed.Text = "Feed";
            // 
            // labelWorkoutsHeader
            // 
            this.labelWorkoutsHeader.AutoSize = true;
            this.labelWorkoutsHeader.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkoutsHeader.Location = new System.Drawing.Point(625, 3);
            this.labelWorkoutsHeader.Name = "labelWorkoutsHeader";
            this.labelWorkoutsHeader.Size = new System.Drawing.Size(130, 27);
            this.labelWorkoutsHeader.TabIndex = 0;
            this.labelWorkoutsHeader.Text = "My Workouts";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSettings.Enabled = false;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(13, 15);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(79, 30);
            this.buttonSettings.TabIndex = 85;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(245, 28);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(132, 130);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            this.pictureBoxProfile.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxProfile.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelAddStatus);
            this.panelStatus.Controls.Add(this.buttonAddVideo);
            this.panelStatus.Controls.Add(this.buttonAddPost);
            this.panelStatus.Controls.Add(this.buttonAddPicture);
            this.panelStatus.Controls.Add(this.textBoxStatus);
            this.panelStatus.Location = new System.Drawing.Point(430, 563);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(793, 85);
            this.panelStatus.TabIndex = 84;
            // 
            // labelAddStatus
            // 
            this.labelAddStatus.AutoSize = true;
            this.labelAddStatus.Location = new System.Drawing.Point(13, 8);
            this.labelAddStatus.Name = "labelAddStatus";
            this.labelAddStatus.Size = new System.Drawing.Size(102, 24);
            this.labelAddStatus.TabIndex = 87;
            this.labelAddStatus.Text = "Add status:";
            // 
            // buttonAddVideo
            // 
            this.buttonAddVideo.BackColor = System.Drawing.Color.White;
            this.buttonAddVideo.Enabled = false;
            this.buttonAddVideo.Location = new System.Drawing.Point(412, 50);
            this.buttonAddVideo.Name = "buttonAddVideo";
            this.buttonAddVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddVideo.Size = new System.Drawing.Size(136, 31);
            this.buttonAddVideo.TabIndex = 89;
            this.buttonAddVideo.Text = "Add video";
            this.buttonAddVideo.UseVisualStyleBackColor = false;
            this.buttonAddVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.BackColor = System.Drawing.Color.White;
            this.buttonAddPost.Enabled = false;
            this.buttonAddPost.Location = new System.Drawing.Point(709, 6);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddPost.Size = new System.Drawing.Size(70, 31);
            this.buttonAddPost.TabIndex = 85;
            this.buttonAddPost.Text = "Post";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.addPostButton_Click);
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.BackColor = System.Drawing.Color.White;
            this.buttonAddPicture.Enabled = false;
            this.buttonAddPicture.Location = new System.Drawing.Point(270, 50);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddPicture.Size = new System.Drawing.Size(136, 31);
            this.buttonAddPicture.TabIndex = 88;
            this.buttonAddPicture.Text = "Add picture";
            this.buttonAddPicture.UseVisualStyleBackColor = false;
            this.buttonAddPicture.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(124, 7);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(579, 28);
            this.textBoxStatus.TabIndex = 86;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(391, 64);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 24);
            this.labelEmail.TabIndex = 81;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(391, 107);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 24);
            this.labelBirthday.TabIndex = 80;
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEvents.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEvents.Enabled = false;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(73, 594);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(91, 35);
            this.buttonEvents.TabIndex = 74;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.events_Click);
            // 
            // eventesPicture
            // 
            this.eventesPicture.Enabled = false;
            this.eventesPicture.Image = global::BasicFacebookFeatures.Properties.Resources.events_icon;
            this.eventesPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.events_icon;
            this.eventesPicture.Location = new System.Drawing.Point(18, 585);
            this.eventesPicture.Name = "eventesPicture";
            this.eventesPicture.Size = new System.Drawing.Size(49, 48);
            this.eventesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventesPicture.TabIndex = 73;
            this.eventesPicture.TabStop = false;
            this.eventesPicture.Click += new System.EventHandler(this.events_Click);
            this.eventesPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.eventesPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // dataPanel
            // 
            this.dataPanel.ColumnCount = 2;
            this.dataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPanel.Location = new System.Drawing.Point(430, 198);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPanel.RowCount = 2;
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.Size = new System.Drawing.Size(785, 356);
            this.dataPanel.TabIndex = 72;
            // 
            // dataListBox
            // 
            this.dataListBox.AccessibleName = "DataListBox";
            this.dataListBox.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.HorizontalScrollbar = true;
            this.dataListBox.ItemHeight = 22;
            this.dataListBox.Location = new System.Drawing.Point(195, 179);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataListBox.ScrollAlwaysVisible = true;
            this.dataListBox.Size = new System.Drawing.Size(215, 466);
            this.dataListBox.TabIndex = 70;
            this.dataListBox.SelectedIndexChanged += new System.EventHandler(this.dataListBox_SelectedIndexChanged);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAlbums.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(73, 435);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(91, 35);
            this.buttonAlbums.TabIndex = 69;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.photos_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPosts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPosts.Enabled = false;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.Location = new System.Drawing.Point(73, 515);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(91, 35);
            this.buttonPosts.TabIndex = 68;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Click += new System.EventHandler(this.posts_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonFriends.Enabled = false;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriends.Location = new System.Drawing.Point(73, 353);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(91, 35);
            this.buttonFriends.TabIndex = 66;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.friends_Click);
            // 
            // buttonLikesPages
            // 
            this.buttonLikesPages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLikesPages.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLikesPages.Enabled = false;
            this.buttonLikesPages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLikesPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLikesPages.Location = new System.Drawing.Point(73, 277);
            this.buttonLikesPages.Name = "buttonLikesPages";
            this.buttonLikesPages.Size = new System.Drawing.Size(91, 32);
            this.buttonLikesPages.TabIndex = 65;
            this.buttonLikesPages.Text = "Pages";
            this.buttonLikesPages.UseVisualStyleBackColor = false;
            this.buttonLikesPages.Click += new System.EventHandler(this.pages_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGroups.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGroups.Enabled = false;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(73, 199);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(91, 35);
            this.buttonGroups.TabIndex = 64;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.groups_Click);
            // 
            // photosPicture
            // 
            this.photosPicture.Enabled = false;
            this.photosPicture.Image = global::BasicFacebookFeatures.Properties.Resources.photos_icon__2_;
            this.photosPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.photos_icon__2_;
            this.photosPicture.Location = new System.Drawing.Point(18, 426);
            this.photosPicture.Name = "photosPicture";
            this.photosPicture.Size = new System.Drawing.Size(49, 48);
            this.photosPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photosPicture.TabIndex = 63;
            this.photosPicture.TabStop = false;
            this.photosPicture.Click += new System.EventHandler(this.photos_Click);
            this.photosPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.photosPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // postsPicture
            // 
            this.postsPicture.Enabled = false;
            this.postsPicture.Image = global::BasicFacebookFeatures.Properties.Resources.posts_icon;
            this.postsPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.posts_icon;
            this.postsPicture.Location = new System.Drawing.Point(18, 506);
            this.postsPicture.Name = "postsPicture";
            this.postsPicture.Size = new System.Drawing.Size(49, 48);
            this.postsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postsPicture.TabIndex = 62;
            this.postsPicture.TabStop = false;
            this.postsPicture.Click += new System.EventHandler(this.posts_Click);
            this.postsPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.postsPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // friendsPicture
            // 
            this.friendsPicture.Enabled = false;
            this.friendsPicture.Image = global::BasicFacebookFeatures.Properties.Resources.new_friends_icon;
            this.friendsPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.new_friends_icon;
            this.friendsPicture.Location = new System.Drawing.Point(18, 346);
            this.friendsPicture.Name = "friendsPicture";
            this.friendsPicture.Size = new System.Drawing.Size(49, 48);
            this.friendsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendsPicture.TabIndex = 60;
            this.friendsPicture.TabStop = false;
            this.friendsPicture.Click += new System.EventHandler(this.friends_Click);
            this.friendsPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.friendsPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // likedPagesPicture
            // 
            this.likedPagesPicture.Enabled = false;
            this.likedPagesPicture.Image = global::BasicFacebookFeatures.Properties.Resources.liked_icon;
            this.likedPagesPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.liked_icon;
            this.likedPagesPicture.Location = new System.Drawing.Point(18, 269);
            this.likedPagesPicture.Name = "likedPagesPicture";
            this.likedPagesPicture.Size = new System.Drawing.Size(49, 45);
            this.likedPagesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likedPagesPicture.TabIndex = 59;
            this.likedPagesPicture.TabStop = false;
            this.likedPagesPicture.Click += new System.EventHandler(this.pages_Click);
            this.likedPagesPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.likedPagesPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // groupsPicture
            // 
            this.groupsPicture.Enabled = false;
            this.groupsPicture.Image = global::BasicFacebookFeatures.Properties.Resources.groups_icon;
            this.groupsPicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.groups_icon;
            this.groupsPicture.Location = new System.Drawing.Point(18, 193);
            this.groupsPicture.Name = "groupsPicture";
            this.groupsPicture.Size = new System.Drawing.Size(49, 48);
            this.groupsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupsPicture.TabIndex = 58;
            this.groupsPicture.TabStop = false;
            this.groupsPicture.Click += new System.EventHandler(this.groups_Click);
            this.groupsPicture.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.groupsPicture.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(12, 137);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(159, 28);
            this.rememberMeCheckBox.TabIndex = 56;
            this.rememberMeCheckBox.Text = "Remember Me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panelWorkoutFeature
            // 
            this.panelWorkoutFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkoutFeature.Controls.Add(this.buttonInviteFriends);
            this.panelWorkoutFeature.Controls.Add(this.buttonShareWorkout);
            this.panelWorkoutFeature.Controls.Add(this.buttonStatistics);
            this.panelWorkoutFeature.Controls.Add(this.panelWorkouts);
            this.panelWorkoutFeature.Controls.Add(this.buttonAddWorkout);
            this.panelWorkoutFeature.Location = new System.Drawing.Point(609, 28);
            this.panelWorkoutFeature.Name = "panelWorkoutFeature";
            this.panelWorkoutFeature.Size = new System.Drawing.Size(623, 165);
            this.panelWorkoutFeature.TabIndex = 86;
            // 
            // buttonInviteFriends
            // 
            this.buttonInviteFriends.BackColor = System.Drawing.Color.LightPink;
            this.buttonInviteFriends.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonInviteFriends.Enabled = false;
            this.buttonInviteFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInviteFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInviteFriends.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInviteFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInviteFriends.Location = new System.Drawing.Point(521, 121);
            this.buttonInviteFriends.Name = "buttonInviteFriends";
            this.buttonInviteFriends.Size = new System.Drawing.Size(71, 29);
            this.buttonInviteFriends.TabIndex = 91;
            this.buttonInviteFriends.Text = "invite";
            this.buttonInviteFriends.UseVisualStyleBackColor = false;
            this.buttonInviteFriends.Click += new System.EventHandler(this.buttonInviteFriends_Click);
            // 
            // buttonShareWorkout
            // 
            this.buttonShareWorkout.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonShareWorkout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonShareWorkout.Enabled = false;
            this.buttonShareWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShareWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareWorkout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShareWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShareWorkout.Location = new System.Drawing.Point(513, 86);
            this.buttonShareWorkout.Name = "buttonShareWorkout";
            this.buttonShareWorkout.Size = new System.Drawing.Size(88, 29);
            this.buttonShareWorkout.TabIndex = 90;
            this.buttonShareWorkout.Text = "share\r\n";
            this.buttonShareWorkout.UseVisualStyleBackColor = false;
            this.buttonShareWorkout.Click += new System.EventHandler(this.shareWorkoutButton_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStatistics.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonStatistics.Enabled = false;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(514, 51);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(88, 29);
            this.buttonStatistics.TabIndex = 89;
            this.buttonStatistics.Text = "statistics";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // panelWorkouts
            // 
            this.panelWorkouts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkouts.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWorkouts.Location = new System.Drawing.Point(4, 15);
            this.panelWorkouts.Name = "panelWorkouts";
            this.panelWorkouts.Size = new System.Drawing.Size(488, 137);
            this.panelWorkouts.TabIndex = 88;
            // 
            // buttonAddWorkout
            // 
            this.buttonAddWorkout.BackColor = System.Drawing.Color.LightYellow;
            this.buttonAddWorkout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonAddWorkout.Enabled = false;
            this.buttonAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddWorkout.Location = new System.Drawing.Point(501, 18);
            this.buttonAddWorkout.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.buttonAddWorkout.Name = "buttonAddWorkout";
            this.buttonAddWorkout.Size = new System.Drawing.Size(116, 27);
            this.buttonAddWorkout.TabIndex = 87;
            this.buttonAddWorkout.Text = "Add Workout";
            this.buttonAddWorkout.UseVisualStyleBackColor = false;
            this.buttonAddWorkout.Click += new System.EventHandler(this.buttonAddWorkout_Click);
            // 
            // tabWishlist
            // 
            this.tabWishlist.Controls.Add(this.buttonDeleteItem);
            this.tabWishlist.Controls.Add(this.labelNameOfWish);
            this.tabWishlist.Controls.Add(this.labelCategory);
            this.tabWishlist.Controls.Add(this.buttonShareWishlist);
            this.tabWishlist.Controls.Add(this.buttonAdd);
            this.tabWishlist.Controls.Add(this.labelActivities);
            this.tabWishlist.Controls.Add(this.labelPets);
            this.tabWishlist.Controls.Add(this.labelShopping);
            this.tabWishlist.Controls.Add(this.labelFood);
            this.tabWishlist.Controls.Add(this.pictureBoxPets);
            this.tabWishlist.Controls.Add(this.pictureBoxShopping);
            this.tabWishlist.Controls.Add(this.pictureBoxActivities);
            this.tabWishlist.Controls.Add(this.pictureBoxFood);
            this.tabWishlist.Controls.Add(this.checkedListBoxShopping);
            this.tabWishlist.Controls.Add(this.checkedListBoxPets);
            this.tabWishlist.Controls.Add(this.checkedListBoxActivities);
            this.tabWishlist.Controls.Add(this.checkedListBoxFood);
            this.tabWishlist.Controls.Add(this.buttonAddPhoto);
            this.tabWishlist.Controls.Add(this.comboBoxCategory);
            this.tabWishlist.Controls.Add(this.textBoxName);
            this.tabWishlist.Controls.Add(this.labelWishlistHeader);
            this.tabWishlist.Location = new System.Drawing.Point(4, 31);
            this.tabWishlist.Name = "tabWishlist";
            this.tabWishlist.Padding = new System.Windows.Forms.Padding(3);
            this.tabWishlist.Size = new System.Drawing.Size(1235, 662);
            this.tabWishlist.TabIndex = 1;
            this.tabWishlist.Text = "Wishlist";
            this.tabWishlist.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteItem.Enabled = false;
            this.buttonDeleteItem.FlatAppearance.BorderSize = 0;
            this.buttonDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteItem.Location = new System.Drawing.Point(1120, 505);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(81, 34);
            this.buttonDeleteItem.TabIndex = 25;
            this.buttonDeleteItem.Text = "delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // labelNameOfWish
            // 
            this.labelNameOfWish.AutoSize = true;
            this.labelNameOfWish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfWish.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelNameOfWish.Location = new System.Drawing.Point(281, 73);
            this.labelNameOfWish.Name = "labelNameOfWish";
            this.labelNameOfWish.Size = new System.Drawing.Size(132, 16);
            this.labelNameOfWish.TabIndex = 24;
            this.labelNameOfWish.Text = "what do you wish for?";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelCategory.Location = new System.Drawing.Point(540, 71);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCategory.Size = new System.Drawing.Size(60, 16);
            this.labelCategory.TabIndex = 23;
            this.labelCategory.Text = "category";
            // 
            // buttonShareWishlist
            // 
            this.buttonShareWishlist.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonShareWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShareWishlist.Enabled = false;
            this.buttonShareWishlist.FlatAppearance.BorderSize = 0;
            this.buttonShareWishlist.ForeColor = System.Drawing.Color.Black;
            this.buttonShareWishlist.Location = new System.Drawing.Point(517, 567);
            this.buttonShareWishlist.Name = "buttonShareWishlist";
            this.buttonShareWishlist.Size = new System.Drawing.Size(191, 43);
            this.buttonShareWishlist.TabIndex = 22;
            this.buttonShareWishlist.Text = "Share your wishlist!";
            this.buttonShareWishlist.UseVisualStyleBackColor = false;
            this.buttonShareWishlist.Click += new System.EventHandler(this.buttonPostWishlist_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(848, 87);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(190, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Without Photo";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddWithoutPhoto_Click);
            // 
            // labelActivities
            // 
            this.labelActivities.AutoSize = true;
            this.labelActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivities.Location = new System.Drawing.Point(421, 147);
            this.labelActivities.Name = "labelActivities";
            this.labelActivities.Size = new System.Drawing.Size(92, 24);
            this.labelActivities.TabIndex = 11;
            this.labelActivities.Text = "Activities";
            // 
            // labelPets
            // 
            this.labelPets.AutoSize = true;
            this.labelPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPets.Location = new System.Drawing.Point(699, 147);
            this.labelPets.Name = "labelPets";
            this.labelPets.Size = new System.Drawing.Size(50, 24);
            this.labelPets.TabIndex = 10;
            this.labelPets.Text = "Pets";
            // 
            // labelShopping
            // 
            this.labelShopping.AutoSize = true;
            this.labelShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopping.Location = new System.Drawing.Point(938, 147);
            this.labelShopping.Name = "labelShopping";
            this.labelShopping.Size = new System.Drawing.Size(100, 24);
            this.labelShopping.TabIndex = 9;
            this.labelShopping.Text = "Shopping";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(176, 147);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(59, 24);
            this.labelFood.TabIndex = 8;
            this.labelFood.Text = "Food";
            // 
            // pictureBoxPets
            // 
            this.pictureBoxPets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPets.Location = new System.Drawing.Point(741, 439);
            this.pictureBoxPets.Name = "pictureBoxPets";
            this.pictureBoxPets.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPets.TabIndex = 16;
            this.pictureBoxPets.TabStop = false;
            // 
            // pictureBoxShopping
            // 
            this.pictureBoxShopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShopping.Location = new System.Drawing.Point(1001, 439);
            this.pictureBoxShopping.Name = "pictureBoxShopping";
            this.pictureBoxShopping.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxShopping.TabIndex = 15;
            this.pictureBoxShopping.TabStop = false;
            // 
            // pictureBoxActivities
            // 
            this.pictureBoxActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxActivities.Location = new System.Drawing.Point(479, 439);
            this.pictureBoxActivities.Name = "pictureBoxActivities";
            this.pictureBoxActivities.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxActivities.TabIndex = 14;
            this.pictureBoxActivities.TabStop = false;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFood.Location = new System.Drawing.Point(218, 439);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFood.TabIndex = 13;
            this.pictureBoxFood.TabStop = false;
            // 
            // checkedListBoxShopping
            // 
            this.checkedListBoxShopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxShopping.DisplayMember = "Text";
            this.checkedListBoxShopping.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxShopping.FormattingEnabled = true;
            this.checkedListBoxShopping.Location = new System.Drawing.Point(876, 190);
            this.checkedListBoxShopping.Name = "checkedListBoxShopping";
            this.checkedListBoxShopping.Size = new System.Drawing.Size(225, 347);
            this.checkedListBoxShopping.TabIndex = 17;
            this.checkedListBoxShopping.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxShopping_ItemCheck);
            this.checkedListBoxShopping.SelectedValueChanged += new System.EventHandler(this.checkedListBoxShopping_SelectedIndexChanged);
            // 
            // checkedListBoxPets
            // 
            this.checkedListBoxPets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxPets.DisplayMember = "Text";
            this.checkedListBoxPets.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxPets.FormattingEnabled = true;
            this.checkedListBoxPets.Location = new System.Drawing.Point(616, 190);
            this.checkedListBoxPets.Name = "checkedListBoxPets";
            this.checkedListBoxPets.Size = new System.Drawing.Size(225, 347);
            this.checkedListBoxPets.TabIndex = 18;
            this.checkedListBoxPets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPets_ItemCheck);
            this.checkedListBoxPets.SelectedValueChanged += new System.EventHandler(this.checkedListBoxPets_SelectedIndexChanged);
            // 
            // checkedListBoxActivities
            // 
            this.checkedListBoxActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxActivities.DisplayMember = "Text";
            this.checkedListBoxActivities.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxActivities.FormattingEnabled = true;
            this.checkedListBoxActivities.Location = new System.Drawing.Point(354, 190);
            this.checkedListBoxActivities.Name = "checkedListBoxActivities";
            this.checkedListBoxActivities.Size = new System.Drawing.Size(225, 347);
            this.checkedListBoxActivities.TabIndex = 19;
            this.checkedListBoxActivities.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxActivities_ItemCheck);
            this.checkedListBoxActivities.SelectedValueChanged += new System.EventHandler(this.checkedListBoxActivities_SelectedIndexChanged);
            // 
            // checkedListBoxFood
            // 
            this.checkedListBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxFood.DisplayMember = "Text";
            this.checkedListBoxFood.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxFood.FormattingEnabled = true;
            this.checkedListBoxFood.Location = new System.Drawing.Point(93, 190);
            this.checkedListBoxFood.Name = "checkedListBoxFood";
            this.checkedListBoxFood.Size = new System.Drawing.Size(225, 347);
            this.checkedListBoxFood.TabIndex = 20;
            this.checkedListBoxFood.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFood_ItemCheck);
            this.checkedListBoxFood.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFood_SelectedIndexChanged);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Enabled = false;
            this.buttonAddPhoto.Location = new System.Drawing.Point(666, 87);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(175, 35);
            this.buttonAddPhoto.TabIndex = 21;
            this.buttonAddPhoto.Text = "Add With Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddWithPhoto_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            BasicFacebookFeatures.EWishlistCategories.Food,
            BasicFacebookFeatures.EWishlistCategories.Pets,
            BasicFacebookFeatures.EWishlistCategories.Activities,
            BasicFacebookFeatures.EWishlistCategories.Shopping});
            this.comboBoxCategory.Location = new System.Drawing.Point(539, 90);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 30);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.Location = new System.Drawing.Point(281, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(245, 28);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxWishlistName_TextChanged);
            // 
            // labelWishlistHeader
            // 
            this.labelWishlistHeader.AutoSize = true;
            this.labelWishlistHeader.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWishlistHeader.Location = new System.Drawing.Point(523, 14);
            this.labelWishlistHeader.Name = "labelWishlistHeader";
            this.labelWishlistHeader.Size = new System.Drawing.Size(185, 43);
            this.labelWishlistHeader.TabIndex = 0;
            this.labelWishlistHeader.Text = "My Wishlist";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControlMainForm);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.tabControlMainForm.ResumeLayout(false);
            this.tabFeed.ResumeLayout(false);
            this.tabFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsPicture)).EndInit();
            this.panelWorkoutFeature.ResumeLayout(false);
            this.tabWishlist.ResumeLayout(false);
            this.tabWishlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControlMainForm;
		private System.Windows.Forms.TabPage tabFeed;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.PictureBox groupsPicture;
        private System.Windows.Forms.PictureBox likedPagesPicture;
        private System.Windows.Forms.PictureBox photosPicture;
        private System.Windows.Forms.PictureBox postsPicture;
        private System.Windows.Forms.PictureBox friendsPicture;
        private System.Windows.Forms.Button buttonGroups;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonLikesPages;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.TableLayoutPanel dataPanel;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.PictureBox eventesPicture;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelAddStatus;
        private System.Windows.Forms.Button buttonAddVideo;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TabPage tabWishlist;
        private System.Windows.Forms.CheckedListBox checkedListBoxShopping;
        private System.Windows.Forms.CheckedListBox checkedListBoxPets;
        private System.Windows.Forms.CheckedListBox checkedListBoxActivities;
        private System.Windows.Forms.CheckedListBox checkedListBoxFood;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelWishlistHeader;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.Label labelPets;
        private System.Windows.Forms.Label labelShopping;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPets;
        private System.Windows.Forms.PictureBox pictureBoxShopping;
        private System.Windows.Forms.PictureBox pictureBoxActivities;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Button buttonShareWishlist;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelNameOfWish;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Panel panelWorkoutFeature;
        private System.Windows.Forms.Label labelWorkoutsHeader;
        private System.Windows.Forms.Button buttonAddWorkout;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Panel panelWorkouts;
        private System.Windows.Forms.Button buttonShareWorkout;
        private System.Windows.Forms.Button buttonInviteFriends;
        private System.Windows.Forms.BindingSource albumBindingSource;
    }
}

