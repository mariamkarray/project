
namespace Project_Cashier
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SellerPwTab = new Guna.UI2.WinForms.Guna2TextBox();
            this.Spw = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SellerIDTab = new Guna.UI2.WinForms.Guna2TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SellerNameTab = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerPhoneTab = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sname = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.Label();
            this.Sphone = new System.Windows.Forms.Label();
            this.SellerAgeTab = new Guna.UI2.WinForms.Guna2TextBox();
            this.SID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.SellerPwTab);
            this.panel1.Controls.Add(this.Spw);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.SellerIDTab);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.SellerNameTab);
            this.panel1.Controls.Add(this.SellerPhoneTab);
            this.panel1.Controls.Add(this.Sname);
            this.panel1.Controls.Add(this.Sage);
            this.panel1.Controls.Add(this.Sphone);
            this.panel1.Controls.Add(this.SellerAgeTab);
            this.panel1.Controls.Add(this.SID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(122, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 520);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellerDGV.EnableHeadersVisualStyles = false;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.Location = new System.Drawing.Point(245, 84);
            this.SellerDGV.Margin = new System.Windows.Forms.Padding(2);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.RowHeadersWidth = 51;
            this.SellerDGV.RowTemplate.Height = 24;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(586, 418);
            this.SellerDGV.TabIndex = 21;
            this.SellerDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // SellerPwTab
            // 
            this.SellerPwTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPwTab.DefaultText = "";
            this.SellerPwTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerPwTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerPwTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPwTab.DisabledState.Parent = this.SellerPwTab;
            this.SellerPwTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPwTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerPwTab.FocusedState.Parent = this.SellerPwTab;
            this.SellerPwTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerPwTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerPwTab.HoverState.Parent = this.SellerPwTab;
            this.SellerPwTab.Location = new System.Drawing.Point(97, 250);
            this.SellerPwTab.Margin = new System.Windows.Forms.Padding(2);
            this.SellerPwTab.Name = "SellerPwTab";
            this.SellerPwTab.PasswordChar = '\0';
            this.SellerPwTab.PlaceholderText = "";
            this.SellerPwTab.SelectedText = "";
            this.SellerPwTab.ShadowDecoration.Parent = this.SellerPwTab;
            this.SellerPwTab.Size = new System.Drawing.Size(108, 19);
            this.SellerPwTab.TabIndex = 20;
            // 
            // Spw
            // 
            this.Spw.AutoSize = true;
            this.Spw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Spw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Spw.Location = new System.Drawing.Point(9, 250);
            this.Spw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Spw.Name = "Spw";
            this.Spw.Size = new System.Drawing.Size(80, 19);
            this.Spw.TabIndex = 19;
            this.Spw.Text = "Password";
            this.Spw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(89, 315);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "EDIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(159, 315);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SellerIDTab
            // 
            this.SellerIDTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerIDTab.DefaultText = "";
            this.SellerIDTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerIDTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerIDTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerIDTab.DisabledState.Parent = this.SellerIDTab;
            this.SellerIDTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerIDTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerIDTab.FocusedState.Parent = this.SellerIDTab;
            this.SellerIDTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerIDTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerIDTab.HoverState.Parent = this.SellerIDTab;
            this.SellerIDTab.Location = new System.Drawing.Point(97, 84);
            this.SellerIDTab.Margin = new System.Windows.Forms.Padding(2);
            this.SellerIDTab.Name = "SellerIDTab";
            this.SellerIDTab.PasswordChar = '\0';
            this.SellerIDTab.PlaceholderText = "";
            this.SellerIDTab.SelectedText = "";
            this.SellerIDTab.ShadowDecoration.Parent = this.SellerIDTab;
            this.SellerIDTab.Size = new System.Drawing.Size(108, 19);
            this.SellerIDTab.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(12, 315);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 32);
            this.button5.TabIndex = 12;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SellerNameTab
            // 
            this.SellerNameTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerNameTab.DefaultText = "";
            this.SellerNameTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerNameTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerNameTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerNameTab.DisabledState.Parent = this.SellerNameTab;
            this.SellerNameTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerNameTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerNameTab.FocusedState.Parent = this.SellerNameTab;
            this.SellerNameTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerNameTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerNameTab.HoverState.Parent = this.SellerNameTab;
            this.SellerNameTab.Location = new System.Drawing.Point(97, 125);
            this.SellerNameTab.Margin = new System.Windows.Forms.Padding(2);
            this.SellerNameTab.Name = "SellerNameTab";
            this.SellerNameTab.PasswordChar = '\0';
            this.SellerNameTab.PlaceholderText = "";
            this.SellerNameTab.SelectedText = "";
            this.SellerNameTab.ShadowDecoration.Parent = this.SellerNameTab;
            this.SellerNameTab.Size = new System.Drawing.Size(108, 19);
            this.SellerNameTab.TabIndex = 9;
            // 
            // SellerPhoneTab
            // 
            this.SellerPhoneTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPhoneTab.DefaultText = "";
            this.SellerPhoneTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerPhoneTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerPhoneTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPhoneTab.DisabledState.Parent = this.SellerPhoneTab;
            this.SellerPhoneTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPhoneTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerPhoneTab.FocusedState.Parent = this.SellerPhoneTab;
            this.SellerPhoneTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerPhoneTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerPhoneTab.HoverState.Parent = this.SellerPhoneTab;
            this.SellerPhoneTab.Location = new System.Drawing.Point(97, 213);
            this.SellerPhoneTab.Margin = new System.Windows.Forms.Padding(2);
            this.SellerPhoneTab.Name = "SellerPhoneTab";
            this.SellerPhoneTab.PasswordChar = '\0';
            this.SellerPhoneTab.PlaceholderText = "";
            this.SellerPhoneTab.SelectedText = "";
            this.SellerPhoneTab.ShadowDecoration.Parent = this.SellerPhoneTab;
            this.SellerPhoneTab.Size = new System.Drawing.Size(108, 19);
            this.SellerPhoneTab.TabIndex = 8;
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sname.Location = new System.Drawing.Point(9, 125);
            this.Sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(58, 19);
            this.Sname.TabIndex = 5;
            this.Sname.Text = "Name";
            this.Sname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sage
            // 
            this.Sage.AutoSize = true;
            this.Sage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sage.Location = new System.Drawing.Point(9, 171);
            this.Sage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(42, 19);
            this.Sage.TabIndex = 4;
            this.Sage.Text = "Age";
            this.Sage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sphone
            // 
            this.Sphone.AutoSize = true;
            this.Sphone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sphone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sphone.Location = new System.Drawing.Point(9, 213);
            this.Sphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sphone.Name = "Sphone";
            this.Sphone.Size = new System.Drawing.Size(58, 19);
            this.Sphone.TabIndex = 3;
            this.Sphone.Text = "Phone";
            this.Sphone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SellerAgeTab
            // 
            this.SellerAgeTab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAgeTab.DefaultText = "";
            this.SellerAgeTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerAgeTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerAgeTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAgeTab.DisabledState.Parent = this.SellerAgeTab;
            this.SellerAgeTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAgeTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerAgeTab.FocusedState.Parent = this.SellerAgeTab;
            this.SellerAgeTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerAgeTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SellerAgeTab.HoverState.Parent = this.SellerAgeTab;
            this.SellerAgeTab.Location = new System.Drawing.Point(97, 171);
            this.SellerAgeTab.Margin = new System.Windows.Forms.Padding(2);
            this.SellerAgeTab.Name = "SellerAgeTab";
            this.SellerAgeTab.PasswordChar = '\0';
            this.SellerAgeTab.PlaceholderText = "";
            this.SellerAgeTab.SelectedText = "";
            this.SellerAgeTab.ShadowDecoration.Parent = this.SellerAgeTab;
            this.SellerAgeTab.Size = new System.Drawing.Size(108, 19);
            this.SellerAgeTab.TabIndex = 2;
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SID.Location = new System.Drawing.Point(9, 84);
            this.SID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(24, 19);
            this.SID.TabIndex = 1;
            this.SID.Text = "ID";
            this.SID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(371, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Sellers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(0, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Categories";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(0, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(921, 3);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(12, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox SellerPwTab;
        private System.Windows.Forms.Label Spw;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2TextBox SellerIDTab;
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2TextBox SellerNameTab;
        private Guna.UI2.WinForms.Guna2TextBox SellerPhoneTab;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label Sage;
        private System.Windows.Forms.Label Sphone;
        private Guna.UI2.WinForms.Guna2TextBox SellerAgeTab;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private Guna.UI2.WinForms.Guna2DataGridView SellerDGV;
        private System.Windows.Forms.Label label7;
    }
}