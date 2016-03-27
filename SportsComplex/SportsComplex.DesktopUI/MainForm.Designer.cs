namespace SportsComplex.DesktopUI
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsHallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowPriceList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRents = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbRenter = new System.Windows.Forms.ComboBox();
            this.lblRenter = new System.Windows.Forms.Label();
            this.btnCancelRent = new System.Windows.Forms.Button();
            this.btnExtendRent = new System.Windows.Forms.Button();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            this.grpRents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.manageToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(714, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(35, 20);
            this.miFile.Text = "File";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(92, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sportsHallsToolStripMenuItem,
            this.rentersToolStripMenuItem,
            this.toolStripSeparator1,
            this.miShowPriceList});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // sportsHallsToolStripMenuItem
            // 
            this.sportsHallsToolStripMenuItem.Name = "sportsHallsToolStripMenuItem";
            this.sportsHallsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.sportsHallsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sportsHallsToolStripMenuItem.Text = "Sports Halls...";
            this.sportsHallsToolStripMenuItem.Click += new System.EventHandler(this.sportsHallsToolStripMenuItem_Click);
            // 
            // rentersToolStripMenuItem
            // 
            this.rentersToolStripMenuItem.Name = "rentersToolStripMenuItem";
            this.rentersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rentersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rentersToolStripMenuItem.Text = "Renters...";
            this.rentersToolStripMenuItem.Click += new System.EventHandler(this.rentersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // miShowPriceList
            // 
            this.miShowPriceList.Name = "miShowPriceList";
            this.miShowPriceList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miShowPriceList.Size = new System.Drawing.Size(182, 22);
            this.miShowPriceList.Text = "Show Price List";
            this.miShowPriceList.Click += new System.EventHandler(this.miShowPriceList_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpRents
            // 
            this.grpRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRents.Controls.Add(this.dtpDate);
            this.grpRents.Controls.Add(this.lblDate);
            this.grpRents.Controls.Add(this.lblFilter);
            this.grpRents.Controls.Add(this.btnReset);
            this.grpRents.Controls.Add(this.cbRenter);
            this.grpRents.Controls.Add(this.lblRenter);
            this.grpRents.Controls.Add(this.btnCancelRent);
            this.grpRents.Controls.Add(this.btnExtendRent);
            this.grpRents.Controls.Add(this.btnNewRent);
            this.grpRents.Controls.Add(this.dgvRents);
            this.grpRents.Location = new System.Drawing.Point(13, 28);
            this.grpRents.Name = "grpRents";
            this.grpRents.Size = new System.Drawing.Size(689, 391);
            this.grpRents.TabIndex = 1;
            this.grpRents.TabStop = false;
            this.grpRents.Text = "Rents";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(567, 288);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(116, 20);
            this.dtpDate.TabIndex = 13;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(564, 271);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilter.Location = new System.Drawing.Point(608, 249);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 13);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Filter";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(564, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbRenter
            // 
            this.cbRenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenter.FormattingEnabled = true;
            this.cbRenter.Location = new System.Drawing.Point(564, 327);
            this.cbRenter.Name = "cbRenter";
            this.cbRenter.Size = new System.Drawing.Size(119, 21);
            this.cbRenter.TabIndex = 9;
            this.cbRenter.DropDown += new System.EventHandler(this.cbRenter_DropDown);
            this.cbRenter.SelectedIndexChanged += new System.EventHandler(this.cbRenter_SelectedIndexChanged);
            // 
            // lblRenter
            // 
            this.lblRenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(564, 311);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(42, 13);
            this.lblRenter.TabIndex = 8;
            this.lblRenter.Text = "Renter:";
            // 
            // btnCancelRent
            // 
            this.btnCancelRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelRent.Location = new System.Drawing.Point(564, 131);
            this.btnCancelRent.Name = "btnCancelRent";
            this.btnCancelRent.Size = new System.Drawing.Size(119, 50);
            this.btnCancelRent.TabIndex = 6;
            this.btnCancelRent.Text = "Complete rent";
            this.btnCancelRent.UseVisualStyleBackColor = true;
            this.btnCancelRent.Click += new System.EventHandler(this.btnCancelRent_Click);
            // 
            // btnExtendRent
            // 
            this.btnExtendRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtendRent.Location = new System.Drawing.Point(564, 75);
            this.btnExtendRent.Name = "btnExtendRent";
            this.btnExtendRent.Size = new System.Drawing.Size(119, 50);
            this.btnExtendRent.TabIndex = 5;
            this.btnExtendRent.Text = "Extend rent";
            this.btnExtendRent.UseVisualStyleBackColor = true;
            this.btnExtendRent.Click += new System.EventHandler(this.btnExtendRent_Click);
            // 
            // btnNewRent
            // 
            this.btnNewRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRent.Location = new System.Drawing.Point(564, 19);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(119, 50);
            this.btnNewRent.TabIndex = 4;
            this.btnNewRent.Text = "New rent";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // dgvRents
            // 
            this.dgvRents.AllowUserToAddRows = false;
            this.dgvRents.AllowUserToDeleteRows = false;
            this.dgvRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnRenter,
            this.ColumnType,
            this.ColumnArea,
            this.ColumnRate,
            this.ColumnDateFrom,
            this.ColumnDateTo,
            this.ColumnContactPhone,
            this.ColumnCost});
            this.dgvRents.Location = new System.Drawing.Point(6, 19);
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.ReadOnly = true;
            this.dgvRents.RowHeadersVisible = false;
            this.dgvRents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRents.Size = new System.Drawing.Size(552, 358);
            this.dgvRents.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.FillWeight = 78.07982F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnRenter
            // 
            this.ColumnRenter.FillWeight = 98.71521F;
            this.ColumnRenter.HeaderText = "Renter";
            this.ColumnRenter.Name = "ColumnRenter";
            this.ColumnRenter.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.FillWeight = 98.71521F;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnArea
            // 
            this.ColumnArea.FillWeight = 98.71521F;
            this.ColumnArea.HeaderText = "Area";
            this.ColumnArea.Name = "ColumnArea";
            this.ColumnArea.ReadOnly = true;
            // 
            // ColumnRate
            // 
            this.ColumnRate.FillWeight = 98.71521F;
            this.ColumnRate.HeaderText = "Rate/Hour";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            // 
            // ColumnDateFrom
            // 
            this.ColumnDateFrom.FillWeight = 98.71521F;
            this.ColumnDateFrom.HeaderText = "Date From";
            this.ColumnDateFrom.Name = "ColumnDateFrom";
            this.ColumnDateFrom.ReadOnly = true;
            // 
            // ColumnDateTo
            // 
            this.ColumnDateTo.FillWeight = 98.71521F;
            this.ColumnDateTo.HeaderText = "Date To";
            this.ColumnDateTo.Name = "ColumnDateTo";
            this.ColumnDateTo.ReadOnly = true;
            // 
            // ColumnContactPhone
            // 
            this.ColumnContactPhone.HeaderText = "Contact Phone";
            this.ColumnContactPhone.Name = "ColumnContactPhone";
            this.ColumnContactPhone.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.FillWeight = 98.71521F;
            this.ColumnCost.HeaderText = "Sum Cost";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 431);
            this.Controls.Add(this.grpRents);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Complex Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpRents.ResumeLayout(false);
            this.grpRents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsHallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRents;
        private System.Windows.Forms.Button btnCancelRent;
        private System.Windows.Forms.Button btnExtendRent;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miShowPriceList;
        public System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.ComboBox cbRenter;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

