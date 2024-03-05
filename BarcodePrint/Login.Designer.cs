namespace BarcodePrint
{
    partial class Login
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
            this.gradient1 = new BarcodePrint.Component.Gradient();
            this.Number_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.White;
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradient1.Controls.Add(this.Number_Id);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.password);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(800, 450);
            this.gradient1.TabIndex = 0;
            // 
            // Number_Id
            // 
            this.Number_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Number_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Id.Location = new System.Drawing.Point(234, 251);
            this.Number_Id.Name = "Number_Id";
            this.Number_Id.Size = new System.Drawing.Size(338, 39);
            this.Number_Id.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(142, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(142, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Id";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(234, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Inspector ID";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(234, 308);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(338, 39);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Defect Record\r\nLaundry System Bussines Unit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradient1);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.Gradient gradient1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Number_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}