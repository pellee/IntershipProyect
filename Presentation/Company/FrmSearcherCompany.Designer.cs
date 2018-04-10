namespace Presentation
{
    partial class FrmSearcherCompany
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
            this.btnDeleteCom = new System.Windows.Forms.Button();
            this.btnModifyCom = new System.Windows.Forms.Button();
            this.txtSearcher = new System.Windows.Forms.TextBox();
            this.lblSearcher = new System.Windows.Forms.Label();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCom
            // 
            this.btnDeleteCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteCom.Location = new System.Drawing.Point(549, 420);
            this.btnDeleteCom.Name = "btnDeleteCom";
            this.btnDeleteCom.Size = new System.Drawing.Size(308, 50);
            this.btnDeleteCom.TabIndex = 18;
            this.btnDeleteCom.Text = "ELIMINAR";
            this.btnDeleteCom.UseVisualStyleBackColor = true;
            // 
            // btnModifyCom
            // 
            this.btnModifyCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModifyCom.Location = new System.Drawing.Point(43, 420);
            this.btnModifyCom.Name = "btnModifyCom";
            this.btnModifyCom.Size = new System.Drawing.Size(308, 50);
            this.btnModifyCom.TabIndex = 17;
            this.btnModifyCom.Text = "MODIFICAR";
            this.btnModifyCom.UseVisualStyleBackColor = true;
            // 
            // txtSearcher
            // 
            this.txtSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearcher.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearcher.Location = new System.Drawing.Point(175, 42);
            this.txtSearcher.Name = "txtSearcher";
            this.txtSearcher.Size = new System.Drawing.Size(176, 33);
            this.txtSearcher.TabIndex = 16;
            // 
            // lblSearcher
            // 
            this.lblSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearcher.AutoSize = true;
            this.lblSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSearcher.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearcher.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSearcher.Location = new System.Drawing.Point(36, 35);
            this.lblSearcher.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSearcher.Name = "lblSearcher";
            this.lblSearcher.Size = new System.Drawing.Size(128, 37);
            this.lblSearcher.TabIndex = 15;
            this.lblSearcher.Text = "BUSCAR:";
            this.lblSearcher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Location = new System.Drawing.Point(43, 113);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.Size = new System.Drawing.Size(814, 251);
            this.dgvCompanies.TabIndex = 14;
            // 
            // FrmSearcherCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.Controls.Add(this.btnDeleteCom);
            this.Controls.Add(this.btnModifyCom);
            this.Controls.Add(this.txtSearcher);
            this.Controls.Add(this.lblSearcher);
            this.Controls.Add(this.dgvCompanies);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSearcherCompany";
            this.Text = "BUSCAR EMPRESA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCom;
        private System.Windows.Forms.Button btnModifyCom;
        private System.Windows.Forms.TextBox txtSearcher;
        private System.Windows.Forms.Label lblSearcher;
        private System.Windows.Forms.DataGridView dgvCompanies;
    }
}