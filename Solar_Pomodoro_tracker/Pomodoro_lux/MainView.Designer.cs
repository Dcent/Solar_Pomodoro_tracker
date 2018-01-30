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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.runBtn = new System.Windows.Forms.Button();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoroPanel = new System.Windows.Forms.Panel();
            this.loopCountBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addStepBtn = new System.Windows.Forms.Button();
            this.stepTimeBox = new System.Windows.Forms.TextBox();
            this.stepNameBox = new System.Windows.Forms.TextBox();
            this.loopCheck = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lockScreenCheck = new System.Windows.Forms.CheckBox();
            this.colorsBox = new System.Windows.Forms.ComboBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pomodoroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(757, 238);
            this.runBtn.Name = "runBtn";
            this.runBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Go";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(676, 238);
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
            this.pomodoroPanel.Controls.Add(this.loopCountBox);
            this.pomodoroPanel.Controls.Add(this.listView1);
            this.pomodoroPanel.Controls.Add(this.addStepBtn);
            this.pomodoroPanel.Controls.Add(this.stepTimeBox);
            this.pomodoroPanel.Controls.Add(this.stepNameBox);
            this.pomodoroPanel.Controls.Add(this.loopCheck);
            this.pomodoroPanel.Controls.Add(this.checkBox2);
            this.pomodoroPanel.Controls.Add(this.lockScreenCheck);
            this.pomodoroPanel.Controls.Add(this.colorsBox);
            this.pomodoroPanel.Controls.Add(this.shutdownBtn);
            this.pomodoroPanel.Controls.Add(this.runBtn);
            this.pomodoroPanel.Location = new System.Drawing.Point(12, 27);
            this.pomodoroPanel.Name = "pomodoroPanel";
            this.pomodoroPanel.Size = new System.Drawing.Size(835, 264);
            this.pomodoroPanel.TabIndex = 7;
            // 
            // loopCountBox
            // 
            this.loopCountBox.Location = new System.Drawing.Point(311, 238);
            this.loopCountBox.Name = "loopCountBox";
            this.loopCountBox.Size = new System.Drawing.Size(100, 20);
            this.loopCountBox.TabIndex = 15;
            this.loopCountBox.Text = "Number of Loops";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 176);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addStepBtn
            // 
            this.addStepBtn.Location = new System.Drawing.Point(375, 20);
            this.addStepBtn.Name = "addStepBtn";
            this.addStepBtn.Size = new System.Drawing.Size(24, 23);
            this.addStepBtn.TabIndex = 12;
            this.addStepBtn.Text = "+";
            this.addStepBtn.UseVisualStyleBackColor = true;
            // 
            // stepTimeBox
            // 
            this.stepTimeBox.Location = new System.Drawing.Point(142, 20);
            this.stepTimeBox.Name = "stepTimeBox";
            this.stepTimeBox.Size = new System.Drawing.Size(100, 20);
            this.stepTimeBox.TabIndex = 11;
            this.stepTimeBox.Text = "Time in Min";
            // 
            // stepNameBox
            // 
            this.stepNameBox.Location = new System.Drawing.Point(36, 20);
            this.stepNameBox.Name = "stepNameBox";
            this.stepNameBox.Size = new System.Drawing.Size(100, 20);
            this.stepNameBox.TabIndex = 10;
            this.stepNameBox.Text = "Name";
            // 
            // loopCheck
            // 
            this.loopCheck.AutoSize = true;
            this.loopCheck.Location = new System.Drawing.Point(224, 238);
            this.loopCheck.Name = "loopCheck";
            this.loopCheck.Size = new System.Drawing.Size(78, 17);
            this.loopCheck.TabIndex = 9;
            this.loopCheck.Text = "Loop steps";
            this.loopCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(137, 238);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Show Overlay";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lockScreenCheck
            // 
            this.lockScreenCheck.AutoSize = true;
            this.lockScreenCheck.Location = new System.Drawing.Point(4, 238);
            this.lockScreenCheck.Name = "lockScreenCheck";
            this.lockScreenCheck.Size = new System.Drawing.Size(135, 17);
            this.lockScreenCheck.TabIndex = 7;
            this.lockScreenCheck.Text = "Pause on Lock Screen";
            this.lockScreenCheck.UseVisualStyleBackColor = true;
            // 
            // colorsBox
            // 
            this.colorsBox.FormattingEnabled = true;
            this.colorsBox.Location = new System.Drawing.Point(248, 20);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(121, 21);
            this.colorsBox.TabIndex = 6;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(12, 27);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(835, 264);
            this.settingsPanel.TabIndex = 16;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 303);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.pomodoroPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Text = "Solar Pomodoro App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pomodoroPanel.ResumeLayout(false);
            this.pomodoroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel pomodoroPanel;
        private System.Windows.Forms.ComboBox colorsBox;
        private System.Windows.Forms.TextBox loopCountBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addStepBtn;
        private System.Windows.Forms.TextBox stepTimeBox;
        private System.Windows.Forms.TextBox stepNameBox;
        private System.Windows.Forms.CheckBox loopCheck;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox lockScreenCheck;
        private System.Windows.Forms.Panel settingsPanel;
    }
}

