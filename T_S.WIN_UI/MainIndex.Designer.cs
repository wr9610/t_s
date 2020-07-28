namespace T_S.WIN_UI
{
    partial class MainIndex
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tcPages = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T_S_Ment = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.T_S_Ment);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1399, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1399, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tcPages
            // 
            this.tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPages.Location = new System.Drawing.Point(0, 74);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(1399, 596);
            this.tcPages.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 635);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 35);
            this.panel1.TabIndex = 3;
            // 
            // Txt_Date
            // 
            this.Txt_Date.AutoSize = true;
            this.Txt_Date.Location = new System.Drawing.Point(258, 11);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(0, 12);
            this.Txt_Date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "登录时间：";
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(72, 11);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(0, 12);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录人：";
            // 
            // T_S_Ment
            // 
            this.T_S_Ment.Location = new System.Drawing.Point(3, 17);
            this.T_S_Ment.Name = "T_S_Ment";
            this.T_S_Ment.Size = new System.Drawing.Size(1393, 24);
            this.T_S_Ment.TabIndex = 0;
            this.T_S_Ment.Text = "menuStrip1";
            // 
            // MainIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcPages);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainIndex";
            this.Text = "MainIndex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainIndex_FormClosing);
            this.Load += new System.EventHandler(this.MainIndex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Txt_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip T_S_Ment;
    }
}