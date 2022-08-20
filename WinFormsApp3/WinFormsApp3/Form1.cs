using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
namespace WinFormsApp3
{

    public partial class Form1 : Form
    {
        public bool StartStatus = false;
        public delegate void MyInvoke(string str1, string str2);
        public Form1()
        {
            InitializeComponent();
            this.showresult.HorizontalScrollbar = true;
        }

        private void startbt_Click(object sender, EventArgs e)
        {
            StartStatus = true;
            
            Thread t = new Thread(new ThreadStart( Pings));
            t.Start();
            
        }
        public void UpdateForm(string param1, string param2)
        {
            
            this.showresult.Items.Add($"{param1}    {param2}ms");
        }
        private void Pings() {
            MyInvoke mi = new MyInvoke(UpdateForm);
            Ping pingSender = new Ping();

            while (StartStatus)
            {
                PingReply reply = pingSender.Send("1.1.1.1", 1000);
                String date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                if (reply != null)
                {
                    
                    this.BeginInvoke(mi, new Object[] { date, reply.RoundtripTime.ToString() });
                    this.BeginInvoke(SetAutoScrollMargins);
                    Thread.Sleep(1000);
                }
            }
            
            
        }
        private void SetAutoScrollMargins()
        {
            showresult.SelectedIndex = showresult.Items.Count - 1;
            showresult.SelectedIndex = -1;
        }

        private void stopbt_Click(object sender, EventArgs e)
        {
            if (StartStatus) {
                StartStatus = false;
            };
        }

        private void showresult_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}