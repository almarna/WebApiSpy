using System.Drawing;
using System.Windows.Forms;
using RecordWebApi;

namespace WebApiSpy
{
    public partial class frmShowDetails : Form
    {
        public frmShowDetails()
        {
            InitializeComponent();
        }

        public void ShowWebApiInfo(FiddlerHandler.WebApiInfo webApiInfo)
        {
            Memory.webApiInfo = webApiInfo;

            string formattedRequest = string.IsNullOrWhiteSpace(webApiInfo.Request) ? " -" : "\r\n" + webApiInfo.PrettyRequest;
            string formattedResponse = string.IsNullOrWhiteSpace(webApiInfo.Response) ? " -" : "\r\n" + webApiInfo.PrettyResponse;

            rtbMain.Text = string.Format("{0:HH:mm:ss:fff} [{1:s\\.ffffff}] {2}:{3}\r\nRequest{4}\r\nResponse{5}", 
                webApiInfo.StartTime,
                webApiInfo.Timer,
                webApiInfo.Method,
                webApiInfo.Url,
                formattedRequest,
                formattedResponse
                );
        }

        public void Clear()
        {
            rtbMain.Clear();
        }

        private void frmShowDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.Location = Location;
            Memory.Size = Size;
        }

        private void frmShowDetails_Load(object sender, System.EventArgs e)
        {
            if (Memory.Location != null)
            {
                this.Location = Memory.Location.Value;
            }
            if (Memory.Size != null)
            {
                this.Size = Memory.Size.Value;
            }
            if (Memory.webApiInfo != null)
            {
                ShowWebApiInfo(Memory.webApiInfo);
            }
        }

        // Could use locks but don't think I need it
        private static class Memory
        {
            public static Point? Location { get; set; }
            public static Size? Size { get; set; }
            public static FiddlerHandler.WebApiInfo webApiInfo { get; set; }
        }
    }
}
