namespace Presentation
{
    partial class FrmAddCompany
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
            this.lblDataCompany = new System.Windows.Forms.Label();
            this.btnCreateCom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAdressCom = new System.Windows.Forms.TextBox();
            this.txtNameCom = new System.Windows.Forms.TextBox();
            this.txtCuilCom = new System.Windows.Forms.TextBox();
            this.lblAdressCom = new System.Windows.Forms.Label();
            this.lblNameCom = new System.Windows.Forms.Label();
            this.lblCuilCom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCompany
            // 
            this.lblDataCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataCompany.AutoSize = true;
            this.lblDataCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataCompany.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompany.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDataCompany.Location = new System.Drawing.Point(17, 56);
            this.lblDataCompany.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDataCompany.Name = "lblDataCompany";
            this.lblDataCompany.Size = new System.Drawing.Size(222, 37);
            this.lblDataCompany.TabIndex = 14;
            this.lblDataCompany.Text = "DATOS EMPRESA";
            this.lblDataCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateCom
            // 
            this.btnCreateCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCom.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateCom.Location = new System.Drawing.Point(24, 364);
            this.btnCreateCom.Name = "btnCreateCom";
            this.btnCreateCom.Size = new System.Drawing.Size(360, 56);
            this.btnCreateCom.TabIndex = 13;
            this.btnCreateCom.Text = "CREAR EMPRESA";
            this.btnCreateCom.UseVisualStyleBackColor = true;
            this.btnCreateCom.Click += new System.EventHandler(this.btnCreateCom_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtAdressCom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNameCom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCuilCom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdressCom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNameCom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCuilCom, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 214);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtAdressCom
            // 
            this.txtAdressCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdressCom.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAdressCom.Location = new System.Drawing.Point(183, 167);
            this.txtAdressCom.Name = "txtAdressCom";
            this.txtAdressCom.Size = new System.Drawing.Size(174, 22);
            this.txtAdressCom.TabIndex = 6;
            // 
            // txtNameCom
            // 
            this.txtNameCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameCom.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNameCom.Location = new System.Drawing.Point(183, 95);
            this.txtNameCom.Name = "txtNameCom";
            this.txtNameCom.Size = new System.Drawing.Size(174, 22);
            this.txtNameCom.TabIndex = 4;
            // 
            // txtCuilCom
            // 
            this.txtCuilCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuilCom.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCuilCom.Location = new System.Drawing.Point(183, 24);
            this.txtCuilCom.Name = "txtCuilCom";
            this.txtCuilCom.Size = new System.Drawing.Size(174, 22);
            this.txtCuilCom.TabIndex = 2;
            // 
            // lblAdressCom
            // 
            this.lblAdressCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdressCom.AutoSize = true;
            this.lblAdressCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdressCom.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAdressCom.Location = new System.Drawing.Point(8, 167);
            this.lblAdressCom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAdressCom.Name = "lblAdressCom";
            this.lblAdressCom.Size = new System.Drawing.Size(164, 21);
            this.lblAdressCom.TabIndex = 3;
            this.lblAdressCom.Text = "DIRECCION:";
            this.lblAdressCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameCom
            // 
            this.lblNameCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameCom.AutoSize = true;
            this.lblNameCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNameCom.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNameCom.Location = new System.Drawing.Point(8, 96);
            this.lblNameCom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNameCom.Name = "lblNameCom";
            this.lblNameCom.Size = new System.Drawing.Size(164, 21);
            this.lblNameCom.TabIndex = 1;
            this.lblNameCom.Text = "NOMBRE EMPRESA:";
            this.lblNameCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuilCom
            // 
            this.lblCuilCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuilCom.AutoSize = true;
            this.lblCuilCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCuilCom.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuilCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCuilCom.Location = new System.Drawing.Point(8, 25);
            this.lblCuilCom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCuilCom.Name = "lblCuilCom";
            this.lblCuilCom.Size = new System.Drawing.Size(164, 21);
            this.lblCuilCom.TabIndex = 5;
            this.lblCuilCom.Text = "CUIL EMPRESA:";
            this.lblCuilCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.lblDataCompany);
            this.Controls.Add(this.btnCreateCom);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAddCompany";
            this.Text = "AGREGAR ALUMNO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataCompany;
        private System.Windows.Forms.Button btnCreateCom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAdressCom;
        private System.Windows.Forms.Label lblCuilCom;
        private System.Windows.Forms.TextBox txtNameCom;
        private System.Windows.Forms.Label lblAdressCom;
        private System.Windows.Forms.Label lblNameCom;
        private System.Windows.Forms.TextBox txtCuilCom;
    }
}