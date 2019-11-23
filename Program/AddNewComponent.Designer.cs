namespace Drone_Calculations.Program
{
    partial class AddNewComponent
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
            this.tblAddNewComponent = new System.Windows.Forms.TableLayoutPanel();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSpecifications = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtBoxComponentName = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxSpecifications = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblAddNewComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAddNewComponent
            // 
            this.tblAddNewComponent.ColumnCount = 2;
            this.tblAddNewComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblAddNewComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblAddNewComponent.Controls.Add(this.btnCancel, 1, 4);
            this.tblAddNewComponent.Controls.Add(this.txtBoxWeight, 1, 3);
            this.tblAddNewComponent.Controls.Add(this.txtBoxSpecifications, 1, 2);
            this.tblAddNewComponent.Controls.Add(this.txtBoxModel, 1, 1);
            this.tblAddNewComponent.Controls.Add(this.lblComponentName, 0, 0);
            this.tblAddNewComponent.Controls.Add(this.lblModel, 0, 1);
            this.tblAddNewComponent.Controls.Add(this.lblSpecifications, 0, 2);
            this.tblAddNewComponent.Controls.Add(this.lblWeight, 0, 3);
            this.tblAddNewComponent.Controls.Add(this.txtBoxComponentName, 1, 0);
            this.tblAddNewComponent.Controls.Add(this.btnSave, 0, 4);
            this.tblAddNewComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAddNewComponent.Location = new System.Drawing.Point(0, 0);
            this.tblAddNewComponent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblAddNewComponent.Name = "tblAddNewComponent";
            this.tblAddNewComponent.RowCount = 5;
            this.tblAddNewComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddNewComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddNewComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddNewComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddNewComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddNewComponent.Size = new System.Drawing.Size(811, 402);
            this.tblAddNewComponent.TabIndex = 0;
            // 
            // lblComponentName
            // 
            this.lblComponentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Location = new System.Drawing.Point(3, 31);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(318, 18);
            this.lblComponentName.TabIndex = 0;
            this.lblComponentName.Text = "Component Name";
            this.lblComponentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(3, 111);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(318, 18);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecifications
            // 
            this.lblSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecifications.AutoSize = true;
            this.lblSpecifications.Location = new System.Drawing.Point(3, 191);
            this.lblSpecifications.Name = "lblSpecifications";
            this.lblSpecifications.Size = new System.Drawing.Size(318, 18);
            this.lblSpecifications.TabIndex = 2;
            this.lblSpecifications.Text = "Specifications";
            this.lblSpecifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(3, 271);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(318, 18);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxComponentName
            // 
            this.txtBoxComponentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxComponentName.Location = new System.Drawing.Point(327, 27);
            this.txtBoxComponentName.Name = "txtBoxComponentName";
            this.txtBoxComponentName.Size = new System.Drawing.Size(286, 26);
            this.txtBoxComponentName.TabIndex = 4;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxModel.Location = new System.Drawing.Point(327, 107);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(286, 26);
            this.txtBoxModel.TabIndex = 5;
            // 
            // txtBoxSpecifications
            // 
            this.txtBoxSpecifications.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxSpecifications.Location = new System.Drawing.Point(327, 187);
            this.txtBoxSpecifications.Name = "txtBoxSpecifications";
            this.txtBoxSpecifications.Size = new System.Drawing.Size(286, 26);
            this.txtBoxSpecifications.TabIndex = 6;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxWeight.Location = new System.Drawing.Point(327, 267);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(286, 26);
            this.txtBoxWeight.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(173, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(493, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddNewComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 402);
            this.Controls.Add(this.tblAddNewComponent);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddNewComponent";
            this.Text = "Add New Component";
            this.tblAddNewComponent.ResumeLayout(false);
            this.tblAddNewComponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAddNewComponent;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxSpecifications;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtBoxComponentName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}