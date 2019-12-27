namespace MScan
{
    partial class ParamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okayBtn = new System.Windows.Forms.Button();
            this.printersLstBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpiCmbBox = new System.Windows.Forms.ComboBox();
            this.networkPrefChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paramètres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choix du scanner :";
            // 
            // okayBtn
            // 
            this.okayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayBtn.Location = new System.Drawing.Point(362, 410);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(86, 29);
            this.okayBtn.TabIndex = 3;
            this.okayBtn.Text = "OK";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // printersLstBox
            // 
            this.printersLstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printersLstBox.FormattingEnabled = true;
            this.printersLstBox.ItemHeight = 17;
            this.printersLstBox.Location = new System.Drawing.Point(12, 64);
            this.printersLstBox.Name = "printersLstBox";
            this.printersLstBox.Size = new System.Drawing.Size(436, 208);
            this.printersLstBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emplacement de sauvegarde :";
            // 
            // pathTxt
            // 
            this.pathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTxt.Location = new System.Drawing.Point(12, 322);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(436, 25);
            this.pathTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qualité (nombre de DPI) :";
            // 
            // dpiCmbBox
            // 
            this.dpiCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpiCmbBox.FormattingEnabled = true;
            this.dpiCmbBox.Items.AddRange(new object[] {
            "75",
            "100",
            "150",
            "200",
            "300",
            "400",
            "600",
            "1200"});
            this.dpiCmbBox.Location = new System.Drawing.Point(174, 355);
            this.dpiCmbBox.Name = "dpiCmbBox";
            this.dpiCmbBox.Size = new System.Drawing.Size(274, 25);
            this.dpiCmbBox.TabIndex = 8;
            // 
            // networkPrefChk
            // 
            this.networkPrefChk.AutoSize = true;
            this.networkPrefChk.Location = new System.Drawing.Point(12, 278);
            this.networkPrefChk.Name = "networkPrefChk";
            this.networkPrefChk.Size = new System.Drawing.Size(209, 21);
            this.networkPrefChk.TabIndex = 9;
            this.networkPrefChk.Text = "Privilégier les scanneurs réseau";
            this.networkPrefChk.UseVisualStyleBackColor = true;
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 451);
            this.Controls.Add(this.networkPrefChk);
            this.Controls.Add(this.dpiCmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printersLstBox);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.ListBox printersLstBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dpiCmbBox;
        private System.Windows.Forms.CheckBox networkPrefChk;
    }
}