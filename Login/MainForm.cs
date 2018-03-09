using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.BorderSize = 0;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
            reloadConfig();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.cbbAccounts.SelectedIndex < 0)
                return;
            string acc = ((Account)this.cbbAccounts.SelectedItem).AccountName;
            string pass = ((Account)this.cbbAccounts.SelectedItem).Password;

            PatchGameAccount(acc);
            ClipboardSetText(pass);
            StartClient();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
#if !DEBUG
            if (!File.Exists("main.exe") || !File.Exists("LauncherOption.if"))
            {
                MessageBox.Show("Bác cho file này vào thư mục MU Legend thì mới được nhé");
                Environment.Exit(1);
            }
#endif
            reloadConfig();
        }

        private void reloadConfig()
        {
            AccountManager.Load();
            this.cbbAccounts.DataSource = AccountManager.Accounts;
            this.cbbAccounts.DisplayMember = "AccountName";
        }
        
        private void PatchGameAccount(string account)
        {
            string[] lines = File.ReadAllLines("LauncherOption.if");
            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim().StartsWith("ID:"))
                {
                    lines[i] = "ID:" + account;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                string[] data = new string[lines.Length + 1];
                Array.Copy(lines, data, lines.Length);
                data[data.Length - 1] = "ID:" + account;
                lines = data;
            }
            File.WriteAllLines("LauncherOption.if", lines);
        }

        private void StartClient()
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            string exe = System.IO.Path.Combine(dir, "main.exe");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo prs = new System.Diagnostics.ProcessStartInfo();
            prs.WorkingDirectory = dir;
            prs.UseShellExecute = false;
            prs.Arguments = "/LauncherStart";
            prs.FileName = exe;
            prc.StartInfo = prs;
            prc.Start();
        }

        private void ClipboardSetText(string inTextToCopy)
        {
            ClipBoardThreadWorker(inTextToCopy);
            /*
            var clipboardThread = new Thread(() => ClipBoardThreadWorker(inTextToCopy));
            clipboardThread.SetApartmentState(ApartmentState.STA);
            clipboardThread.IsBackground = false;
            clipboardThread.Start();
            */
        }

        private void ClipBoardThreadWorker(string inTextToCopy)
        {
            Clipboard.SetText(inTextToCopy, TextDataFormat.Text);
        }
    }
}
