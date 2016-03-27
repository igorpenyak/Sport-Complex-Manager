namespace SportsComplex.DesktopUI
{
    partial class SportsHallsForm
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
            this.grbSportsHalls = new System.Windows.Forms.GroupBox();
            this.btnSportsHallTypes = new System.Windows.Forms.Button();
            this.dgvSportsHalls = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSportsHalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSportsHalls
            // 
            this.grbSportsHalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSportsHalls.Controls.Add(this.btnSportsHallTypes);
            this.grbSportsHalls.Controls.Add(this.dgvSportsHalls);
            this.grbSportsHalls.Controls.Add(this.btnRemove);
            this.grbSportsHalls.Controls.Add(this.btnAdd);
            this.grbSportsHalls.Location = new System.Drawing.Point(12, 12);
            this.grbSportsHalls.Name = "grbSportsHalls";
            this.grbSportsHalls.Size = new System.Drawing.Size(360, 254);
            this.grbSportsHalls.TabIndex = 7;
            this.grbSportsHalls.TabStop = false;
            // 
            // btnSportsHallTypes
            // 
            this.btnSportsHallTypes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSportsHallTypes.Location = new System.Drawing.Point(12, 225);
            this.btnSportsHallTypes.Name = "btnSportsHallTypes";
            this.btnSportsHallTypes.Size = new System.Drawing.Size(93, 23);
            this.btnSportsHallTypes.TabIndex = 3;
            this.btnSportsHallTypes.Text = "Types...";
            this.btnSportsHallTypes.UseVisualStyleBackColor = true;
            this.btnSportsHallTypes.Click += new System.EventHandler(this.btnSportsHallTypes_Click);
            // 
            // dgvSportsHalls
            // 
            this.dgvSportsHalls.AllowUserToAddRows = false;
            this.dgvSportsHalls.AllowUserToDeleteRows = false;
            this.dgvSportsHalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSportsHalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSportsHalls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSportsHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportsHalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnType,
            this.ColumnArea,
            this.ColumnRate});
            this.dgvSportsHalls.Location = new System.Drawing.Point(12, 19);
            this.dgvSportsHalls.MultiSelect = false;
            this.dgvSportsHalls.Name = "dgvSportsHalls";
            this.dgvSportsHalls.RowHeadersVisible = false;
            this.dgvSportsHalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportsHalls.Size = new System.Drawing.Size(342, 200);
            this.dgvSportsHalls.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemove.Location = new System.Drawing.Point(288, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(216, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(279, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // 
            // ColumnRate
            // 
            this.ColumnRate.HeaderText = "Rate";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            // 
            // SportsHallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(384, 307);
            this.Controls.Add(this.grbSportsHalls);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SportsHallsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sports Halls";
            this.Load += new System.EventHandler(this.SportsHallsForm_Load);
            this.grbSportsHalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsHalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSportsHalls;
        private System.Windows.Forms.DataGridView dgvSportsHalls;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSportsHallTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRate;
    }
}