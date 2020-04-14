namespace MScan
{
    partial class BonjourForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.preciseBtn = new System.Windows.Forms.Button();
            this.mailBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sélectionnez un pré-réglage de qualité :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "(photos, documents)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "(scan très long)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "(fichier léger)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 47);
            this.label5.TabIndex = 7;
            this.label5.Text = "MScan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MScan.Properties.Resources.iconfinder_icon_128_document_scan_314709__2_;
            this.pictureBox1.Location = new System.Drawing.Point(99, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // preciseBtn
            // 
            this.preciseBtn.Image = global::MScan.Properties.Resources.star64;
            this.preciseBtn.Location = new System.Drawing.Point(15, 126);
            this.preciseBtn.Name = "preciseBtn";
            this.preciseBtn.Size = new System.Drawing.Size(108, 96);
            this.preciseBtn.TabIndex = 4;
            this.preciseBtn.Text = "Très précis";
            this.preciseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.preciseBtn.UseVisualStyleBackColor = true;
            this.preciseBtn.Click += new System.EventHandler(this.preciseBtn_Click);
            // 
            // mailBtn
            // 
            this.mailBtn.Image = global::MScan.Properties.Resources.mail64;
            this.mailBtn.Location = new System.Drawing.Point(263, 126);
            this.mailBtn.Name = "mailBtn";
            this.mailBtn.Size = new System.Drawing.Size(108, 96);
            this.mailBtn.TabIndex = 1;
            this.mailBtn.Text = "Mail";
            this.mailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mailBtn.UseVisualStyleBackColor = true;
            this.mailBtn.Click += new System.EventHandler(this.mailBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Image = global::MScan.Properties.Resources.imageFile64;
            this.normalBtn.Location = new System.Drawing.Point(139, 126);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(108, 96);
            this.normalBtn.TabIndex = 0;
            this.normalBtn.Text = "Normal";
            this.normalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // BonjourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preciseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailBtn);
            this.Controls.Add(this.normalBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BonjourForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonjour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BonjourForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button mailBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button preciseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}