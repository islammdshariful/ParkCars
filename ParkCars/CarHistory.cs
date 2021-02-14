using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace ParkCars
{
    public partial class CarHistory : UserControl
    {
        DatabaseManagement database = new DatabaseManagement();
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        Boolean flag = false;

        public static CarHistory _instance;
        public static CarHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CarHistory();
                }
                return _instance;
            }
        }
        public CarHistory()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                string query1 = "Select SlotNumber from carlist;";
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
                    MessageBox.Show("No Vehicle Available in the parking slots");
                }

                Connection.Close();

                Connection.Open();

                string query = "Select * from carlist;";

                if (flag)
                {
                    SqlCommand command = new SqlCommand(query, Connection);



                    SqlDataReader DR = command.ExecuteReader();

                    BindingSource source = new BindingSource();

                    source.DataSource = DR;

                    CarlistTable.DataSource = source;
                }


                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
    }
}
