namespace Presentation
{
    partial class FrmAddProyect
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
            this.btnCreateProyect = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.tlpProyect = new System.Windows.Forms.TableLayoutPanel();
            this.txtKindPro = new System.Windows.Forms.TextBox();
            this.lblHoursPro = new System.Windows.Forms.Label();
            this.lblKindPro = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHoursPro = new System.Windows.Forms.TextBox();
            this.tlpProyect2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblSlot = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.cboxCompanies = new System.Windows.Forms.ComboBox();
            this.lblCompanies = new System.Windows.Forms.Label();
            this.btnCreateCom = new System.Windows.Forms.Button();
            this.btnSelecCom = new System.Windows.Forms.Button();
            this.tlpProyect.SuspendLayout();
            this.tlpProyect2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateProyect
            // 
            this.btnCreateProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateProyect.Location = new System.Drawing.Point(314, 574);
            this.btnCreateProyect.Name = "btnCreateProyect";
            this.btnCreateProyect.Size = new System.Drawing.Size(349, 56);
            this.btnCreateProyect.TabIndex = 0;
            this.btnCreateProyect.Text = "CREAR PROYECTO";
            this.btnCreateProyect.UseVisualStyleBackColor = true;
            this.btnCreateProyect.Click += new System.EventHandler(this.btnCreateProyect_Click);
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbData.Location = new System.Drawing.Point(356, 48);
            this.lbData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(239, 37);
            this.lbData.TabIndex = 16;
            this.lbData.Text = "DATOS PROYECTO";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpProyect
            // 
            this.tlpProyect.ColumnCount = 2;
            this.tlpProyect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProyect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProyect.Controls.Add(this.txtKindPro, 1, 2);
            this.tlpProyect.Controls.Add(this.lblHoursPro, 0, 3);
            this.tlpProyect.Controls.Add(this.lblKindPro, 0, 2);
            this.tlpProyect.Controls.Add(this.txtGoal, 1, 1);
            this.tlpProyect.Controls.Add(this.lblGoal, 0, 1);
            this.tlpProyect.Controls.Add(this.lblName, 0, 0);
            this.tlpProyect.Controls.Add(this.txtName, 1, 0);
            this.tlpProyect.Controls.Add(this.txtHoursPro, 1, 3);
            this.tlpProyect.Location = new System.Drawing.Point(68, 112);
            this.tlpProyect.Name = "tlpProyect";
            this.tlpProyect.RowCount = 4;
            this.tlpProyect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProyect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProyect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProyect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProyect.Size = new System.Drawing.Size(360, 196);
            this.tlpProyect.TabIndex = 15;
            // 
            // txtKindPro
            // 
            this.txtKindPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKindPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKindPro.Location = new System.Drawing.Point(183, 106);
            this.txtKindPro.Name = "txtKindPro";
            this.txtKindPro.Size = new System.Drawing.Size(174, 33);
            this.txtKindPro.TabIndex = 2;
            // 
            // lblHoursPro
            // 
            this.lblHoursPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoursPro.AutoSize = true;
            this.lblHoursPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHoursPro.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPro.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblHoursPro.Location = new System.Drawing.Point(8, 161);
            this.lblHoursPro.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblHoursPro.Name = "lblHoursPro";
            this.lblHoursPro.Size = new System.Drawing.Size(164, 21);
            this.lblHoursPro.TabIndex = 7;
            this.lblHoursPro.Text = "HORAS PROYECTO:";
            this.lblHoursPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKindPro
            // 
            this.lblKindPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKindPro.AutoSize = true;
            this.lblKindPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKindPro.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKindPro.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblKindPro.Location = new System.Drawing.Point(8, 112);
            this.lblKindPro.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblKindPro.Name = "lblKindPro";
            this.lblKindPro.Size = new System.Drawing.Size(164, 21);
            this.lblKindPro.TabIndex = 5;
            this.lblKindPro.Text = "TIPO PROYECTO:";
            this.lblKindPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGoal
            // 
            this.txtGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGoal.Location = new System.Drawing.Point(183, 57);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(174, 33);
            this.txtGoal.TabIndex = 1;
            // 
            // lblGoal
            // 
            this.lblGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoal.AutoSize = true;
            this.lblGoal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGoal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblGoal.Location = new System.Drawing.Point(8, 63);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(164, 21);
            this.lblGoal.TabIndex = 3;
            this.lblGoal.Text = "OBJETIVO:";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblName.Location = new System.Drawing.Point(8, 14);
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
            this.txtName.Location = new System.Drawing.Point(183, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 33);
            this.txtName.TabIndex = 0;
            // 
            // txtHoursPro
            // 
            this.txtHoursPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoursPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHoursPro.Location = new System.Drawing.Point(183, 155);
            this.txtHoursPro.Name = "txtHoursPro";
            this.txtHoursPro.Size = new System.Drawing.Size(174, 33);
            this.txtHoursPro.TabIndex = 3;
            // 
            // tlpProyect2
            // 
            this.tlpProyect2.ColumnCount = 2;
            this.tlpProyect2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProyect2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProyect2.Controls.Add(this.dtpEndDate, 1, 2);
            this.tlpProyect2.Controls.Add(this.lblEndDate, 0, 2);
            this.tlpProyect2.Controls.Add(this.lblStartDate, 0, 1);
            this.tlpProyect2.Controls.Add(this.dtpStartDate, 1, 1);
            this.tlpProyect2.Controls.Add(this.lblSlot, 0, 0);
            this.tlpProyect2.Controls.Add(this.txtSlot, 1, 0);
            this.tlpProyect2.Location = new System.Drawing.Point(509, 112);
            this.tlpProyect2.Name = "tlpProyect2";
            this.tlpProyect2.RowCount = 3;
            this.tlpProyect2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProyect2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProyect2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProyect2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProyect2.Size = new System.Drawing.Size(360, 196);
            this.tlpProyect2.TabIndex = 22;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(183, 146);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(174, 33);
            this.dtpEndDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEndDate.Location = new System.Drawing.Point(8, 152);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(164, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "FECHA FIN:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStartDate.Location = new System.Drawing.Point(8, 87);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(164, 21);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "FECHA INICIO:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(183, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(174, 33);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblSlot
            // 
            this.lblSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlot.AutoSize = true;
            this.lblSlot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSlot.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSlot.Location = new System.Drawing.Point(8, 22);
            this.lblSlot.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(164, 21);
            this.lblSlot.TabIndex = 1;
            this.lblSlot.Text = "VACANTES:";
            this.lblSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSlot
            // 
            this.txtSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSlot.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSlot.Location = new System.Drawing.Point(183, 16);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(174, 33);
            this.txtSlot.TabIndex = 0;
            // 
            // cboxCompanies
            // 
            this.cboxCompanies.BackColor = System.Drawing.Color.DimGray;
            this.cboxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCompanies.FormattingEnabled = true;
            this.cboxCompanies.Location = new System.Drawing.Point(68, 421);
            this.cboxCompanies.Name = "cboxCompanies";
            this.cboxCompanies.Size = new System.Drawing.Size(357, 33);
            this.cboxCompanies.TabIndex = 23;
            // 
            // lblCompanies
            // 
            this.lblCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCompanies.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanies.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCompanies.Location = new System.Drawing.Point(61, 361);
            this.lblCompanies.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(288, 37);
            this.lblCompanies.TabIndex = 24;
            this.lblCompanies.Text = "SELECCIONE EMPRESA";
            this.lblCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateCom
            // 
            this.btnCreateCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCom.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateCom.Location = new System.Drawing.Point(299, 474);
            this.btnCreateCom.Name = "btnCreateCom";
            this.btnCreateCom.Size = new System.Drawing.Size(126, 30);
            this.btnCreateCom.TabIndex = 25;
            this.btnCreateCom.Text = "CREAR EMPRESA";
            this.btnCreateCom.UseVisualStyleBackColor = true;
            // 
            // btnSelecCom
            // 
            this.btnSelecCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCom.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelecCom.Location = new System.Drawing.Point(68, 474);
            this.btnSelecCom.Name = "btnSelecCom";
            this.btnSelecCom.Size = new System.Drawing.Size(126, 30);
            this.btnSelecCom.TabIndex = 26;
            this.btnSelecCom.Text = "SELEC EMPRESA";
            this.btnSelecCom.UseVisualStyleBackColor = true;
            this.btnSelecCom.Click += new System.EventHandler(this.btnSelecCom_Click);
            // 
            // FrmAddProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(919, 658);
            this.Controls.Add(this.btnSelecCom);
            this.Controls.Add(this.btnCreateCom);
            this.Controls.Add(this.lblCompanies);
            this.Controls.Add(this.cboxCompanies);
            this.Controls.Add(this.tlpProyect2);
            this.Controls.Add(this.btnCreateProyect);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.tlpProyect);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddProyect";
            this.Text = "AGREGAR PROYECTO";
            this.tlpProyect.ResumeLayout(false);
            this.tlpProyect.PerformLayout();
            this.tlpProyect2.ResumeLayout(false);
            this.tlpProyect2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProyect;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TableLayoutPanel tlpProyect;
        private System.Windows.Forms.TextBox txtKindPro;
        private System.Windows.Forms.Label lblKindPro;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHoursPro;
        private System.Windows.Forms.TextBox txtHoursPro;
        private System.Windows.Forms.TableLayoutPanel tlpProyect2;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboxCompanies;
        private System.Windows.Forms.Label lblCompanies;
        private System.Windows.Forms.Button btnCreateCom;
        private System.Windows.Forms.Button btnSelecCom;
    }
}