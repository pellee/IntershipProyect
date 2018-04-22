namespace Presentation
{
    partial class FrmSearcherProyect
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
            this.btnModifyPro = new System.Windows.Forms.Button();
            this.txtSearcher = new System.Windows.Forms.TextBox();
            this.lblSearcher = new System.Windows.Forms.Label();
            this.dgvProyects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyPro
            // 
            this.btnModifyPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPro.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModifyPro.Location = new System.Drawing.Point(346, 419);
            this.btnModifyPro.Name = "btnModifyPro";
            this.btnModifyPro.Size = new System.Drawing.Size(308, 50);
            this.btnModifyPro.TabIndex = 22;
            this.btnModifyPro.Text = "MODIFICAR";
            this.btnModifyPro.UseVisualStyleBackColor = true;
            this.btnModifyPro.Click += new System.EventHandler(this.btnModifyPro_Click);
            // 
            // txtSearcher
            // 
            this.txtSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearcher.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearcher.Location = new System.Drawing.Point(216, 45);
            this.txtSearcher.Name = "txtSearcher";
            this.txtSearcher.Size = new System.Drawing.Size(199, 33);
            this.txtSearcher.TabIndex = 21;
            // 
            // lblSearcher
            // 
            this.lblSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearcher.AutoSize = true;
            this.lblSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSearcher.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearcher.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSearcher.Location = new System.Drawing.Point(65, 38);
            this.lblSearcher.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSearcher.Name = "lblSearcher";
            this.lblSearcher.Size = new System.Drawing.Size(128, 37);
            this.lblSearcher.TabIndex = 20;
            this.lblSearcher.Text = "BUSCAR:";
            this.lblSearcher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProyects
            // 
            this.dgvProyects.AllowUserToAddRows = false;
            this.dgvProyects.AllowUserToDeleteRows = false;
            this.dgvProyects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProyects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyects.Location = new System.Drawing.Point(72, 128);
            this.dgvProyects.Name = "dgvProyects";
            this.dgvProyects.ReadOnly = true;
            this.dgvProyects.RowHeadersVisible = false;
            this.dgvProyects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyects.Size = new System.Drawing.Size(814, 251);
            this.dgvProyects.TabIndex = 19;
            // 
            // FrmSearcherProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(930, 511);
            this.Controls.Add(this.btnModifyPro);
            this.Controls.Add(this.txtSearcher);
            this.Controls.Add(this.lblSearcher);
            this.Controls.Add(this.dgvProyects);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSearcherProyect";
            this.Text = "BUSCAR PROYECTO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSearcherProyect_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyPro;
        private System.Windows.Forms.TextBox txtSearcher;
        private System.Windows.Forms.Label lblSearcher;
        private System.Windows.Forms.DataGridView dgvProyects;
    }
}