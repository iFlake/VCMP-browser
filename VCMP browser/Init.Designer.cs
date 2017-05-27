namespace VCMP_browser
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelWait = new System.Windows.Forms.Label();
            this.LabelProcess = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LabelProcess);
            this.panel1.Controls.Add(this.LabelWait);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 138);
            this.panel1.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Silver;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.LabelTitle.Size = new System.Drawing.Size(398, 31);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "VCMP browser";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelWait
            // 
            this.LabelWait.ForeColor = System.Drawing.Color.White;
            this.LabelWait.Location = new System.Drawing.Point(0, 55);
            this.LabelWait.Name = "LabelWait";
            this.LabelWait.Size = new System.Drawing.Size(398, 19);
            this.LabelWait.TabIndex = 1;
            this.LabelWait.Text = "Please wait...";
            this.LabelWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelProcess
            // 
            this.LabelProcess.ForeColor = System.Drawing.Color.White;
            this.LabelProcess.Location = new System.Drawing.Point(0, 74);
            this.LabelProcess.Name = "LabelProcess";
            this.LabelProcess.Size = new System.Drawing.Size(398, 19);
            this.LabelProcess.TabIndex = 2;
            this.LabelProcess.Text = "Initializing";
            this.LabelProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 140);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Init";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Init_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Init_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelWait;
        private System.Windows.Forms.Label LabelProcess;
    }
}

