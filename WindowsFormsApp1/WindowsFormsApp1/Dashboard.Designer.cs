
namespace WindowsFormsApp1
{
    partial class Dashboard
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutlink = new System.Windows.Forms.LinkLabel();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.removeitemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateitemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.additemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.placeorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteuc1 = new WindowsFormsApp1.allusercontrol.deleteuc();
            this.uc_update1 = new WindowsFormsApp1.allusercontrol.uc_update();
            this.uc_placeordercontrol1 = new WindowsFormsApp1.allusercontrol.Uc_placeordercontrol();
            this.uC_additems1 = new WindowsFormsApp1.allusercontrol.UC_additems();
            this.uC_welcome1 = new WindowsFormsApp1.allusercontrol.UC_welcome();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel1.Controls.Add(this.logoutlink);
            this.guna2Panel1.Controls.Add(this.guna2GradientCircleButton1);
            this.guna2Panel1.Controls.Add(this.removeitemsbtn);
            this.guna2Panel1.Controls.Add(this.updateitemsbtn);
            this.guna2Panel1.Controls.Add(this.additemsbtn);
            this.guna2Panel1.Controls.Add(this.placeorderbtn);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(215, 492);
            this.guna2Panel1.TabIndex = 0;
            // 
            // logoutlink
            // 
            this.logoutlink.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.logoutlink, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutlink.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlink.LinkColor = System.Drawing.Color.White;
            this.logoutlink.Location = new System.Drawing.Point(61, 436);
            this.logoutlink.Name = "logoutlink";
            this.logoutlink.Size = new System.Drawing.Size(86, 26);
            this.logoutlink.TabIndex = 6;
            this.logoutlink.TabStop = true;
            this.logoutlink.Text = "LogOut";
            this.logoutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutlink_LinkClicked);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2Transition1.SetDecoration(this.guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(46, 49);
            this.guna2GradientCircleButton1.TabIndex = 5;
            this.guna2GradientCircleButton1.Text = "x";
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // removeitemsbtn
            // 
            this.removeitemsbtn.BorderRadius = 20;
            this.removeitemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.removeitemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.removeitemsbtn.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.removeitemsbtn.CheckedState.Parent = this.removeitemsbtn;
            this.removeitemsbtn.CustomImages.Parent = this.removeitemsbtn;
            this.guna2Transition1.SetDecoration(this.removeitemsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removeitemsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removeitemsbtn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeitemsbtn.ForeColor = System.Drawing.Color.White;
            this.removeitemsbtn.HoverState.Parent = this.removeitemsbtn;
            this.removeitemsbtn.Location = new System.Drawing.Point(55, 297);
            this.removeitemsbtn.Name = "removeitemsbtn";
            this.removeitemsbtn.ShadowDecoration.Parent = this.removeitemsbtn;
            this.removeitemsbtn.Size = new System.Drawing.Size(180, 45);
            this.removeitemsbtn.TabIndex = 3;
            this.removeitemsbtn.Text = "Remove Items";
            this.removeitemsbtn.Click += new System.EventHandler(this.removeitemsbtn_Click);
            // 
            // updateitemsbtn
            // 
            this.updateitemsbtn.BorderRadius = 20;
            this.updateitemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateitemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.updateitemsbtn.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.updateitemsbtn.CheckedState.Parent = this.updateitemsbtn;
            this.updateitemsbtn.CustomImages.Parent = this.updateitemsbtn;
            this.guna2Transition1.SetDecoration(this.updateitemsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateitemsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.updateitemsbtn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateitemsbtn.ForeColor = System.Drawing.Color.White;
            this.updateitemsbtn.HoverState.Parent = this.updateitemsbtn;
            this.updateitemsbtn.Location = new System.Drawing.Point(55, 223);
            this.updateitemsbtn.Name = "updateitemsbtn";
            this.updateitemsbtn.ShadowDecoration.Parent = this.updateitemsbtn;
            this.updateitemsbtn.Size = new System.Drawing.Size(180, 45);
            this.updateitemsbtn.TabIndex = 2;
            this.updateitemsbtn.Text = "Update Items";
            this.updateitemsbtn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // additemsbtn
            // 
            this.additemsbtn.BorderRadius = 20;
            this.additemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.additemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.additemsbtn.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.additemsbtn.CheckedState.Parent = this.additemsbtn;
            this.additemsbtn.CustomImages.Parent = this.additemsbtn;
            this.guna2Transition1.SetDecoration(this.additemsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.additemsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.additemsbtn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemsbtn.ForeColor = System.Drawing.Color.White;
            this.additemsbtn.HoverState.Parent = this.additemsbtn;
            this.additemsbtn.Location = new System.Drawing.Point(55, 151);
            this.additemsbtn.Name = "additemsbtn";
            this.additemsbtn.ShadowDecoration.Parent = this.additemsbtn;
            this.additemsbtn.Size = new System.Drawing.Size(180, 45);
            this.additemsbtn.TabIndex = 1;
            this.additemsbtn.Text = "Add Items";
            this.additemsbtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // placeorderbtn
            // 
            this.placeorderbtn.BorderRadius = 20;
            this.placeorderbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.placeorderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.placeorderbtn.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.placeorderbtn.CheckedState.Parent = this.placeorderbtn;
            this.placeorderbtn.CustomImages.Parent = this.placeorderbtn;
            this.guna2Transition1.SetDecoration(this.placeorderbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeorderbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.placeorderbtn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderbtn.ForeColor = System.Drawing.Color.White;
            this.placeorderbtn.HoverState.Parent = this.placeorderbtn;
            this.placeorderbtn.Location = new System.Drawing.Point(55, 78);
            this.placeorderbtn.Name = "placeorderbtn";
            this.placeorderbtn.ShadowDecoration.Parent = this.placeorderbtn;
            this.placeorderbtn.Size = new System.Drawing.Size(180, 45);
            this.placeorderbtn.TabIndex = 0;
            this.placeorderbtn.Text = "Place Order";
            this.placeorderbtn.Click += new System.EventHandler(this.placeorderbtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.deleteuc1);
            this.guna2Panel2.Controls.Add(this.uc_update1);
            this.guna2Panel2.Controls.Add(this.uc_placeordercontrol1);
            this.guna2Panel2.Controls.Add(this.uC_additems1);
            this.guna2Panel2.Controls.Add(this.uC_welcome1);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(249, 24);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(743, 492);
            this.guna2Panel2.TabIndex = 1;
            // 
            // deleteuc1
            // 
            this.deleteuc1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.deleteuc1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.deleteuc1.Location = new System.Drawing.Point(0, 0);
            this.deleteuc1.Name = "deleteuc1";
            this.deleteuc1.Size = new System.Drawing.Size(781, 514);
            this.deleteuc1.TabIndex = 4;
            // 
            // uc_update1
            // 
            this.uc_update1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uc_update1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uc_update1.Location = new System.Drawing.Point(3, -11);
            this.uc_update1.Name = "uc_update1";
            this.uc_update1.Size = new System.Drawing.Size(781, 514);
            this.uc_update1.TabIndex = 3;
            // 
            // uc_placeordercontrol1
            // 
            this.uc_placeordercontrol1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uc_placeordercontrol1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uc_placeordercontrol1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_placeordercontrol1.ForeColor = System.Drawing.Color.Black;
            this.uc_placeordercontrol1.Location = new System.Drawing.Point(0, -11);
            this.uc_placeordercontrol1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_placeordercontrol1.Name = "uc_placeordercontrol1";
            this.uc_placeordercontrol1.Size = new System.Drawing.Size(739, 491);
            this.uc_placeordercontrol1.TabIndex = 2;
            this.uc_placeordercontrol1.Load += new System.EventHandler(this.uc_placeordercontrol1_Load);
            // 
            // uC_additems1
            // 
            this.uC_additems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_additems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_additems1.Location = new System.Drawing.Point(3, 3);
            this.uC_additems1.Name = "uC_additems1";
            this.uC_additems1.Size = new System.Drawing.Size(781, 514);
            this.uC_additems1.TabIndex = 1;
            this.uC_additems1.Load += new System.EventHandler(this.uC_additems1_Load);
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(781, 538);
            this.uC_welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.guna2Panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlideAndRotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 548);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button removeitemsbtn;
        private Guna.UI2.WinForms.Guna2Button updateitemsbtn;
        private Guna.UI2.WinForms.Guna2Button additemsbtn;
        private Guna.UI2.WinForms.Guna2Button placeorderbtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel logoutlink;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private allusercontrol.UC_welcome uC_welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private allusercontrol.UC_additems uC_additems1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private allusercontrol.Uc_placeordercontrol uc_placeordercontrol1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private allusercontrol.uc_update uc_update1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private allusercontrol.deleteuc deleteuc1;
    }
}