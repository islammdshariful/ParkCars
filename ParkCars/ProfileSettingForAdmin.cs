using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkCars
{
    public partial class ProfileSettingForAdmin : UserControl
    {
        DatabaseManagement database = new DatabaseManagement();
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        SqlCommand Command2;
        Boolean flag1 = false;
        Boolean flag2 = false;
        string NAME, USERID, USERNAME, EMAIL, ADDRESS, PASSWORD;
        string Emailc, Passwordc, Addressc;
        public ProfileSettingForAdmin()
        {
            InitializeComponent();
        }

        public ProfileSettingForAdmin(string name, string id, string username, string email, string address, string password)
        {
            InitializeComponent();
            NAME = name;
            USERID = id;
            USERNAME = username;
            EMAIL = email;
            ADDRESS = address;
            PASSWORD = password;

            //ChangePersonName.Text = name;
            //ChangePersonEmailAddress.Text = email;
           // ChangePersonAddress.Text = address;

        }
        private void PasswordChangedButton_Click(object sender, EventArgs e)
        {

            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            string pass = ChangedPasswordTextBox.Text;
            string repass = NewPasswordTextBox.Text;
            string conpass = RePasswordTextBox.Text;


            Boolean emplty = string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(repass) || string.IsNullOrEmpty(conpass);

            String query = "update admin  set AdminPassword = '" + conpass + "';";

            Connection.Open();

            Command2 = new SqlCommand(query, Connection);
            if (emplty)
            {
                MessageBox.Show("Please fill all the feilds");
            }
            else if (!pass.Equals(PASSWORD))
            {
                MessageBox.Show("Password is in correct");
            }
            else if (!repass.Equals(conpass))
            {
                MessageBox.Show("Password not matched");
            }
            else
            {
                Command2.ExecuteNonQuery();
                MessageBox.Show(w, "Password Updated");
            }

            Connection.Close();

        }

        /*private void SaveButton_Click(object sender, EventArgs e)
        {
            string id = USERID;

            string name = ChangePersonName.Text;
            string email = ChangePersonEmailAddress.Text;
            string address = ChangePersonAddress.Text;

            Boolean emplty = string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email)  || string.IsNullOrEmpty(address);


            //Connection.Open();
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());


            String query = "update admin  set AdminName = '" + name + "', AdminEmailAddress = '" + email + "', AdminAddress = '" + address + "' WHERE AdminID = '" + id + "';";

            Connection.Open();
            Command1 = new SqlCommand(query, Connection);

            if (emplty)
            {
                MessageBox.Show(w, "Please Enter all the fields");
            }
            else if (flag2)
            {
                MessageBox.Show("Username not available");
            }
            else
            {
                Command1.ExecuteNonQuery();
                MessageBox.Show(w, "Information Updated");
                Connection.Close();
            }
            Connection.Close();
        }
        */

        private void BackToProfileButton_Click(object sender, EventArgs e)
        {
            /*string query = "select *  from admin where AdminID = '" + USERID + "' ;";

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();

            //string Emailc, Passwordc, Addressc;

            try
            {

                while (result.Read())
                {
                    string username = result["AdminUsername"].ToString();
                    string password = result["AdminPassword"].ToString();
                    string email = result["AdminEmailAddress"].ToString();
                    string address = result["AdminAddress"].ToString();
                    string id = result["AdminID"].ToString();
                    string name = result["AdminName"].ToString();

                    Emailc = email;
                    Passwordc = password;
                    Addressc = address;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ADMIN ERROR: " + ex);
            }
            Connection.Close();*/

            Profile c = new Profile(NAME, USERID, USERNAME, EMAIL, ADDRESS);

            if (!ProfileChangeWindow.Controls.Contains(c))
            {
                ProfileChangeWindow.Controls.Add(c);
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
