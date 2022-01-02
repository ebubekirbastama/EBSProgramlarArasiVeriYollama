using System;
using System.Windows.Forms;

namespace EBSProgramlarArasiVeriYollama
{
    static class Program
    {

        [STAThread]
        static void Main(string[] argumentler)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EBPArams.Set(argumentler);
            Application.Run(new Form1());
        }
    }
}
