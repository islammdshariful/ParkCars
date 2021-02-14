using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkCars
{
    public partial class AdminProfile : UserControl
    {
        string NAME, USERID, USERNAME, EMAIL, ADDRESS, PASSWORD;
        public AdminProfile(string name, string id, string username, string email, string address, string password)
        {
            InitializeComponent();
            NAME = name;
            USERID = id;
            USERNAME = username;
            EMAIL = email;
            ADDRESS = address;
            PASSWORD = password;

            PersonName.Text = name;
            PersonID.Text = id;
            PersonUsername.Text = username;
            PersonEmailAddress.Text = email;
            PersonAddress.Text = address;
        }
        public AdminProfile(string name, string id, string username, string email, string address)
        {
            InitializeComponent();
            NAME = name;
            USERID = id;
            USERNAME = username;
            EMAIL = email;
            ADDRESS = address;
            //PASSWORD = password;

            PersonName.Text = name;
            PersonID.Text = id;
            PersonUsername.Text = username;
            PersonEmailAddress.Text = email;
            PersonAddress.Text = address;

            NAME = name;
            USERID = id;
            USERNAME = username;
            EMAIL = email;
            ADDRESS = address;
            //PASSWORD = password;


        }
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            ProfileSettingForAdmin c = new ProfileSettingForAdmin(NAME, USERID, USERNAME, EMAIL, ADDRESS, PASSWORD);
            if (!PersonProfileWindow.Controls.Contains(c))
            {
                PersonProfileWindow.Controls.Add(c);
                c.Dock = DockStyle.Fill;
                c.BringToFront();
            }
            else
            {
                c.BringToFront();
            }
        }
    }
}
