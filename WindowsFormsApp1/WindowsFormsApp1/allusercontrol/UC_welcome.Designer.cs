
namespace WindowsFormsApp1.allusercontrol
{
    partial class UC_welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_welcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hindcafelabel = new System.Windows.Forms.Label();
            this.tolabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hindcafelabel
            // 
            this.hindcafelabel.AutoSize = true;
            this.hindcafelabel.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hindcafelabel.Location = new System.Drawing.Point(230, 410);
            this.hindcafelabel.Name = "hindcafelabel";
            this.hindcafelabel.Size = new System.Drawing.Size(311, 79);
            this.hindcafelabel.TabIndex = 1;
            this.hindcafelabel.Text = "Hind Cafe";
            this.hindcafelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tolabel
            // 
            this.tolabel.AutoSize = true;
            this.tolabel.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolabel.Location = new System.Drawing.Point(350, 365);
            this.tolabel.Name = "tolabel";
            this.tolabel.Size = new System.Drawing.Size(58, 45);
            this.tolabel.TabIndex = 2;
            this.tolabel.Text = "to";
            this.tolabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tolabel);
            this.Controls.Add(this.hindcafelabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_welcome";
            this.Size = new System.Drawing.Size(781, 538);
            this.Load += new System.EventHandler(this.UC_welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hindcafelabel;
        private System.Windows.Forms.Label tolabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
