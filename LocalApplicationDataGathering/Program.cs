using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalApplicationDataGathering
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //general main start
         main_application_call();

            //testing 
       //   other_win_form_debug();
        }

        private static void other_win_form_debug()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          //    Application.Run(new DataBags());
            Application.Run(new DataBag_manipulate());
        }

        private static void main_application_call()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FileStream outstream;
            StreamWriter writer;

            outstream = new FileStream("./LOGS.txt", FileMode.OpenOrCreate, FileAccess.Write);
            writer = new StreamWriter(outstream);
            Console.SetOut(writer);

            OpcUastartup.Instance.OPC();

            Application.Run(new Form1());
        }
    }
}
