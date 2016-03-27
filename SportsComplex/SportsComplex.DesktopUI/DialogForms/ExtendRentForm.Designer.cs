namespace SportsComplex.DesktopUI
{
    partial class ExtendRentForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExtendRent = new System.Windows.Forms.Button();
            this.grbExtendRent = new System.Windows.Forms.GroupBox();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.lblOverpay = new System.Windows.Forms.Label();
            this.lblOverpayLabel = new System.Windows.Forms.Label();
            this.grbExtendRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExtendRent
            // 
            this.btnExtendRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtendRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtendRent.Location = new System.Drawing.Point(21, 146);
            this.btnExtendRent.Name = "btnExtendRent";
            this.btnExtendRent.Size = new System.Drawing.Size(77, 23);
            this.btnExtendRent.TabIndex = 3;
            this.btnExtendRent.Text = "Extend";
            this.btnExtendRent.UseVisualStyleBackColor = true;
            this.btnExtendRent.Click += new System.EventHandler(this.btnExtendRent_Click);
            // 
            // grbExtendRent
            // 
            this.grbExtendRent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbExtendRent.Controls.Add(this.dtpTimeTo);
            this.grbExtendRent.Controls.Add(this.lblTimeTo);
            this.grbExtendRent.Controls.Add(this.dtpTimeFrom);
            this.grbExtendRent.Controls.Add(this.lblTimeFrom);
            this.grbExtendRent.Controls.Add(this.lblOverpay);
            this.grbExtendRent.Controls.Add(this.lblOverpayLabel);
            this.grbExtendRent.Location = new System.Drawing.Point(13, 13);
            this.grbExtendRent.Name = "grbExtendRent";
            this.grbExtendRent.Size = new System.Drawing.Size(169, 127);
            this.grbExtendRent.TabIndex = 5;
            this.grbExtendRent.TabStop = false;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(22, 68);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(131, 20);
            this.dtpTimeTo.TabIndex = 45;
            this.dtpTimeTo.ValueChanged += new System.EventHandler(this.dtpTimeTo_ValueChanged);
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Location = new System.Drawing.Point(6, 52);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(45, 13);
            this.lblTimeTo.TabIndex = 44;
            this.lblTimeTo.Text = "Time to:";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeFrom.Enabled = false;
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(22, 29);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(129, 20);
            this.dtpTimeFrom.TabIndex = 43;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Location = new System.Drawing.Point(6, 11);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(56, 13);
            this.lblTimeFrom.TabIndex = 42;
            this.lblTimeFrom.Text = "Time from:";
            // 
            // lblOverpay
            // 
            this.lblOverpay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverpay.BackColor = System.Drawing.SystemColors.Control;
            this.lblOverpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverpay.Location = new System.Drawing.Point(106, 108);
            this.lblOverpay.Name = "lblOverpay";
            this.lblOverpay.Size = new System.Drawing.Size(57, 16);
            this.lblOverpay.TabIndex = 41;
            this.lblOverpay.Text = "0";
            this.lblOverpay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverpayLabel
            // 
            this.lblOverpayLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOverpayLabel.AutoSize = true;
            this.lblOverpayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOverpayLabel.Location = new System.Drawing.Point(6, 108);
            this.lblOverpayLabel.Name = "lblOverpayLabel";
            this.lblOverpayLabel.Size = new System.Drawing.Size(71, 16);
            this.lblOverpayLabel.TabIndex = 39;
            this.lblOverpayLabel.Text = "Overpay:";
            // 
            // ExtendRentForm
            // 
            this.AcceptButton = this.btnExtendRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(194, 181);
            this.Controls.Add(this.grbExtendRent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExtendRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extend Rent";
            this.Load += new System.EventHandler(this.ExtendRentForm_Load);
            this.grbExtendRent.ResumeLayout(false);
            this.grbExtendRent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExtendRent;
        private System.Windows.Forms.GroupBox grbExtendRent;
        private System.Windows.Forms.Label lblOverpay;
        private System.Windows.Forms.Label lblOverpayLabel;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
    }
}