namespace SportsComplex.DesktopUI
{
    partial class AddRenterForm
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
            this.btnAddRenter = new System.Windows.Forms.Button();
            this.grbRenter = new System.Windows.Forms.GroupBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbRenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddRenter
            // 
            this.btnAddRenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRenter.Location = new System.Drawing.Point(36, 176);
            this.btnAddRenter.Name = "btnAddRenter";
            this.btnAddRenter.Size = new System.Drawing.Size(77, 23);
            this.btnAddRenter.TabIndex = 1;
            this.btnAddRenter.Text = "Add";
            this.btnAddRenter.UseVisualStyleBackColor = true;
            this.btnAddRenter.Click += new System.EventHandler(this.btnAddRenter_Click);
            // 
            // grbRenter
            // 
            this.grbRenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRenter.Controls.Add(this.mtbPhone);
            this.grbRenter.Controls.Add(this.tbFirstName);
            this.grbRenter.Controls.Add(this.tbLastName);
            this.grbRenter.Controls.Add(this.lblPhone);
            this.grbRenter.Controls.Add(this.lblLastName);
            this.grbRenter.Controls.Add(this.lblFirstName);
            this.grbRenter.Location = new System.Drawing.Point(13, 13);
            this.grbRenter.Name = "grbRenter";
            this.grbRenter.Size = new System.Drawing.Size(184, 157);
            this.grbRenter.TabIndex = 0;
            this.grbRenter.TabStop = false;
            this.grbRenter.Text = "Renter";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(10, 127);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(90, 20);
            this.mtbPhone.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(6, 32);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(168, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(6, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(168, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 111);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name:";
            // 
            // AddRenterForm
            // 
            this.AcceptButton = this.btnAddRenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(209, 211);
            this.Controls.Add(this.grbRenter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Renter";
            this.grbRenter.ResumeLayout(false);
            this.grbRenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRenter;
        private System.Windows.Forms.GroupBox grbRenter;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}