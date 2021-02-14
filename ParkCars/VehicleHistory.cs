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
    public partial class VehicleHistory : UserControl
    {
        DatabaseManagement database = new DatabaseManagement();
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        SqlCommand Command2;
        SqlCommand Command3;
        Boolean flag = false;
        public static VehicleHistory _instance;
        public static VehicleHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VehicleHistory();
                }
                return _instance;
            }
        }
        public VehicleHistory()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                string query1 = "Select SlotNumber from carhistory;";
                Connection.Open();
                Command1 = new SqlCommand(query1, Connection);
                SqlDataReader result1 = Command1.ExecuteReader();

                while (result1.Read())
                {
                    string name = result1["SlotNumber"].ToString();
                    flag = true;
                }

                if (!flag)
                {
                    MessageBox.Show("No car entered yet");
                }

                Connection.Close();

                Connection.Open();

                string query = "Select * from carhistory;";

                if (flag)
                {
                    SqlCommand command = new SqlCommand(query, Connection);



                    SqlDataReader DR = command.ExecuteReader();

                    BindingSource source = new BindingSource();

                    source.DataSource = DR;

                    VehileHistoryTable.DataSource = source;
                }


                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        private void FindByUSerID(object sender, KeyEventArgs e)
        {
            try
            {
                Boolean flg = false;
                if (e.KeyCode == Keys.Enter)
                {
                    string id = FindByUserIDTExtBox.Text;

                    string query = "select * from carhistory where ID = '" + id + "' ;";

                    Connection.Open();
                    Command = new SqlCommand(query, Connection);

                    SqlDataReader result = Command.ExecuteReader();

                    while (result.Read())
                    {
                        string userid = result["ID"].ToString();
                        flg = true;
                    }
                    Connection.Close();

                    if (flg)
                    {
                        Connection.Open();
                        Command3 = new SqlCommand(query, Connection);

                        SqlDataReader result1 = Command3.ExecuteReader();

                        BindingSource source = new BindingSource();
                        source.DataSource = result1;

                        VehileHistoryTable.DataSource = source;
                    }
                    if (!flg)
                    {
                        MessageBox.Show("No Data found");
                    }

                }
                Connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show( "Error : " + ex);
            }
           

        }

        private void FindByVehicleID(object sender, KeyEventArgs e)
        {
            try
            {
                Boolean fg = false;

                if (e.KeyCode == Keys.Enter)
                {
                    string vid = FindByVehicleIDTExtBox.Text;

                    string query = "select * from carhistory where CarID = '" + vid + "' ;";

                    Connection.Open();
                    Command = new SqlCommand(query, Connection);

                    SqlDataReader result = Command.ExecuteReader();

                    while (result.Read())
                    {
                        string userid = result["CarID"].ToString();
                        fg = true;
                    }

                    Connection.Close();

                    if (fg)
                    {
                        Connection.Open();
                        Command3 = new SqlCommand(query, Connection);
                        SqlDataReader result2 = Command3.ExecuteReader();

                        BindingSource source = new BindingSource();
                        source.DataSource = result2;

                        VehileHistoryTable.DataSource = source;
                    }
                    if (!fg)
                    {
                        MessageBox.Show("No Data found");
                    }
                }
                Connection.Close();
            }catch(Exception ex1)
            {
                MessageBox.Show("Error : " + ex1);
            }
            
        }

        private void SearchSlotInformation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Boolean fg = false;
                string slotid = SearchBySlotTextBox.Text;
                string time = ChooseTime.Text;

                string query = " Select * from carhistory where SlotNumber = '" + slotid + "' and ParkingTime = '" + time + "' ;";

                Connection.Open();
                Command2 = new SqlCommand(query, Connection);
                SqlDataReader result = Command2.ExecuteReader();

                while (result.Read())
                {
                    string userid = result["CarID"].ToString();
                    fg = true;
                }

                Connection.Close();

                if (fg)
                {
                    Connection.Open();
                    Command3 = new SqlCommand(query, Connection);
                    SqlDataReader result2 = Command3.ExecuteReader();

                    BindingSource source = new BindingSource();
                    source.DataSource = result2;

                    VehileHistoryTable.DataSource = source;

                    Connection.Close();
                }
                if (!fg)
                {
                    MessageBox.Show("No Data found");
                }

            }


        }

        private void SearchSlotInfo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Boolean fg = false;
                string slotid = SearchBySlotTextBox.Text;
                string time1 = TimePickerOne.Text;
                string time2 = TimePickerTwo.Text;

                string query = " Select * from carhistory where SlotNumber = '" + slotid + "' AND  ParkingTime BETWEEN '" + time1 + "' AND '" + time2 + "' ;";

                Connection.Open();
                Command2 = new SqlCommand(query, Connection);
                SqlDataReader result = Command2.ExecuteReader();

                while (result.Read())
                {
                    string userid = result["CarID"].ToString();
                    fg = true;
                }

                Connection.Close();

                if (fg)
                {
                    Connection.Open();
                    Command3 = new SqlCommand(query, Connection);
                    SqlDataReader result2 = Command3.ExecuteReader();

                    BindingSource source = new BindingSource();
                    source.DataSource = result2;

                    VehileHistoryTable.DataSource = source;

                    Connection.Close();
                }
                if (!fg)
                {
                    MessageBox.Show("No Data found");
                }
            }
        }
    }
}
