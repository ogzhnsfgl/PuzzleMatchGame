
namespace EsiniBulv2
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
            this.components = new System.ComponentModel.Container();
            this.pnlKartlar = new System.Windows.Forms.Panel();
            this.tbxSonuc = new System.Windows.Forms.TextBox();
            this.btnYenidenOyna = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlKartlar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKartlar
            // 
            this.pnlKartlar.Controls.Add(this.tbxSonuc);
            this.pnlKartlar.Controls.Add(this.btnYenidenOyna);
            this.pnlKartlar.Location = new System.Drawing.Point(12, 12);
            this.pnlKartlar.Name = "pnlKartlar";
            this.pnlKartlar.Size = new System.Drawing.Size(500, 500);
            this.pnlKartlar.TabIndex = 0;
            // 
            // tbxSonuc
            // 
            this.tbxSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSonuc.Location = new System.Drawing.Point(66, 151);
            this.tbxSonuc.Multiline = true;
            this.tbxSonuc.Name = "tbxSonuc";
            this.tbxSonuc.Size = new System.Drawing.Size(380, 113);
            this.tbxSonuc.TabIndex = 0;
            this.tbxSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSonuc.Visible = false;
            // 
            // btnYenidenOyna
            // 
            this.btnYenidenOyna.Location = new System.Drawing.Point(157, 403);
            this.btnYenidenOyna.Name = "btnYenidenOyna";
            this.btnYenidenOyna.Size = new System.Drawing.Size(189, 72);
            this.btnYenidenOyna.TabIndex = 0;
            this.btnYenidenOyna.Text = "Yeniden Oyna";
            this.btnYenidenOyna.UseVisualStyleBackColor = true;
            this.btnYenidenOyna.Visible = false;
            this.btnYenidenOyna.Click += new System.EventHandler(this.btnYenidenOyna_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(118, 17);
            this.tssStatus.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 536);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlKartlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Esini Bul v2";
            this.pnlKartlar.ResumeLayout(false);
            this.pnlKartlar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKartlar;
        private System.Windows.Forms.Button btnYenidenOyna;
        private System.Windows.Forms.TextBox tbxSonuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
    }
}

