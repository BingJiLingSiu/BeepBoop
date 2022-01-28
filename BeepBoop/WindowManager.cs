using System;
using System.Runtime.InteropServices;

namespace BeepBoop
{
    public class WindowManager
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        

        public static void hideWindow()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, 0);
        }
    }
}