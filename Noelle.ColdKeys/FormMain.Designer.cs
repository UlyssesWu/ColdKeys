namespace Noelle.ColdKeys
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnCapsLk = new System.Windows.Forms.Button();
            this.btnNumLk = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.lnkAuthor = new System.Windows.Forms.LinkLabel();
            this.btnLaunchHotKeys = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCapsLk
            // 
            this.btnCapsLk.Location = new System.Drawing.Point(64, 40);
            this.btnCapsLk.Name = "btnCapsLk";
            this.btnCapsLk.Size = new System.Drawing.Size(246, 50);
            this.btnCapsLk.TabIndex = 0;
            this.btnCapsLk.Text = "禁用CapsLk提示";
            this.toolTipMain.SetToolTip(this.btnCapsLk, "关闭大小写提示");
            this.btnCapsLk.UseVisualStyleBackColor = true;
            this.btnCapsLk.Click += new System.EventHandler(this.btnCapsLk_Click);
            // 
            // btnNumLk
            // 
            this.btnNumLk.Location = new System.Drawing.Point(64, 113);
            this.btnNumLk.Name = "btnNumLk";
            this.btnNumLk.Size = new System.Drawing.Size(246, 50);
            this.btnNumLk.TabIndex = 0;
            this.btnNumLk.Text = "禁用NumLk提示";
            this.toolTipMain.SetToolTip(this.btnNumLk, "关闭小键盘提示");
            this.btnNumLk.UseVisualStyleBackColor = true;
            this.btnNumLk.Click += new System.EventHandler(this.btnNumLk_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Location = new System.Drawing.Point(64, 332);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(246, 50);
            this.btnSuspend.TabIndex = 0;
            this.btnSuspend.Text = "暂停/恢复HotKeys服务";
            this.toolTipMain.SetToolTip(this.btnSuspend, "【可能造成输入卡顿，不推荐！】\r\n点击后暂停HotKeys服务，所有提示均不再显示；再次点击恢复。");
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(64, 186);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(246, 50);
            this.btnKillProcess.TabIndex = 0;
            this.btnKillProcess.Text = "强退HotKeys进程";
            this.toolTipMain.SetToolTip(this.btnKillProcess, "尝试杀死HotKeys进程，所有提示均不再显示。\r\n如果你想恢复被禁用的大小写/小键盘提示，\r\n你可以先强退进程，再重新启动HotKeys。");
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // lnkAuthor
            // 
            this.lnkAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAuthor.AutoSize = true;
            this.lnkAuthor.Location = new System.Drawing.Point(129, 435);
            this.lnkAuthor.Name = "lnkAuthor";
            this.lnkAuthor.Size = new System.Drawing.Size(117, 28);
            this.lnkAuthor.TabIndex = 1;
            this.lnkAuthor.TabStop = true;
            this.lnkAuthor.Text = "by Ulysses";
            this.toolTipMain.SetToolTip(this.lnkAuthor, "点击浏览源代码");
            this.lnkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAuthor_LinkClicked);
            // 
            // btnLaunchHotKeys
            // 
            this.btnLaunchHotKeys.Location = new System.Drawing.Point(64, 259);
            this.btnLaunchHotKeys.Name = "btnLaunchHotKeys";
            this.btnLaunchHotKeys.Size = new System.Drawing.Size(246, 50);
            this.btnLaunchHotKeys.TabIndex = 0;
            this.btnLaunchHotKeys.Text = "启动HotKeys";
            this.toolTipMain.SetToolTip(this.btnLaunchHotKeys, "如果你结束了HotKeys进程，可以点这个尝试重新启动。");
            this.btnLaunchHotKeys.UseVisualStyleBackColor = true;
            this.btnLaunchHotKeys.Click += new System.EventHandler(this.btnLaunchHotKeys_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(374, 472);
            this.Controls.Add(this.lnkAuthor);
            this.Controls.Add(this.btnLaunchHotKeys);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.btnNumLk);
            this.Controls.Add(this.btnCapsLk);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "ColdKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapsLk;
        private System.Windows.Forms.Button btnNumLk;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.LinkLabel lnkAuthor;
        private System.Windows.Forms.Button btnLaunchHotKeys;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

