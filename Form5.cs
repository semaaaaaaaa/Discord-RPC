using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Runtime.InteropServices;
namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        public Form5(Form1 f1)
        {
            InitializeComponent();
            f1 = frm;
        }
        Form1 frm = new Form1();
        public bool Initialized = false;

        public DiscordRpcClient client;
        private void button2_Click(object sender, EventArgs e)
        {
            Initialized = true;
            client = new DiscordRpcClient("762689227895865395");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Initialized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else if (Initialized == true)
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox1.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "youtube",
                        LargeImageText = "YouTube",

                    }


                });

                

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
