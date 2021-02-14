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

    public partial class NewEmployee : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        DatabaseManagement database = new DatabaseManagement();


        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {

        }


        private void NewEmployeeSaveButton_Click(object sender, EventArgs e)
        {
            ArrayList Employee = new ArrayList();
            string EmployeeName = NewEmployeeNameTextBox.Text;
            string EmployeeAddress = NewEmployeeAddressTextBok.Text;
            string EmployeeEmail = NewEmployeeEmailTextBox.Text;
            string EmployeeID = NewEmployeeIDTextBox.Text;
            string EmployeePassword = NewEmployeePasswordTextBox.Text;
            string EmployeeRePassword = NewEmployeeRePasswordTextBox.Text;
            string EmployeeUsername = NewEmployeeUsernameTextBox.Text;
            string EmployeeGender = "";

            Boolean flag = false;
            Boolean flag1 = false;


            if (MaleEmployee.Checked)
            {
                EmployeeGender = "Male";
            }
            if (FemaleEmployee.Checked)
            {
                EmployeeGender = "Female";
            }

            Boolean empty = string.IsNullOrEmpty(EmployeeName) || string.IsNullOrEmpty(EmployeeAddress) || string.IsNullOrEmpty(EmployeeEmail) || string.IsNullOrEmpty(EmployeeID) || string.IsNullOrEmpty(EmployeePassword) || string.IsNullOrEmpty(EmployeeRePassword) || string.IsNullOrEmpty(EmployeeUsername) || string.IsNullOrEmpty(EmployeeGender);



            string query = "select UserID  from Employee where UserID= '" + EmployeeID + "';";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();

            while (result.Read())
            {
                string id = result["UserID"].ToString();
                flag = true;
            }
            Connection.Close();
            string query1 = "select UserUsername  from Employee where UserUsername= '" + EmployeeUsername + "';";
            Connection.Open();
            Command1 = new SqlCommand(query1, Connection);
            SqlDataReader result1 = Command1.ExecuteReader();
            

            while (result1.Read())
            {
                string name = result1["UserUsername"].ToString();
                flag1 = true;
            }

            Connection.Close();

            if (empty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Please fill all the fields");
            }
            else if (!EmployeePassword.Equals(EmployeeRePassword))
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Password not matched");
            }
            else if (flag)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"ID already exist");
            }
            else if (flag1)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Username not available");
            }
            else
            {
                Employee.Add(EmployeeID);
                Employee.Add(EmployeeName);
                Employee.Add(EmployeeEmail);
                Employee.Add(EmployeeUsername);
                Employee.Add(EmployeeRePassword);
                Employee.Add(EmployeeGender);
                Employee.Add(EmployeeAddress);
                database.InsertNewEmployee(Employee);
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Employee Added successfully");
            }

            EmployeeInformation eq = new EmployeeInformation();
            eq.LoadData();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            NewEmployeeNameTextBox.Text = "";
            NewEmployeeAddressTextBok.Text = "";
            NewEmployeeEmailTextBox.Text = "";
            NewEmployeeIDTextBox.Text = "";
            NewEmployeePasswordTextBox.Text = "";
            NewEmployeeRePasswordTextBox.Text = "";
            NewEmployeeUsernameTextBox.Text = "";
            FemaleEmployee.Checked = false;
            MaleEmployee.Checked = false;
        }
    }
}
