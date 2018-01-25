namespace Pomodro_lux
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(197, 226);
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
            this.colorR.Location = new System.Drawing.Point(12, 12);
            this.colorR.Name = "colorR";
            this.colorR.Size = new System.Drawing.Size(44, 20);
            this.colorR.TabIndex = 1;
            this.colorR.Text = "0";
            // 
            // colorG
            // 
            this.colorG.Location = new System.Drawing.Point(62, 12);
            this.colorG.Name = "colorG";
            this.colorG.Size = new System.Drawing.Size(44, 20);
            this.colorG.TabIndex = 2;
            this.colorG.Text = "255";
            // 
            // colorB
            // 
            this.colorB.Location = new System.Drawing.Point(112, 12);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(44, 20);
            this.colorB.TabIndex = 3;
            this.colorB.Text = "0";
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(13, 226);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(75, 23);
            this.shutdownBtn.TabIndex = 5;
            this.shutdownBtn.Text = "Turn off";
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.shutdownBtn);
            this.Controls.Add(this.colorB);
            this.Controls.Add(this.colorG);
            this.Controls.Add(this.colorR);
            this.Controls.Add(this.runBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox colorR;
        private System.Windows.Forms.TextBox colorG;
        private System.Windows.Forms.TextBox colorB;
        private System.Windows.Forms.Button shutdownBtn;
    }
}

