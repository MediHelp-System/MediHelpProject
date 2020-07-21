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
            this.SuspendLayout();
            // 
            // btnCustomerReg
            // 
            this.btnCustomerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.btnCustomerReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerReg.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReg.Location = new System.Drawing.Point(165, 141);
            this.btnCustomerReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerReg.Name = "btnCustomerReg";
            this.btnCustomerReg.Size = new System.Drawing.Size(99, 45);
            this.btnCustomerReg.TabIndex = 0;
            this.btnCustomerReg.Text = "Customer Registration";
            this.btnCustomerReg.UseVisualStyleBackColor = false;
            this.btnCustomerReg.Click += new System.EventHandler(this.btnCustomerReg_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(166)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(485, 141);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(99, 45);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input Order Details";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(604, 363);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // COM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCustomerReg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "COM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediHelp - Customer Order Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerReg;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnBack;
    }
}