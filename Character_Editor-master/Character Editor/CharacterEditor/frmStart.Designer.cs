namespace CharacterEditor
{
    partial class frmStart
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
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.btnLoadCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCharacter.Location = new System.Drawing.Point(12, 3);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(217, 81);
            this.btnNewCharacter.TabIndex = 0;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // btnLoadCharacter
            // 
            this.btnLoadCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCharacter.Location = new System.Drawing.Point(12, 90);
            this.btnLoadCharacter.Name = "btnLoadCharacter";
            this.btnLoadCharacter.Size = new System.Drawing.Size(217, 86);
            this.btnLoadCharacter.TabIndex = 1;
            this.btnLoadCharacter.Text = "Load Character";
            this.btnLoadCharacter.UseVisualStyleBackColor = true;
            this.btnLoadCharacter.Click += new System.EventHandler(this.btnLoadCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(131, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 252);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadCharacter);
            this.Controls.Add(this.btnNewCharacter);
            this.Name = "frmStart";
            this.Text = "Character Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.Button btnLoadCharacter;
        private System.Windows.Forms.Button btnExit;
    }
}

