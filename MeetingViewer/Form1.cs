using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VncSharp;

namespace MeetingViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();

            InitBrowser();
            remoteDesktop.GetPassword = new AuthenticateDelegate(GetPassword);

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }


        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            string url = ConfigurationManager.AppSettings["meetingLink"].ToString();
            browser = new ChromiumWebBrowser(url);
            this.panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                browser.Forward();
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.Back();
            }
        }
        private string GetPassword()
        {
            string textFile = ConfigurationManager.AppSettings["PasswordFileLink"].ToString();
            return ReadTextFromFile(textFile);

            //return "sebl12";
        }


        //set timer
        Timer timer;
        Stopwatch sw;
        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Show();
            timeLabel.Show();

            timerLabel.Text = sw.Elapsed.ToString(@"h\:mm\:ss");
            Application.DoEvents();
        }
        public void DisconnectRemote()
        {
            remoteDesktop.Disconnect();
            Taskbar.Show();
            reconnectTimer.Stop();
            recSW.Stop();
            timer.Stop();
            sw.Stop();
            connectButton.BackColor = System.Drawing.Color.Green;
            connectButton.Text = "Connect";
            avatarPictureBox.Show();
            connectMessageLabel.Show();
            meetingOngoinglabel.Text = "You Viewed " + sw.Elapsed.Hours + " h " + sw.Elapsed.Minutes + " m " + sw.Elapsed.Seconds + " seconds";
            //progressBar.Hide();
            livePictureBox.Hide();
            timerLabel.Hide();
            timeLabel.Hide();
            fullScreenCheckBox.Show();
            //hubConnection.Stop();
            //hubConnection.Dispose();

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //string host = "192.168.104.45";

            if (remoteDesktop.IsConnected)
            {
                this.DisconnectRemote();


            }
            else
            {


                try
                {

                    string host = ReadTextFromFile(ConfigurationManager.AppSettings["HostIPLink"].ToString());
                    //string host = ConfigurationManager.AppSettings["host"].ToString();

                    //string host="192.168.104.45";

                    bool scale = !fullScreenCheckBox.Checked;
                    remoteDesktop.Connect(host, 0, true, scale);

                    //ConnectWithSignalIR();

                    if (remoteDesktop.IsConnected)
                    {
                       // Form1.FormBorderStyle = FormBorderStyle.FixedDialog;
                        Taskbar.Hide();
                        //Form1
                        avatarPictureBox.Hide();
                        connectMessageLabel.Hide();
                        connectButton.BackColor = System.Drawing.Color.Red;
                        connectButton.Text = "Disconnect";
                        meetingOngoinglabel.Show();
                        meetingOngoinglabel.Text = "Meeting Ongoing !!";
                        livePictureBox.Show();
                        wellcomePictureBox.Hide();
                        fullScreenCheckBox.Hide();
                        //progressBar.Show();

                        //progressBar.Style = ProgressBarStyle.Marquee;
                        //progressBar.MarqueeAnimationSpeed = 30;


                        //time count
                        timer = new Timer();
                        timer.Interval = (1000);
                        timer.Tick += new EventHandler(timer_Tick);
                        sw = new Stopwatch();
                        timer.Start();
                        sw.Start();


                    }
                    else
                    {
                        reconnectTimer.Stop();
                        reconnectTimer.Dispose();
                        recSW.Stop();
                        recSW.Reset();
                        MessageBox.Show("Incorrect Password");

                        this.Reconnect();


                    }

                    //progressBar

                }
                catch (Exception ex)
                {
                    reconnectTimer.Stop();
                    reconnectTimer.Dispose();
                    recSW.Stop();
                    recSW.Reset();
                    MessageBox.Show(this, "Unable to Join Meeting Because it has not Been Started",
                                    ex.Message,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    this.Reconnect();
                }

            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // If the user tries to close the window without doing a clean
            // shutdown of the remote connection, do it for them.
            if (remoteDesktop.IsConnected)
                remoteDesktop.Disconnect();

            base.OnClosing(e);
        }

        private void fullScreenRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Request a fullscreen update (normally incremental updates are sent)
            if (remoteDesktop.IsConnected)
                remoteDesktop.FullScreenUpdate();
        }

        public string ReadTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Required text files Not found");

            }

            return File.ReadAllText(path);
        }

        //private Timer reconnectTimer;
        //private Stopwatch recSW;
        Timer reconnectTimer = new Timer();
        Stopwatch recSW = new Stopwatch();
        public void Reconnect()
        {
            if (!remoteDesktop.IsConnected)
            {
                reconnectTimer.Interval = 1000;
                reconnectTimer.Tick += new EventHandler(reconnectTimer_tick);
                reconnectTimer.Start();
                recSW.Start();
            }
            else
            {
                reconnectLabel.Hide();
            }
        }
        public void reconnectTimer_tick(object sender, EventArgs e)
        {
            if (!remoteDesktop.IsConnected)
            {
                reconnectLabel.Show();
                reconnectLabel.Text = "Automatically reconnect after " + (Convert.ToInt32(ConfigurationManager.AppSettings["Interval"]) - recSW.Elapsed.Seconds) + " seconds";
                Application.DoEvents();
                if (recSW.Elapsed.Seconds >= Convert.ToInt32(ConfigurationManager.AppSettings["Interval"]))
                {
                    connectButton_Click(sender, e);
                }
            }
            else
            {
                reconnectLabel.Hide();
            }
        }




        





        //public void ConnectWithSignalIR()
        //{
        //    //string localIp = GetLocalIPAddress();

        //    //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(14);
        //    string userName = UserPrincipal.Current.DisplayName;


        //        //var hubConnection = new HubConnection("http://172.17.250.91:8088");

        //        var chat = hubConnection.CreateHubProxy("ChatHub");

        //        chat.On<string, string>("broadcastMessage", (name, message) =>
        //        {
        //            if (message == "end"&& remoteDesktop.IsConnected) { 
        //                InvokeUpdateControls(); 
        //            }
        //        });

        //        hubConnection.Start().Wait();

        //       chat.Invoke("Notify", userName, hubConnection.ConnectionId).Wait();
        //        string msg = " joined the Meeting at " + DateTime.Now;

        //      //chat.Invoke("Send", userName, msg).Wait();

        //}
        //public  string GetLocalIPAddress()
        //{
        //    var host = Dns.GetHostEntry(Dns.GetHostName());
        //    foreach (var ip in host.AddressList)
        //    {
        //        if (ip.AddressFamily == AddressFamily.InterNetwork)
        //        {
        //            return ip.ToString();
        //        }
        //    }
        //    throw new Exception("No network adapters with an IPv4 address in the system!");
        //}
        //public delegate void UpdateControlsDelegate();
        //public void InvokeUpdateControls()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new UpdateControlsDelegate(UpdateControls));
        //    }
        //    else
        //    {
        //        UpdateControls();
        //    }
        //}
        //private void UpdateControls()
        //{
        //    this.DisconnectRemote();
        //    // update your controls here
        //}



        //


    }

}
