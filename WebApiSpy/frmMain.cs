using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using RecordWebApi;
using WebApiSpy.Properties;

namespace WebApiSpy
{
    public partial class frmMain : Form
    {
        private readonly FiddlerHandler fiddlerHandler = new FiddlerHandler();
        private frmShowDetails frmShowDetailsInstance;

        private readonly IList<FiddlerHandler.WebApiInfo> webApiInfoList = new List<FiddlerHandler.WebApiInfo>();
 
        public frmMain()
        {
            InitializeComponent();

            fiddlerHandler.OnDataRecieved += ShowWebApiInfo;

            this.Disposed += OnFrmMainDisposed;

            Fiddler.FiddlerApplication.OnNotification +=
                (sender, oNEA) => Debug.WriteLine("** NotifyUser: " + oNEA.NotifyString);
            Fiddler.FiddlerApplication.Log.OnLogString +=
                (sender, oLEA) => Debug.WriteLine("** LogString: " + oLEA.LogString);

            //Fiddler.FiddlerApplication.BeforeRequest += 
            //    oS => Debug.WriteLine("Before request for:\t" + oS.fullUrl);

            //Fiddler.FiddlerApplication.BeforeResponse +=
            //    oS => Debug.WriteLine("{0}:HTTP {1} for {2}", oS.id, oS.responseCode, oS.fullUrl);


        }

        private void ShowWebApiInfo(FiddlerHandler.WebApiInfo webApiInfo)
        {
            var action = new Action<FiddlerHandler.WebApiInfo>(ShowWebApiInfoSafe);
            BeginInvoke(action, webApiInfo);
        }

        private void ShowWebApiInfoSafe(FiddlerHandler.WebApiInfo webApiInfo)
        {
            webApiInfoList.Add(webApiInfo);

            string startTime = webApiInfo.StartTime.ToString("HH:mm:ss:fff");
            string timer = webApiInfo.Timer.ToString("s\\.ffffff");

            dgrdLog.Rows.Add(startTime, timer, webApiInfo.Method, webApiInfo.Url, webApiInfo.Request, webApiInfo.Response);
        }


        private void tsbRecord_Click(object sender, EventArgs e)
        {
            tsbPause.Visible = true;
            tsbRecord.Visible = false;
            fiddlerHandler.Start();
        }

        private void tsbPause_Click(object sender, EventArgs e)
        {
            tsbRecord.Visible = true;
            tsbPause.Visible = false;
            fiddlerHandler.Stop();
        }

        private void OnFrmMainDisposed(object sender, EventArgs e)
        {
            if (fiddlerHandler != null)
            {
                fiddlerHandler.Dispose();
            }
        }

        private void dgrdLog_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetails();
        }

        private void dgrdLog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrdLog.CurrentCell != null && dgrdLog.CurrentCell.RowIndex >= 0)
            {
                int rowIndex = dgrdLog.CurrentCell.RowIndex;
                EnsureDetailsInstance();
                frmShowDetailsInstance.ShowWebApiInfo(webApiInfoList[rowIndex]);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dgrdLog.Rows.Clear();
            EnsureDetailsInstance();
            frmShowDetailsInstance.Clear();

            webApiInfoList.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowOrHideDetails();
        }

        private void ShowOrHideDetails()
        {
            EnsureDetailsInstance();
            frmShowDetailsInstance.Visible = !frmShowDetailsInstance.Visible;
        }

        private void ShowDetails()
        {
            EnsureDetailsInstance();
            frmShowDetailsInstance.Show();
        }

        private void EnsureDetailsInstance()
        {
            if (frmShowDetailsInstance == null || frmShowDetailsInstance.IsDisposed)
            {
                frmShowDetailsInstance = new frmShowDetails();
            }
        }
    }
}
