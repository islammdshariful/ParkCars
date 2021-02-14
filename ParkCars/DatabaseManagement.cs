using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkCars
{
    class DatabaseManagement
    {
        SqlCommand Command;
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");

        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }



        public void ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                Command = new SqlCommand(query, Connection);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Successfully.");
                   // MessageBox.Show("Successfully");
                }
                else
                {
                    Console.WriteLine("Unsuccessfully.");
                    MessageBox.Show("Unsuccessfully");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Can't excute query. " + e.Message);
                MessageBox.Show("Unsuccessfully." + e.Message);

            }
            finally
            {
                CloseConnection();
            }

        }

        public void InsertNewUser(ArrayList user)
        {
            string name = (string)user[0];
            string id = (string)user[1];
            string email = (string)user[2];
            string gender = (string)user[3];
            string carid = (string)user[4];
            string carname = (string)user[5];
            string carmodel = (string)user[6];
            string carcolor = (string)user[7];

            string query = "insert into member(Name,ID,EmailAddress,Gender,CarID,CarName,CarModel,CarColor)values("
                            + "'" + name + "',"
                            + "'" + id + "',"
                            + "'" + email + "',"
                            + "'" + gender + "',"
                            + "'" + carid + "',"
                            + "'" + carname + "',"
                            + "'" + carmodel + "',"
                            + "'" + carcolor + "'"
                            + ")";

            ExecuteQuery(query);


        }

        public void InsertNewEmployee(ArrayList employee)
        {
            string id = (string)employee[0];
            string name = (string)employee[1];
            string email = (string)employee[2];
            string username = (string)employee[3];
            string userpassword = (string)employee[4];
            string gender = (string)employee[5];
            string useraddress = (string)employee[6];

            String query = "insert into Employee(UserID,UserName,UserEmailAddress,UserUsername,UserPassword,Gender,UserAddress)values("
                            + "'" + id + "',"
                            + "'" + name + "',"
                            + "'" + email + "',"
                            + "'" + username + "',"
                            + "'" + userpassword + "',"
                            + "'" + gender + "',"
                            + "'" + useraddress + "'"
                            + ")";

            ExecuteQuery(query);

        }

        public void InsertCarIntoPark(ArrayList park)
        {
            string slotnumber = (string)park[0];
            string name = (string)park[1];
            string id = (string)park[2];
            string carid = (string)park[3];
            string carname = (string)park[4];
            string carmodel = (string)park[5];
            string carcolor = (string)park[6];
            string time = (string)park[7];
            String query = "insert into carlist(SlotNumber,Name,ID,CarID,CarName,CarModel,CarColor,ParkingTime)values("
                            + "'" + slotnumber + "',"
                            + "'" + name + "',"
                            + "'" + id + "',"
                            + "'" + carid + "',"
                            + "'" + carname + "',"
                            + "'" + carmodel + "',"
                            + "'" + carcolor + "',"
                            + "'" + time + "'"
                            + ")";
            ExecuteQuery(query);
        }

        public void CarEnterHistory(ArrayList history)
        {
            string slotnumber = (string)history[0];
            string name = (string)history[1];
            string id = (string)history[2];
            string email = (string)history[3];
            string carid = (string)history[4];
            string carname = (string)history[5];
            string carmodel = (string)history[6];
            string carcolor = (string)history[7];
            string time = (string)history[8];
            //string left = (string)history[9];
            String query = "insert into carhistory(SlotNumber,Name,ID,EmailAddress,CarID,CarName,CarModel,CarColor,ParkingTime,LeftTime)values("
                            + "'" + slotnumber + "',"
                            + "'" + name + "',"
                            + "'" + id + "',"
                            + "'" + email + "',"
                            + "'" + carid + "',"
                            + "'" + carname + "',"
                            + "'" + carmodel + "',"
                            + "'" + carcolor + "',"
                            + "'" + time + "',"
                            + "'" + "00:00:00" + "'"
                            + ")";

            ExecuteQuery(query);

        }
    }



}
