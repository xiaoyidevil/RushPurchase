using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;

namespace RushPurchase
{
    public partial class frmMain : Form
    {
        public GoogleWebBrowser googleWebBrowser = new GoogleWebBrowser();
        public GoogleWebBrowser loginWebBrowser = new GoogleWebBrowser();

        POINT P_purchase = new POINT();

        public frmMain()
        {
            InitializeComponent();
            txtLoginUrl.Text = Common.strLoginUrl;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loginWebBrowser.Start(pnlLogin, txtLoginUrl.Text);
            googleWebBrowser.Start(pnlBrowser_01, txtUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] utf8 = Encoding.UTF8.GetBytes(txtChineseCharacter.Text);
            string strResult = "";
            foreach (byte item in utf8)
            {
                strResult += string.Format("{0:X2}", item) + " ";
            }
            txtUTF8.Text = strResult;
            //Common.AutoClick(P_purchase.X, P_purchase.Y);
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                googleWebBrowser.Dispose(pnlBrowser_01);
                googleWebBrowser.Start(pnlBrowser_01, txtUrl.Text);
            }
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            P_purchase = Common.getPurchasePoint(this,this.txtUrl,this.pnlBrowser_01);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            P_purchase = Common.getPurchasePoint(this, this.txtUrl, this.pnlBrowser_01);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Common.ExecuteJs(loginWebBrowser, "document.getElementById('cellphone').value = '" + Common.strUserName + "';");
            loginWebBrowser.browser.Select();
            Common.ExecuteJs(loginWebBrowser, "document.getElementById('password').value = '" + Common.strPwd.Substring(0,Common.strPwd.Length-1) + "';");
            Common.ExecuteJs(loginWebBrowser, "document.getElementById('password').focus();");
            Thread.Sleep(500);
            Common.keybd_event((byte)Keys.NumPad6, 0, 0, 0);         //按下D
            Common.keybd_event((byte)Keys.NumPad6, 0, 2, 0);        //释放D
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Common.ExecuteJs(loginWebBrowser, "document.getElementById('loginBtn').click();");
        }

        private void btnUTF8ToChinese_Click(object sender, EventArgs e)
        {
            string utf8Char = txtUTF8.Text;
            string[] b4 = utf8Char.Trim().Split(' ');

            byte[] bs = new byte[3];
            for (int i = 1; i <= b4.Length; i++)
            {
                int a = i % 3;
                if (a == 0)
                {
                    bs[2] = (byte)Convert.ToByte(b4[i - 1], 16);
                }
                else
                {
                    bs[a - 1] = (byte)Convert.ToByte(b4[i - 1], 16);
                }
                if (a == 0)
                {
                    txtChineseCharacter.Text += Encoding.GetEncoding("UTF-8").GetString(bs);
                }
            }
        }

        private void btnJson解析_Click(object sender, EventArgs e)
        {
            //我们的接口
            string url = "https://midway.51tiangou.com/search/result/init.node?type=index&tgTabBarParams={%22startNum%22%3A%220%22%2C%22pageCount%22%3A%2210%22}&topBarIndex=0&cityId=2554&cityIds=2554&storeIds=1065&listType=product&range=all&tabIndex=0&startNum=0&pageCount=10&scp=07.searchresult.search.0&words=%E8%8C%85%E5%8F%B0&_=1599633833337&childIndex=0&currentView=2&superStoreId=1065";

            //将接口传入，这个HttpUitls的类，有兴趣可以研究下，也可以直接用就可以，不用管如何实现。
            string getJson = HttpUitls.Get(url);

            //这个需要引入Newtonsoft.Json这个DLL并using
            //传入我们的实体类还有需要解析的JSON字符串这样就OK了。然后就可以通过实体类使用数据了。

            int LastDataFrom = getJson.LastIndexOf(",{");
            int LastDataTo = getJson.LastIndexOf("]");
            string strTempFrist = getJson.Substring(0, LastDataFrom);
            string strTempEnd = getJson.Substring(LastDataTo);
            getJson = strTempFrist + strTempEnd;
            Root rt = JsonConvert.DeserializeObject<Root>(getJson);
            //这样就可以取出json数据里面的值

            //由于这个JSON字符串的 public List<DataItem> data 是一个集合，所以我们需要遍历集合里面的所有数据
            foreach (DataItem item in rt.data)
            {
                string strUrl = "http:" + item.data.clickUrl;
                Common.listUrl.Add(strUrl);
                
                TabPage tp = new TabPage(item.data.title);

                Panel pnlBrowser = new Panel();
                pnlBrowser.Dock = DockStyle.Fill;
                tp.Controls.Add(pnlBrowser);

                TextBox txtUrl = new TextBox();
                txtUrl.Dock = DockStyle.Top;
                pnlBrowser.Controls.Add(txtUrl);

                GoogleWebBrowser googleBrowser = new GoogleWebBrowser();
                googleBrowser.Start(pnlBrowser, strUrl);

                tabControl1.TabPages.Add(tp);

            }
        }
    }


}

