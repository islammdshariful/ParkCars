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
    public partial class EmployeeInformation : UserControl
    {
        DatabaseManagement database = new DatabaseManagement();
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        Boolean flag = false;
        public static EmployeeInformation _instance;
        public static EmployeeInformation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeInformation();
                }
                return _instance;
            }
        }
        public EmployeeInformation()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
                string query = "Select * from Employee;";
                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                SqlDataReader DR = command.ExecuteReader();

                BindingSource source = new BindingSource();

                source.DataSource = DR;

                EmployeeTable.DataSource = source;

                Connection.Close();

        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            string id = EmployeeIDTextBox.Text;

            string name = EmployeeNameTextBox.Text;
            string email = EmployeeEmailAddressTextBox.Text;
            string gender = EmployeeGenderTextBox.Text;
            string username = EmployeeUsernameTextBox.Text;
            string password = EmployeePasswordTextBox.Text;
            string address = EmployeeAddressTextBox.Text;

            string query = "delete from Employee where UserID = '" + id + "' ;";

            Boolean emplty = string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address);

            if (emplty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "Please Enter all the fields");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want delete this employee?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Connection.Open();
                    Command = new SqlCommand(query, Connection);
                    Command.ExecuteNonQuery();

                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(1))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w, "Employee Removed", " Error !");
                    EmployeeNameTextBox.Text = "";
                    EmployeeIDTextBox.Text = "";
                    EmployeeEmailAddressTextBox.Text = "";
                    EmployeeGenderTextBox.Text = "";
                    EmployeeUsernameTextBox.Text = "";
                    EmployeePasswordTextBox.Text = "";
                    EmployeeAddressTextBox.Text = "";
                    Connection.Close();
                }
            }

            LoadData();

        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            string id = EmployeeIDTextBox.Text;

            string name = EmployeeNameTextBox.Text;
            string email = EmployeeEmailAddressTextBox.Text;
            string gender = EmployeeGenderTextBox.Text;
            string username = EmployeeUsernameTextBox.Text;
            string password = EmployeePasswordTextBox.Text;
            string address = EmployeeAddressTextBox.Text;

            Boolean emplty = string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address);

            String query = "update Employee  set UserName = '" + name + "', UserEmailAddress = '" + email + "', Gender = '" + gender + "', UserUsername = '" + username + "', UserPassword = '" + password + "', UserAddress = '" + address + "' WHERE UserID = '" + id + "';";

            //Connection.Open();
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                Connection.Open();
                Command = new SqlCommand(query, Connection);
            if (emplty)
            {
                MessageBox.Show(w, "Please Enter all the fields");
            }
            else
            {
                Command.ExecuteNonQuery();
                MessageBox.Show(w, "Employee Updated");
                Connection.Close();
            }
            Connection.Close();

            LoadData();
        }

        private void EmployeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){

                DataGridViewRow row = this.EmployeeTable.Rows[e.RowIndex];

                EmployeeIDTextBox.Text = row.Cells["UserID"].Value.ToString();
                EmployeeNameTextBox.Text = row.Cells["UserName"].Value.ToString();
                EmployeeEmailAddressTextBox.Text = row.Cells["UserEmailAddress"].Value.ToString();
                EmployeeGenderTextBox.Text = row.Cells["Gender"].Value.ToString();
                EmployeeUsernameTextBox.Text = row.Cells["UserUsername"].Value.ToString();
                EmployeePasswordTextBox.Text = row.Cells["UserPassword"].Value.ToString();
                EmployeeAddressTextBox.Text = row.Cells["UserAddress"].Value.ToString();
            }
        }
    }
}
