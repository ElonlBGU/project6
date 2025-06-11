    using System;
using System.Windows.Forms;

namespace Project6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RateProductForm()); // Start with the RateProductForm
        }
    }
}
