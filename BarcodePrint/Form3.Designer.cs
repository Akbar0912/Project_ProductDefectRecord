namespace BarcodePrint
{
    partial class Form3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdButton1 = new BarcodePrint.Component.RdButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 350);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rdButton1
            // 
            this.rdButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rdButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rdButton1.BorderRadius = 20;
            this.rdButton1.BorderSize = 0;
            this.rdButton1.FlatAppearance.BorderSize = 0;
            this.rdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdButton1.ForeColor = System.Drawing.Color.White;
            this.rdButton1.Location = new System.Drawing.Point(365, 111);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(150, 40);
            this.rdButton1.TabIndex = 1;
            this.rdButton1.Text = "rdButton1";
            this.rdButton1.TextColor = System.Drawing.Color.White;
            this.rdButton1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Component.RdButton rdButton1;
    }
}