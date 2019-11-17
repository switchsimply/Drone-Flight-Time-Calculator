namespace Drone_Calculations
{
    partial class DroneFlightTimeCalculator
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
            this.tblComponents = new System.Windows.Forms.TableLayoutPanel();
            this.cmbComponents = new System.Windows.Forms.ComboBox();
            this.lblComponents = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.btnAddNewPart = new System.Windows.Forms.Button();
            this.lblTotalWgt = new System.Windows.Forms.Label();
            this.tblComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblComponents
            // 
            this.tblComponents.ColumnCount = 2;
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblComponents.Controls.Add(this.cmbComponents, 1, 0);
            this.tblComponents.Controls.Add(this.lblComponents, 0, 0);
            this.tblComponents.Controls.Add(this.lblTotalWeight, 0, 2);
            this.tblComponents.Controls.Add(this.btnAddNewPart, 0, 1);
            this.tblComponents.Controls.Add(this.lblTotalWgt, 1, 2);
            this.tblComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblComponents.Location = new System.Drawing.Point(0, 0);
            this.tblComponents.Name = "tblComponents";
            this.tblComponents.RowCount = 3;
            this.tblComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblComponents.Size = new System.Drawing.Size(1735, 200);
            this.tblComponents.TabIndex = 0;
            // 
            // cmbComponents
            // 
            this.cmbComponents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponents.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponents.FormattingEnabled = true;
            this.cmbComponents.Location = new System.Drawing.Point(870, 18);
            this.cmbComponents.Name = "cmbComponents";
            this.cmbComponents.Size = new System.Drawing.Size(261, 29);
            this.cmbComponents.TabIndex = 0;
            // 
            // lblComponents
            // 
            this.lblComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComponents.AutoSize = true;
            this.lblComponents.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponents.Location = new System.Drawing.Point(3, 22);
            this.lblComponents.Name = "lblComponents";
            this.lblComponents.Size = new System.Drawing.Size(861, 21);
            this.lblComponents.TabIndex = 1;
            this.lblComponents.Text = "Components";
            this.lblComponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(3, 155);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(861, 21);
            this.lblTotalWeight.TabIndex = 2;
            this.lblTotalWeight.Text = "Total Weight";
            this.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalWeight.Visible = false;
            // 
            // btnAddNewPart
            // 
            this.btnAddNewPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewPart.Location = new System.Drawing.Point(378, 77);
            this.btnAddNewPart.Name = "btnAddNewPart";
            this.btnAddNewPart.Size = new System.Drawing.Size(111, 44);
            this.btnAddNewPart.TabIndex = 2;
            this.btnAddNewPart.Text = "Add New Part";
            this.btnAddNewPart.UseVisualStyleBackColor = true;
            this.btnAddNewPart.Click += new System.EventHandler(this.btnAddNewPart_Click);
            // 
            // lblTotalWgt
            // 
            this.lblTotalWgt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalWgt.AutoSize = true;
            this.lblTotalWgt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWgt.Location = new System.Drawing.Point(870, 155);
            this.lblTotalWgt.Name = "lblTotalWgt";
            this.lblTotalWgt.Size = new System.Drawing.Size(138, 21);
            this.lblTotalWgt.TabIndex = 3;
            this.lblTotalWgt.Text = "Total Weight Value";
            this.lblTotalWgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalWgt.Visible = false;
            // 
            // DroneFlightTimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1735, 751);
            this.Controls.Add(this.tblComponents);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "DroneFlightTimeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneFlightTimeCalculator";
            this.tblComponents.ResumeLayout(false);
            this.tblComponents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblComponents;
        private System.Windows.Forms.ComboBox cmbComponents;
        private System.Windows.Forms.Label lblComponents;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Button btnAddNewPart;
        private System.Windows.Forms.Label lblTotalWgt;
    }
}