namespace DroneFlightTimeCalculator.MainForms
{
    partial class Main
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
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewComponent = new System.Windows.Forms.Button();
            this.btnAddNewComponent = new System.Windows.Forms.Button();
            this.lblTotalFinalWeight = new System.Windows.Forms.Label();
            this.lblTotalFinalWeightValue = new System.Windows.Forms.Label();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.tblComponents = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitWeight = new System.Windows.Forms.Label();
            this.lblSpecifications = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.lblTotalUnitWeight = new System.Windows.Forms.Label();
            this.lblFinalWeight = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.IsSplitterFixed = true;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            this.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.tblMain);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.tblComponents);
            this.SplitContainerMain.Size = new System.Drawing.Size(982, 609);
            this.SplitContainerMain.SplitterDistance = 80;
            this.SplitContainerMain.TabIndex = 4;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 5;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.Controls.Add(this.btnViewComponent, 0, 0);
            this.tblMain.Controls.Add(this.btnAddNewComponent, 0, 0);
            this.tblMain.Controls.Add(this.lblTotalFinalWeight, 3, 0);
            this.tblMain.Controls.Add(this.lblTotalFinalWeightValue, 3, 0);
            this.tblMain.Controls.Add(this.btnAddComponent, 2, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(982, 80);
            this.tblMain.TabIndex = 4;
            // 
            // btnViewComponent
            // 
            this.btnViewComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewComponent.Location = new System.Drawing.Point(219, 19);
            this.btnViewComponent.Name = "btnViewComponent";
            this.btnViewComponent.Size = new System.Drawing.Size(150, 42);
            this.btnViewComponent.TabIndex = 2;
            this.btnViewComponent.Text = "View Components";
            this.btnViewComponent.UseVisualStyleBackColor = true;
            this.btnViewComponent.Click += new System.EventHandler(this.btnViewComponent_Click);
            // 
            // btnAddNewComponent
            // 
            this.btnAddNewComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewComponent.Location = new System.Drawing.Point(11, 19);
            this.btnAddNewComponent.Name = "btnAddNewComponent";
            this.btnAddNewComponent.Size = new System.Drawing.Size(173, 42);
            this.btnAddNewComponent.TabIndex = 0;
            this.btnAddNewComponent.Text = "Add New Component";
            this.btnAddNewComponent.UseVisualStyleBackColor = true;
            this.btnAddNewComponent.Click += new System.EventHandler(this.btnAddNewComponent_Click);
            // 
            // lblTotalFinalWeight
            // 
            this.lblTotalFinalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFinalWeight.AutoSize = true;
            this.lblTotalFinalWeight.Location = new System.Drawing.Point(591, 29);
            this.lblTotalFinalWeight.Name = "lblTotalFinalWeight";
            this.lblTotalFinalWeight.Size = new System.Drawing.Size(190, 21);
            this.lblTotalFinalWeight.TabIndex = 3;
            this.lblTotalFinalWeight.Text = "Total Final Weight";
            this.lblTotalFinalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalFinalWeight.Visible = false;
            // 
            // lblTotalFinalWeightValue
            // 
            this.lblTotalFinalWeightValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFinalWeightValue.AutoSize = true;
            this.lblTotalFinalWeightValue.Location = new System.Drawing.Point(787, 29);
            this.lblTotalFinalWeightValue.Name = "lblTotalFinalWeightValue";
            this.lblTotalFinalWeightValue.Size = new System.Drawing.Size(192, 21);
            this.lblTotalFinalWeightValue.TabIndex = 4;
            this.lblTotalFinalWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalFinalWeightValue.Visible = false;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddComponent.Location = new System.Drawing.Point(415, 19);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(150, 42);
            this.btnAddComponent.TabIndex = 1;
            this.btnAddComponent.Text = "Add Component";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // tblComponents
            // 
            this.tblComponents.ColumnCount = 6;
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblComponents.Controls.Add(this.lblQuantity, 4, 0);
            this.tblComponents.Controls.Add(this.lblUnitWeight, 3, 0);
            this.tblComponents.Controls.Add(this.lblSpecifications, 2, 0);
            this.tblComponents.Controls.Add(this.lblModel, 1, 0);
            this.tblComponents.Controls.Add(this.lblComponentName, 0, 0);
            this.tblComponents.Controls.Add(this.lblTotalUnitWeight, 5, 0);
            this.tblComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblComponents.Location = new System.Drawing.Point(0, 0);
            this.tblComponents.Name = "tblComponents";
            this.tblComponents.RowCount = 2;
            this.tblComponents.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblComponents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblComponents.Size = new System.Drawing.Size(982, 525);
            this.tblComponents.TabIndex = 4;
            this.tblComponents.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(655, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(157, 21);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitWeight
            // 
            this.lblUnitWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitWeight.AutoSize = true;
            this.lblUnitWeight.Location = new System.Drawing.Point(492, 0);
            this.lblUnitWeight.Name = "lblUnitWeight";
            this.lblUnitWeight.Size = new System.Drawing.Size(157, 21);
            this.lblUnitWeight.TabIndex = 3;
            this.lblUnitWeight.Text = "Unit Weight";
            this.lblUnitWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecifications
            // 
            this.lblSpecifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecifications.AutoSize = true;
            this.lblSpecifications.Location = new System.Drawing.Point(329, 0);
            this.lblSpecifications.Name = "lblSpecifications";
            this.lblSpecifications.Size = new System.Drawing.Size(157, 21);
            this.lblSpecifications.TabIndex = 2;
            this.lblSpecifications.Text = "Specifications";
            this.lblSpecifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(166, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(157, 21);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComponentName
            // 
            this.lblComponentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Location = new System.Drawing.Point(3, 0);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(157, 21);
            this.lblComponentName.TabIndex = 0;
            this.lblComponentName.Text = "Component Name";
            this.lblComponentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalUnitWeight
            // 
            this.lblTotalUnitWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalUnitWeight.AutoSize = true;
            this.lblTotalUnitWeight.Location = new System.Drawing.Point(818, 0);
            this.lblTotalUnitWeight.Name = "lblTotalUnitWeight";
            this.lblTotalUnitWeight.Size = new System.Drawing.Size(161, 21);
            this.lblTotalUnitWeight.TabIndex = 5;
            this.lblTotalUnitWeight.Text = "Total Unit Weight";
            this.lblTotalUnitWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalWeight
            // 
            this.lblFinalWeight.Location = new System.Drawing.Point(0, 0);
            this.lblFinalWeight.Name = "lblFinalWeight";
            this.lblFinalWeight.Size = new System.Drawing.Size(100, 23);
            this.lblFinalWeight.TabIndex = 0;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(0, 0);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxQuantity.TabIndex = 0;
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(0, 0);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.txtBoxWeight.TabIndex = 0;
            this.txtBoxWeight.TextChanged += new System.EventHandler(this.txtBoxWeight_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 609);
            this.Controls.Add(this.SplitContainerMain);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Drone Flight Time Calculator";
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblComponents.ResumeLayout(false);
            this.tblComponents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnAddNewComponent;
        private System.Windows.Forms.TableLayoutPanel tblComponents;
        private System.Windows.Forms.Button btnViewComponent;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitWeight;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.Label lblTotalUnitWeight;
        private System.Windows.Forms.Label lblFinalWeight;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Label lblTotalFinalWeight;
        private System.Windows.Forms.Label lblTotalFinalWeightValue;
    }
}