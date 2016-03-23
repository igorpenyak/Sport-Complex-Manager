namespace SportsComplex.DesktopUI
{
    partial class NewRentForm
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
            this.grbNewRent = new System.Windows.Forms.GroupBox();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.nudAreaMax = new System.Windows.Forms.NumericUpDown();
            this.nudRateMax = new System.Windows.Forms.NumericUpDown();
            this.nudRateMin = new System.Windows.Forms.NumericUpDown();
            this.lblRateDivider = new System.Windows.Forms.Label();
            this.nudAreaMin = new System.Windows.Forms.NumericUpDown();
            this.lblAreaDivider = new System.Windows.Forms.Label();
            this.lblClassRate = new System.Windows.Forms.Label();
            this.lblClassArea = new System.Windows.Forms.Label();
            this.cbClassType = new System.Windows.Forms.ComboBox();
            this.lblClassType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudCash = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.cbRenter = new System.Windows.Forms.ComboBox();
            this.lblRenter = new System.Windows.Forms.Label();
            this.dgvSportsHalls = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbNewRent.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRateMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRateMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNewRent
            // 
            this.grbNewRent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNewRent.Controls.Add(this.dtpTimeTo);
            this.grbNewRent.Controls.Add(this.lblTimeTo);
            this.grbNewRent.Controls.Add(this.dtpTimeFrom);
            this.grbNewRent.Controls.Add(this.lblTimeFrom);
            this.grbNewRent.Controls.Add(this.grbSearch);
            this.grbNewRent.Controls.Add(this.nudCash);
            this.grbNewRent.Controls.Add(this.dtpDate);
            this.grbNewRent.Controls.Add(this.lblDate);
            this.grbNewRent.Controls.Add(this.lblCash);
            this.grbNewRent.Controls.Add(this.cbRenter);
            this.grbNewRent.Controls.Add(this.lblRenter);
            this.grbNewRent.Controls.Add(this.dgvSportsHalls);
            this.grbNewRent.Location = new System.Drawing.Point(13, 13);
            this.grbNewRent.Name = "grbNewRent";
            this.grbNewRent.Size = new System.Drawing.Size(327, 446);
            this.grbNewRent.TabIndex = 0;
            this.grbNewRent.TabStop = false;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(171, 371);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(146, 20);
            this.dtpTimeTo.TabIndex = 36;
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Location = new System.Drawing.Point(170, 353);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(45, 13);
            this.lblTimeTo.TabIndex = 35;
            this.lblTimeTo.Text = "Time to:";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(16, 371);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(146, 20);
            this.dtpTimeFrom.TabIndex = 34;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Location = new System.Drawing.Point(13, 353);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(56, 13);
            this.lblTimeFrom.TabIndex = 33;
            this.lblTimeFrom.Text = "Time from:";
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.nudAreaMax);
            this.grbSearch.Controls.Add(this.nudRateMax);
            this.grbSearch.Controls.Add(this.nudRateMin);
            this.grbSearch.Controls.Add(this.lblRateDivider);
            this.grbSearch.Controls.Add(this.nudAreaMin);
            this.grbSearch.Controls.Add(this.lblAreaDivider);
            this.grbSearch.Controls.Add(this.lblClassRate);
            this.grbSearch.Controls.Add(this.lblClassArea);
            this.grbSearch.Controls.Add(this.cbClassType);
            this.grbSearch.Controls.Add(this.lblClassType);
            this.grbSearch.Controls.Add(this.btnReset);
            this.grbSearch.Location = new System.Drawing.Point(7, 173);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(311, 116);
            this.grbSearch.TabIndex = 32;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // nudAreaMax
            // 
            this.nudAreaMax.Location = new System.Drawing.Point(249, 35);
            this.nudAreaMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAreaMax.Name = "nudAreaMax";
            this.nudAreaMax.Size = new System.Drawing.Size(55, 20);
            this.nudAreaMax.TabIndex = 17;
            this.nudAreaMax.ValueChanged += new System.EventHandler(this.nudAreaMin_ValueChanged);
            // 
            // nudRateMax
            // 
            this.nudRateMax.Location = new System.Drawing.Point(99, 86);
            this.nudRateMax.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudRateMax.Name = "nudRateMax";
            this.nudRateMax.Size = new System.Drawing.Size(55, 20);
            this.nudRateMax.TabIndex = 16;
            this.nudRateMax.ValueChanged += new System.EventHandler(this.nudAreaMin_ValueChanged);
            // 
            // nudRateMin
            // 
            this.nudRateMin.Location = new System.Drawing.Point(12, 86);
            this.nudRateMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudRateMin.Name = "nudRateMin";
            this.nudRateMin.Size = new System.Drawing.Size(55, 20);
            this.nudRateMin.TabIndex = 15;
            this.nudRateMin.ValueChanged += new System.EventHandler(this.nudAreaMin_ValueChanged);
            // 
            // lblRateDivider
            // 
            this.lblRateDivider.AutoSize = true;
            this.lblRateDivider.Location = new System.Drawing.Point(77, 88);
            this.lblRateDivider.Name = "lblRateDivider";
            this.lblRateDivider.Size = new System.Drawing.Size(10, 13);
            this.lblRateDivider.TabIndex = 14;
            this.lblRateDivider.Text = "-";
            // 
            // nudAreaMin
            // 
            this.nudAreaMin.Location = new System.Drawing.Point(172, 36);
            this.nudAreaMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAreaMin.Name = "nudAreaMin";
            this.nudAreaMin.Size = new System.Drawing.Size(55, 20);
            this.nudAreaMin.TabIndex = 12;
            this.nudAreaMin.ValueChanged += new System.EventHandler(this.nudAreaMin_ValueChanged);
            // 
            // lblAreaDivider
            // 
            this.lblAreaDivider.AutoSize = true;
            this.lblAreaDivider.Location = new System.Drawing.Point(233, 38);
            this.lblAreaDivider.Name = "lblAreaDivider";
            this.lblAreaDivider.Size = new System.Drawing.Size(10, 13);
            this.lblAreaDivider.TabIndex = 11;
            this.lblAreaDivider.Text = "-";
            // 
            // lblClassRate
            // 
            this.lblClassRate.AutoSize = true;
            this.lblClassRate.Location = new System.Drawing.Point(9, 68);
            this.lblClassRate.Name = "lblClassRate";
            this.lblClassRate.Size = new System.Drawing.Size(61, 13);
            this.lblClassRate.TabIndex = 9;
            this.lblClassRate.Text = "Class Rate:";
            // 
            // lblClassArea
            // 
            this.lblClassArea.AutoSize = true;
            this.lblClassArea.Location = new System.Drawing.Point(172, 16);
            this.lblClassArea.Name = "lblClassArea";
            this.lblClassArea.Size = new System.Drawing.Size(60, 13);
            this.lblClassArea.TabIndex = 8;
            this.lblClassArea.Text = "Class Area:";
            // 
            // cbClassType
            // 
            this.cbClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassType.FormattingEnabled = true;
            this.cbClassType.Location = new System.Drawing.Point(10, 35);
            this.cbClassType.Name = "cbClassType";
            this.cbClassType.Size = new System.Drawing.Size(144, 21);
            this.cbClassType.TabIndex = 7;
            this.cbClassType.DropDown += new System.EventHandler(this.cbClassType_DropDown);
            this.cbClassType.SelectedIndexChanged += new System.EventHandler(this.nudAreaMin_ValueChanged);
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Location = new System.Drawing.Point(7, 16);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(62, 13);
            this.lblClassType.TabIndex = 6;
            this.lblClassType.Text = "Class Type:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(172, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 26);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudCash
            // 
            this.nudCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudCash.Location = new System.Drawing.Point(252, 415);
            this.nudCash.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudCash.Name = "nudCash";
            this.nudCash.Size = new System.Drawing.Size(66, 20);
            this.nudCash.TabIndex = 31;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpDate.Location = new System.Drawing.Point(170, 319);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(146, 20);
            this.dtpDate.TabIndex = 29;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(170, 303);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date:";
            // 
            // lblCash
            // 
            this.lblCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCash.Location = new System.Drawing.Point(206, 417);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(39, 13);
            this.lblCash.TabIndex = 26;
            this.lblCash.Text = "Cash:";
            // 
            // cbRenter
            // 
            this.cbRenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenter.FormattingEnabled = true;
            this.cbRenter.Location = new System.Drawing.Point(16, 320);
            this.cbRenter.Name = "cbRenter";
            this.cbRenter.Size = new System.Drawing.Size(144, 21);
            this.cbRenter.TabIndex = 25;
            // 
            // lblRenter
            // 
            this.lblRenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(13, 303);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(42, 13);
            this.lblRenter.TabIndex = 24;
            this.lblRenter.Text = "Renter:";
            // 
            // dgvSportsHalls
            // 
            this.dgvSportsHalls.AllowUserToAddRows = false;
            this.dgvSportsHalls.AllowUserToDeleteRows = false;
            this.dgvSportsHalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSportsHalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSportsHalls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSportsHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportsHalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnType,
            this.ColumnArea,
            this.ColumnRate});
            this.dgvSportsHalls.Location = new System.Drawing.Point(7, 19);
            this.dgvSportsHalls.MultiSelect = false;
            this.dgvSportsHalls.Name = "dgvSportsHalls";
            this.dgvSportsHalls.ReadOnly = true;
            this.dgvSportsHalls.RowHeadersVisible = false;
            this.dgvSportsHalls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSportsHalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportsHalls.Size = new System.Drawing.Size(311, 148);
            this.dgvSportsHalls.TabIndex = 11;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnArea
            // 
            this.ColumnArea.HeaderText = "Area";
            this.ColumnArea.Name = "ColumnArea";
            this.ColumnArea.ReadOnly = true;
            // 
            // ColumnRate
            // 
            this.ColumnRate.HeaderText = "Rate/Hour";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            // 
            // btnNewRent
            // 
            this.btnNewRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRent.Location = new System.Drawing.Point(184, 465);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(75, 23);
            this.btnNewRent.TabIndex = 1;
            this.btnNewRent.Text = "OK";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewRentForm
            // 
            this.AcceptButton = this.btnNewRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(352, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewRent);
            this.Controls.Add(this.grbNewRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New rent";
            this.Load += new System.EventHandler(this.NewRentForm_Load);
            this.grbNewRent.ResumeLayout(false);
            this.grbNewRent.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRateMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRateMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsHalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNewRent;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudCash;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.ComboBox cbRenter;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.DataGridView dgvSportsHalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRate;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbClassType;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.Label lblClassArea;
        private System.Windows.Forms.NumericUpDown nudRateMax;
        private System.Windows.Forms.NumericUpDown nudRateMin;
        private System.Windows.Forms.Label lblRateDivider;
        private System.Windows.Forms.NumericUpDown nudAreaMin;
        private System.Windows.Forms.Label lblAreaDivider;
        private System.Windows.Forms.Label lblClassRate;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.NumericUpDown nudAreaMax;
    }
}