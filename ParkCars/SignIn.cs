using System;
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
    public partial class SignIn : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source = SABIROUZUMAKI\\SQLEXPRESS; Initial Catalog = parking management database; Integrated Security = SSPI");
        //SqlConnection Connection1 = new SqlConnection("Data Source = SABIROUZUMAKI\\SQLEXPRESS; Initial Catalog = parking management database; Integrated Security = SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        string username2;
        string password2;
        string email2;
        string address2;
        string id2;
        string name2;


        string username1;
        string password1;
        string email1;
        string address1;
        string id1;
        string name1;

        public SignIn()
        {
            InitializeComponent();
            Username.ForeColor = Color.FromArgb(86, 101, 115);
            Password.ForeColor = Color.FromArgb(86, 101, 115);
            Password.Text = "pppppp";
            Username.Text = "U s e r n a m e";
            Connection.Open();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            
            Application.Exit();
            
        }


        private void SignInButton_Click(object sender, EventArgs e)
        {
            
            
            string UserName = Username.Text;
            string PassWord = Password.Text;

            string query = "select *  from Employee;";

            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();

            Boolean flag1 = false;
            Boolean flag2 = false;
            Boolean flag3 = false;
            Boolean flag4 = false;


            try
            {
               
                while (result.Read())
                {
                    string username = result["UserUsername"].ToString();
                    string password = result["UserPassword"].ToString();
                    string email = result["UserEmailAddress"].ToString();
                    string address = result["UserAddress"].ToString();
                    string id = result["UserID"].ToString();
                    string name = result["UserName"].ToString();


                    if (username.Equals(UserName) && password.Equals(PassWord))
                    {

                        flag1 = true;
                        username1 = username;
                        password1 = password;
                        email1 = email;
                        address1 = address;
                        id1 = id;
                        name1 = name;
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(" USER ERROR: " + ex);
            }
            Connection.Close();



            string query1 = "select * from admin;";

            Connection.Open();

            Command1 = new SqlCommand(query1, Connection);
            SqlDataReader result1 = Command1.ExecuteReader();


            try
            {
                
                while (result1.Read())
                {
                    string username = result1["AdminUsername"].ToString();
                    string password = result1["AdminPassword"].ToString();
                    string email = result1["AdminEmailAddress"].ToString();
                    string address = result1["AdminAddress"].ToString();
                    string id = result1["AdminID"].ToString();
                    string name = result1["AdminName"].ToString();



                    if (username.Equals(UserName) && password.Equals(PassWord))
                    {
                        flag2 = true;
                        username2 = username;
                        password2 = password;
                        email2 = email;
                        address2 = address;
                        id2 = id;
                        name2 = name;

                    }
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("ADMIN ERROR: " + ex);
            }
            Connection.Close();



            if (flag1)
            {
                SystemView view1 = new SystemView(name1, id1, username1, email1, address1, password1);
                view1.Show();
                this.Hide();
            }
            else if (flag2)
            {
                AdminSystemView view2 = new AdminSystemView(name2, id2, username2, email2, address2, password2);
                view2.Show();
                this.Hide();
            }
            /*else if (UserName.Equals("e") && PassWord.Equals("e"))
            {
                this.Hide();
                SystemView view3 = new SystemView();
                view3.Show();
           
            }
            else if (UserName.Equals("a") && PassWord.Equals("a"))
            {
                this.Hide();
                AdminSystemView view4 = new AdminSystemView();
                view4.Show();
             
            }*/
            else
            {
                Message.ForeColor = Color.FromArgb(225, 39, 61);
                Message.Text = "Incorrect username or password!!";
            }
        }



        private void Username_Clicked(object sender, MouseEventArgs e)
        {
            Username.Text = "";
            Username.ForeColor = Color.FromArgb(33, 47, 61);
        }

        private void Password_Clicked(object sender, MouseEventArgs e)
        {
            Password.ForeColor = Color.FromArgb(33, 47, 61);
            Password.Text = "";
        }

        private void Username_MouseLeave(object sender, EventArgs e)
        {
            Username.ForeColor = Color.FromArgb(86, 101, 115);
            Username.Text = "U s e r n a m e";
        }

        private void Username_MouseEnter(object sender, EventArgs e)
        {
            Username.Text = "";
            Username.ForeColor = Color.FromArgb(33, 47, 61);
        }

        private void Exit_Clicked(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void EnterKey_Clicked(object sender, KeyEventArgs e)
        {
            Connection.Close();
            if (e.KeyCode == Keys.Enter)
            {
                string UserName = Username.Text;
                string PassWord = Password.Text;

                string query = "select *  from Employee;";

                Connection.Open();
                Command = new SqlCommand(query, Connection);
                SqlDataReader result = Command.ExecuteReader();

                Boolean flag1 = false;
                Boolean flag2 = false;
                Boolean flag3 = false;
                Boolean flag4 = false;


                try
                {

                    while (result.Read())
                    {
                        string username = result["UserUsername"].ToString();
                        string password = result["UserPassword"].ToString();
                        string email = result["UserEmailAddress"].ToString();
                        string address = result["UserAddress"].ToString();
                        string id = result["UserID"].ToString();
                        string name = result["UserName"].ToString();



                        if (username.Equals(UserName) && password.Equals(PassWord))
                        {
                            flag1 = true;
                            username1 = username;
                            password1 = password;
                            email1 = email;
                            address1 = address;
                            id1 = id;
                            name1 = name;
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(" USER ERROR: " + ex);
                }
                Connection.Close();



                string query1 = "select * from admin;";

                Connection.Open();

                Command1 = new SqlCommand(query1, Connection);
                SqlDataReader result1 = Command1.ExecuteReader();


                try
                {

                    while (result1.Read())
                    {
                        string username = result1["AdminUsername"].ToString();
                        string password = result1["AdminPassword"].ToString();
                        string email = result1["AdminEmailAddress"].ToString();
                        string address = result1["AdminAddress"].ToString();
                        string id = result1["AdminID"].ToString();
                        string name = result1["AdminName"].ToString();

                        username2 = username;
                        password2 = password;
                        email2 = email;
                        address2 = address;
                        id2 = id;
                        name2 = name;

                        if (username.Equals(UserName) && password.Equals(PassWord))
                        {
                            flag2 = true;
                            username2 = username;
                            password2 = password;
                            email2 = email;
                            address2 = address;
                            id2 = id;
                            name2 = name;

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ADMIN ERROR: " + ex);
                }
                Connection.Close();



                if (flag1)
                {
                    SystemView view1 = new SystemView(name1, id1, username1, email1, address1, password1);
                    view1.Show();
                    this.Hide();
                }
                else if (flag2)
                {
                    AdminSystemView view2 = new AdminSystemView(name2, id2, username2, email2, address2, password2);
                    view2.Show();
                    this.Hide();
                }
                else if (UserName.Equals("e") && PassWord.Equals("e"))
                {
                    this.Hide();
                    SystemView view3 = new SystemView();
                    view3.Show();
                }
                else if (UserName.Equals("a") && PassWord.Equals("a"))
                {
                    this.Hide();
                    AdminSystemView view4 = new AdminSystemView();
                    view4.Show();
                }
                else
                {
                    Message.ForeColor = Color.FromArgb(225, 39, 61);
                    Message.Text = "Incorrect username or password!!";
                }
            }
        }
    }
}
