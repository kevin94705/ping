namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startbt = new System.Windows.Forms.Button();
            this.stopbt = new System.Windows.Forms.Button();
            this.showresult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbt
            // 
            this.startbt.Location = new System.Drawing.Point(12, 224);
            this.startbt.Name = "startbt";
            this.startbt.Size = new System.Drawing.Size(75, 23);
            this.startbt.TabIndex = 1;
            this.startbt.Text = "開始";
            this.startbt.UseVisualStyleBackColor = true;
            this.startbt.Click += new System.EventHandler(this.startbt_Click);
            // 
            // stopbt
            // 
            this.stopbt.Location = new System.Drawing.Point(262, 224);
            this.stopbt.Name = "stopbt";
            this.stopbt.Size = new System.Drawing.Size(75, 23);
            this.stopbt.TabIndex = 2;
            this.stopbt.Text = "停止";
            this.stopbt.UseVisualStyleBackColor = true;
            this.stopbt.Click += new System.EventHandler(this.stopbt_Click);
            // 
            // showresult
            // 
            this.showresult.FormattingEnabled = true;
            this.showresult.ItemHeight = 15;
            this.showresult.Location = new System.Drawing.Point(12, 3);
            this.showresult.Name = "showresult";
            this.showresult.ScrollAlwaysVisible = true;
            this.showresult.Size = new System.Drawing.Size(343, 199);
            this.showresult.TabIndex = 3;
            this.showresult.SelectedIndexChanged += new System.EventHandler(this.showresult_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showresult);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 218);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopbt);
            this.Controls.Add(this.startbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button startbt;
        private Button stopbt;
        private ListBox showresult;
        private Panel panel1;
    }
}