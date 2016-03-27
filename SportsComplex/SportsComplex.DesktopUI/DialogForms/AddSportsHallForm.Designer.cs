namespace SportsComplex.DesktopUI
{
    partial class AddSportsHallForm
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
            this.btnSportsHall = new System.Windows.Forms.Button();
            this.grbSportsHall = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.grbSportsHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(122, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSportsHall
            // 
            this.btnSportsHall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSportsHall.Location = new System.Drawing.Point(13, 135);
            this.btnSportsHall.Name = "btnSportsHall";
            this.btnSportsHall.Size = new System.Drawing.Size(95, 23);
            this.btnSportsHall.TabIndex = 3;
            this.btnSportsHall.Text = "Add";
            this.btnSportsHall.UseVisualStyleBackColor = true;
            this.btnSportsHall.Click += new System.EventHandler(this.btnSportsHall_Click);
            // 
            // grbSportsHall
            // 
            this.grbSportsHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSportsHall.Controls.Add(this.nudRate);
            this.grbSportsHall.Controls.Add(this.nudArea);
            this.grbSportsHall.Controls.Add(this.cbType);
            this.grbSportsHall.Controls.Add(this.lblRate);
            this.grbSportsHall.Controls.Add(this.lblArea);
            this.grbSportsHall.Controls.Add(this.lblType);
            this.grbSportsHall.Location = new System.Drawing.Point(13, 13);
            this.grbSportsHall.Name = "grbSportsHall";
            this.grbSportsHall.Size = new System.Drawing.Size(204, 116);
            this.grbSportsHall.TabIndex = 5;
            this.grbSportsHall.TabStop = false;
            this.grbSportsHall.Text = "Sports hall";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 16);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(8, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(106, 66);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 13);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Rate:";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(9, 32);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(189, 21);
            this.cbType.TabIndex = 4;
            // 
            // nudArea
            // 
            this.nudArea.Location = new System.Drawing.Point(9, 82);
            this.nudArea.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(86, 20);
            this.nudArea.TabIndex = 5;
            this.nudArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(109, 82);
            this.nudRate.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(89, 20);
            this.nudRate.TabIndex = 6;
            this.nudRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddSportsHallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(229, 170);
            this.Controls.Add(this.grbSportsHall);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSportsHall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSportsHallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Sports Hall";
            this.Load += new System.EventHandler(this.AddSportsHallForm_Load);
            this.grbSportsHall.ResumeLayout(false);
            this.grbSportsHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSportsHall;
        private System.Windows.Forms.GroupBox grbSportsHall;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.NumericUpDown nudArea;
    }
}