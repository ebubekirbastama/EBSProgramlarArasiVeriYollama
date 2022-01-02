using System;
using System.Threading;
using System.Windows.Forms;

namespace EBSProgramlarArasiVeriYollama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private void Form1_Load(object sender, EventArgs e)
        {
            th = new Thread(EBSBas); th.Start();

        }

        private void EBSBas()
        {
            var veriler = EBPArams.Get();
            foreach (var item in veriler)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
