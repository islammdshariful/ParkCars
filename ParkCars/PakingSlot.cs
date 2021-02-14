using System;
using System.Collections;
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
    public partial class PakingSlot : UserControl
    {
        SqlConnection Connection = new SqlConnection("Data Source=SABIROUZUMAKI\\SQLEXPRESS;Initial Catalog=parking management database;Integrated Security=SSPI");
        SqlCommand Command;
        
        ArrayList slotid = new ArrayList();
        public static PakingSlot _instance;
        List<TextBox> textbox = new List<TextBox>();
        List<TextBox> status = new List<TextBox>();

        //Boolean flag = false;
        //int i = 0;

        public static PakingSlot Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new PakingSlot();   
                }
                return _instance;
            }
        }

        public PakingSlot()
        {
            InitializeComponent();
            checkStatus();
            timer1.Start();
            //List<TextBox> textbox = new List<TextBox>();

            //textbox.Add(S1);
           /* foreach(TextBox tb in flowLayoutPanel1.Controls.OfType<TextBox>())
            {
                textbox.Add(tb);
            }*/




            textbox.Add(S1); textbox.Add(S2); textbox.Add(S3); textbox.Add(S4); textbox.Add(S5); textbox.Add(S6); textbox.Add(S7);
            textbox.Add(S8); textbox.Add(S9); textbox.Add(S10); textbox.Add(S11); textbox.Add(S12); textbox.Add(S13); textbox.Add(S14);
            textbox.Add(S15); textbox.Add(S16); textbox.Add(S17); textbox.Add(S18); textbox.Add(S19); textbox.Add(S20); textbox.Add(S21);
            textbox.Add(S22); textbox.Add(S23); textbox.Add(S24); textbox.Add(S25); textbox.Add(S26); textbox.Add(S27); textbox.Add(S28);
            textbox.Add(S29); textbox.Add(S30); textbox.Add(S31); textbox.Add(S32); textbox.Add(S33); textbox.Add(S34); textbox.Add(S35);
            textbox.Add(S36); textbox.Add(S37); textbox.Add(S38); textbox.Add(S39); textbox.Add(S40); textbox.Add(S41); textbox.Add(S42);
            textbox.Add(S43); textbox.Add(S44); textbox.Add(S45); textbox.Add(S46); textbox.Add(S47); textbox.Add(S48); textbox.Add(S49);
            textbox.Add(S50); textbox.Add(S51); textbox.Add(S52); textbox.Add(S53); textbox.Add(S54); textbox.Add(S55); textbox.Add(S56);
            textbox.Add(S57); textbox.Add(S58); textbox.Add(S59); textbox.Add(S60); textbox.Add(S61); textbox.Add(S62); textbox.Add(S63);
            textbox.Add(S64); textbox.Add(S65); textbox.Add(S66); textbox.Add(S67); textbox.Add(S68); textbox.Add(S69); textbox.Add(S70);
            textbox.Add(S71); textbox.Add(S72); textbox.Add(S73); textbox.Add(S74); textbox.Add(S75); textbox.Add(S76); textbox.Add(S77);
            textbox.Add(S78); textbox.Add(S79); textbox.Add(S80); textbox.Add(S81); textbox.Add(S82); textbox.Add(S83); textbox.Add(S84);
            textbox.Add(S85); textbox.Add(S86); textbox.Add(S87); textbox.Add(S88); textbox.Add(S89); textbox.Add(S90); textbox.Add(S91);
            textbox.Add(S92); textbox.Add(S93); textbox.Add(S94); textbox.Add(S95); textbox.Add(S96); textbox.Add(S97); textbox.Add(S98);
            textbox.Add(S99); textbox.Add(S100); textbox.Add(S101); textbox.Add(S102); textbox.Add(S103); textbox.Add(S104); textbox.Add(S105);
            textbox.Add(S106); textbox.Add(S107); textbox.Add(S108); textbox.Add(S109); textbox.Add(S110); textbox.Add(S111); textbox.Add(S112);
            textbox.Add(S113); textbox.Add(S114); textbox.Add(S115); textbox.Add(S116); textbox.Add(S117); textbox.Add(S118); textbox.Add(S119);
            textbox.Add(S120); textbox.Add(S121); textbox.Add(S122); textbox.Add(S123); textbox.Add(S124); textbox.Add(S125); textbox.Add(S126);
            textbox.Add(S127); textbox.Add(S128); textbox.Add(S129); textbox.Add(S130); textbox.Add(S131); textbox.Add(S132); textbox.Add(S133);
            textbox.Add(S134); textbox.Add(S135);textbox.Add(S136); textbox.Add(S137); textbox.Add(S138); textbox.Add(S139); textbox.Add(S140);
            textbox.Add(S141); textbox.Add(S142);textbox.Add(S143); textbox.Add(S144); textbox.Add(S145); textbox.Add(S146); textbox.Add(S147);
            textbox.Add(S148); textbox.Add(S149);textbox.Add(S150); textbox.Add(S151); textbox.Add(S152); textbox.Add(S153); textbox.Add(S154); 


        }

        public void checkStatus()
        {
            string query = "Select SlotNumber from carlist";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();
            try
            {

                while (result.Read())
                {

                    string slot = result["SlotNumber"].ToString();

                    switch (slot)
                    {
                        case "1":
                              S1.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "2":
                              S2.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "3":
                              S3.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "4":
                              S4.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "5":
                              S5.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "6":
                              S6.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "7":
                              S7.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "8":
                              S8.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "9":
                              S9.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "10":
                             S10.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "11":
                              S11.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "12":
                              S12.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "13":
                              S13.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "14":
                              S14.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "15":
                              S15.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "16":
                              S16.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "17":
                              S17.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "18":
                              S18.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "19":
                              S19.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "20":
                              S20.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "21":
                              S21.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "22":
                              S22.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "23":
                              S23.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "24":
                              S24.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "25":
                              S25.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "26":
                              S26.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "27":
                              S27.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "28":
                              S28.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "29":
                              S29.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "30":
                              S30.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "31":
                              S31.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "32":
                              S32.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "33":
                              S33.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "34":
                              S34.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "35":
                              S35.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "36":
                              S36.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "37":
                              S37.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "38":
                              S38.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "39":
                              S39.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "40":
                              S40.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "41":
                             S41.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "42":
                             S42.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "43":
                             S43.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "44":
                             S44.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "45":
                             S45.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "46":
                             S46.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "47":
                             S47.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "48":
                              S48.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "49":
                              S49.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "50":
                              S50.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "51":
                              S51.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "52":
                              S52.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "53":
                              S53.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "54":
                              S54.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "55":
                              S55.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "56":
                              S56.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "57":
                              S57.BackColor = Color.FromArgb(231, 76, 60);
                              break;
                        case "58":
                              S58.BackColor = Color.FromArgb(231, 76, 60); ;
                              break;
                        case "59":
                             S59.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "60":
                             S60.BackColor = Color.FromArgb(231, 76, 60);
                             break;
                        case "61":
                            S61.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "62":
                            S62.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "63":
                            S63.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "64":
                            S64.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "65":
                            S65.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "66":
                            S66.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "67":
                            S67.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "68":
                            S68.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "69":
                            S69.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "70":
                            S70.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "71":
                            S71.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "72":
                            S72.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "73":
                            S73.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "74":
                            S74.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "75":
                            S75.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "76":
                            S76.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "77":
                            S77.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "78":
                            S78.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "79":
                            S79.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "80":
                            S80.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "81":
                            S81.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "82":
                            S82.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "83":
                            S83.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "84":
                            S84.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "85":
                            S85.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "86":
                            S86.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "87":
                            S87.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "88":
                            S88.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "89":
                            S89.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "90":
                            S10.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "91":
                            S91.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "92":
                            S92.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "93":
                            S93.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "94":
                            S94.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "95":
                            S95.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "96":
                            S96.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "97":
                            S97.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "98":
                            S98.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "99":
                            S99.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "100":
                            S100.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "101":
                            S101.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "102":
                            S102.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "103":
                            S103.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "104":
                            S104.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "105":
                            S105.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "106":
                            S106.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "107":
                            S107.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "108":
                            S108.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "109":
                            S109.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "110":
                            S110.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "111":
                            S111.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "112":
                            S112.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "113":
                            S113.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "114":
                            S114.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "115":
                            S115.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "116":
                            S116.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "117":
                            S117.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "118":
                            S118.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "119":
                            S119.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "120":
                            S120.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "121":
                            S121.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "122":
                            S122.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "123":
                            S123.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "124":
                            S124.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "125":
                            S125.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "126":
                            S126.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "127":
                            S127.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "128":
                            S128.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "129":
                            S129.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "130":
                            S130.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "131":
                            S131.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "132":
                            S132.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "133":
                            S133.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "134":
                            S134.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "135":
                            S135.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "136":
                            S136.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "137":
                            S137.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "138":
                            S138.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "139":
                            S139.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "140":
                            S140.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "141":
                            S141.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "142":
                            S142.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "143":
                            S143.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "144":
                            S144.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "145":
                            S145.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "146":
                            S146.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "147":
                            S147.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "148":
                            S148.BackColor = Color.FromArgb(231, 76, 60); ;
                            break;
                        case "149":
                            S149.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "150":
                            S150.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "151":
                            S151.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "152":
                            S152.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "153":
                            S153.BackColor = Color.FromArgb(231, 76, 60);
                            break;
                        case "154":
                            S154.BackColor = Color.FromArgb(231, 76, 60);
                            break;

                    }

                    /*for (int i = 0; i < textbox.Count; i++)
                    {
                        if (textbox[i].Text == slot)
                        {
                            textbox[i].BackColor = Color.FromArgb(231, 76, 60);
                            //break;
                        }

                    }*/
                }

                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                Console.WriteLine("Error: " + ex);
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string ID = UserIDForSearchInformationTextBox.Text;
            string Name = SearchResultName.Text;
            string Email = SearchResultEmail.Text;
            string CarID = SearchResultVehicleID.Text;
            string CarName = SearchResultVehicleName.Text;
            string CarModel = SearchResultVehicleModel.Text;
            string CarColour = SearchResultVehicleColor.Text;

            Boolean empty = string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(CarID) || string.IsNullOrEmpty(CarName) || string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(CarColour); ;

            String query = "update member  set Name = '" + Name + "', EmailAddress = '" + Email + "', CarID = '" + CarID + "', CarName = '" + CarName + "', CarModel = '" + CarModel + "', CarColor = '" + CarColour + "' WHERE ID = '" + ID + "';";
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            try
            {
                Connection.Open();
                Command = new SqlCommand(query, Connection);


                if (empty)
                {

                    MessageBox.Show(w, "Please fill all the fields.", " Error !");
                }
                else
                {
                    Command.ExecuteNonQuery();
                    MessageBox.Show(w, "User Updated");
                    Connection.Close();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't update data in Member table." + ex);

            }
            Connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string ID = UserIDForSearchInformationTextBox.Text;
            string Name = SearchResultName.Text;
            string Email = SearchResultEmail.Text;
            string CarID = SearchResultVehicleID.Text;
            string CarName = SearchResultVehicleName.Text;
            string CarModel = SearchResultVehicleModel.Text;
            string CarColour = SearchResultVehicleColor.Text;

            Boolean empty = string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(CarID) || string.IsNullOrEmpty(CarName) || string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(CarColour); ;

            String query = " delete from member where ID = '" + ID + "' ;";
            try
            {
                if (empty)
                {
                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(1))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w, "No cars to delete.", " Error !");
                }
                else
                {
                    Command = new SqlCommand(query, Connection);
                    DialogResult dr = MessageBox.Show("Are you sure, you want delete this user?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Connection.Open();
                        Command = new SqlCommand(query, Connection);
                        Command.ExecuteNonQuery();

                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(1))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        MessageBox.Show(w, "User Removed", " Error !");
                        UserIDForSearchInformationTextBox.Text = "";
                        SearchResultName.Text = "";
                        SearchResultEmail.Text = "";
                        SearchResultVehicleID.Text = "";
                        SearchResultVehicleName.Text = "";
                        SearchResultVehicleModel.Text = "";
                        SearchResultVehicleColor.Text = "";
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(1))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"Can't delete data from Member table.", " Error !" + ex);
                
            }
        }



        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string vehicleid = VehicleID.Text;
            string vehivclename = VehicleName.Text;
            string vehivlemodel = VehicleModel.Text;
            string vehiclecolor = VehicleColour.Text;
            string slotid = SlotIDNumber.Text;


            //string time = Clock.Text;
            string time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            Boolean emplty = string.IsNullOrEmpty(vehicleid) || string.IsNullOrEmpty(vehivclename) || string.IsNullOrEmpty(vehivlemodel) || string.IsNullOrEmpty(vehiclecolor) || string.IsNullOrEmpty(slotid);

            String query = "delete from carlist where SlotNumber = '" + slotid + "';";

            string query1 = "update carhistory set LeftTime = '" + time + "' where SlotNumber = '" + slotid + "';";




            if (emplty)
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                MessageBox.Show(w,"No car to delete");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure want to Remove this vehicle?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i <153; i++)
                        {
                            if (textbox[i].Text == slotid)
                            {
                                textbox[i].BackColor = Color.FromArgb(128, 255, 128);
                                //PakingSlot p = new PakingSlot();
                                break;
                            }
                        }
                        Connection.Open();
                        Command = new SqlCommand(query, Connection);
                        Command.ExecuteNonQuery();
                        Connection.Close();

                        Connection.Open();
                        Command = new SqlCommand(query1, Connection);
                        Command.ExecuteNonQuery();

                        VehicleID.Text = "";
                        VehicleName.Text = "";
                        VehicleModel.Text = "";
                        VehicleColour.Text = "";

                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(2))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        MessageBox.Show(w, "Vehicle removed.");

                        Connection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                        Console.WriteLine("Error: " + ex);
                    }
                    
                }
                

            }





        }


            
        private void SearchSlotNumberByCarID(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string carid = CarIDForSearchTextBox.Text;
                Boolean flag = false;

                Boolean empty = string.IsNullOrEmpty(carid);

                string query = "select * from carlist where CarID = '" + carid + "';";
                Connection.Open();

                Command = new SqlCommand(query, Connection);
                SqlDataReader result = Command.ExecuteReader();
                try
                {
                    while (result.Read())
                    {
                        string SlotNumber = result["SlotNumber"].ToString();
                        string Time = result["ParkingTime"].ToString();

                        SlotNumberTextBox.ForeColor = Color.FromArgb(253, 254, 254);

                        SlotNumberTextBox.Text = SlotNumber;

                        ParkingTimeTextBox.Text = Time;
                        flag = true;

                    }
                    Connection.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }

                if (empty)
                {
                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(1))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w,"Please enter a vehicle ID");
                }
                else if (!flag)
                {
                    SlotNumberTextBox.ForeColor = Color.FromArgb(231, 76, 60);
                    SlotNumberTextBox.Text = "No such car available in parking slot";
                    ParkingTimeTextBox.Text = "";
                }

            }
        }

        private void SearchSlotNumberByUserID(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = UserIDForSearchTextBox.Text;

                Boolean flag = false;
                Boolean emplty = string.IsNullOrEmpty(id);

                String query = "select * from carlist where ID = '" + id + "';";
                Connection.Open();
                Command = new SqlCommand(query, Connection);
                SqlDataReader result = Command.ExecuteReader();
                try
                {
                    while (result.Read())
                    {
                        string SlotNumber = result["SlotNumber"].ToString();
                        string Time = result["ParkingTime"].ToString();

                        SlotNumberTextBox.ForeColor = Color.FromArgb(253, 254, 254);

                        SlotNumberTextBox.Text = SlotNumber;

                        ParkingTimeTextBox.Text = Time;
                        flag = true;

                    }
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                if (emplty)
                {
                    var w = new Form() { Size = new Size(0, 0) };
                    Task.Delay(TimeSpan.FromSeconds(1))
                        .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                    MessageBox.Show(w,"Please enter  a user ID");
                }
                else if (!flag)
                {
                    SlotNumberTextBox.ForeColor = Color.FromArgb(231, 76, 60);
                    SlotNumberTextBox.Text = "No such car available in parking slot";
                    ParkingTimeTextBox.Text = "";
                }
            }


        }
  

        public void findvehicle(String i)
        {
            String slotID = i;

            String query = "select * from carlist where SlotNumber = '" + slotID + "';";
            Connection.Open();
            Command = new SqlCommand(query, Connection);
            SqlDataReader result = Command.ExecuteReader();
            while (result.Read())
            {
                String CarID = result["CarID"].ToString();
                String CarName = result["CarName"].ToString();
                String CarModel = result["CarModel"].ToString();
                String CarColor = result["CarColor"].ToString();



                SlotIDNumber.Text = slotID;
                VehicleID.Text = CarID;
                VehicleName.Text = CarName;
                VehicleModel.Text = CarModel;
                VehicleColour.Text = CarColor;
            }
            Connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Clock.Text = dateTime.ToString();
        }

        private void S1ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S1.Text;



            if (S1.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S2ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S2.Text;



            if (S2.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S3ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S3.Text;



            if (S3.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S4ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S4.Text;



            if (S4.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S5ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S5.Text;



            if (S5.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S6ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S6.Text;



            if (S6.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S7ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S7.Text;



            if (S7.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S8ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S8.Text;



            if (S8.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S9ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S9.Text;



            if (S9.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S10ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S10.Text;



            if (S10.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S11ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S11.Text;



            if (S11.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S12ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S12.Text;



            if (S12.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S13ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S13.Text;



            if (S13.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S14ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S14.Text;



            if (S14.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S15ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S15.Text;



            if (S15.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S16ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S16.Text;



            if (S16.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S17ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S17.Text;



            if (S17.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S18ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S18.Text;



            if (S18.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S19ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S19.Text;



            if (S19.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S20ButtonClicked(object sender, EventArgs e)
        {

        }
        private void S21ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S21.Text;



            if (S21.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S22ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S22.Text;



            if (S22.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S23ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S23.Text;



            if (S23.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S24ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S24.Text;



            if (S24.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S25ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S25.Text;



            if (S25.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S26ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S26.Text;



            if (S26.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S27ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S7.Text;



            if (S27.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S28ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S8.Text;



            if (S28.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S29ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S9.Text;



            if (S29.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S30ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S30.Text;



            if (S30.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S31ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S31.Text;



            if (S31.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S32ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S32.Text;



            if (S32.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S33ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S33.Text;



            if (S33.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S34ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S34.Text;



            if (S34.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S35ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S35.Text;



            if (S35.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S36ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S36.Text;



            if (S36.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S37ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S37.Text;



            if (S37.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S38ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S38.Text;



            if (S38.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S39ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S39.Text;



            if (S39.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S40ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S40.Text;



            if (S40.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S41ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S41.Text;



            if (S41.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S42ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S42.Text;



            if (S42.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S43ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S43.Text;



            if (S43.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S44ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S44.Text;



            if (S44.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S45ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S45.Text;



            if (S45.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S46ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S46.Text;



            if (S46.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S47ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S47.Text;

            

            if (S47.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S48ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S48.Text;



            if (S48.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S49ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S49.Text;



            if (S49.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S50ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S50.Text;



            if (S50.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S51ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S51.Text;



            if (S51.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S52ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S52.Text;



            if (S52.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S53ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S53.Text;



            if (S53.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S54ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S54.Text;



            if (S54.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S55ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S55.Text;



            if (S55.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S56ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S56.Text;



            if (S56.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S57ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S57.Text;



            if (S57.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S58ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S58.Text;



            if (S58.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S59ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S59.Text;



            if (S59.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S60ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S60.Text;



            if (S60.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S61ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S61.Text;



            if (S61.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S62ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S62.Text;



            if (S62.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S63ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S63.Text;



            if (S63.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S64ButtonClicked(object sender, EventArgs e)
        {

        }
        private void S65ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S65.Text;



            if (S65.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S66ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S66.Text;



            if (S66.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S67ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S67.Text;



            if (S67.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S68ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S68.Text;



            if (S68.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S69ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S69.Text;



            if (S69.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S70ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S70.Text;



            if (S70.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S71ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S71.Text;



            if (S71.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S72ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S72.Text;



            if (S72.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S73ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S73.Text;



            if (S73.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S74ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S74.Text;



            if (S74.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S75ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S75.Text;



            if (S75.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S76ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S76.Text;



            if (S76.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S77ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S77.Text;



            if (S77.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S78ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S78.Text;



            if (S78.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S79ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S79.Text;



            if (S79.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S80ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S80.Text;



            if (S80.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S81ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S81.Text;



            if (S81.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S82ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S82.Text;



            if (S82.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S83ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S83.Text;



            if (S83.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S84ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S4.Text;



            if (S84.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S85ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S85.Text;



            if (S85.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S86ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S86.Text;



            if (S86.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S87ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S87.Text;



            if (S87.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S88ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S88.Text;



            if (S88.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S89ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S89.Text;



            if (S89.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S90ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S90.Text;



            if (S90.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S91ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S91.Text;



            if (S91.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S92ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S92.Text;



            if (S92.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S93ButtonClicked(object sender, EventArgs e)
        {

        }

        private void S94ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S94.Text;



            if (S94.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S95ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S95.Text;



            if (S95.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S96ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S96.Text;



            if (S96.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S97ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S97.Text;



            if (S97.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S98ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S98.Text;



            if (S98.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S99ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S99.Text;



            if (S99.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S100ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S100.Text;



            if (S100.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S101ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S101.Text;



            if (S101.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S102ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S102.Text;



            if (S102.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S103ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S103.Text;



            if (S103.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S104ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S104.Text;



            if (S104.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S105ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S105.Text;



            if (S105.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S106ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S106.Text;



            if (S106.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S107ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S107.Text;



            if (S107.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S108ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S108.Text;



            if (S108.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S109ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S109.Text;



            if (S109.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S110ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S110.Text;



            if (S110.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S111ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S111.Text;



            if (S111.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S112ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S112.Text;



            if (S112.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S113ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S113.Text;



            if (S113.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S114ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S114.Text;



            if (S114.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S115ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S115.Text;



            if (S115.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S116ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S116.Text;



            if (S116.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S117ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S117.Text;



            if (S117.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S118ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S118.Text;



            if (S118.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S119ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S119.Text;



            if (S119.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S120ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S120.Text;



            if (S120.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S121ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S121.Text;



            if (S121.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S122ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S122.Text;



            if (S122.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S123ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S123.Text;



            if (S123.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S124ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S124.Text;



            if (S124.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S125ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S125.Text;



            if (S125.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S126ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S126.Text;



            if (S126.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S127ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S17.Text;



            if (S127.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S128ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S18.Text;



            if (S128.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S129ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S19.Text;



            if (S129.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S130ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S130.Text;



            if (S130.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S131ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S131.Text;



            if (S131.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S132ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S32.Text;



            if (S132.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S133ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S133.Text;



            if (S133.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S134ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S134.Text;



            if (S134.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S135ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S135.Text;



            if (S135.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S136ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S136.Text;



            if (S136.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S137ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S137.Text;



            if (S137.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S138ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S138.Text;



            if (S138.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S139ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S139.Text;



            if (S139.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S140ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S140.Text;



            if (S140.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S141ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S141.Text;



            if (S141.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S142ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S142.Text;



            if (S142.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S143ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S143.Text;



            if (S143.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S144ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S144.Text;



            if (S144.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S145ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S145.Text;



            if (S145.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S146ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S146.Text;



            if (S146.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S147ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S147.Text;



            if (S147.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S148ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S148.Text;



            if (S148.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S149ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S149.Text;



            if (S149.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S150ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S150.Text;



            if (S150.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }
        private void S151ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S151.Text;



            if (S151.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S152ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S152.Text;



            if (S152.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S153ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S153.Text;



            if (S153.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void S154ButtonClicked(object sender, EventArgs e)
        {
            string slotnumber = S154.Text;



            if (S154.BackColor == Color.FromArgb(128, 255, 128))
            {
                BookSlot s = new BookSlot(textbox, slotnumber);
                s.Show();
            }
            else
            {
                findvehicle(slotnumber);
            }
        }

        private void SearchUserInformationByUserID(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = UserIDForSearchInformationTextBox.Text;

                string query = "select * from member where id ='" + id + "';";
                Connection.Open();
                Command = new SqlCommand(query, Connection);
                SqlDataReader result = Command.ExecuteReader();
                Boolean flag = false;
                Boolean emplty = string.IsNullOrEmpty(id);
                try
                {
                    while (result.Read())
                    {
                        string Name = result["Name"].ToString();
                        string Email = result["EmailAddress"].ToString();
                        string CarID = result["CarID"].ToString();
                        string CarName = result["CarName"].ToString();
                        string CarModel = result["CarModel"].ToString();
                        string CarColor = result["CarColor"].ToString();

                        SearchResultName.ForeColor = Color.FromArgb(255, 255, 255);

                        SearchResultName.Text = Name;
                        SearchResultEmail.Text = Email;
                        SearchResultVehicleID.Text = CarID;
                        SearchResultVehicleName.Text = CarName;
                        SearchResultVehicleModel.Text = CarModel;
                        SearchResultVehicleColor.Text = CarColor;

                        flag = true;

                    }
                    Connection.Close();
                    if (emplty)
                    {
                        var w = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(1))
                            .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        MessageBox.Show(w, "Please enter  a user ID");
                    }
                    else if (!flag)
                    {

                        SearchResultName.ForeColor = Color.FromArgb(223, 49, 31);

                        SearchResultName.Text = "No such member available";
                        SearchResultEmail.Text = "";
                        SearchResultVehicleID.Text = "";
                        SearchResultVehicleName.Text = "";
                        SearchResultVehicleModel.Text = "";
                        SearchResultVehicleColor.Text = "";

                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Can't find user information" + ex);
                }
            }
        }
    }
}
