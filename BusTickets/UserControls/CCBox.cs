using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTickets.UserControls
{
    public class CCBox : ComboBox
    {
        private const int WM_PAINT = 0x000F;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetScrollbarWidth();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                SetScrollbarWidth();
            }
        }

        private void SetScrollbarWidth()
        {
            int scrollbarWidth = 30; // Set the width of the scrollbar
            IntPtr scrollbarHandle = WinApi.GetWindow(Handle, WinApi.GW_CHILD + WinApi.GW_HWNDFIRST); // Get the handle of the scrollbar
            WinApi.SetWindowPos(scrollbarHandle, IntPtr.Zero, 0, 0, scrollbarWidth, Height, WinApi.SWP_SHOWWINDOW); // Set the width of the scrollbar
        }

        private static class WinApi
        {
            public const int GW_CHILD = 5;
            public const int GW_HWNDFIRST = 0;
            public const int SWP_SHOWWINDOW = 0x0040;

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
        }
    }
}


