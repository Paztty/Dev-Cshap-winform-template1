namespace Template_project1
{
    partial class FormReport
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
            this.panelSetting = new System.Windows.Forms.Panel();
            this.labelTest = new System.Windows.Forms.Label();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panelSetting.Controls.Add(this.labelTest);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(4);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(1067, 658);
            this.panelSetting.TabIndex = 0;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 50F);
            this.labelTest.Location = new System.Drawing.Point(33, 30);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(711, 88);
            this.labelTest.TabIndex = 0;
            this.labelTest.Text = "labelTestFormReport";
            this.labelTest.Click += new System.EventHandler(this.labelTest_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.ControlBox = false;
            this.Controls.Add(this.panelSetting);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReport";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Label labelTest;
    }
}