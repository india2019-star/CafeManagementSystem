
namespace WindowsFormsApp1.allusercontrol
{
    partial class UC_additems
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
            this.label1 = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.itemnamelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.additembtn = new Guna.UI2.WinForms.Guna2Button();
            this.categorytextbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.itemnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.itempricetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Item";
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel.Location = new System.Drawing.Point(185, 91);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(96, 25);
            this.categorylabel.TabIndex = 1;
            this.categorylabel.Text = "Category";
            this.categorylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemnamelabel
            // 
            this.itemnamelabel.AutoSize = true;
            this.itemnamelabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamelabel.Location = new System.Drawing.Point(185, 182);
            this.itemnamelabel.Name = "itemnamelabel";
            this.itemnamelabel.Size = new System.Drawing.Size(120, 25);
            this.itemnamelabel.TabIndex = 2;
            this.itemnamelabel.Text = "Item Name";
            this.itemnamelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(185, 272);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(60, 25);
            this.pricelabel.TabIndex = 3;
            this.pricelabel.Text = "Price";
            this.pricelabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // additembtn
            // 
            this.additembtn.BorderRadius = 20;
            this.additembtn.CheckedState.Parent = this.additembtn;
            this.additembtn.CustomImages.Parent = this.additembtn;
            this.additembtn.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additembtn.ForeColor = System.Drawing.Color.White;
            this.additembtn.HoverState.Parent = this.additembtn;
            this.additembtn.Location = new System.Drawing.Point(284, 398);
            this.additembtn.Name = "additembtn";
            this.additembtn.ShadowDecoration.Parent = this.additembtn;
            this.additembtn.Size = new System.Drawing.Size(198, 56);
            this.additembtn.TabIndex = 4;
            this.additembtn.Text = "Add Item";
            this.additembtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // categorytextbox
            // 
            this.categorytextbox.BackColor = System.Drawing.Color.Transparent;
            this.categorytextbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorytextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorytextbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorytextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorytextbox.FocusedState.Parent = this.categorytextbox;
            this.categorytextbox.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.categorytextbox.ForeColor = System.Drawing.Color.Black;
            this.categorytextbox.HoverState.Parent = this.categorytextbox;
            this.categorytextbox.ItemHeight = 30;
            this.categorytextbox.Items.AddRange(new object[] {
            "Soft Drink",
            "Tea",
            "Coffee",
            "North Indian ",
            "South Indian",
            "Italian",
            "Chinese"});
            this.categorytextbox.ItemsAppearance.Parent = this.categorytextbox;
            this.categorytextbox.Location = new System.Drawing.Point(188, 128);
            this.categorytextbox.Name = "categorytextbox";
            this.categorytextbox.ShadowDecoration.Parent = this.categorytextbox;
            this.categorytextbox.Size = new System.Drawing.Size(364, 36);
            this.categorytextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categorytextbox.TabIndex = 5;
            // 
            // itemnametxt
            // 
            this.itemnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemnametxt.DefaultText = "";
            this.itemnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnametxt.DisabledState.Parent = this.itemnametxt;
            this.itemnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnametxt.FocusedState.Parent = this.itemnametxt;
            this.itemnametxt.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnametxt.ForeColor = System.Drawing.Color.Black;
            this.itemnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnametxt.HoverState.Parent = this.itemnametxt;
            this.itemnametxt.Location = new System.Drawing.Point(190, 218);
            this.itemnametxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.PasswordChar = '\0';
            this.itemnametxt.PlaceholderText = "";
            this.itemnametxt.SelectedText = "";
            this.itemnametxt.ShadowDecoration.Parent = this.itemnametxt;
            this.itemnametxt.Size = new System.Drawing.Size(362, 36);
            this.itemnametxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemnametxt.TabIndex = 6;
            this.itemnametxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // itempricetxt
            // 
            this.itempricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itempricetxt.DefaultText = "";
            this.itempricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itempricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itempricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itempricetxt.DisabledState.Parent = this.itempricetxt;
            this.itempricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itempricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itempricetxt.FocusedState.Parent = this.itempricetxt;
            this.itempricetxt.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itempricetxt.ForeColor = System.Drawing.Color.Black;
            this.itempricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itempricetxt.HoverState.Parent = this.itempricetxt;
            this.itempricetxt.Location = new System.Drawing.Point(190, 308);
            this.itempricetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itempricetxt.Name = "itempricetxt";
            this.itempricetxt.PasswordChar = '\0';
            this.itempricetxt.PlaceholderText = "";
            this.itempricetxt.SelectedText = "";
            this.itempricetxt.ShadowDecoration.Parent = this.itempricetxt;
            this.itempricetxt.Size = new System.Drawing.Size(362, 36);
            this.itempricetxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itempricetxt.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itempricetxt);
            this.Controls.Add(this.itemnametxt);
            this.Controls.Add(this.categorytextbox);
            this.Controls.Add(this.additembtn);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.itemnamelabel);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.label1);
            this.Name = "UC_additems";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_additems_Load);
            this.Leave += new System.EventHandler(this.UC_additems_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label itemnamelabel;
        private System.Windows.Forms.Label pricelabel;
        private Guna.UI2.WinForms.Guna2Button additembtn;
        private Guna.UI2.WinForms.Guna2ComboBox categorytextbox;
        private Guna.UI2.WinForms.Guna2TextBox itemnametxt;
        private Guna.UI2.WinForms.Guna2TextBox itempricetxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
