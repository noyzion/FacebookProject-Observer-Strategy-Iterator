namespace BasicFacebookFeatures.WorkoutFeature
{
    partial class InviteFriendsForm
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonInviteFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonInviteFriends
            // 
            this.buttonInviteFriends.BackColor = System.Drawing.Color.LightPink;
            this.buttonInviteFriends.Enabled = false;
            this.buttonInviteFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInviteFriends.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInviteFriends.Location = new System.Drawing.Point(121, 386);
            this.buttonInviteFriends.Name = "buttonInviteFriends";
            this.buttonInviteFriends.Size = new System.Drawing.Size(136, 38);
            this.buttonInviteFriends.TabIndex = 1;
            this.buttonInviteFriends.Text = "invite!";
            this.buttonInviteFriends.UseVisualStyleBackColor = false;
            this.buttonInviteFriends.Click += new System.EventHandler(this.buttonInviteFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(38, 16);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(312, 361);
            this.listBoxFriends.TabIndex = 2;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // InviteFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonInviteFriends);
            this.Name = "InviteFriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invite Frirends";
            this.Load += new System.EventHandler(this.inviteFriendsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonInviteFriends;
        private System.Windows.Forms.CheckedListBox listBoxFriends;
    }
}