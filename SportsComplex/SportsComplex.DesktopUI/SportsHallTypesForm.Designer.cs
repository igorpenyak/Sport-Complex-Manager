namespace SportsComplex.DesktopUI
{
    partial class SportsHallTypesForm
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
            this.lstSportsHallTypes = new System.Windows.Forms.ListBox();
            this.btnAddHallType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbNewSportshall = new System.Windows.Forms.GroupBox();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grbNewSportshall.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSportsHallTypes
            // 
            this.lstSportsHallTypes.FormattingEnabled = true;
            this.lstSportsHallTypes.Location = new System.Drawing.Point(12, 12);
            this.lstSportsHallTypes.Name = "lstSportsHallTypes";
            this.lstSportsHallTypes.Size = new System.Drawing.Size(198, 147);
            this.lstSportsHallTypes.TabIndex = 1;
            // 
            // btnAddHallType
            // 
            this.btnAddHallType.Location = new System.Drawing.Point(6, 58);
            this.btnAddHallType.Name = "btnAddHallType";
            this.btnAddHallType.Size = new System.Drawing.Size(186, 23);
            this.btnAddHallType.TabIndex = 2;
            this.btnAddHallType.Text = "Add";
            this.btnAddHallType.UseVisualStyleBackColor = true;
            this.btnAddHallType.Click += new System.EventHandler(this.btnAddHallType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(118, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grbNewSportshall
            // 
            this.grbNewSportshall.Controls.Add(this.lblTypeName);
            this.grbNewSportshall.Controls.Add(this.tbTypeName);
            this.grbNewSportshall.Controls.Add(this.btnAddHallType);
            this.grbNewSportshall.Location = new System.Drawing.Point(12, 165);
            this.grbNewSportshall.Name = "grbNewSportshall";
            this.grbNewSportshall.Size = new System.Drawing.Size(198, 92);
            this.grbNewSportshall.TabIndex = 4;
            this.grbNewSportshall.TabStop = false;
            this.grbNewSportshall.Text = "New sports hall type";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(6, 32);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(186, 20);
            this.tbTypeName.TabIndex = 3;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(6, 16);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(38, 13);
            this.lblTypeName.TabIndex = 4;
            this.lblTypeName.Text = "Name:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemove.Location = new System.Drawing.Point(12, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SportsHallTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(222, 299);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grbNewSportshall);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstSportsHallTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SportsHallTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sports Hall Types";
            this.Load += new System.EventHandler(this.SportsHallTypesForm_Load);
            this.grbNewSportshall.ResumeLayout(false);
            this.grbNewSportshall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSportsHallTypes;
        private System.Windows.Forms.Button btnAddHallType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbNewSportshall;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Button btnRemove;
    }
}