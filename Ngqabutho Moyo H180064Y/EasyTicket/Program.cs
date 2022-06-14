using EasyTicket.App_UI.Forms.Admin;
using EasyTicket.App_UI.Forms.Main_Menu.Account_Settings;
using EasyTicket.Forms;
using EasyTicket.Forms.Main_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket
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
            Application.Run(new Login());            
        }
    }
}
