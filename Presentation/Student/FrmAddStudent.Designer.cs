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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPreference = new System.Windows.Forms.Label();
            this.txtPreference = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstboxPreferences = new System.Windows.Forms.ListBox();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.btnAddPreference = new System.Windows.Forms.Button();
            this.btnCreateStu = new System.Windows.Forms.Button();
            this.gboxPreferences = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gboxPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblName.Location = new System.Drawing.Point(8, 61);
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
            this.txtName.Location = new System.Drawing.Point(183, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 43);
            this.txtName.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDni, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDni, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtProm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 244);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDni.Location = new System.Drawing.Point(183, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(174, 43);
            this.txtDni.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDni.AutoSize = true;
            this.lblDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDni.Location = new System.Drawing.Point(8, 13);
            this.lblDni.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(164, 21);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreference
            // 
            this.lblPreference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreference.AutoSize = true;
            this.lblPreference.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPreference.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreference.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPreference.Location = new System.Drawing.Point(28, 95);
            this.lblPreference.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreference.Name = "lblPreference";
            this.lblPreference.Size = new System.Drawing.Size(87, 17);
            this.lblPreference.TabIndex = 0;
            this.lblPreference.Text = "PREFERENCIA";
            this.lblPreference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPreference
            // 
            this.txtPreference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreference.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPreference.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreference.Location = new System.Drawing.Point(31, 124);
            this.txtPreference.Name = "txtPreference";
            this.txtPreference.Size = new System.Drawing.Size(122, 29);
            this.txtPreference.TabIndex = 1;
            // 
            // lblProm
            // 
            this.lblProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProm.AutoSize = true;
            this.lblProm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProm.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProm.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProm.Location = new System.Drawing.Point(8, 157);
            this.lblProm.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(164, 21);
            this.lblProm.TabIndex = 3;
            this.lblProm.Text = "PROMEDIO:";
            this.lblProm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProm
            // 
            this.txtProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProm.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProm.Location = new System.Drawing.Point(183, 147);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(174, 43);
            this.txtProm.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLastName.Location = new System.Drawing.Point(8, 109);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(164, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "APELLIDO:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.Location = new System.Drawing.Point(183, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 43);
            this.txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS ALUMNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxPreferences
            // 
            this.lstboxPreferences.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPreferences.FormattingEnabled = true;
            this.lstboxPreferences.ItemHeight = 21;
            this.lstboxPreferences.Location = new System.Drawing.Point(257, 79);
            this.lstboxPreferences.Name = "lstboxPreferences";
            this.lstboxPreferences.Size = new System.Drawing.Size(133, 214);
            this.lstboxPreferences.TabIndex = 4;
            // 
            // lblPreferences
            // 
            this.lblPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPreferences.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferences.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPreferences.Location = new System.Drawing.Point(253, 52);
            this.lblPreferences.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(116, 21);
            this.lblPreferences.TabIndex = 3;
            this.lblPreferences.Text = "PREFERENCIAS";
            this.lblPreferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPreference
            // 
            this.btnAddPreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPreference.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPreference.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddPreference.Location = new System.Drawing.Point(31, 165);
            this.btnAddPreference.Name = "btnAddPreference";
            this.btnAddPreference.Size = new System.Drawing.Size(89, 29);
            this.btnAddPreference.TabIndex = 2;
            this.btnAddPreference.Text = "AGREGAR";
            this.btnAddPreference.UseVisualStyleBackColor = true;
            this.btnAddPreference.Click += new System.EventHandler(this.btnAddPreference_Click);
            // 
            // btnCreateStu
            // 
            this.btnCreateStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStu.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStu.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateStu.Location = new System.Drawing.Point(210, 403);
            this.btnCreateStu.Name = "btnCreateStu";
            this.btnCreateStu.Size = new System.Drawing.Size(392, 56);
            this.btnCreateStu.TabIndex = 3;
            this.btnCreateStu.Text = "CREAR ALUMNO";
            this.btnCreateStu.UseVisualStyleBackColor = true;
            this.btnCreateStu.Click += new System.EventHandler(this.btnCreateStu_Click);
            // 
            // gboxPreferences
            // 
            this.gboxPreferences.Controls.Add(this.lblPreference);
            this.gboxPreferences.Controls.Add(this.txtPreference);
            this.gboxPreferences.Controls.Add(this.btnAddPreference);
            this.gboxPreferences.Controls.Add(this.lblPreferences);
            this.gboxPreferences.Controls.Add(this.lstboxPreferences);
            this.gboxPreferences.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gboxPreferences.Location = new System.Drawing.Point(416, 40);
            this.gboxPreferences.Name = "gboxPreferences";
            this.gboxPreferences.Size = new System.Drawing.Size(419, 310);
            this.gboxPreferences.TabIndex = 2;
            this.gboxPreferences.TabStop = false;
            this.gboxPreferences.Text = "AGREGAR PREFERENCIAS";
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(923, 522);
            this.Controls.Add(this.gboxPreferences);
            this.Controls.Add(this.btnCreateStu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmAddStudent";
            this.Text = "AGREGAR ALUMNO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gboxPreferences.ResumeLayout(false);
            this.gboxPreferences.PerformLayout();
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
        private System.Windows.Forms.ListBox lstboxPreferences;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.Button btnAddPreference;
        private System.Windows.Forms.Button btnCreateStu;
        private System.Windows.Forms.TextBox txtPreference;
        private System.Windows.Forms.Label lblPreference;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox gboxPreferences;
    }
}