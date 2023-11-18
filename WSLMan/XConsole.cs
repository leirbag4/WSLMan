using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan
{
    public class XConsole
    {
        private static RichTextBox _outp;

        public static void Setup(RichTextBox outp)
        {
            _outp = outp;
        }

        public static void Alert(string str)
        { 
            MessageBox.Show(str);
        }

        public static void Clear()
        {
            if (_outp.InvokeRequired)
            {
                _outp.Invoke(new MethodInvoker(delegate { _outp.Text = ""; }));
            }
            else
                _outp.Text = "";
        }

        public static void Print(String str)
        {
            if (_outp.InvokeRequired)
            {
                _outp.Invoke(new MethodInvoker(delegate { _Print(str); }));
            }
            else
                _Print(str);
        }

        public static void Print(String str, Color color)
        {
            if (_outp.InvokeRequired)
            {
                _outp.Invoke(new MethodInvoker(delegate { _Print(str, color); }));
            }
            else
                _Print(str, color);
        }

        private static void _Print(String str, Color color)
        {
            int length = _outp.TextLength;  // at end of text
            _outp.AppendText(str);
            _outp.SelectionStart =  length;
            _outp.SelectionLength = str.Length;
            _outp.SelectionColor =  color;
            _outp.ScrollToCaret();
        }

        private static void _Print(String str)
        {
            int length = _outp.TextLength;  // at end of text
            _outp.AppendText(str);
            _outp.ScrollToCaret();
        }

        
        public static void Println(String str)
        {
            if (_outp.InvokeRequired)
            {
                _outp.Invoke(new MethodInvoker(delegate { _Println(str); }));
            }
            else
                _Println(str);
        }

        public static void Println(String str, Color color)
        {
            if (_outp.InvokeRequired)
            {
                _outp.Invoke(new MethodInvoker(delegate { _Println(str, color); }));
            }
            else
                _Println(str, color);
        }

        public static void PrintError(String str)
        {
            Println(str, Color.Red);
        }

        private static void _Println(String str, Color color)
        {
            int length = _outp.TextLength;  // at end of text
            str = str + "\n";
            _outp.AppendText(str);
            _outp.SelectionStart = length;
            _outp.SelectionLength = str.Length;
            _outp.SelectionColor = color;
            _outp.ScrollToCaret();
        }

        private static void _Println(String str)
        {
            int length = _outp.TextLength;  // at end of text
            str = str + "\n";
            _outp.AppendText(str);
            _outp.ScrollToCaret();
        }
    }
}
