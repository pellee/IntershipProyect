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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblProyects = new System.Windows.Forms.Label();
            this.lstboxProyects = new System.Windows.Forms.ListBox();
            this.cboxProyects = new System.Windows.Forms.ComboBox();
            this.lblDataCompany = new System.Windows.Forms.Label();
            this.btnCreateCom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdressCom = new System.Windows.Forms.Label();
            this.lblNameCom = new System.Windows.Forms.Label();
            this.lblCuilCom = new System.Windows.Forms.Label();
            this.btnCreateProyect = new System.Windows.Forms.Button();
            this.btnAddProyect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(690, 102);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 41);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "QUITAR";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblProyects
            // 
            this.lblProyects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProyects.AutoSize = true;
            this.lblProyects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProyects.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyects.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProyects.Location = new System.Drawing.Point(460, 46);
            this.lblProyects.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProyects.Name = "lblProyects";
            this.lblProyects.Size = new System.Drawing.Size(162, 37);
            this.lblProyects.TabIndex = 17;
            this.lblProyects.Text = "PROYECTOS";
            this.lblProyects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxProyects
            // 
            this.lstboxProyects.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxProyects.FormattingEnabled = true;
            this.lstboxProyects.ItemHeight = 30;
            this.lstboxProyects.Location = new System.Drawing.Point(467, 102);
            this.lstboxProyects.Name = "lstboxProyects";
            this.lstboxProyects.Size = new System.Drawing.Size(217, 244);
            this.lstboxProyects.TabIndex = 16;
            // 
            // cboxProyects
            // 
            this.cboxProyects.BackColor = System.Drawing.Color.DarkGray;
            this.cboxProyects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProyects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxProyects.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProyects.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxProyects.FormattingEnabled = true;
            this.cboxProyects.Items.AddRange(new object[] {
            "HOLA"});
            this.cboxProyects.Location = new System.Drawing.Point(10, 330);
            this.cboxProyects.Name = "cboxProyects";
            this.cboxProyects.Size = new System.Drawing.Size(360, 29);
            this.cboxProyects.TabIndex = 15;
            // 
            // lblDataCompany
            // 
            this.lblDataCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataCompany.AutoSize = true;
            this.lblDataCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataCompany.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompany.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDataCompany.Location = new System.Drawing.Point(31, 46);
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
            this.btnCreateCom.Location = new System.Drawing.Point(273, 468);
            this.btnCreateCom.Name = "btnCreateCom";
            this.btnCreateCom.Size = new System.Drawing.Size(349, 56);
            this.btnCreateCom.TabIndex = 13;
            this.btnCreateCom.Text = "CREAR EMPRESA";
            this.btnCreateCom.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtProm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdressCom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNameCom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCuilCom, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 196);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtProm
            // 
            this.txtProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProm.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProm.Location = new System.Drawing.Point(183, 152);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(174, 22);
            this.txtProm.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.Location = new System.Drawing.Point(183, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(183, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblAdressCom
            // 
            this.lblAdressCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdressCom.AutoSize = true;
            this.lblAdressCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdressCom.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAdressCom.Location = new System.Drawing.Point(8, 152);
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
            this.lblNameCom.Location = new System.Drawing.Point(8, 87);
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
            this.lblCuilCom.Location = new System.Drawing.Point(8, 22);
            this.lblCuilCom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCuilCom.Name = "lblCuilCom";
            this.lblCuilCom.Size = new System.Drawing.Size(164, 21);
            this.lblCuilCom.TabIndex = 5;
            this.lblCuilCom.Text = "CUIL EMPRESA:";
            this.lblCuilCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateProyect
            // 
            this.btnCreateProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateProyect.Location = new System.Drawing.Point(198, 385);
            this.btnCreateProyect.Name = "btnCreateProyect";
            this.btnCreateProyect.Size = new System.Drawing.Size(172, 53);
            this.btnCreateProyect.TabIndex = 19;
            this.btnCreateProyect.Text = "CREAR PROYECTO";
            this.btnCreateProyect.UseVisualStyleBackColor = true;
            this.btnCreateProyect.Click += new System.EventHandler(this.btnCreateProyect_Click);
            // 
            // btnAddProyect
            // 
            this.btnAddProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProyect.Location = new System.Drawing.Point(10, 385);
            this.btnAddProyect.Name = "btnAddProyect";
            this.btnAddProyect.Size = new System.Drawing.Size(172, 53);
            this.btnAddProyect.TabIndex = 20;
            this.btnAddProyect.Text = "AGREGAR PROYECTO";
            this.btnAddProyect.UseVisualStyleBackColor = true;
            this.btnAddProyect.Click += new System.EventHandler(this.btnAddProyect_Click);
            // 
            // FrmAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnAddProyect);
            this.Controls.Add(this.btnCreateProyect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblProyects);
            this.Controls.Add(this.lstboxProyects);
            this.Controls.Add(this.cboxProyects);
            this.Controls.Add(this.lblDataCompany);
            this.Controls.Add(this.btnCreateCom);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAddCompany";
            this.Text = "AGREGAR ALUMNO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddCompany_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblProyects;
        private System.Windows.Forms.ListBox lstboxProyects;
        private System.Windows.Forms.ComboBox cboxProyects;
        private System.Windows.Forms.Label lblDataCompany;
        private System.Windows.Forms.Button btnCreateCom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.Label lblCuilCom;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdressCom;
        private System.Windows.Forms.Label lblNameCom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreateProyect;
        private System.Windows.Forms.Button btnAddProyect;
    }
}