namespace Pomodro_lux
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.runBtn = new System.Windows.Forms.Button();
            this.colorR = new System.Windows.Forms.TextBox();
            this.colorG = new System.Windows.Forms.TextBox();
            this.colorB = new System.Windows.Forms.TextBox();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoroPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pomodoroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(328, 171);
            this.runBtn.Name = "runBtn";
            this.runBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Go";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // colorR
            // 
            this.colorR.Location = new System.Drawing.Point(259, 145);
            this.colorR.Name = "colorR";
            this.colorR.Size = new System.Drawing.Size(44, 20);
            this.colorR.TabIndex = 1;
            this.colorR.Text = "0";
            // 
            // colorG
            // 
            this.colorG.Location = new System.Drawing.Point(309, 145);
            this.colorG.Name = "colorG";
            this.colorG.Size = new System.Drawing.Size(44, 20);
            this.colorG.TabIndex = 2;
            this.colorG.Text = "255";
            // 
            // colorB
            // 
            this.colorB.Location = new System.Drawing.Point(359, 145);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(44, 20);
            this.colorB.TabIndex = 3;
            this.colorB.Text = "0";
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(144, 171);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(75, 23);
            this.shutdownBtn.TabIndex = 5;
            this.shutdownBtn.Text = "Turn off";
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomodoroToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomodoroToolStripMenuItem
            // 
            this.pomodoroToolStripMenuItem.Name = "pomodoroToolStripMenuItem";
            this.pomodoroToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.pomodoroToolStripMenuItem.Text = "Pomodoro";
            this.pomodoroToolStripMenuItem.Click += new System.EventHandler(this.pomodoroToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pomodoroPanel
            // 
            this.pomodoroPanel.Controls.Add(this.colorR);
            this.pomodoroPanel.Controls.Add(this.shutdownBtn);
            this.pomodoroPanel.Controls.Add(this.runBtn);
            this.pomodoroPanel.Controls.Add(this.colorB);
            this.pomodoroPanel.Controls.Add(this.colorG);
            this.pomodoroPanel.Location = new System.Drawing.Point(106, 56);
            this.pomodoroPanel.Name = "pomodoroPanel";
            this.pomodoroPanel.Size = new System.Drawing.Size(413, 206);
            this.pomodoroPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 303);
            this.Controls.Add(this.pomodoroPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pomodoroPanel.ResumeLayout(false);
            this.pomodoroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox colorR;
        private System.Windows.Forms.TextBox colorG;
        private System.Windows.Forms.TextBox colorB;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel pomodoroPanel;
    }
}

