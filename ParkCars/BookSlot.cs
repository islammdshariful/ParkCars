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
    public partial class BookSlot : Form
    {
        public TextBox s1;
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        SqlCommand Command1;
        SqlCommand Command4;
        DatabaseManagement database = new DatabaseManagement();

        string VName;
        string ID;
        string Email;
        string CarID;
        string CarName;
        string CarModel;
        string CarColor;


        List<TextBox> textbox = new List<TextBox>();

        string slotid;

        public BookSlot()
        {
            InitializeComponent();
            timer1.Start();
        }

        public BookSlot(List<TextBox> box , string id)
        {
            InitializeComponent();
            
            timer1.Start();

            textbox = box;

            SlotNumber.Text = id;

        }

        private void BookSlotButton_Click(object sender, EventArgs e)
        {
            string id = UserIDForBookSlot.Text;
            //string time = TimeForStay.Text;
            string slot = SlotNumber.Text;

            //string time = Clock.Text;
            string time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            Boolean flag = false;
            Boolean flag2 = false;
            Boolean flag1 = false;
            ArrayList carlist = new ArrayList();
            ArrayList carhistory = new ArrayList();

            String query1 = "select *  from carlist where ID = '" + id + "';";
            Connection.Open();
            Command = new SqlCommand(query1, Connection);
            SqlDataReader result1 = Command.ExecuteReader();
            try
            {
                while (result1.Read())
                {
                    string idd = result1["ID"].ToString();
                    flag = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            Connection.Close();

            String query4 = "select *  from carlist where SlotNumber = '" + slot + "';";
            Connection.Open();
            Command4 = new SqlCommand(query4, Connection);
            SqlDataReader result4 = Command4.ExecuteReader();
            try
            {
                while (result4.Read())
                {
                    string s = result4["SlotNumber"].ToString();
                    flag1 = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Connection.Close();
            String query2 = "select * from member where id ='" + id + "';";
            Connection.Open();
            Command1 = new SqlCommand(query2, Connection);
            SqlDataReader result2 = Command1.ExecuteReader();


            Boolean empty = string.IsNullOrEmpty(id);

            if (empty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "Plase enter User ID");

            }
            else if (flag1)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "Slot not available");
                Connection.Close();
            }
            else if (flag)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Car already available in the park");
                Connection.Close();
            }
            else
            {
                try
                {
                    while (result2.Read())
                    {
                        VName = result2["Name"].ToString();
                        ID = result2["ID"].ToString();
                        Email = result2["EmailAddress"].ToString();
                        CarID = result2["CarID"].ToString();
                        CarName = result2["CarName"].ToString();
                        CarModel = result2["CarModel"].ToString();
                        CarColor = result2["CarColor"].ToString();

                        flag2 = true;

                        carlist.Add(slot);
                        carlist.Add(VName);
                        carlist.Add(ID);
                        carlist.Add(CarID);
                        carlist.Add(CarName);
                        carlist.Add(CarModel);
                        carlist.Add(CarColor);
                        carlist.Add(time);
                        //carlist.Add(DateTime.Now.ToString());

                        carhistory.Add(slot);
                        carhistory.Add(VName);
                        carhistory.Add(ID);
                        carhistory.Add(Email);
                        carhistory.Add(CarID);
                        carhistory.Add(CarName);
                        carhistory.Add(CarModel);
                        carhistory.Add(CarColor);
                        carhistory.Add(time);

                        for (int i = 0; i < textbox.Count; i++)
                        {
                            if (textbox[i].Text == slot)
                            {
                                textbox[i].BackColor = Color.FromArgb(231, 76, 6);
                                break;
                            }
                        }

                        
                    }

                    if (!flag2)
                    {
                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(2))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        MessageBox.Show(w, "No such type member  available");
                        Connection.Close();
                    }
                    else
                    {
                        database.InsertCarIntoPark(carlist);

                        database.CarEnterHistory(carhistory);
                       // MessageBox.Show("Vehicle Added to slot");
                        ParkingDetailsWindow pw = new ParkingDetailsWindow(CarID, CarName, CarModel, CarColor, slot);
                        pw.Show();
                    }
                    Connection.Close();

                }
                catch(Exception exx)
                {
                    MessageBox.Show("Error: " + exx);
                }
                
            }




        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UserIDForBookSlot.Text = "";
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            this.Clock.Text = datetime.ToString();
        }

        private void BookSlot_Load(object sender, EventArgs e)
        {

        }
    }
}
