namespace BasicFacebookFeatures
{
    partial class FormAppSettings
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.textBoxPermissionsToAdd = new System.Windows.Forms.TextBox();
            this.listBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.labelPermissions = new System.Windows.Forms.Label();
            this.buttonAddAppID = new System.Windows.Forms.Button();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.comboBoxAppID = new System.Windows.Forms.ComboBox();
            this.labelAppID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(247, 440);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(77, 24);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Location = new System.Drawing.Point(186, 410);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(138, 24);
            this.buttonAddPermission.TabIndex = 16;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // textBoxPermissionsToAdd
            // 
            this.textBoxPermissionsToAdd.Location = new System.Drawing.Point(11, 412);
            this.textBoxPermissionsToAdd.Name = "textBoxPermissionsToAdd";
            this.textBoxPermissionsToAdd.Size = new System.Drawing.Size(169, 22);
            this.textBoxPermissionsToAdd.TabIndex = 15;
            // 
            // listBoxPermissions
            // 
            this.listBoxPermissions.FormattingEnabled = true;
            this.listBoxPermissions.Items.AddRange(new object[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"});
            this.listBoxPermissions.Location = new System.Drawing.Point(11, 111);
            this.listBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPermissions.Name = "listBoxPermissions";
            this.listBoxPermissions.Size = new System.Drawing.Size(313, 293);
            this.listBoxPermissions.Sorted = true;
            this.listBoxPermissions.TabIndex = 8;
            // 
            // permissionsLabel
            // 
            this.labelPermissions.AutoSize = true;
            this.labelPermissions.Location = new System.Drawing.Point(8, 92);
            this.labelPermissions.Name = "permissionsLabel";
            this.labelPermissions.Size = new System.Drawing.Size(84, 16);
            this.labelPermissions.TabIndex = 13;
            this.labelPermissions.Text = "Permissions:";
            // 
            // buttonAddAppID
            // 
            this.buttonAddAppID.Location = new System.Drawing.Point(288, 54);
            this.buttonAddAppID.Name = "buttonAddAppID";
            this.buttonAddAppID.Size = new System.Drawing.Size(46, 24);
            this.buttonAddAppID.TabIndex = 12;
            this.buttonAddAppID.Text = "Add";
            this.buttonAddAppID.UseVisualStyleBackColor = true;
            this.buttonAddAppID.Click += new System.EventHandler(this.buttonAddAppID_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(67, 55);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(215, 22);
            this.textBoxAppID.TabIndex = 11;
            // 
            // comboAppID
            // 
            this.comboBoxAppID.FormattingEnabled = true;
            this.comboBoxAppID.Items.AddRange(new object[] {
            "914564353962957"});
            this.comboBoxAppID.Location = new System.Drawing.Point(67, 25);
            this.comboBoxAppID.Name = "comboAppID";
            this.comboBoxAppID.Size = new System.Drawing.Size(215, 24);
            this.comboBoxAppID.TabIndex = 10;
            // 
            // appIDLabel
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Location = new System.Drawing.Point(8, 28);
            this.labelAppID.Name = "appIDLabel";
            this.labelAppID.Size = new System.Drawing.Size(53, 16);
            this.labelAppID.TabIndex = 9;
            this.labelAppID.Text = "APP ID:";
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 489);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.textBoxPermissionsToAdd);
            this.Controls.Add(this.listBoxPermissions);
            this.Controls.Add(this.labelPermissions);
            this.Controls.Add(this.buttonAddAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.comboBoxAppID);
            this.Controls.Add(this.labelAppID);
            this.Name = "FormAppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonAddPermission;
        private System.Windows.Forms.TextBox textBoxPermissionsToAdd;
        private System.Windows.Forms.CheckedListBox listBoxPermissions;
        private System.Windows.Forms.Label labelPermissions;
        private System.Windows.Forms.Button buttonAddAppID;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.ComboBox comboBoxAppID;
        private System.Windows.Forms.Label labelAppID;
    }
}