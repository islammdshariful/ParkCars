using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkCars
{
    public partial class ParkingDetailsWindow : Form
    {
        //string vehicleid, vehiclename, vehiclemodel, vehiclecolor, slotnumber;
        private System.Windows.Forms.Timer tmr;
        public ParkingDetailsWindow()
        {
            InitializeComponent();
        }
        public ParkingDetailsWindow(string id, string name, string model, string color, string number)
        {
            InitializeComponent();
            VehicleID.Text = id;
            VehicleModel.Text = model;
            VehicleName.Text = name;
            VehicleColor.Text = color;
            SlotNumberLabel.Text = number;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
           
            tmr.Interval = (int)TimeSpan.FromSeconds(2).TotalMilliseconds;
            tmr.Start();
        }


    }
}
