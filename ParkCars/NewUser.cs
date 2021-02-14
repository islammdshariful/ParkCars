using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkCars
{
    public partial class NewUser : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI"); 
        SqlCommand Command;
        DatabaseManagement database = new DatabaseManagement();
        
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewMemberSaveButton_Click(object sender, EventArgs e)
        {
            ArrayList User = new ArrayList();
            string Username = UserNameTextBox.Text;
            string Userid = UserIDTextBox.Text;
            string UseremailAddress = UserEmailTextBox.Text;
            string UsercarID = VehicleIDTextBox.Text;
            string UserVehicleName = VehicleNameTextBox.Text;
            string UserVehicleModel = VehicleModelTextBox.Text;
            string UserVehicleColour = VehicleColorTextBox.Text;
            string UserGender = "";

            Boolean flag = false;

            if (MaleUser.Checked)
            {
                UserGender = "Male";
            }
            if (FemaleUser.Checked)
            {
                UserGender = "Female";
            }

            Boolean empty = string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Userid) || string.IsNullOrEmpty(UseremailAddress) || string.IsNullOrEmpty(UsercarID) || string.IsNullOrEmpty(UserVehicleName) || string.IsNullOrEmpty(UserVehicleModel) || string.IsNullOrEmpty(UserVehicleColour) || string.IsNullOrEmpty(UserGender);

            string query = "select ID  from member where ID= '" + Userid + "';";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();

            while (result.Read())
            {
                
                string id = result["ID"].ToString();
                flag = true;
            }
            Connection.Close();

            if (empty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Please fill all the fields");
            }
            else if (flag)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"ID already exist");
            }
            else
            {
                User.Add(Username);
                User.Add(Userid);
                User.Add(UseremailAddress);
                User.Add(UserGender);
                User.Add(UsercarID);
                User.Add(UserVehicleName);
                User.Add(UserVehicleModel);
                User.Add(UserVehicleColour);
                database.InsertNewUser(User);
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show("User Added successfully");

                ViewUsers vu = new ViewUsers();
                vu.LoadData();



            }

        }

        private void NewUserResetButton_Click(object sender, EventArgs e)
        {
            this.UserNameTextBox.Text = "";
            this.UserIDTextBox.Text = "";
            this.UserEmailTextBox.Text = "";
            this.VehicleIDTextBox.Text = "";
            this.VehicleNameTextBox.Text = "";
            this.VehicleModelTextBox.Text = "";
            this.VehicleColorTextBox.Text = "";
            MaleUser.Checked = false;
            FemaleUser.Checked = false;

        }
    }
}
