namespace MediHelp_System
{
    partial class COM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COM));
            this.btnCustomerReg = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerReg
            // 
            this.btnCustomerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.btnCustomerReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerReg.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReg.Location = new System.Drawing.Point(368, 212);
            this.btnCustomerReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerReg.Name = "btnCustomerReg";
            this.btnCustomerReg.Size = new System.Drawing.Size(267, 227);
            this.btnCustomerReg.TabIndex = 0;
            this.btnCustomerReg.Text = "Customer Registration";
            this.btnCustomerReg.UseVisualStyleBackColor = false;
            this.btnCustomerReg.Click += new System.EventHandler(this.btnCustomerReg_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(1016, 212);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(267, 227);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input Order Details";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1396, 677);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 93);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 227);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customers Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 229);
            this.button2.TabIndex = 3;
            this.button2.Text = "Order Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // COM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCustomerReg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "COM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediHelp - Customer Order Manager";
            this.Load += new System.EventHandler(this.COM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerReg;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}