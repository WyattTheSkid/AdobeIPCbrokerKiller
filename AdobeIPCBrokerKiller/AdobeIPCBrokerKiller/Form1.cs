using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeIPCBrokerKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcessesByName("AdobeIPCBroker"))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit(); 
                }
                catch (Win32Exception winException)
                {
                   
                }
                catch (InvalidOperationException invalidException)
                {
                   
                }
            }
        }
    }
}
