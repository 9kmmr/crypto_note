using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace CryptoCoin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public Checkenter checkenter = new Checkenter();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            checkenter.loadData();
            Application.Run(new Splashscreen(checkenter));
            
            Application.Run(new Form1(checkenter));
        }
        
    }
}
