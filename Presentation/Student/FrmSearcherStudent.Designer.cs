namespace Presentation
{
    partial class FrmSearcherStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblSearcher = new System.Windows.Forms.Label();
            this.txtSearcher = new System.Windows.Forms.TextBox();
            this.btnModifyStu = new System.Windows.Forms.Button();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(47, -107);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "DATOS ALUMNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(36, 125);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(814, 251);
            this.dgvStudents.TabIndex = 9;
            // 
            // lblSearcher
            // 
            this.lblSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearcher.AutoSize = true;
            this.lblSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSearcher.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearcher.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSearcher.Location = new System.Drawing.Point(29, 45);
            this.lblSearcher.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSearcher.Name = "lblSearcher";
            this.lblSearcher.Size = new System.Drawing.Size(128, 37);
            this.lblSearcher.TabIndex = 10;
            this.lblSearcher.Text = "BUSCAR:";
            this.lblSearcher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearcher
            // 
            this.txtSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearcher.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearcher.Location = new System.Drawing.Point(168, 52);
            this.txtSearcher.Name = "txtSearcher";
            this.txtSearcher.Size = new System.Drawing.Size(176, 33);
            this.txtSearcher.TabIndex = 11;
            // 
            // btnModifyStu
            // 
            this.btnModifyStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyStu.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModifyStu.Location = new System.Drawing.Point(36, 423);
            this.btnModifyStu.Name = "btnModifyStu";
            this.btnModifyStu.Size = new System.Drawing.Size(308, 50);
            this.btnModifyStu.TabIndex = 12;
            this.btnModifyStu.Text = "MODIFICAR";
            this.btnModifyStu.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStu.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteStu.Location = new System.Drawing.Point(542, 423);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(308, 50);
            this.btnDeleteStu.TabIndex = 13;
            this.btnDeleteStu.Text = "ELIMINAR";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            // 
            // FrmSearcherStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(937, 531);
            this.Controls.Add(this.btnDeleteStu);
            this.Controls.Add(this.btnModifyStu);
            this.Controls.Add(this.txtSearcher);
            this.Controls.Add(this.lblSearcher);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSearcherStudent";
            this.Text = "BUSCAR ALUMNOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSearcherStudent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblSearcher;
        private System.Windows.Forms.TextBox txtSearcher;
        private System.Windows.Forms.Button btnModifyStu;
        private System.Windows.Forms.Button btnDeleteStu;
    }
}