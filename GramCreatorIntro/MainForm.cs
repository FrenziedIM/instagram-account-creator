using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GramCreatorIntro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser("https://gramcreator.com");
            chrome.Dock = DockStyle.Fill;
            MessageBox.Show("Hello");
            Controls.Add(chrome);
        }
    }
}
