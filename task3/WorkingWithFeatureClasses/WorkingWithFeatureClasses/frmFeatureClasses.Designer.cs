
namespace WorkingWithFeatureClasses
{
    partial class frmFeatureClasses
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
            this.cboLayers = new System.Windows.Forms.ComboBox();
            this.GetValues = new System.Windows.Forms.Button();
            this.cboFields = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layers";
            // 
            // cboLayers
            // 
            this.cboLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLayers.FormattingEnabled = true;
            this.cboLayers.Location = new System.Drawing.Point(224, 16);
            this.cboLayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLayers.Name = "cboLayers";
            this.cboLayers.Size = new System.Drawing.Size(292, 24);
            this.cboLayers.TabIndex = 1;
            this.cboLayers.SelectedIndexChanged += new System.EventHandler(this.cboLayers_SelectedIndexChanged);
            // 
            // GetValues
            // 
            this.GetValues.Location = new System.Drawing.Point(224, 116);
            this.GetValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetValues.Name = "GetValues";
            this.GetValues.Size = new System.Drawing.Size(109, 28);
            this.GetValues.TabIndex = 3;
            this.GetValues.Text = "Get Values";
            this.GetValues.UseVisualStyleBackColor = true;
            this.GetValues.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboFields
            // 
            this.cboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFields.FormattingEnabled = true;
            this.cboFields.Location = new System.Drawing.Point(224, 63);
            this.cboFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFields.Name = "cboFields";
            this.cboFields.Size = new System.Drawing.Size(292, 24);
            this.cboFields.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fields";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 116);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmFeatureClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 170);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFields);
            this.Controls.Add(this.GetValues);
            this.Controls.Add(this.cboLayers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFeatureClasses";
            this.Text = "Working With FeatureClasses";
            this.Load += new System.EventHandler(this.frmFeatureClasses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLayers;
        private System.Windows.Forms.Button GetValues;
        private System.Windows.Forms.ComboBox cboFields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}