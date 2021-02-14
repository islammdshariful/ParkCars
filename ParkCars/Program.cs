using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkCars
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QRScanner());
            //Application.Run(new SystemView());
            //Application.Run(new AdminSystemView());
            //Application.Run(new NewUser());
            //Application.Run(new NewEmployee());
            Application.Run(new SignIn());
            //Application.Run(new BookSlot());



        }
    }
}
