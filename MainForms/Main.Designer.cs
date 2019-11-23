namespace Drone_Calculations.Main
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
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.btnAddNewComponent = new System.Windows.Forms.Button();
            this.grpBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Controls.Add(this.btnAddNewComponent);
            this.grpBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMain.Location = new System.Drawing.Point(0, 0);
            this.grpBoxMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxMain.Size = new System.Drawing.Size(1022, 648);
            this.grpBoxMain.TabIndex = 0;
            this.grpBoxMain.TabStop = false;
            // 
            // btnAddNewComponent
            // 
            this.btnAddNewComponent.Location = new System.Drawing.Point(69, 318);
            this.btnAddNewComponent.Name = "btnAddNewComponent";
            this.btnAddNewComponent.Size = new System.Drawing.Size(169, 39);
            this.btnAddNewComponent.TabIndex = 0;
            this.btnAddNewComponent.Text = "Add New Component";
            this.btnAddNewComponent.UseVisualStyleBackColor = true;
            this.btnAddNewComponent.Click += new System.EventHandler(this.btnAddNewComponent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.grpBoxMain);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFT Calculator";
            this.grpBoxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMain;
        private System.Windows.Forms.Button btnAddNewComponent;
    }
}