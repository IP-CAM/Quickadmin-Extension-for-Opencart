using System;
using System.Windows.Forms;

namespace UI.View
{
    internal interface IView
    {
        event EventHandler LoadView;
        void Loading(bool isBusy);
        void Message(string text);
        DialogResult Message(string caption, string text, MessageBoxButtons boxButtons, MessageBoxIcon boxIcon);
    }
}
