using System;
using System.Windows.Forms;
using UygulamaÖdevi;

namespace UygulamaOdevi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Konular());
        }
    }
}
