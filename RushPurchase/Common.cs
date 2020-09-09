using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushPurchase
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }
    public static class Common
    {
        public static string strUserName = "13700047433";
        public static string strPwd = "aa123456";
        public static bool BrowserInit = false;
        public static string strLoginUrl = "https://m.51tiangou.com/login/login.html";
        //public static string strLoginUrl = "http://localhost:8001/dragdemo.html";
        public static List<string> listUrl = new List<string>();

        //[DllImport("user32.dll")]
        //public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "keybd_event")]

        public static extern void keybd_event(

              byte bVk,    //虚拟键值

              byte bScan,// 一般为0

              int dwFlags,  //这里是整数类型  0 为按下，2为释放

              int dwExtraInfo  //这里是整数类型 一般情况下设成为 0

        );

        public const int KEYEVENTF_EXTENDEDKEY = 0x1;
        public const int KEYEVENTF_KEYUP = 0x2;
        public const int KEYEVENTF_6 = 0x66;
        public static void ExecuteJs(GoogleWebBrowser chromiumWebBrowser, string js)
        {
            var frame = chromiumWebBrowser.GetMainFrame();
            frame.EvaluateScriptAsync(js);
        }
        public static POINT getPurchasePoint(Form form,TextBox txtUrl,Panel pnlBrowser)
        {
            POINT P_purchase = new POINT();

            P_purchase.X = form.Location.X + 100;
            P_purchase.Y = form.Location.Y + txtUrl.Height + pnlBrowser.Height - 10;

            return P_purchase;
        }

        public enum MouseEventFlags       //鼠标按键的ASCLL码
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }

        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        [DllImport("User32")]
        public extern static bool GetCursorPos(out POINT p);

        public static void AutoClick(int x, int y)
        {
            POINT p = new POINT();
            GetCursorPos(out p);
            try
            {
                SetCursorPos(x, y);//设置光标位置               
                mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);//自动按下的按键
                mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
            }
            finally
            {
                SetCursorPos(p.X, p.Y);
            }
        }

    }
       
}
