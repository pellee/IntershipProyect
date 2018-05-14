namespace Presentation
{
    partial class FrmAssignaments
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
            this.cboxStudents = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCreateAssignaments = new System.Windows.Forms.Button();
            this.lstboxShowStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboxStudents
            // 
            this.cboxStudents.BackColor = System.Drawing.Color.DimGray;
            this.cboxStudents.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboxStudents.FormattingEnabled = true;
            this.cboxStudents.Items.AddRange(new object[] {
            "ALUMNOS ASIGNADOS A PROYECTOS",
            "ALUMNOS NO ASIGNADOS A PROYECTOS"});
            this.cboxStudents.Location = new System.Drawing.Point(252, 130);
            this.cboxStudents.Name = "cboxStudents";
            this.cboxStudents.Size = new System.Drawing.Size(349, 29);
            this.cboxStudents.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbData.Location = new System.Drawing.Point(4, 120);
            this.lbData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(151, 37);
            this.lbData.TabIndex = 17;
            this.lbData.Text = "ALUMNOS ";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccept.Location = new System.Drawing.Point(719, 130);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(125, 29);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "ACEPTAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCreateAssignaments
            // 
            this.btnCreateAssignaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAssignaments.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAssignaments.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateAssignaments.Location = new System.Drawing.Point(122, 27);
            this.btnCreateAssignaments.Name = "btnCreateAssignaments";
            this.btnCreateAssignaments.Size = new System.Drawing.Size(614, 56);
            this.btnCreateAssignaments.TabIndex = 19;
            this.btnCreateAssignaments.Text = "CREAR ASIGNACIONES";
            this.btnCreateAssignaments.UseVisualStyleBackColor = true;
            this.btnCreateAssignaments.Click += new System.EventHandler(this.btnCreateAssignaments_Click);
            // 
            // lstboxShowStudents
            // 
            this.lstboxShowStudents.FormattingEnabled = true;
            this.lstboxShowStudents.ItemHeight = 21;
            this.lstboxShowStudents.Location = new System.Drawing.Point(11, 190);
            this.lstboxShowStudents.Name = "lstboxShowStudents";
            this.lstboxShowStudents.Size = new System.Drawing.Size(833, 361);
            this.lstboxShowStudents.TabIndex = 20;
            // 
            // FrmAssignaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(874, 584);
            this.Controls.Add(this.lstboxShowStudents);
            this.Controls.Add(this.btnCreateAssignaments);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.cboxStudents);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAssignaments";
            this.Text = "FrmAssignaments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxStudents;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCreateAssignaments;
        private System.Windows.Forms.ListBox lstboxShowStudents;
    }
}