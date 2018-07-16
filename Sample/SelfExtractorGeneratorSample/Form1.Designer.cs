namespace SelfExtractorGeneratorSample
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSelectSelfExtractorExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectSelfExtractorExec = new System.Windows.Forms.TextBox();
            this.txtSelfExtractorContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelfExtractorContent = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 245);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(507, 60);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectSelfExtractorExec
            // 
            this.btnSelectSelfExtractorExec.Location = new System.Drawing.Point(447, 26);
            this.btnSelectSelfExtractorExec.Name = "btnSelectSelfExtractorExec";
            this.btnSelectSelfExtractorExec.Size = new System.Drawing.Size(89, 72);
            this.btnSelectSelfExtractorExec.TabIndex = 2;
            this.btnSelectSelfExtractorExec.Text = "Select";
            this.btnSelectSelfExtractorExec.UseVisualStyleBackColor = true;
            this.btnSelectSelfExtractorExec.Click += new System.EventHandler(this.btnSelectSelfExtractorExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the self extractor executable";
            // 
            // txtSelectSelfExtractorExec
            // 
            this.txtSelectSelfExtractorExec.Location = new System.Drawing.Point(29, 76);
            this.txtSelectSelfExtractorExec.Name = "txtSelectSelfExtractorExec";
            this.txtSelectSelfExtractorExec.ReadOnly = true;
            this.txtSelectSelfExtractorExec.Size = new System.Drawing.Size(380, 22);
            this.txtSelectSelfExtractorExec.TabIndex = 5;
            // 
            // txtSelfExtractorContent
            // 
            this.txtSelfExtractorContent.Location = new System.Drawing.Point(29, 185);
            this.txtSelfExtractorContent.Name = "txtSelfExtractorContent";
            this.txtSelfExtractorContent.ReadOnly = true;
            this.txtSelfExtractorContent.Size = new System.Drawing.Size(380, 22);
            this.txtSelfExtractorContent.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select the self extractor content folder";
            // 
            // btnSelfExtractorContent
            // 
            this.btnSelfExtractorContent.Location = new System.Drawing.Point(447, 135);
            this.btnSelfExtractorContent.Name = "btnSelfExtractorContent";
            this.btnSelfExtractorContent.Size = new System.Drawing.Size(89, 72);
            this.btnSelfExtractorContent.TabIndex = 6;
            this.btnSelfExtractorContent.Text = "Select";
            this.btnSelfExtractorContent.UseVisualStyleBackColor = true;
            this.btnSelfExtractorContent.Click += new System.EventHandler(this.btnSelfExtractorContent_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 316);
            this.Controls.Add(this.txtSelfExtractorContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelfExtractorContent);
            this.Controls.Add(this.txtSelectSelfExtractorExec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectSelfExtractorExec);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectSelfExtractorExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectSelfExtractorExec;
        private System.Windows.Forms.TextBox txtSelfExtractorContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelfExtractorContent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

