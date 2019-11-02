namespace Drone_Flight_Time_Calculator
{
    partial class Drone_Flight_Time_Calculator
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
            this.gbAerodynamic_Forces = new System.Windows.Forms.GroupBox();
            this.gbTricopter = new System.Windows.Forms.GroupBox();
            this.gbParts_Details = new System.Windows.Forms.GroupBox();
            this.dgvParts_Details = new System.Windows.Forms.DataGridView();
            this.tblPart_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lblDroneType = new System.Windows.Forms.Label();
            this.cmbDroneType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbParts_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts_Details)).BeginInit();
            this.tblPart_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAerodynamic_Forces
            // 
            this.gbAerodynamic_Forces.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAerodynamic_Forces.Location = new System.Drawing.Point(0, 656);
            this.gbAerodynamic_Forces.Name = "gbAerodynamic_Forces";
            this.gbAerodynamic_Forces.Size = new System.Drawing.Size(907, 339);
            this.gbAerodynamic_Forces.TabIndex = 5;
            this.gbAerodynamic_Forces.TabStop = false;
            this.gbAerodynamic_Forces.Text = "Aerodynamic_Forces";
            // 
            // gbTricopter
            // 
            this.gbTricopter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTricopter.Location = new System.Drawing.Point(0, 494);
            this.gbTricopter.Name = "gbTricopter";
            this.gbTricopter.Size = new System.Drawing.Size(907, 162);
            this.gbTricopter.TabIndex = 4;
            this.gbTricopter.TabStop = false;
            this.gbTricopter.Text = "Tricopter";
            // 
            // gbParts_Details
            // 
            this.gbParts_Details.Controls.Add(this.dgvParts_Details);
            this.gbParts_Details.Controls.Add(this.tblPart_Details);
            this.gbParts_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbParts_Details.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbParts_Details.Location = new System.Drawing.Point(0, 0);
            this.gbParts_Details.Name = "gbParts_Details";
            this.gbParts_Details.Size = new System.Drawing.Size(907, 494);
            this.gbParts_Details.TabIndex = 3;
            this.gbParts_Details.TabStop = false;
            // 
            // dgvParts_Details
            // 
            this.dgvParts_Details.BackgroundColor = System.Drawing.Color.White;
            this.dgvParts_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParts_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts_Details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvParts_Details.GridColor = System.Drawing.Color.Teal;
            this.dgvParts_Details.Location = new System.Drawing.Point(3, 96);
            this.dgvParts_Details.Name = "dgvParts_Details";
            this.dgvParts_Details.RowHeadersWidth = 51;
            this.dgvParts_Details.RowTemplate.Height = 24;
            this.dgvParts_Details.Size = new System.Drawing.Size(901, 395);
            this.dgvParts_Details.TabIndex = 2;
            // 
            // tblPart_Details
            // 
            this.tblPart_Details.ColumnCount = 3;
            this.tblPart_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4596F));
            this.tblPart_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.16942F));
            this.tblPart_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.37098F));
            this.tblPart_Details.Controls.Add(this.lblDroneType, 0, 0);
            this.tblPart_Details.Controls.Add(this.cmbDroneType, 1, 0);
            this.tblPart_Details.Controls.Add(this.btnUpdate, 2, 0);
            this.tblPart_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPart_Details.Location = new System.Drawing.Point(3, 19);
            this.tblPart_Details.Name = "tblPart_Details";
            this.tblPart_Details.RowCount = 1;
            this.tblPart_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPart_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tblPart_Details.Size = new System.Drawing.Size(901, 71);
            this.tblPart_Details.TabIndex = 1;
            // 
            // lblDroneType
            // 
            this.lblDroneType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDroneType.AutoSize = true;
            this.lblDroneType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroneType.Location = new System.Drawing.Point(3, 25);
            this.lblDroneType.Name = "lblDroneType";
            this.lblDroneType.Size = new System.Drawing.Size(187, 20);
            this.lblDroneType.TabIndex = 1;
            this.lblDroneType.Text = "Drone Type";
            this.lblDroneType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDroneType
            // 
            this.cmbDroneType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDroneType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDroneType.FormattingEnabled = true;
            this.cmbDroneType.Location = new System.Drawing.Point(196, 24);
            this.cmbDroneType.Name = "cmbDroneType";
            this.cmbDroneType.Size = new System.Drawing.Size(263, 26);
            this.cmbDroneType.TabIndex = 0;
            this.cmbDroneType.SelectedIndexChanged += new System.EventHandler(this.CmbDroneType_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(693, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Drone_Flight_Time_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 875);
            this.Controls.Add(this.gbAerodynamic_Forces);
            this.Controls.Add(this.gbTricopter);
            this.Controls.Add(this.gbParts_Details);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Drone_Flight_Time_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drone Flight Time Calculator";
            this.gbParts_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts_Details)).EndInit();
            this.tblPart_Details.ResumeLayout(false);
            this.tblPart_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAerodynamic_Forces;
        private System.Windows.Forms.GroupBox gbTricopter;
        private System.Windows.Forms.GroupBox gbParts_Details;
        private System.Windows.Forms.TableLayoutPanel tblPart_Details;
        private System.Windows.Forms.ComboBox cmbDroneType;
        private System.Windows.Forms.DataGridView dgvParts_Details;
        private System.Windows.Forms.Label lblDroneType;
        private System.Windows.Forms.Button btnUpdate;
    }
}