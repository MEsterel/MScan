﻿namespace MScan
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.numerizeBtn = new System.Windows.Forms.Button();
            this.parametersBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MScan";
            // 
            // numerizeBtn
            // 
            this.numerizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numerizeBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerizeBtn.Location = new System.Drawing.Point(127, 500);
            this.numerizeBtn.Name = "numerizeBtn";
            this.numerizeBtn.Size = new System.Drawing.Size(578, 53);
            this.numerizeBtn.TabIndex = 1;
            this.numerizeBtn.Text = "Numériser";
            this.numerizeBtn.UseVisualStyleBackColor = true;
            this.numerizeBtn.Click += new System.EventHandler(this.numerizeBtn_Click);
            // 
            // parametersBtn
            // 
            this.parametersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parametersBtn.Location = new System.Drawing.Point(12, 500);
            this.parametersBtn.Name = "parametersBtn";
            this.parametersBtn.Size = new System.Drawing.Size(109, 53);
            this.parametersBtn.TabIndex = 3;
            this.parametersBtn.Text = "Paramètres";
            this.parametersBtn.UseVisualStyleBackColor = true;
            this.parametersBtn.Click += new System.EventHandler(this.parametersBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Développé par Matthieu Badoy pour JMM (décembre 2019)";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.Location = new System.Drawing.Point(184, 32);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(98, 17);
            this.versionLbl.TabIndex = 10;
            this.versionLbl.Text = "Version 0.0.0.0";
            // 
            // pctBox
            // 
            this.pctBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBox.Location = new System.Drawing.Point(12, 59);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(693, 435);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox.TabIndex = 2;
            this.pctBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MScan.Properties.Resources.iconfinder_icon_128_document_scan_314709__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parametersBtn);
            this.Controls.Add(this.numerizeBtn);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MScan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button numerizeBtn;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button parametersBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label versionLbl;
    }
}

