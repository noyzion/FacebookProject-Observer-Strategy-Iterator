using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
     public partial class FormAppSettings : Form
    {
        private readonly AppSettings r_AppSettings;

        public FormAppSettings(AppSettings i_AppSettings)
        {
            InitializeComponent();
            this.r_AppSettings = i_AppSettings;
            foreach (string permission in i_AppSettings.Permissions)
            {
                int indexOfPermission = listBoxPermissions.Items.IndexOf(permission);
                listBoxPermissions.SetItemChecked(indexOfPermission,true);
            }

            int appIDIndex = comboBoxAppID.Items.IndexOf(i_AppSettings
                .AppID);

            comboBoxAppID.SelectedIndex = appIDIndex;
        }
        private void buttonAddAppID_Click(object sender, EventArgs e)
        {
            comboBoxAppID.Items.Insert(0, textBoxAppID.Text);
            comboBoxAppID.SelectedIndex = 0;
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboBoxAppID.SelectedIndex == -1)
            {
                comboBoxAppID.SelectedIndex = 0;
            }

            r_AppSettings.AppID = comboBoxAppID.SelectedItem.ToString();
            r_AppSettings.Permissions = new string[listBoxPermissions.CheckedItems.Count];
            listBoxPermissions.CheckedItems.CopyTo(r_AppSettings.Permissions, 0);
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonAddPermission_Click(object sender, EventArgs e)
        {
            listBoxPermissions.Items.Add(textBoxPermissionsToAdd.Text);
        }
    }
}
