using Memory;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noelle.ColdKeys
{
    public enum HotKey
    {
        None,
        CapsLk = 58,
        NumLk = 69
    }

    public partial class FormMain : Form
    {
        public string ProgramNameWithoutExt = "utility";
        public string HotKeysAppId = "E0469640.LenovoUtility_5grkq8ppsgwt4!LenovoUtility";

        public FormMain()
        {
            InitializeComponent();
        }

        private async void btnCapsLk_Click(object sender, EventArgs e)
        {
            await DisableHotKeyHint(HotKey.CapsLk);
        }

        private async void btnNumLk_Click(object sender, EventArgs e)
        {
            await DisableHotKeyHint(HotKey.NumLk);
        }

        private Process GetHotKeyProcess()
        {
            var procs = Process.GetProcessesByName(ProgramNameWithoutExt);
            Process proc = null;
            if (procs.Length > 1)
            {
                proc = procs.FirstOrDefault(p =>
                p.MainModule != null && p.MainModule.FileName.Contains("LenovoUtility"));
            }
            else if (procs.Length > 0)
            {
                proc = procs[0];
            }
            return proc;
        }

        public async Task DisableHotKeyHint(HotKey key)
        {
            if (key == HotKey.None)
            {
                return;
            }

            Mem mem = new Mem();
            
            var proc = GetHotKeyProcess();
            if (proc == null)
            {
                MessageBox.Show("没有检测到HotKeys程序！");
                return;
            }

            int modCount = 0;
            mem.OpenProcess(proc.Id);
            if (key == HotKey.CapsLk)
            {
                var sigs = await mem.AoBScan("B9 14 00 00 00 FF 15 ?? ?? 0E 00 98"); // mov ecx, 14h; call GetKeyState; cwde;
                var sigsList = sigs.ToList();
                if (sigsList.Count > 0)
                {
                    foreach (var sig in sigsList)
                    {
                        var sigs2 = await mem.AoBScan(sig, sig + 100, "48 8B 48 08 FF 15 ?? ?? 0E 00"); //mov rcx, [rax+8] (hWnd); call PostMessageW;
                        var sigs2List = sigs2.ToList();
                        if (sigs2List.Count > 0)
                        {
                            foreach (var sig2 in sigs2List)
                            {
                                Debug.WriteLine($"Write {(sig2 + 4):X}");
                                mem.WriteBytes(new UIntPtr((ulong)(sig2 + 4)), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                                modCount++;
                            }
                        }
                    }
                }
            }
            else if (key == HotKey.NumLk)
            {
                var sigs = await mem.AoBScan("B9 90 00 00 00 FF 15 ?? ?? 0E 00 98"); // mov ecx, 90h; call GetKeyState; cwde;
                var sigsList = sigs.ToList();
                if (sigsList.Count > 0)
                {
                    foreach (var sig in sigsList)
                    {
                        var sigs2 = await mem.AoBScan(sig, sig + 105, "48 8B 48 08 FF 15 ?? ?? 0E 00"); //mov rcx, [rax+8] (hWnd); call PostMessageW;
                        var sigs2List = sigs2.ToList();
                        if (sigs2List.Count > 0)
                        {
                            foreach (var sig2 in sigs2List)
                            {
                                Debug.WriteLine($"Write {(sig2 + 4):X}");
                                mem.WriteBytes(new UIntPtr((ulong)(sig2 + 4)), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                                modCount++;
                            }
                        }
                    }
                }
            }

            if (modCount >= 2)
            {
                MessageBox.Show("修改成功!");
            }
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            GetHotKeyProcess()?.Kill();
        }

        private bool _suspended = false;
        private void btnSuspend_Click(object sender, EventArgs e)
        {
            var proc = GetHotKeyProcess();
            if (proc != null)
            {
                if (_suspended)
                {
                    Mem.ResumeProcess(proc.Id);
                }
                else
                {
                    Mem.SuspendProcess(proc.Id);
                }
                _suspended = !_suspended;
            }
        }

        private void lnkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/UlyssesWu/ColdKeys");
        }

        private void btnLaunchHotKeys_Click(object sender, EventArgs e)
        {
            var appxLauncher = Path.Combine(Application.StartupPath, "appxlauncher.exe");
            if (File.Exists(appxLauncher))
            {
                Process.Start(appxLauncher, HotKeysAppId);
            }
        }

        //Log: HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\LenovoUtility\log
    }
}
