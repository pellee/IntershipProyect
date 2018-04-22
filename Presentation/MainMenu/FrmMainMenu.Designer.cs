namespace Presentation
{
    partial class FrmMainMenu
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
            this.tlpMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnProyect = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.tlpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainMenu
            // 
            this.tlpMainMenu.ColumnCount = 2;
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainMenu.Controls.Add(this.btnProyect, 0, 2);
            this.tlpMainMenu.Controls.Add(this.btnStudent, 0, 0);
            this.tlpMainMenu.Controls.Add(this.btnCompany, 0, 1);
            this.tlpMainMenu.Location = new System.Drawing.Point(241, 56);
            this.tlpMainMenu.Name = "tlpMainMenu";
            this.tlpMainMenu.RowCount = 3;
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainMenu.Size = new System.Drawing.Size(448, 317);
            this.tlpMainMenu.TabIndex = 0;
            // 
            // btnProyect
            // 
            this.btnProyect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainMenu.SetColumnSpan(this.btnProyect, 2);
            this.btnProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProyect.Location = new System.Drawing.Point(3, 235);
            this.btnProyect.Name = "btnProyect";
            this.btnProyect.Size = new System.Drawing.Size(442, 56);
            this.btnProyect.TabIndex = 17;
            this.btnProyect.Text = "PROYECTO";
            this.btnProyect.UseVisualStyleBackColor = true;
            this.btnProyect.Click += new System.EventHandler(this.btnProyect_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainMenu.SetColumnSpan(this.btnStudent, 2);
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStudent.Location = new System.Drawing.Point(3, 24);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(442, 56);
            this.btnStudent.TabIndex = 15;
            this.btnStudent.Text = "ALUMNO";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // btnCompany
            // 
            this.btnCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainMenu.SetColumnSpan(this.btnCompany, 2);
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCompany.Location = new System.Drawing.Point(3, 129);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(442, 56);
            this.btnCompany.TabIndex = 16;
            this.btnCompany.Text = "EMPRESA";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(918, 441);
            this.Controls.Add(this.tlpMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMainMenu";
            this.Text = "MENÚ PRINCIPAL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainMenu_FormClosed);
            this.tlpMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainMenu;
        private System.Windows.Forms.Button btnProyect;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnCompany;
    }
}