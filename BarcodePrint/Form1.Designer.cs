namespace BarcodePrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDefect = new System.Windows.Forms.TextBox();
            this.textBoxInspec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdButton4 = new BarcodePrint.Component.RdButton();
            this.rdButton3 = new BarcodePrint.Component.RdButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdButton2 = new BarcodePrint.Component.RdButton();
            this.rdButton1 = new BarcodePrint.Component.RdButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdButton10 = new BarcodePrint.Component.RdButton();
            this.rdButton5 = new BarcodePrint.Component.RdButton();
            this.rdButton6 = new BarcodePrint.Component.RdButton();
            this.rdButton7 = new BarcodePrint.Component.RdButton();
            this.rdButton8 = new BarcodePrint.Component.RdButton();
            this.rdButton9 = new BarcodePrint.Component.RdButton();
            this.rdButton11 = new BarcodePrint.Component.RdButton();
            this.rdButton12 = new BarcodePrint.Component.RdButton();
            this.rdButton13 = new BarcodePrint.Component.RdButton();
            this.rdButton14 = new BarcodePrint.Component.RdButton();
            this.rdButton15 = new BarcodePrint.Component.RdButton();
            this.rdButton16 = new BarcodePrint.Component.RdButton();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdButton17 = new BarcodePrint.Component.RdButton();
            this.rdButton18 = new BarcodePrint.Component.RdButton();
            this.rdButton19 = new BarcodePrint.Component.RdButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Location = new System.Drawing.Point(173, 12);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(223, 26);
            this.textBoxModel.TabIndex = 4;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDefect
            // 
            this.textBoxDefect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefect.Location = new System.Drawing.Point(175, 94);
            this.textBoxDefect.Name = "textBoxDefect";
            this.textBoxDefect.Size = new System.Drawing.Size(219, 26);
            this.textBoxDefect.TabIndex = 6;
            this.textBoxDefect.TextChanged += new System.EventHandler(this.textBoxDefect_TextChanged);
            // 
            // textBoxInspec
            // 
            this.textBoxInspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInspec.HideSelection = false;
            this.textBoxInspec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxInspec.Location = new System.Drawing.Point(173, 136);
            this.textBoxInspec.Name = "textBoxInspec";
            this.textBoxInspec.ReadOnly = true;
            this.textBoxInspec.Size = new System.Drawing.Size(221, 26);
            this.textBoxInspec.TabIndex = 8;
            this.textBoxInspec.WordWrap = false;
            this.textBoxInspec.TextChanged += new System.EventHandler(this.textBoxInpec_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Inspector";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // preview
            // 
            this.preview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.preview.Location = new System.Drawing.Point(284, 660);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(155, 43);
            this.preview.TabIndex = 9;
            this.preview.Text = "Preview";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.print_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Serial Number";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdButton3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rdButton4);
            this.panel1.Controls.Add(this.rdButton2);
            this.panel1.Controls.Add(this.rdButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSerial);
            this.panel1.Controls.Add(this.textBoxModel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxInspec);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDefect);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 185);
            this.panel1.TabIndex = 15;
            // 
            // rdButton4
            // 
            this.rdButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdButton4.AutoSize = true;
            this.rdButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rdButton4.BorderRadius = 8;
            this.rdButton4.BorderSize = 0;
            this.rdButton4.FlatAppearance.BorderSize = 0;
            this.rdButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton4.ForeColor = System.Drawing.Color.White;
            this.rdButton4.Location = new System.Drawing.Point(420, 54);
            this.rdButton4.Name = "rdButton4";
            this.rdButton4.Size = new System.Drawing.Size(177, 99);
            this.rdButton4.TabIndex = 20;
            this.rdButton4.Text = ".....";
            this.rdButton4.TextColor = System.Drawing.Color.White;
            this.rdButton4.UseVisualStyleBackColor = false;
            // 
            // rdButton3
            // 
            this.rdButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdButton3.AutoSize = true;
            this.rdButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rdButton3.BorderRadius = 8;
            this.rdButton3.BorderSize = 0;
            this.rdButton3.FlatAppearance.BorderSize = 0;
            this.rdButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton3.ForeColor = System.Drawing.Color.White;
            this.rdButton3.Location = new System.Drawing.Point(610, 54);
            this.rdButton3.Name = "rdButton3";
            this.rdButton3.Size = new System.Drawing.Size(177, 99);
            this.rdButton3.TabIndex = 19;
            this.rdButton3.Text = "Clear Data";
            this.rdButton3.TextColor = System.Drawing.Color.White;
            this.rdButton3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 4, 16, 12, 59, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rdButton2
            // 
            this.rdButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdButton2.AutoSize = true;
            this.rdButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton2.BorderRadius = 8;
            this.rdButton2.BorderSize = 0;
            this.rdButton2.FlatAppearance.BorderSize = 0;
            this.rdButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton2.ForeColor = System.Drawing.Color.White;
            this.rdButton2.Location = new System.Drawing.Point(591, 5);
            this.rdButton2.Name = "rdButton2";
            this.rdButton2.Size = new System.Drawing.Size(95, 40);
            this.rdButton2.TabIndex = 17;
            this.rdButton2.Text = "Setting";
            this.rdButton2.TextColor = System.Drawing.Color.White;
            this.rdButton2.UseVisualStyleBackColor = false;
            // 
            // rdButton1
            // 
            this.rdButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdButton1.AutoSize = true;
            this.rdButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton1.BorderRadius = 8;
            this.rdButton1.BorderSize = 0;
            this.rdButton1.FlatAppearance.BorderSize = 0;
            this.rdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton1.ForeColor = System.Drawing.Color.White;
            this.rdButton1.Location = new System.Drawing.Point(692, 5);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(95, 40);
            this.rdButton1.TabIndex = 16;
            this.rdButton1.Text = "Logout";
            this.rdButton1.TextColor = System.Drawing.Color.White;
            this.rdButton1.UseVisualStyleBackColor = false;
            this.rdButton1.Click += new System.EventHandler(this.rdButton1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model Code";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.rdButton11);
            this.panel2.Controls.Add(this.rdButton12);
            this.panel2.Controls.Add(this.rdButton13);
            this.panel2.Controls.Add(this.rdButton14);
            this.panel2.Controls.Add(this.rdButton15);
            this.panel2.Controls.Add(this.rdButton16);
            this.panel2.Controls.Add(this.rdButton9);
            this.panel2.Controls.Add(this.rdButton8);
            this.panel2.Controls.Add(this.rdButton7);
            this.panel2.Controls.Add(this.rdButton6);
            this.panel2.Controls.Add(this.rdButton5);
            this.panel2.Controls.Add(this.rdButton10);
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 144);
            this.panel2.TabIndex = 0;
            // 
            // rdButton10
            // 
            this.rdButton10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton10.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton10.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton10.BorderRadius = 8;
            this.rdButton10.BorderSize = 0;
            this.rdButton10.FlatAppearance.BorderSize = 0;
            this.rdButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton10.ForeColor = System.Drawing.Color.White;
            this.rdButton10.Location = new System.Drawing.Point(668, 7);
            this.rdButton10.Name = "rdButton10";
            this.rdButton10.Size = new System.Drawing.Size(119, 59);
            this.rdButton10.TabIndex = 30;
            this.rdButton10.Text = "Pulsator";
            this.rdButton10.TextColor = System.Drawing.Color.White;
            this.rdButton10.UseVisualStyleBackColor = false;
            // 
            // rdButton5
            // 
            this.rdButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton5.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton5.BorderRadius = 8;
            this.rdButton5.BorderSize = 0;
            this.rdButton5.FlatAppearance.BorderSize = 0;
            this.rdButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton5.ForeColor = System.Drawing.Color.White;
            this.rdButton5.Location = new System.Drawing.Point(533, 7);
            this.rdButton5.Name = "rdButton5";
            this.rdButton5.Size = new System.Drawing.Size(119, 59);
            this.rdButton5.TabIndex = 31;
            this.rdButton5.Text = "Pulsator";
            this.rdButton5.TextColor = System.Drawing.Color.White;
            this.rdButton5.UseVisualStyleBackColor = false;
            // 
            // rdButton6
            // 
            this.rdButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton6.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton6.BorderRadius = 8;
            this.rdButton6.BorderSize = 0;
            this.rdButton6.FlatAppearance.BorderSize = 0;
            this.rdButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton6.ForeColor = System.Drawing.Color.White;
            this.rdButton6.Location = new System.Drawing.Point(400, 7);
            this.rdButton6.Name = "rdButton6";
            this.rdButton6.Size = new System.Drawing.Size(119, 59);
            this.rdButton6.TabIndex = 32;
            this.rdButton6.Text = "SF Switch";
            this.rdButton6.TextColor = System.Drawing.Color.White;
            this.rdButton6.UseVisualStyleBackColor = false;
            // 
            // rdButton7
            // 
            this.rdButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton7.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton7.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton7.BorderRadius = 8;
            this.rdButton7.BorderSize = 0;
            this.rdButton7.FlatAppearance.BorderSize = 0;
            this.rdButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton7.ForeColor = System.Drawing.Color.White;
            this.rdButton7.Location = new System.Drawing.Point(270, 7);
            this.rdButton7.Name = "rdButton7";
            this.rdButton7.Size = new System.Drawing.Size(119, 59);
            this.rdButton7.TabIndex = 33;
            this.rdButton7.Text = "Base A";
            this.rdButton7.TextColor = System.Drawing.Color.White;
            this.rdButton7.UseVisualStyleBackColor = false;
            // 
            // rdButton8
            // 
            this.rdButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton8.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton8.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton8.BorderRadius = 8;
            this.rdButton8.BorderSize = 0;
            this.rdButton8.FlatAppearance.BorderSize = 0;
            this.rdButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton8.ForeColor = System.Drawing.Color.White;
            this.rdButton8.Location = new System.Drawing.Point(137, 7);
            this.rdButton8.Name = "rdButton8";
            this.rdButton8.Size = new System.Drawing.Size(119, 59);
            this.rdButton8.TabIndex = 34;
            this.rdButton8.Text = "Tub A";
            this.rdButton8.TextColor = System.Drawing.Color.White;
            this.rdButton8.UseVisualStyleBackColor = false;
            // 
            // rdButton9
            // 
            this.rdButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton9.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton9.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton9.BorderRadius = 8;
            this.rdButton9.BorderSize = 0;
            this.rdButton9.FlatAppearance.BorderSize = 0;
            this.rdButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton9.ForeColor = System.Drawing.Color.White;
            this.rdButton9.Location = new System.Drawing.Point(4, 4);
            this.rdButton9.Name = "rdButton9";
            this.rdButton9.Size = new System.Drawing.Size(119, 59);
            this.rdButton9.TabIndex = 35;
            this.rdButton9.Text = "Top Defect";
            this.rdButton9.TextColor = System.Drawing.Color.White;
            this.rdButton9.UseVisualStyleBackColor = false;
            // 
            // rdButton11
            // 
            this.rdButton11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton11.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton11.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton11.BorderRadius = 8;
            this.rdButton11.BorderSize = 0;
            this.rdButton11.FlatAppearance.BorderSize = 0;
            this.rdButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton11.ForeColor = System.Drawing.Color.White;
            this.rdButton11.Location = new System.Drawing.Point(4, 69);
            this.rdButton11.Name = "rdButton11";
            this.rdButton11.Size = new System.Drawing.Size(119, 59);
            this.rdButton11.TabIndex = 41;
            this.rdButton11.Text = "Motor Wash";
            this.rdButton11.TextColor = System.Drawing.Color.White;
            this.rdButton11.UseVisualStyleBackColor = false;
            // 
            // rdButton12
            // 
            this.rdButton12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton12.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton12.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton12.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton12.BorderRadius = 8;
            this.rdButton12.BorderSize = 0;
            this.rdButton12.FlatAppearance.BorderSize = 0;
            this.rdButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton12.ForeColor = System.Drawing.Color.White;
            this.rdButton12.Location = new System.Drawing.Point(137, 72);
            this.rdButton12.Name = "rdButton12";
            this.rdButton12.Size = new System.Drawing.Size(119, 59);
            this.rdButton12.TabIndex = 40;
            this.rdButton12.Text = "Motor Spin";
            this.rdButton12.TextColor = System.Drawing.Color.White;
            this.rdButton12.UseVisualStyleBackColor = false;
            this.rdButton12.Click += new System.EventHandler(this.rdButton12_Click);
            // 
            // rdButton13
            // 
            this.rdButton13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton13.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton13.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton13.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton13.BorderRadius = 8;
            this.rdButton13.BorderSize = 0;
            this.rdButton13.FlatAppearance.BorderSize = 0;
            this.rdButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton13.ForeColor = System.Drawing.Color.White;
            this.rdButton13.Location = new System.Drawing.Point(270, 72);
            this.rdButton13.Name = "rdButton13";
            this.rdButton13.Size = new System.Drawing.Size(119, 59);
            this.rdButton13.TabIndex = 39;
            this.rdButton13.Text = "Panel";
            this.rdButton13.TextColor = System.Drawing.Color.White;
            this.rdButton13.UseVisualStyleBackColor = false;
            // 
            // rdButton14
            // 
            this.rdButton14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton14.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton14.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton14.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton14.BorderRadius = 8;
            this.rdButton14.BorderSize = 0;
            this.rdButton14.FlatAppearance.BorderSize = 0;
            this.rdButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton14.ForeColor = System.Drawing.Color.White;
            this.rdButton14.Location = new System.Drawing.Point(400, 72);
            this.rdButton14.Name = "rdButton14";
            this.rdButton14.Size = new System.Drawing.Size(119, 59);
            this.rdButton14.TabIndex = 38;
            this.rdButton14.Text = "Body B";
            this.rdButton14.TextColor = System.Drawing.Color.White;
            this.rdButton14.UseVisualStyleBackColor = false;
            // 
            // rdButton15
            // 
            this.rdButton15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton15.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton15.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton15.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton15.BorderRadius = 8;
            this.rdButton15.BorderSize = 0;
            this.rdButton15.FlatAppearance.BorderSize = 0;
            this.rdButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton15.ForeColor = System.Drawing.Color.White;
            this.rdButton15.Location = new System.Drawing.Point(533, 72);
            this.rdButton15.Name = "rdButton15";
            this.rdButton15.Size = new System.Drawing.Size(119, 59);
            this.rdButton15.TabIndex = 37;
            this.rdButton15.Text = "Lid";
            this.rdButton15.TextColor = System.Drawing.Color.White;
            this.rdButton15.UseVisualStyleBackColor = false;
            // 
            // rdButton16
            // 
            this.rdButton16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton16.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton16.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton16.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton16.BorderRadius = 8;
            this.rdButton16.BorderSize = 0;
            this.rdButton16.FlatAppearance.BorderSize = 0;
            this.rdButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton16.ForeColor = System.Drawing.Color.White;
            this.rdButton16.Location = new System.Drawing.Point(668, 72);
            this.rdButton16.Name = "rdButton16";
            this.rdButton16.Size = new System.Drawing.Size(119, 59);
            this.rdButton16.TabIndex = 36;
            this.rdButton16.Text = "DLL";
            this.rdButton16.TextColor = System.Drawing.Color.White;
            this.rdButton16.UseVisualStyleBackColor = false;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerial.Location = new System.Drawing.Point(173, 50);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(223, 26);
            this.textBoxSerial.TabIndex = 4;
            this.textBoxSerial.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.rdButton19);
            this.flowLayoutPanel1.Controls.Add(this.rdButton18);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 205);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // rdButton17
            // 
            this.rdButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton17.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton17.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton17.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton17.BorderRadius = 8;
            this.rdButton17.BorderSize = 0;
            this.rdButton17.FlatAppearance.BorderSize = 0;
            this.rdButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton17.ForeColor = System.Drawing.Color.White;
            this.rdButton17.Location = new System.Drawing.Point(3, 3);
            this.rdButton17.Name = "rdButton17";
            this.rdButton17.Size = new System.Drawing.Size(94, 44);
            this.rdButton17.TabIndex = 42;
            this.rdButton17.Text = "Motor Spin";
            this.rdButton17.TextColor = System.Drawing.Color.White;
            this.rdButton17.UseVisualStyleBackColor = false;
            this.rdButton17.Click += new System.EventHandler(this.rdButton17_Click);
            // 
            // rdButton18
            // 
            this.rdButton18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton18.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton18.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton18.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton18.BorderRadius = 8;
            this.rdButton18.BorderSize = 0;
            this.rdButton18.FlatAppearance.BorderSize = 0;
            this.rdButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton18.ForeColor = System.Drawing.Color.White;
            this.rdButton18.Location = new System.Drawing.Point(128, 3);
            this.rdButton18.Name = "rdButton18";
            this.rdButton18.Size = new System.Drawing.Size(119, 59);
            this.rdButton18.TabIndex = 43;
            this.rdButton18.Text = "Motor Spin";
            this.rdButton18.TextColor = System.Drawing.Color.White;
            this.rdButton18.UseVisualStyleBackColor = false;
            // 
            // rdButton19
            // 
            this.rdButton19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdButton19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rdButton19.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton19.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton19.BorderColor = System.Drawing.Color.Transparent;
            this.rdButton19.BorderRadius = 8;
            this.rdButton19.BorderSize = 0;
            this.rdButton19.FlatAppearance.BorderSize = 0;
            this.rdButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButton19.ForeColor = System.Drawing.Color.White;
            this.rdButton19.Location = new System.Drawing.Point(3, 3);
            this.rdButton19.Name = "rdButton19";
            this.rdButton19.Size = new System.Drawing.Size(119, 59);
            this.rdButton19.TabIndex = 44;
            this.rdButton19.Text = "Motor Spin";
            this.rdButton19.TextColor = System.Drawing.Color.White;
            this.rdButton19.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdButton17, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Defect Record";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDefect;
        private System.Windows.Forms.TextBox textBoxInspec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Component.RdButton rdButton2;
        private Component.RdButton rdButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Component.RdButton rdButton3;
        private Component.RdButton rdButton4;
        private System.Windows.Forms.Panel panel2;
        private Component.RdButton rdButton10;
        private Component.RdButton rdButton11;
        private Component.RdButton rdButton12;
        private Component.RdButton rdButton13;
        private Component.RdButton rdButton14;
        private Component.RdButton rdButton15;
        private Component.RdButton rdButton16;
        private Component.RdButton rdButton9;
        private Component.RdButton rdButton8;
        private Component.RdButton rdButton7;
        private Component.RdButton rdButton6;
        private Component.RdButton rdButton5;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Component.RdButton rdButton19;
        private Component.RdButton rdButton18;
        private Component.RdButton rdButton17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

