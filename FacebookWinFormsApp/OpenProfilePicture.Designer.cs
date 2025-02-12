using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class OpenProfilePicture
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
            this.pictureBoxShowProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxChangeProfile = new System.Windows.Forms.PictureBox();
            this.buttonchangeProfile = new System.Windows.Forms.Button();
            this.buttonShowProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxShowProfile
            // 
            this.pictureBoxShowProfile.Image = global::BasicFacebookFeatures.Properties.Resources._1865156_200;
            this.pictureBoxShowProfile.InitialImage = global::BasicFacebookFeatures.Properties.Resources._1865156_200;
            this.pictureBoxShowProfile.Location = new System.Drawing.Point(242, 23);
            this.pictureBoxShowProfile.Name = "pictureBoxShowProfile";
            this.pictureBoxShowProfile.Size = new System.Drawing.Size(45, 42);
            this.pictureBoxShowProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowProfile.TabIndex = 7;
            this.pictureBoxShowProfile.TabStop = false;
            this.pictureBoxShowProfile.Click += new System.EventHandler(this.showProfile_Click);
            this.pictureBoxShowProfile.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxShowProfile.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxChangeProfile
            // 
            this.pictureBoxChangeProfile.Image = global::BasicFacebookFeatures.Properties.Resources._3342137;
            this.pictureBoxChangeProfile.InitialImage = global::BasicFacebookFeatures.Properties.Resources._3342137;
            this.pictureBoxChangeProfile.Location = new System.Drawing.Point(242, 73);
            this.pictureBoxChangeProfile.Name = "pictureBoxChangeProfile";
            this.pictureBoxChangeProfile.Size = new System.Drawing.Size(45, 42);
            this.pictureBoxChangeProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChangeProfile.TabIndex = 6;
            this.pictureBoxChangeProfile.TabStop = false;
            this.pictureBoxChangeProfile.Click += new System.EventHandler(this.changeProfile_Click);
            this.pictureBoxChangeProfile.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxChangeProfile.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // buttonchangeProfile
            // 
            this.buttonchangeProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchangeProfile.Location = new System.Drawing.Point(25, 79);
            this.buttonchangeProfile.Name = "buttonChangeProfile";
            this.buttonchangeProfile.Size = new System.Drawing.Size(211, 33);
            this.buttonchangeProfile.TabIndex = 5;
            this.buttonchangeProfile.Text = "Change your profile";
            this.buttonchangeProfile.UseVisualStyleBackColor = true;
            this.buttonchangeProfile.Click += new System.EventHandler(this.changeProfile_Click);
            // 
            // buttonshowProfile
            // 
            this.buttonShowProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowProfile.Location = new System.Drawing.Point(25, 27);
            this.buttonShowProfile.Name = "buttonShowProfile";
            this.buttonShowProfile.Size = new System.Drawing.Size(211, 33);
            this.buttonShowProfile.TabIndex = 4;
            this.buttonShowProfile.Text = "Show your profile";
            this.buttonShowProfile.UseVisualStyleBackColor = true;
            this.buttonShowProfile.Click += new System.EventHandler(this.showProfile_Click);
            // 
            // OpenProfilePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 144);
            this.Controls.Add(this.pictureBoxShowProfile);
            this.Controls.Add(this.pictureBoxChangeProfile);
            this.Controls.Add(this.buttonchangeProfile);
            this.Controls.Add(this.buttonShowProfile);
            this.Name = "OpenProfilePicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Picture Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowProfile;
        private System.Windows.Forms.PictureBox pictureBoxChangeProfile;
        private System.Windows.Forms.PictureBox pictureBoxShowProfile;
        private System.Windows.Forms.Button buttonchangeProfile;
    }
}