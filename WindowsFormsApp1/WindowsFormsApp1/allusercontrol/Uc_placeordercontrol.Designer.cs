
namespace WindowsFormsApp1.allusercontrol
{
    partial class Uc_placeordercontrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listplaceorder = new System.Windows.Forms.ListBox();
            this.categorycombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchplaceorderbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemnameplaceorder = new Guna.UI2.WinForms.Guna2TextBox();
            this.itempriceplaceorder = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalplaceorder = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityplaceorder = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gridviewplaceorder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additemplaceorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.removeitemplaceorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.printitemplaceorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rupeesplaceorder = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantityplaceorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewplaceorder)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // listplaceorder
            // 
            this.listplaceorder.FormattingEnabled = true;
            this.listplaceorder.ItemHeight = 22;
            this.listplaceorder.Location = new System.Drawing.Point(23, 146);
            this.listplaceorder.Name = "listplaceorder";
            this.listplaceorder.Size = new System.Drawing.Size(157, 246);
            this.listplaceorder.TabIndex = 6;
            this.listplaceorder.SelectedIndexChanged += new System.EventHandler(this.listplaceorder_SelectedIndexChanged);
            // 
            // categorycombobox
            // 
            this.categorycombobox.BackColor = System.Drawing.Color.Transparent;
            this.categorycombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorycombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorycombobox.FocusedState.Parent = this.categorycombobox;
            this.categorycombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categorycombobox.ForeColor = System.Drawing.Color.Black;
            this.categorycombobox.HoverState.Parent = this.categorycombobox;
            this.categorycombobox.ItemHeight = 30;
            this.categorycombobox.Items.AddRange(new object[] {
            "Soft Drink",
            "Tea",
            "Coffee",
            "North Indian ",
            "South Indian",
            "Italian",
            "Chinese"});
            this.categorycombobox.ItemsAppearance.Parent = this.categorycombobox;
            this.categorycombobox.Location = new System.Drawing.Point(40, 44);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.ShadowDecoration.Parent = this.categorycombobox;
            this.categorycombobox.Size = new System.Drawing.Size(140, 36);
            this.categorycombobox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categorycombobox.TabIndex = 7;
            this.categorycombobox.SelectedIndexChanged += new System.EventHandler(this.categorycombobox_SelectedIndexChanged);
            // 
            // searchplaceorderbox
            // 
            this.searchplaceorderbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchplaceorderbox.DefaultText = "";
            this.searchplaceorderbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchplaceorderbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchplaceorderbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchplaceorderbox.DisabledState.Parent = this.searchplaceorderbox;
            this.searchplaceorderbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchplaceorderbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchplaceorderbox.FocusedState.Parent = this.searchplaceorderbox;
            this.searchplaceorderbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchplaceorderbox.ForeColor = System.Drawing.Color.Black;
            this.searchplaceorderbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchplaceorderbox.HoverState.Parent = this.searchplaceorderbox;
            this.searchplaceorderbox.Location = new System.Drawing.Point(40, 95);
            this.searchplaceorderbox.Margin = new System.Windows.Forms.Padding(6);
            this.searchplaceorderbox.Name = "searchplaceorderbox";
            this.searchplaceorderbox.PasswordChar = '\0';
            this.searchplaceorderbox.PlaceholderText = "Search";
            this.searchplaceorderbox.SelectedText = "";
            this.searchplaceorderbox.ShadowDecoration.Parent = this.searchplaceorderbox;
            this.searchplaceorderbox.Size = new System.Drawing.Size(140, 39);
            this.searchplaceorderbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchplaceorderbox.TabIndex = 8;
            this.searchplaceorderbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchplaceorderbox.TextChanged += new System.EventHandler(this.searchplaceorderbox_TextChanged);
            // 
            // itemnameplaceorder
            // 
            this.itemnameplaceorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemnameplaceorder.DefaultText = "";
            this.itemnameplaceorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemnameplaceorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemnameplaceorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnameplaceorder.DisabledState.Parent = this.itemnameplaceorder;
            this.itemnameplaceorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemnameplaceorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnameplaceorder.FocusedState.Parent = this.itemnameplaceorder;
            this.itemnameplaceorder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnameplaceorder.ForeColor = System.Drawing.Color.Black;
            this.itemnameplaceorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemnameplaceorder.HoverState.Parent = this.itemnameplaceorder;
            this.itemnameplaceorder.Location = new System.Drawing.Point(215, 49);
            this.itemnameplaceorder.Margin = new System.Windows.Forms.Padding(8);
            this.itemnameplaceorder.Name = "itemnameplaceorder";
            this.itemnameplaceorder.PasswordChar = '\0';
            this.itemnameplaceorder.PlaceholderText = "";
            this.itemnameplaceorder.SelectedText = "";
            this.itemnameplaceorder.ShadowDecoration.Parent = this.itemnameplaceorder;
            this.itemnameplaceorder.Size = new System.Drawing.Size(145, 31);
            this.itemnameplaceorder.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemnameplaceorder.TabIndex = 9;
            // 
            // itempriceplaceorder
            // 
            this.itempriceplaceorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itempriceplaceorder.DefaultText = "";
            this.itempriceplaceorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itempriceplaceorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itempriceplaceorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itempriceplaceorder.DisabledState.Parent = this.itempriceplaceorder;
            this.itempriceplaceorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itempriceplaceorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itempriceplaceorder.FocusedState.Parent = this.itempriceplaceorder;
            this.itempriceplaceorder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itempriceplaceorder.ForeColor = System.Drawing.Color.Black;
            this.itempriceplaceorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itempriceplaceorder.HoverState.Parent = this.itempriceplaceorder;
            this.itempriceplaceorder.Location = new System.Drawing.Point(398, 49);
            this.itempriceplaceorder.Margin = new System.Windows.Forms.Padding(8);
            this.itempriceplaceorder.Name = "itempriceplaceorder";
            this.itempriceplaceorder.PasswordChar = '\0';
            this.itempriceplaceorder.PlaceholderText = "";
            this.itempriceplaceorder.SelectedText = "";
            this.itempriceplaceorder.ShadowDecoration.Parent = this.itempriceplaceorder;
            this.itempriceplaceorder.Size = new System.Drawing.Size(145, 31);
            this.itempriceplaceorder.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itempriceplaceorder.TabIndex = 10;
            // 
            // totalplaceorder
            // 
            this.totalplaceorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalplaceorder.DefaultText = "";
            this.totalplaceorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalplaceorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalplaceorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalplaceorder.DisabledState.Parent = this.totalplaceorder;
            this.totalplaceorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalplaceorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalplaceorder.FocusedState.Parent = this.totalplaceorder;
            this.totalplaceorder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalplaceorder.ForeColor = System.Drawing.Color.Black;
            this.totalplaceorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalplaceorder.HoverState.Parent = this.totalplaceorder;
            this.totalplaceorder.Location = new System.Drawing.Point(398, 131);
            this.totalplaceorder.Margin = new System.Windows.Forms.Padding(8);
            this.totalplaceorder.Name = "totalplaceorder";
            this.totalplaceorder.PasswordChar = '\0';
            this.totalplaceorder.PlaceholderText = "";
            this.totalplaceorder.SelectedText = "";
            this.totalplaceorder.ShadowDecoration.Parent = this.totalplaceorder;
            this.totalplaceorder.Size = new System.Drawing.Size(145, 36);
            this.totalplaceorder.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.totalplaceorder.TabIndex = 11;
            // 
            // quantityplaceorder
            // 
            this.quantityplaceorder.BackColor = System.Drawing.Color.Transparent;
            this.quantityplaceorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityplaceorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityplaceorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityplaceorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityplaceorder.DisabledState.Parent = this.quantityplaceorder;
            this.quantityplaceorder.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.quantityplaceorder.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.quantityplaceorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityplaceorder.FocusedState.Parent = this.quantityplaceorder;
            this.quantityplaceorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityplaceorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quantityplaceorder.Location = new System.Drawing.Point(215, 131);
            this.quantityplaceorder.Name = "quantityplaceorder";
            this.quantityplaceorder.ShadowDecoration.Parent = this.quantityplaceorder;
            this.quantityplaceorder.Size = new System.Drawing.Size(145, 36);
            this.quantityplaceorder.TabIndex = 12;
            this.quantityplaceorder.ValueChanged += new System.EventHandler(this.quantityplaceorder_ValueChanged);
            // 
            // gridviewplaceorder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewplaceorder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewplaceorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewplaceorder.BackgroundColor = System.Drawing.Color.White;
            this.gridviewplaceorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridviewplaceorder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewplaceorder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewplaceorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewplaceorder.ColumnHeadersHeight = 46;
            this.gridviewplaceorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewplaceorder.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewplaceorder.EnableHeadersVisualStyles = false;
            this.gridviewplaceorder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewplaceorder.Location = new System.Drawing.Point(215, 224);
            this.gridviewplaceorder.Name = "gridviewplaceorder";
            this.gridviewplaceorder.RowHeadersVisible = false;
            this.gridviewplaceorder.RowHeadersWidth = 51;
            this.gridviewplaceorder.RowTemplate.Height = 24;
            this.gridviewplaceorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewplaceorder.Size = new System.Drawing.Size(328, 114);
            this.gridviewplaceorder.TabIndex = 13;
            this.gridviewplaceorder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridviewplaceorder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewplaceorder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewplaceorder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewplaceorder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewplaceorder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewplaceorder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewplaceorder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewplaceorder.ThemeStyle.HeaderStyle.Height = 46;
            this.gridviewplaceorder.ThemeStyle.ReadOnly = false;
            this.gridviewplaceorder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewplaceorder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewplaceorder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewplaceorder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridviewplaceorder.ThemeStyle.RowsStyle.Height = 24;
            this.gridviewplaceorder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewplaceorder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewplaceorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewplaceorder_CellClick);
            this.gridviewplaceorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewplaceorder_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // additemplaceorderbtn
            // 
            this.additemplaceorderbtn.BorderRadius = 20;
            this.additemplaceorderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.additemplaceorderbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.additemplaceorderbtn.CheckedState.Parent = this.additemplaceorderbtn;
            this.additemplaceorderbtn.CustomImages.Parent = this.additemplaceorderbtn;
            this.additemplaceorderbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.additemplaceorderbtn.ForeColor = System.Drawing.Color.White;
            this.additemplaceorderbtn.HoverState.Parent = this.additemplaceorderbtn;
            this.additemplaceorderbtn.Location = new System.Drawing.Point(305, 173);
            this.additemplaceorderbtn.Name = "additemplaceorderbtn";
            this.additemplaceorderbtn.ShadowDecoration.Parent = this.additemplaceorderbtn;
            this.additemplaceorderbtn.Size = new System.Drawing.Size(133, 45);
            this.additemplaceorderbtn.TabIndex = 14;
            this.additemplaceorderbtn.Text = "Add Item";
            this.additemplaceorderbtn.Click += new System.EventHandler(this.additemplaceorderbtn_Click);
            // 
            // removeitemplaceorderbtn
            // 
            this.removeitemplaceorderbtn.BorderRadius = 20;
            this.removeitemplaceorderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.removeitemplaceorderbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.removeitemplaceorderbtn.CheckedState.Parent = this.removeitemplaceorderbtn;
            this.removeitemplaceorderbtn.CustomImages.Parent = this.removeitemplaceorderbtn;
            this.removeitemplaceorderbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeitemplaceorderbtn.ForeColor = System.Drawing.Color.White;
            this.removeitemplaceorderbtn.HoverState.Parent = this.removeitemplaceorderbtn;
            this.removeitemplaceorderbtn.Location = new System.Drawing.Point(206, 344);
            this.removeitemplaceorderbtn.Name = "removeitemplaceorderbtn";
            this.removeitemplaceorderbtn.ShadowDecoration.Parent = this.removeitemplaceorderbtn;
            this.removeitemplaceorderbtn.Size = new System.Drawing.Size(69, 45);
            this.removeitemplaceorderbtn.TabIndex = 15;
            this.removeitemplaceorderbtn.Text = "Remove";
            this.removeitemplaceorderbtn.Click += new System.EventHandler(this.removeitemplaceorderbtn_Click);
            // 
            // printitemplaceorderbtn
            // 
            this.printitemplaceorderbtn.BorderRadius = 20;
            this.printitemplaceorderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.printitemplaceorderbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.printitemplaceorderbtn.CheckedState.Parent = this.printitemplaceorderbtn;
            this.printitemplaceorderbtn.CustomImages.Parent = this.printitemplaceorderbtn;
            this.printitemplaceorderbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printitemplaceorderbtn.ForeColor = System.Drawing.Color.White;
            this.printitemplaceorderbtn.HoverState.Parent = this.printitemplaceorderbtn;
            this.printitemplaceorderbtn.Location = new System.Drawing.Point(469, 344);
            this.printitemplaceorderbtn.Name = "printitemplaceorderbtn";
            this.printitemplaceorderbtn.ShadowDecoration.Parent = this.printitemplaceorderbtn;
            this.printitemplaceorderbtn.Size = new System.Drawing.Size(74, 45);
            this.printitemplaceorderbtn.TabIndex = 16;
            this.printitemplaceorderbtn.Text = "Print";
            this.printitemplaceorderbtn.Click += new System.EventHandler(this.printitemplaceorderbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grand Total";
            // 
            // rupeesplaceorder
            // 
            this.rupeesplaceorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rupeesplaceorder.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeesplaceorder.Location = new System.Drawing.Point(335, 372);
            this.rupeesplaceorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rupeesplaceorder.Name = "rupeesplaceorder";
            this.rupeesplaceorder.Size = new System.Drawing.Size(89, 32);
            this.rupeesplaceorder.TabIndex = 18;
            this.rupeesplaceorder.Text = "Rs. 00";
            this.rupeesplaceorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Uc_placeordercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rupeesplaceorder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printitemplaceorderbtn);
            this.Controls.Add(this.removeitemplaceorderbtn);
            this.Controls.Add(this.additemplaceorderbtn);
            this.Controls.Add(this.gridviewplaceorder);
            this.Controls.Add(this.quantityplaceorder);
            this.Controls.Add(this.totalplaceorder);
            this.Controls.Add(this.itempriceplaceorder);
            this.Controls.Add(this.itemnameplaceorder);
            this.Controls.Add(this.searchplaceorderbox);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.listplaceorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_placeordercontrol";
            this.Size = new System.Drawing.Size(629, 491);
            ((System.ComponentModel.ISupportInitialize)(this.quantityplaceorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewplaceorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listplaceorder;
        private Guna.UI2.WinForms.Guna2ComboBox categorycombobox;
        private Guna.UI2.WinForms.Guna2TextBox searchplaceorderbox;
        private Guna.UI2.WinForms.Guna2TextBox itemnameplaceorder;
        private Guna.UI2.WinForms.Guna2TextBox itempriceplaceorder;
        private Guna.UI2.WinForms.Guna2TextBox totalplaceorder;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantityplaceorder;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewplaceorder;
        private Guna.UI2.WinForms.Guna2Button additemplaceorderbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button removeitemplaceorderbtn;
        private Guna.UI2.WinForms.Guna2Button printitemplaceorderbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rupeesplaceorder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
