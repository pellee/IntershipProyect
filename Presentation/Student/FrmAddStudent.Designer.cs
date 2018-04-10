namespace Presentation
{
    partial class FrmAddStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxPreferences = new System.Windows.Forms.ComboBox();
            this.lstboxPreferences = new System.Windows.Forms.ListBox();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreateStu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblName.Location = new System.Drawing.Point(8, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOMBRE:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(183, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 43);
            this.txtName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtProm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 196);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtProm
            // 
            this.txtProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProm.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProm.Location = new System.Drawing.Point(183, 141);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(174, 43);
            this.txtProm.TabIndex = 6;
            // 
            // lblProm
            // 
            this.lblProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProm.AutoSize = true;
            this.lblProm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProm.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProm.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProm.Location = new System.Drawing.Point(8, 152);
            this.lblProm.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(164, 21);
            this.lblProm.TabIndex = 5;
            this.lblProm.Text = "PROMEDIO:";
            this.lblProm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.Location = new System.Drawing.Point(183, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 43);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLastName.Location = new System.Drawing.Point(8, 87);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(164, 21);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "APELLIDO:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATOS ALUMNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxPreferences
            // 
            this.cboxPreferences.BackColor = System.Drawing.Color.DarkGray;
            this.cboxPreferences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxPreferences.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPreferences.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxPreferences.FormattingEnabled = true;
            this.cboxPreferences.Items.AddRange(new object[] {
            "HOLA"});
            this.cboxPreferences.Location = new System.Drawing.Point(27, 321);
            this.cboxPreferences.Name = "cboxPreferences";
            this.cboxPreferences.Size = new System.Drawing.Size(360, 29);
            this.cboxPreferences.TabIndex = 8;
            // 
            // lstboxPreferences
            // 
            this.lstboxPreferences.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPreferences.FormattingEnabled = true;
            this.lstboxPreferences.ItemHeight = 30;
            this.lstboxPreferences.Location = new System.Drawing.Point(484, 106);
            this.lstboxPreferences.Name = "lstboxPreferences";
            this.lstboxPreferences.Size = new System.Drawing.Size(217, 244);
            this.lstboxPreferences.TabIndex = 9;
            // 
            // lblPreferences
            // 
            this.lblPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPreferences.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferences.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPreferences.Location = new System.Drawing.Point(477, 44);
            this.lblPreferences.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(194, 37);
            this.lblPreferences.TabIndex = 10;
            this.lblPreferences.Text = "PREFERENCIAS";
            this.lblPreferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(707, 106);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 41);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "QUITAR";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCreateStu
            // 
            this.btnCreateStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStu.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStu.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateStu.Location = new System.Drawing.Point(258, 478);
            this.btnCreateStu.Name = "btnCreateStu";
            this.btnCreateStu.Size = new System.Drawing.Size(349, 56);
            this.btnCreateStu.TabIndex = 14;
            this.btnCreateStu.Text = "CREAR ALUMNO";
            this.btnCreateStu.UseVisualStyleBackColor = true;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(897, 579);
            this.Controls.Add(this.btnCreateStu);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPreferences);
            this.Controls.Add(this.lstboxPreferences);
            this.Controls.Add(this.cboxPreferences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmAddStudent";
            this.Text = "AGREGAR ALUMNO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPreferences;
        private System.Windows.Forms.ListBox lstboxPreferences;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreateStu;
    }
}