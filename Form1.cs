using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC.Logging;
using DiscordRPC;
using System.Runtime.InteropServices;
namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        //bool isMax = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(this);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(this);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6(this);
            frm.Show();
        }

        
        
        void MenuTest1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void MenuTest2_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
