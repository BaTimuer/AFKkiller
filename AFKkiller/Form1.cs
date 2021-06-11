using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFKkiller
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            String test = listBox1.SelectedItem.ToString();
            
            afk();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }
        private void afk()
        {
            SendKeys.SendWait("a");
            SendKeys.SendWait("b");
            SendKeys.SendWait("c");
            SendKeys.SendWait("d");
            SendKeys.SendWait("e");
            SendKeys.SendWait("f");
            SendKeys.SendWait("g");
            SendKeys.SendWait("h");
            SendKeys.SendWait("i");
            SendKeys.SendWait("j");
            SendKeys.SendWait("k");
            SendKeys.SendWait("l");
            SendKeys.SendWait("m");
            SendKeys.SendWait("n");
            SendKeys.SendWait("o");
            SendKeys.SendWait("p");
            SendKeys.SendWait("q");
            SendKeys.SendWait("r");
            SendKeys.SendWait("s");
            SendKeys.SendWait("t");
            SendKeys.SendWait("u");
            SendKeys.SendWait("v");
            SendKeys.SendWait("w");
            SendKeys.SendWait("x");
            SendKeys.SendWait("y");
            SendKeys.SendWait("z");

        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            string[] processes = Process.GetProcesses().
                     Where(x => x.ProcessName.Contains(txt_process.Text)). // Take care about case-sensivity of comparsion
                     Select(x =>x.Id+":"+ x.ProcessName + ".exe").
                     ToArray();

            listBox1.Items.AddRange(processes);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
