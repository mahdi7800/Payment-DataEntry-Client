namespace DataEntry
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
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.PaymentDate = new System.Windows.Forms.Label();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(149, 64);
            this.textBoxCustomerID.MaxLength = 5;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(116, 20);
            this.textBoxCustomerID.TabIndex = 0;
            this.textBoxCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(149, 113);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(116, 20);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(30, 71);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(62, 13);
            this.CustomerID.TabIndex = 4;
            this.CustomerID.Text = "CustomerID";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(30, 120);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "Amount";
            // 
            // PaymentDate
            // 
            this.PaymentDate.AutoSize = true;
            this.PaymentDate.Location = new System.Drawing.Point(30, 179);
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Size = new System.Drawing.Size(71, 13);
            this.PaymentDate.TabIndex = 6;
            this.PaymentDate.Text = "PaymentDate";
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(149, 172);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerPaymentDate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "پرداخت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(298, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerPaymentDate);
            this.Controls.Add(this.PaymentDate);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label PaymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

