namespace Presentation
{
    partial class FrmModifyStudent
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
            this.btnChangeData = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cboxData = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeData
            // 
            this.btnChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeData.Location = new System.Drawing.Point(187, 292);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(331, 50);
            this.btnChangeData.TabIndex = 20;
            this.btnChangeData.Text = "MODIFICAR ALUMNO";
            this.btnChangeData.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtValue.Location = new System.Drawing.Point(422, 187);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(225, 35);
            this.txtValue.TabIndex = 22;
            // 
            // cboxData
            // 
            this.cboxData.BackColor = System.Drawing.Color.DarkGray;
            this.cboxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxData.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxData.FormattingEnabled = true;
            this.cboxData.Items.AddRange(new object[] {
            "HOLA"});
            this.cboxData.Location = new System.Drawing.Point(23, 189);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(238, 29);
            this.cboxData.TabIndex = 19;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblData.Location = new System.Drawing.Point(16, 130);
            this.lblData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(245, 37);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "DATOS A CAMBIAR";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.AutoSize = true;
            this.lblValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblValue.Location = new System.Drawing.Point(358, 197);
            this.lblValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 21);
            this.lblValue.TabIndex = 21;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(870, 402);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cboxData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmModifyStudent";
            this.Text = "MODIFICAR ALUMNO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifyStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cboxData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValue;
    }
}