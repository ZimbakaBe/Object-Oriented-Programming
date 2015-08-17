using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class UsingAttributes
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Unicode)]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

        static void Main()
        {
            ShowMessageBox(0, "Some text", "Some caption", 0);
        }
    }
}
