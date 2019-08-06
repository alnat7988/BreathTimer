using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Timer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer SecondTimer = new System.Windows.Forms.Timer();
        int Counter;

        public Form1()
        {
            InitializeComponent();
            SecondTimer.Interval = 1000;
            SecondTimer.Tick += new EventHandler(NewSecond);
            Counter = 0;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            SecondTimer.Start();
        }

        private void NewSecond(object source, EventArgs e)
        {
            try
            {
                if (Counter < Convert.ToInt32(textBox1.Text))
                {
                    Counter++;
                }
                else
                {
                    Counter = 1;
                }
                
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Height/2);
                richTextBox1.Text =" "+ Counter.ToString();


            }
            catch
            {
 
            }
        }


    }
}
