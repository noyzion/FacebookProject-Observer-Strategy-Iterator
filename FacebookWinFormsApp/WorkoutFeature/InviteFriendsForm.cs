using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.WorkoutFeature
{
    public partial class InviteFriendsForm : Form
    {
        private readonly FacebookFacade r_FacebookFacade;
        private readonly WorkoutFacade r_WorkoutFacade;

        public InviteFriendsForm(FacebookFacade i_FacebookFacade, WorkoutFacade i_WorkoutFacade)
        {
            InitializeComponent();
            r_FacebookFacade = i_FacebookFacade;
            r_WorkoutFacade = i_WorkoutFacade;
        }
        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonInviteFriends.Enabled = listBoxFriends.SelectedItems.Count > 0;
        }
        private void inviteFriendsForm_Load(object sender, EventArgs e)
        {
            try
            {
                r_FacebookFacade.FetchFriends(listBoxFriends);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching friends: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInviteFriends_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one friend to invite.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            List<User> selectedFriends = listBoxFriends.CheckedItems.Cast<User>().ToList();

            try
            {
                FacebookObjectCollection<User> facebookCollection = new FacebookObjectCollection<User>();

                foreach (User friend in selectedFriends)
                {
                    facebookCollection.Add(friend);
                }

                r_FacebookFacade.InviteFriends(facebookCollection);
                MessageBox.Show("Invitations sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending invites: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            r_WorkoutFacade.DisplayInviteFriendsPost(selectedFriends);
            this.Close();
        }
    }
}
