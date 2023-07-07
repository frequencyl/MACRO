using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Macro_Minstrel
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);

        string[] entered = new string[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            entered[0] = Convert.ToString(macro1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            entered[1] = Convert.ToString(macro2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            entered[2] = Convert.ToString(macro3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            entered[3] = Convert.ToString(macro4.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (GetAsyncKeyState(0x31) != 0)
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send(entered[0]);
            }
            else if (GetAsyncKeyState(0x32) != 0)
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send(entered[1]);
            }
            else if (GetAsyncKeyState(0x33) != 0)
            {

                SendKeys.Send("{BACKSPACE}");

                SendKeys.Send(entered[2]);

            }
            else if (GetAsyncKeyState(0x34) != 0)
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send(entered[3]);

            }

        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            MessageBox.Show("Macro is available.");
            MessageBox.Show("Write down what you will use as macro. And press the numbers which is on the keyboard.");

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Macro is stopped.");
        }

      
    }
}