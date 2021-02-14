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
    public partial class ViewUsers : UserControl
    {

        DatabaseManagement database = new DatabaseManagement();
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command1;
        Boolean flag = false;
        public static ViewUsers _instance;
        public static ViewUsers Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewUsers();
                }
                return _instance;
            }
        }

        public ViewUsers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                string query1 = "Select ID from member;";
                Connection.Open();
                Command1 = new SqlCommand(query1, Connection);
                SqlDataReader result1 = Command1.ExecuteReader();

                while (result1.Read())
                {
                    string id = result1["ID"].ToString();
                    flag = true;
                }

                if (!flag)
                {
                    MessageBox.Show("No ember available");
                }

                Connection.Close();

                Connection.Open();

                string query = "Select * from member;";

                if (flag)
                {
                    SqlCommand command = new SqlCommand(query, Connection);



                    SqlDataReader DR = command.ExecuteReader();

                    BindingSource source = new BindingSource();

                    source.DataSource = DR;

                    ViewUserTables.DataSource = source;
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
