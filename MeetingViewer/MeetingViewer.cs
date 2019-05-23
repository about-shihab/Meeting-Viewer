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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VncSharp;

namespace MeetingViewer
{
    public partial class MeetingViewer : Form
    {
        public MeetingViewer()
        {
            InitializeComponent();
            HideTabControl();
            InitBrowser();
            remoteDesktop.GetPassword = new AuthenticateDelegate(GetPassword);

            GlobalMouseHandler gmh = new GlobalMouseHandler();
            gmh.TheMouseMoved += new MouseMovedEvent(gmh_TheMouseMoved);
            Application.AddMessageFilter(gmh);

            //remoteDesktop.ConnectionLost += RemoteDesktop_ConnectionLost;
        }
        void RemoteDesktop_ConnectionLost(object sender, EventArgs e)
        {

            MessageBox.Show(this,
                    "Disconnected",
                    "Connection Lost");
        }


        public void HideTabControl()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        void gmh_TheMouseMoved()
        {
            Point cur_pos = System.Windows.Forms.Cursor.Position;

            if (cur_pos.Y < 40 && cur_pos.Y >=0)
            {
                topPanel.Show();
            }else
            {
                topPanel.Hide();
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remoteButton_Click(object sender, EventArgs e)
        {
            remoteButton.BackColor = System.Drawing.Color.White;
            manualButton.BackColor = System.Drawing.Color.Gainsboro;
            tabControl1.SelectTab(remoteTabPage);
            tabControl1.SelectedTab.Controls.Add(topPanel);

        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            remoteButton.BackColor = System.Drawing.Color.Gainsboro;
            manualButton.BackColor = System.Drawing.Color.White;
            tabControl1.SelectTab(manualTabPage);
            tabControl1.SelectedTab.Controls.Add(topPanel);


        }
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            string url = ConfigurationManager.AppSettings["meetingLink"].ToString();
            browser = new ChromiumWebBrowser(url);
            this.browserPanel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
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
        Ping p = new Ping();

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                p.Send(ReadTextFromFile(ConfigurationManager.AppSettings["HostIPLink"].ToString()));
                timerLabel.Show();
                timeLabel.Show();

                timerLabel.Text = sw.Elapsed.ToString(@"h\:mm\:ss");
                Application.DoEvents();
            }
            catch(PingException ex)
            {
                this.DisconnectRemote();
                MessageBox.Show(this,
                    "Network connection Lost.\n"+ex.Message,
                    "Connection Lost");
            }
            
        }
        public void DisconnectRemote()
        {
            if(remoteDesktop.IsConnected)
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
           // meetingOngoinglabel.Text = "You Viewed " + sw.Elapsed.Hours + " h " + sw.Elapsed.Minutes + " m " + sw.Elapsed.Seconds + " seconds";
            livePictureBox.Hide();
            timerLabel.Hide();
            timeLabel.Hide();
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

                    

                   // bool scale = !fullScreenCheckBox.Checked;
                    remoteDesktop.Connect(host, 0, true, true);

                    //ConnectWithSignalIR();

                    if (remoteDesktop.IsConnected)
                    {
                        remoteDesktop.FullScreenUpdate();

                        remoteButton_Click(sender, e);

                        // Form1.FormBorderStyle = FormBorderStyle.FixedDialog;
                        Taskbar.Hide();
                        //Form1
                        avatarPictureBox.Hide();
                        connectMessageLabel.Hide();
                        connectButton.BackColor = System.Drawing.Color.Red;
                        connectButton.Text = "Disconnect";
                        //meetingOngoinglabel.Show();
                        //meetingOngoinglabel.Text = "Meeting Ongoing !!";
                        livePictureBox.Show();
                        wellcomePictureBox.Hide();
                       // fullScreenCheckBox.Hide();
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
            Taskbar.Show();
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Taskbar.Show();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

    }

    public delegate void MouseMovedEvent();

    public class GlobalMouseHandler : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 0x0200;

        public event MouseMovedEvent TheMouseMoved;


        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)
            {
                if (TheMouseMoved != null)
                {
                    TheMouseMoved();
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }

    }
}
