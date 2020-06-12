namespace CharacterEditor
{
    partial class frmNewCharacter
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
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtArmor = new System.Windows.Forms.TextBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.txtShield = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.pctUploadedImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctUploadedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Armor";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(12, 70);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(35, 20);
            this.txtHP.TabIndex = 4;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(53, 70);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(35, 20);
            this.txtMP.TabIndex = 5;
            // 
            // txtArmor
            // 
            this.txtArmor.Location = new System.Drawing.Point(94, 70);
            this.txtArmor.Name = "txtArmor";
            this.txtArmor.Size = new System.Drawing.Size(35, 20);
            this.txtArmor.TabIndex = 6;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(12, 25);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(156, 20);
            this.txtCharacterName.TabIndex = 7;
            // 
            // txtShield
            // 
            this.txtShield.Location = new System.Drawing.Point(133, 70);
            this.txtShield.Name = "txtShield";
            this.txtShield.Size = new System.Drawing.Size(35, 20);
            this.txtShield.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shield";
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Location = new System.Drawing.Point(11, 201);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(157, 22);
            this.btnUploadPicture.TabIndex = 10;
            this.btnUploadPicture.Text = "Upload Picture";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            // 
            // pctUploadedImage
            // 
            this.pctUploadedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctUploadedImage.Location = new System.Drawing.Point(11, 106);
            this.pctUploadedImage.Name = "pctUploadedImage";
            this.pctUploadedImage.Size = new System.Drawing.Size(157, 89);
            this.pctUploadedImage.TabIndex = 11;
            this.pctUploadedImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Character";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.Location = new System.Drawing.Point(11, 246);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(157, 23);
            this.btnChangeSave.TabIndex = 13;
            this.btnChangeSave.Text = "Change Save Location";
            this.btnChangeSave.UseVisualStyleBackColor = true;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // frmNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 287);
            this.Controls.Add(this.btnChangeSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctUploadedImage);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.txtShield);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.txtArmor);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewCharacter";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmNewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctUploadedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtArmor;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.TextBox txtShield;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.PictureBox pctUploadedImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangeSave;
    }
}