using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace RushPurchase
{
    public partial class GoogleWebBrowser: UserControl, IDisposable
    {
        public void SetForm(frmMain f) {
            form2 = f;
        }
        frmMain form2 = null;
        private bool _bDisposed = false;
        public ChromiumWebBrowser browser;
        public GoogleWebBrowser() {
            
        }

        public void Dispose(Control ctl) {
            if (ctl.Contains(browser)) {
                ctl.Controls.Remove(browser);
                browser.Dispose();
            }
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IFrame GetMainFrame() {
            return browser.GetMainFrame();
        }

        public IBrowserHost GetHost() {
            return browser.GetBrowser().GetHost();
        }

        public void Start(Control ctl ,string Url) {
            InitBrowser(ctl, Url);
            
        }

        public void InitBrowser(Control ctl,string Url) {
            var settings = new CefSettings
            {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true
            };
            if (Common.BrowserInit == false) {
                Cef.Initialize(settings);
                Common.BrowserInit = true;
            }
            browser = new ChromiumWebBrowser(Url);
            browser.Name = "MainBrowser";
            ctl.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GoogleWebBrowser
            // 
            this.Name = "GoogleWebBrowser";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GoogleWebBrowser_MouseMove);
            this.ResumeLayout(false);

        }

        private void GoogleWebBrowser_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
