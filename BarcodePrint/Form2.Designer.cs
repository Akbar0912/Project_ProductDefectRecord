namespace BarcodePrint
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.textBoxInspec = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDefect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPrint.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPrint.Controls.Add(this.textBoxInspec);
            this.panelPrint.Controls.Add(this.textBoxModel);
            this.panelPrint.Controls.Add(this.textBoxSerial);
            this.panelPrint.Controls.Add(this.panel1);
            this.panelPrint.Controls.Add(this.tableLayoutPanel2);
            this.panelPrint.Controls.Add(this.date);
            this.panelPrint.Controls.Add(this.pictureBox1);
            this.panelPrint.Controls.Add(this.tableLayoutPanel1);
            this.panelPrint.Controls.Add(this.button1);
            this.panelPrint.Controls.Add(this.label5);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Controls.Add(this.label2);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Location = new System.Drawing.Point(0, 65);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(1033, 767);
            this.panelPrint.TabIndex = 13;
            // 
            // textBoxInspec
            // 
            this.textBoxInspec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInspec.Enabled = false;
            this.textBoxInspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInspec.Location = new System.Drawing.Point(305, 271);
            this.textBoxInspec.Name = "textBoxInspec";
            this.textBoxInspec.ReadOnly = true;
            this.textBoxInspec.Size = new System.Drawing.Size(319, 19);
            this.textBoxInspec.TabIndex = 39;
            // 
            // textBoxModel
            // 
            this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModel.Enabled = false;
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(305, 225);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(319, 19);
            this.textBoxModel.TabIndex = 38;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerial.HideSelection = false;
            this.textBoxSerial.Location = new System.Drawing.Point(305, 179);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.ReadOnly = true;
            this.textBoxSerial.Size = new System.Drawing.Size(319, 19);
            this.textBoxSerial.TabIndex = 37;
            this.textBoxSerial.TextChanged += new System.EventHandler(this.textBoxSerial_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(113, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 5);
            this.panel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15701F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.84299F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxDefect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(130, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.77387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.22613F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 306);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // textBoxDefect
            // 
            this.textBoxDefect.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDefect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefect.Enabled = false;
            this.textBoxDefect.HideSelection = false;
            this.textBoxDefect.Location = new System.Drawing.Point(118, 6);
            this.textBoxDefect.Name = "textBoxDefect";
            this.textBoxDefect.ReadOnly = true;
            this.textBoxDefect.Size = new System.Drawing.Size(656, 23);
            this.textBoxDefect.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 106);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item\r\nMasalah\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 87);
            this.label9.TabIndex = 1;
            this.label9.Text = "Analisa";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 101);
            this.label10.TabIndex = 2;
            this.label10.Text = "Action";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Repaired By :";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(106, 15);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 20);
            this.date.TabIndex = 15;
            this.date.Text = "date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::BarcodePrint.Properties.Resources.panasonic;
            this.pictureBox1.Location = new System.Drawing.Point(765, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 39);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(663, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 128);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Reconfirm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Checked";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(808, 710);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inspector          :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Model Number :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Serial Number :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "PRODUK TIDAK LULUS INSPEKSI";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 829);
            this.Controls.Add(this.panelPrint);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Defect Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label date;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxInspec;
        private System.Windows.Forms.TextBox textBoxDefect;
    }
}