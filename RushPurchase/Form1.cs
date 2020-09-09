using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RushPurchase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBMain.Navigate(txtUrl.Text);
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                //webBMain.Navigate(txtUrl.Text);
            }
        }

        private void webBMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e) {
            e.Handled = true;
        }

        private void webBMain_FileDownload(object sender, EventArgs e)
        {
            
        }

        private void webBMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            MessageBox.Show("asdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HtmlElement elementsByTagName = this.webBMain.Document.GetElementById("su");
            //elementsByTagName.InvokeMember("click");

            txtContent.Text = GetHtmlInfo(txtUrl.Text);
        }

        public string GetHtmlInfo(string sUrl)
        {
            string strUrl = sUrl;
            string strHtml = string.Empty;
            Uri httpURL = new Uri(strUrl);
            System.Net.HttpWebRequest httpReq;
            System.Net.HttpWebResponse httpResp;
            string strBuff = "";
            char[] cbuffer = new char[1000];
            int byteRead = 0;

            ///HttpWebRequest类继承于WebRequest，并没有自己的构造函数，需通过WebRequest的Creat方法 建立，并进行强制的类型转换 
            httpReq = (HttpWebRequest)WebRequest.Create(httpURL);
            ///通过HttpWebRequest的GetResponse()方法建立HttpWebResponse,强制类型转换

            httpResp = (HttpWebResponse)httpReq.GetResponse();
            ///GetResponseStream()方法获取HTTP响应的数据流,并尝试取得URL中所指定的网页内容

            ///若成功取得网页的内容，则以System.IO.Stream形式返回，若失败则产生ProtoclViolationException错 误。在此正确的做法应将以下的代码放到一个try块中处理。这里简单处理 
            Stream respStream = httpResp.GetResponseStream();

            ///返回的内容是Stream形式的，所以可以利用StreamReader类获取GetResponseStream的内容，并以

            //StreamReader类的Read方法依次读取网页源程序代码每一行的内容，直至行尾（读取的编码格式：UTF8） 
            StreamReader respStreamReader = new StreamReader(respStream, Encoding.UTF8);

            byteRead = respStreamReader.Read(cbuffer, 0, 256);
            while (byteRead != 0)
            {
                string strResp = new string(cbuffer, 0, byteRead);
                strBuff = strBuff + strResp;
                byteRead = respStreamReader.Read(cbuffer, 0, 256);
            }

            respStream.Close();
            strHtml = strBuff;
            return strHtml;

        }
    }
}
