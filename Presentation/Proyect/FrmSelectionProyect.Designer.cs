namespace Presentation
{
    partial class FrmSelectionProyect
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
            this.btnAddProyect = new System.Windows.Forms.Button();
            this.btnSearchProyect = new System.Windows.Forms.Button();
            this.tlpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainMenu
            // 
            this.tlpMainMenu.ColumnCount = 2;
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainMenu.Controls.Add(this.btnAddProyect, 0, 0);
            this.tlpMainMenu.Controls.Add(this.btnSearchProyect, 0, 1);
            this.tlpMainMenu.Location = new System.Drawing.Point(184, 155);
            this.tlpMainMenu.Name = "tlpMainMenu";
            this.tlpMainMenu.RowCount = 2;
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainMenu.Size = new System.Drawing.Size(435, 172);
            this.tlpMainMenu.TabIndex = 1;
            // 
            // btnAddProyect
            // 
            this.btnAddProyect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainMenu.SetColumnSpan(this.btnAddProyect, 2);
            this.btnAddProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProyect.Location = new System.Drawing.Point(3, 15);
            this.btnAddProyect.Name = "btnAddProyect";
            this.btnAddProyect.Size = new System.Drawing.Size(429, 56);
            this.btnAddProyect.TabIndex = 15;
            this.btnAddProyect.Text = "AGREGAR";
            this.btnAddProyect.UseVisualStyleBackColor = true;
            this.btnAddProyect.Click += new System.EventHandler(this.btnAddProyect_Click);
            // 
            // btnSearchProyect
            // 
            this.btnSearchProyect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainMenu.SetColumnSpan(this.btnSearchProyect, 2);
            this.btnSearchProyect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProyect.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProyect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchProyect.Location = new System.Drawing.Point(3, 101);
            this.btnSearchProyect.Name = "btnSearchProyect";
            this.btnSearchProyect.Size = new System.Drawing.Size(429, 56);
            this.btnSearchProyect.TabIndex = 17;
            this.btnSearchProyect.Text = "BUSCAR";
            this.btnSearchProyect.UseVisualStyleBackColor = true;
            this.btnSearchProyect.Click += new System.EventHandler(this.btnSearchProyect_Click);
            // 
            // FrmSelectionProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(822, 456);
            this.Controls.Add(this.tlpMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSelectionProyect";
            this.Text = "SELECIÓN ACCIÓN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSelectionProyect_FormClosed);
            this.tlpMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainMenu;
        private System.Windows.Forms.Button btnAddProyect;
        private System.Windows.Forms.Button btnSearchProyect;
    }
}