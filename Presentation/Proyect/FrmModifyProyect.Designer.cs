namespace Presentation
{
    partial class FrmModifyProyect
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
            this.btnChangeData.Location = new System.Drawing.Point(230, 360);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(331, 50);
            this.btnChangeData.TabIndex = 25;
            this.btnChangeData.Text = "MODIFICAR PROYECTO";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtValue.Location = new System.Drawing.Point(496, 254);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(208, 33);
            this.txtValue.TabIndex = 27;
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
            this.cboxData.Location = new System.Drawing.Point(128, 254);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(238, 29);
            this.cboxData.TabIndex = 24;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblData.Location = new System.Drawing.Point(121, 150);
            this.lblData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(245, 37);
            this.lblData.TabIndex = 23;
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
            this.lblValue.Location = new System.Drawing.Point(474, 260);
            this.lblValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 21);
            this.lblValue.TabIndex = 26;
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmModifyProyect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(811, 531);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cboxData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmModifyProyect";
            this.Text = "FrmModifyProyect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifyProyect_FormClosed);
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