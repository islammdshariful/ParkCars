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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Data.SqlClient;

namespace ParkCars
{
    public partial class AdminSystemView : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");

        SqlCommand Command1;
        SqlCommand Command2;
        SqlCommand Command3;
        DatabaseManagement database = new DatabaseManagement();
        // Boolean flag = false;
        FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        List<TextBox> textbox = new List<TextBox>();
        string slot;
        string VName;
        string ID;
        string Email;
        string CarID;
        string CarName;
        string CarModel;
        string CarColor;

        public AdminSystemView()
        {
            InitializeComponent();
            Scan();
            timer2.Start();
            //timer1.Start();



            PakingSlot p = new PakingSlot();



            textbox.Add(p.S1); textbox.Add(p.S2); textbox.Add(p.S3); textbox.Add(p.S4); textbox.Add(p.S5); textbox.Add(p.S6); textbox.Add(p.S7);
            textbox.Add(p.S8); textbox.Add(p.S9); textbox.Add(p.S10); textbox.Add(p.S11); textbox.Add(p.S12); textbox.Add(p.S13); textbox.Add(p.S14);
            textbox.Add(p.S15); textbox.Add(p.S16); textbox.Add(p.S17); textbox.Add(p.S18); textbox.Add(p.S19); textbox.Add(p.S20); textbox.Add(p.S21);
            textbox.Add(p.S22); textbox.Add(p.S23); textbox.Add(p.S24); textbox.Add(p.S25); textbox.Add(p.S26); textbox.Add(p.S27); textbox.Add(p.S28);
            textbox.Add(p.S29); textbox.Add(p.S30); textbox.Add(p.S31); textbox.Add(p.S32); textbox.Add(p.S33); textbox.Add(p.S34); textbox.Add(p.S35);
            textbox.Add(p.S36); textbox.Add(p.S37); textbox.Add(p.S38); textbox.Add(p.S39); textbox.Add(p.S40); textbox.Add(p.S41); textbox.Add(p.S42);
            textbox.Add(p.S43); textbox.Add(p.S44); textbox.Add(p.S45); textbox.Add(p.S46); textbox.Add(p.S47); textbox.Add(p.S48); textbox.Add(p.S49);
            textbox.Add(p.S50); textbox.Add(p.S51); textbox.Add(p.S52); textbox.Add(p.S53); textbox.Add(p.S54); textbox.Add(p.S55); textbox.Add(p.S56);
            textbox.Add(p.S57); textbox.Add(p.S58); textbox.Add(p.S59); textbox.Add(p.S60); textbox.Add(p.S61); textbox.Add(p.S62); textbox.Add(p.S63);
            textbox.Add(p.S64); textbox.Add(p.S65); textbox.Add(p.S66); textbox.Add(p.S67); textbox.Add(p.S68); textbox.Add(p.S69); textbox.Add(p.S70);
            textbox.Add(p.S71); textbox.Add(p.S72); textbox.Add(p.S73); textbox.Add(p.S74); textbox.Add(p.S75); textbox.Add(p.S76); textbox.Add(p.S77);
            textbox.Add(p.S78); textbox.Add(p.S79); textbox.Add(p.S80); textbox.Add(p.S81); textbox.Add(p.S82); textbox.Add(p.S83); textbox.Add(p.S84);
            textbox.Add(p.S85); textbox.Add(p.S86); textbox.Add(p.S87); textbox.Add(p.S88); textbox.Add(p.S89); textbox.Add(p.S90); textbox.Add(p.S91);
            textbox.Add(p.S92); textbox.Add(p.S93); textbox.Add(p.S94); textbox.Add(p.S95); textbox.Add(p.S96); textbox.Add(p.S97); textbox.Add(p.S98);
            textbox.Add(p.S99); textbox.Add(p.S100); textbox.Add(p.S101); textbox.Add(p.S102); textbox.Add(p.S103); textbox.Add(p.S104); textbox.Add(p.S105);
            textbox.Add(p.S106); textbox.Add(p.S107); textbox.Add(p.S108); textbox.Add(p.S109); textbox.Add(p.S110); textbox.Add(p.S111); textbox.Add(p.S112);
            textbox.Add(p.S113); textbox.Add(p.S114); textbox.Add(p.S115); textbox.Add(p.S116); textbox.Add(p.S117); textbox.Add(p.S118); textbox.Add(p.S119);
            textbox.Add(p.S120); textbox.Add(p.S121); textbox.Add(p.S122); textbox.Add(p.S123); textbox.Add(p.S124); textbox.Add(p.S125); textbox.Add(p.S126);
            textbox.Add(p.S127); textbox.Add(p.S128); textbox.Add(p.S129); textbox.Add(p.S130); textbox.Add(p.S131); textbox.Add(p.S132); textbox.Add(p.S133);
            textbox.Add(p.S134); textbox.Add(p.S135); textbox.Add(p.S136); textbox.Add(p.S137); textbox.Add(p.S138); textbox.Add(p.S139); textbox.Add(p.S140);
            textbox.Add(p.S141); textbox.Add(p.S142); textbox.Add(p.S143); textbox.Add(p.S144); textbox.Add(p.S145); textbox.Add(p.S146); textbox.Add(p.S147);
            textbox.Add(p.S148); textbox.Add(p.S149); textbox.Add(p.S150); textbox.Add(p.S151); textbox.Add(p.S152); textbox.Add(p.S153); textbox.Add(p.S154);





        }
        string NAME, USERID, USERNAME, EMAIL, ADDRESS, PASSWORD;
        public AdminSystemView(string name, string id, string username, string email, string address, string password)
        {
            InitializeComponent();
            Scan();
            timer2.Start();
            //timer1.Start();

            NAME = name;
            USERID = id;
            USERNAME = username;
            EMAIL = email;
            ADDRESS = address;
            PASSWORD = password;



            PakingSlot p = new PakingSlot();



            textbox.Add(p.S1); textbox.Add(p.S2); textbox.Add(p.S3); textbox.Add(p.S4); textbox.Add(p.S5); textbox.Add(p.S6); textbox.Add(p.S7);
            textbox.Add(p.S8); textbox.Add(p.S9); textbox.Add(p.S10); textbox.Add(p.S11); textbox.Add(p.S12); textbox.Add(p.S13); textbox.Add(p.S14);
            textbox.Add(p.S15); textbox.Add(p.S16); textbox.Add(p.S17); textbox.Add(p.S18); textbox.Add(p.S19); textbox.Add(p.S20); textbox.Add(p.S21);
            textbox.Add(p.S22); textbox.Add(p.S23); textbox.Add(p.S24); textbox.Add(p.S25); textbox.Add(p.S26); textbox.Add(p.S27); textbox.Add(p.S28);
            textbox.Add(p.S29); textbox.Add(p.S30); textbox.Add(p.S31); textbox.Add(p.S32); textbox.Add(p.S33); textbox.Add(p.S34); textbox.Add(p.S35);
            textbox.Add(p.S36); textbox.Add(p.S37); textbox.Add(p.S38); textbox.Add(p.S39); textbox.Add(p.S40); textbox.Add(p.S41); textbox.Add(p.S42);
            textbox.Add(p.S43); textbox.Add(p.S44); textbox.Add(p.S45); textbox.Add(p.S46); textbox.Add(p.S47); textbox.Add(p.S48); textbox.Add(p.S49);
            textbox.Add(p.S50); textbox.Add(p.S51); textbox.Add(p.S52); textbox.Add(p.S53); textbox.Add(p.S54); textbox.Add(p.S55); textbox.Add(p.S56);
            textbox.Add(p.S57); textbox.Add(p.S58); textbox.Add(p.S59); textbox.Add(p.S60); textbox.Add(p.S61); textbox.Add(p.S62); textbox.Add(p.S63);
            textbox.Add(p.S64); textbox.Add(p.S65); textbox.Add(p.S66); textbox.Add(p.S67); textbox.Add(p.S68); textbox.Add(p.S69); textbox.Add(p.S70);
            textbox.Add(p.S71); textbox.Add(p.S72); textbox.Add(p.S73); textbox.Add(p.S74); textbox.Add(p.S75); textbox.Add(p.S76); textbox.Add(p.S77);
            textbox.Add(p.S78); textbox.Add(p.S79); textbox.Add(p.S80); textbox.Add(p.S81); textbox.Add(p.S82); textbox.Add(p.S83); textbox.Add(p.S84);
            textbox.Add(p.S85); textbox.Add(p.S86); textbox.Add(p.S87); textbox.Add(p.S88); textbox.Add(p.S89); textbox.Add(p.S90); textbox.Add(p.S91);
            textbox.Add(p.S92); textbox.Add(p.S93); textbox.Add(p.S94); textbox.Add(p.S95); textbox.Add(p.S96); textbox.Add(p.S97); textbox.Add(p.S98);
            textbox.Add(p.S99); textbox.Add(p.S100); textbox.Add(p.S101); textbox.Add(p.S102); textbox.Add(p.S103); textbox.Add(p.S104); textbox.Add(p.S105);
            textbox.Add(p.S106); textbox.Add(p.S107); textbox.Add(p.S108); textbox.Add(p.S109); textbox.Add(p.S110); textbox.Add(p.S111); textbox.Add(p.S112);
            textbox.Add(p.S113); textbox.Add(p.S114); textbox.Add(p.S115); textbox.Add(p.S116); textbox.Add(p.S117); textbox.Add(p.S118); textbox.Add(p.S119);
            textbox.Add(p.S120); textbox.Add(p.S121); textbox.Add(p.S122); textbox.Add(p.S123); textbox.Add(p.S124); textbox.Add(p.S125); textbox.Add(p.S126);
            textbox.Add(p.S127); textbox.Add(p.S128); textbox.Add(p.S129); textbox.Add(p.S130); textbox.Add(p.S131); textbox.Add(p.S132); textbox.Add(p.S133);
            textbox.Add(p.S134); textbox.Add(p.S135); textbox.Add(p.S136); textbox.Add(p.S137); textbox.Add(p.S138); textbox.Add(p.S139); textbox.Add(p.S140);
            textbox.Add(p.S141); textbox.Add(p.S142); textbox.Add(p.S143); textbox.Add(p.S144); textbox.Add(p.S145); textbox.Add(p.S146); textbox.Add(p.S147);
            textbox.Add(p.S148); textbox.Add(p.S149); textbox.Add(p.S150); textbox.Add(p.S151); textbox.Add(p.S152); textbox.Add(p.S153); textbox.Add(p.S154);





        }

        private void Scan()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                ScannerDevice.Items.Add(Device.Name);
            }

            ScannerDevice.SelectedIndex = -1;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            user.Show();
        }

        private void ParkingSlotButton_Click(object sender, EventArgs e)
        {
            PakingSlot c = new PakingSlot();
            if (!Window.Controls.Contains(c))
            {
                Window.Controls.Add(c);
                c.Dock = DockStyle.Fill;
                c.BringToFront();
            }
            else
            {
                c.BringToFront();
            }
            /* if (!Window.Controls.Contains(PakingSlot.Instance))
             {
                 Window.Controls.Add(PakingSlot.Instance);
                 PakingSlot.Instance.Dock = DockStyle.Fill;
                 PakingSlot.Instance.BringToFront();
             }
             else
             {
                 PakingSlot.Instance.BringToFront();
             }*/


        }

        private void VehicleListButton_Click(object sender, EventArgs e)
        {
            Connection.Close();
            Boolean flag = false;
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
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "No Car Available in the parking slots");
            }

            if (flag)
            {
                CarHistory c = new CarHistory();
                if (!Window.Controls.Contains(c))
                {
                    Window.Controls.Add(c);
                    c.Dock = DockStyle.Fill;
                    c.BringToFront();
                }
                else
                {
                    c.BringToFront();
                }
            }
            Connection.Close();

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

           // timer1.Stop();
            //this.ScannerDevice.Hide();
            //this.Close();
            //Application.Exit();
            SignIn login = new SignIn();
            login.Show();

            //this.Close();
            
            
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();

            }

        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software helps people find parking spots quickly \n "
                                              + "and provide necessary guidelines to make the whole process\n"
                                              + "smooth,reducing frustration and save their valuable time.\n"
                                              + "It also comprises members car’s information, real-time vehicle\n"
                                              + "counting and real-time parking guidance display.");
        }

        public void Frame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                ScannerCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Scanning...\n" + ex + MessageBoxIcon.Error);
            }
        }

        private void ScannerDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[ScannerDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(Frame);
            FinalFrame.Start();
            timer1.Enabled = true;
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            BarcodeReader Reader = new BarcodeReader();
            if (ScannerCamera.Image != null)
            {
                Result Result = Reader.Decode((Bitmap)ScannerCamera.Image);
                try
                {
                    string Decode = Result.ToString().Trim();

                    if (Decode.Equals("001") || Decode.Equals("002") || Decode.Equals("003") || Decode.Equals("004") || Decode.Equals("005") || Decode.Equals("006") || Decode.Equals("007") ||
                        Decode.Equals("008") || Decode.Equals("009") || Decode.Equals("010") || Decode.Equals("011") || Decode.Equals("012") || Decode.Equals("013") || Decode.Equals("014") ||
                        Decode.Equals("015"))
                    {
                        UserIDFromScan.Text = Decode;
                        timer1.Stop();
                        //MessageBox.Show("Scan succecful");
                    }

                    string id = UserIDFromScan.Text;
                    BookSlotByScanning(id);
                    //timer1.Stop();
                   // timer1.Start();
                    timer1.Start();


                }
                catch (Exception ex)
                {

                    //MessageBox.Show("Can't Scanning...\n" + ex + MessageBoxIcon.Error );
                }

                //timer1.Start();
            }


        }

        public void BookSlotByScanning(string id)
        {
            // MessageBox.Show("Welcome");
            UserIDFromScan.Text = "";
            string userid = id;
            //MessageBox.Show(userid);
            for (int i = 0; i < textbox.Count; i++)
            {
                if (textbox[i].BackColor == Color.FromArgb(128, 255, 128))
                {
                    slot = textbox[i].Text;
                    break;
                }
            }
            string time = Clock.Text;
            Boolean flag = false;
            Boolean flag2 = false;
            ArrayList carlist = new ArrayList();
            ArrayList carhistory = new ArrayList();

            String query1 = "select *  from carlist where ID = '" + userid + "';";
            Connection.Open();
            Command1 = new SqlCommand(query1, Connection);
            SqlDataReader result1 = Command1.ExecuteReader();
            try
            {
                while (result1.Read())
                {
                    string idd = result1["ID"].ToString();
                    flag = true;
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }



            String query2 = "select * from member where ID ='" + userid + "';";
            Connection.Open();
            Command2 = new SqlCommand(query2, Connection);
            SqlDataReader result2 = Command2.ExecuteReader();



            Boolean empty = string.IsNullOrEmpty(userid);

            if (empty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "No such type User is available");
            }
            else
            {
                try
                {

                    while (result2.Read())
                    {
                        Name = result2["Name"].ToString();
                        ID = result2["ID"].ToString();
                        Email = result2["EmailAddress"].ToString();
                        CarID = result2["CarID"].ToString();
                        CarName = result2["CarName"].ToString();
                        CarModel = result2["CarModel"].ToString();
                        CarColor = result2["CarColor"].ToString();

                        flag2 = true;

                        carlist.Add(slot);
                        carlist.Add(Name);
                        carlist.Add(ID);
                        carlist.Add(CarID);
                        carlist.Add(CarName);
                        carlist.Add(CarModel);
                        carlist.Add(CarColor);
                        carlist.Add(time);

                        carhistory.Add(slot);
                        carhistory.Add(Name);
                        carhistory.Add(ID);
                        carhistory.Add(Email);
                        carhistory.Add(CarID);
                        carhistory.Add(CarName);
                        carhistory.Add(CarModel);
                        carhistory.Add(CarColor);
                        carhistory.Add(time);

                        /*for (int i = 0; i < textbox.Count; i++)
                        {
                            if (textbox[i].Text == slot)
                            {
                                textbox[i].BackColor = Color.FromArgb(231, 76, 6);
                                break;
                            }
                        }*/

                    }
                    Connection.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Adding Error" + exx);
                }

                if (flag)
                {
                    string query3 = "delete from carlist where ID = '" + userid + "'; ";

                    try
                    {
                        Connection.Open();
                        Command3 = new SqlCommand(query3, Connection);
                        Command3.ExecuteNonQuery();



                        //ParkingSlotButton.Select();

                        PakingSlot c = new PakingSlot();
                        if (!Window.Controls.Contains(c))
                        {
                            Window.Controls.Add(c);
                            c.Dock = DockStyle.Fill;
                            c.BringToFront();

                        }
                        else
                        {
                            //Window.Controls.Add(c);
                            //c.Dock = DockStyle.Fill;
                            c.BringToFront();
                        }
                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(1))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        for (int i = 0; i < 153; i++)
                        {
                            if (textbox[i].Text == slot)
                            {
                                textbox[i].BackColor = Color.FromArgb(128, 255, 128);
                                break;
                            }
                        }
                        MessageBox.Show(w, "Vehicle Removed");
                        Connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Removing Error: " + ex);
                        Console.WriteLine("Error: " + ex);
                    }


                }
                else if (!flag2)
                {
                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(2))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w, "No such type member  available");
                    //Connection.Close();
                }
                else
                {
                    database.InsertCarIntoPark(carlist);

                    database.CarEnterHistory(carhistory);
                    for (int i = 0; i < textbox.Count; i++)
                    {
                        if (textbox[i].Text == slot)
                        {
                            textbox[i].BackColor = Color.FromArgb(231, 76, 6);
                            break;
                        }
                    }
                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(1))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w, "Vehicle Added to slot");
                    ParkingDetailsWindow pw = new ParkingDetailsWindow(CarID, CarName, CarModel, CarColor, slot);
                    pw.Show();

                    PakingSlot c = new PakingSlot();


                    if (!Window.Controls.Contains(c))
                    {
                        Window.Controls.Add(c);
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

        private void SystemView_Load(object sender, EventArgs e)
        {
            //carHistory1.Hide();
            //pakingSlot1.Hide();
            //home1.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!Window.Controls.Contains(Home.Instance))
            {
                Window.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
            {
                Home.Instance.BringToFront();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            this.Clock.Text = datetime.ToString();
        }

        private void VehicleRecordsMenu_Click(object sender, EventArgs e)
        {

            Connection.Close();
            Boolean flag = false;
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
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "No car entered yet");
            }

            if (flag)
            {
                VehicleHistory c = new VehicleHistory();
                if (!Window.Controls.Contains(c))
                {
                    Window.Controls.Add(c);
                    c.Dock = DockStyle.Fill;
                    c.BringToFront();
                }
                else
                {
                    c.BringToFront();
                }
            }
            Connection.Close();

        }

        private void ViewMemberMenu_Click(object sender, EventArgs e)
        {

            Connection.Close();
            Boolean flag = false;
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
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w, "No member available");
            }

            if (flag)
            {
                ViewUsers c = new ViewUsers();
                if (!Window.Controls.Contains(c))
                {
                    Window.Controls.Add(c);
                    c.Dock = DockStyle.Fill;
                    c.BringToFront();
                }
                else
                {
                    c.BringToFront();
                }
            }
            Connection.Close();

        }

        private void EmployeeInformationButton_Click(object sender, EventArgs e)
        {
            EmployeeInformation c = new EmployeeInformation();
            if (!Window.Controls.Contains(c))
            {
                Window.Controls.Add(c);
                c.Dock = DockStyle.Fill;
                c.BringToFront();
            }
            else
            {
                c.BringToFront();
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployee n = new NewEmployee();
            n.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            AdminProfile c = new AdminProfile(NAME, USERID, USERNAME, EMAIL, ADDRESS, PASSWORD);
            if (!Window.Controls.Contains(c))
            {
                Window.Controls.Add(c);
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
