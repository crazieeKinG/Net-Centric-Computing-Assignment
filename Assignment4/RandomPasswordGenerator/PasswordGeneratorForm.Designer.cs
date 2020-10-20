namespace RandomPasswordGenerator
{
    partial class PasswordGeneratorForm
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
            this.letterCountBar = new System.Windows.Forms.TrackBar();
            this.generatedPassword = new System.Windows.Forms.TextBox();
            this.specialCharacter = new System.Windows.Forms.CheckBox();
            this.number = new System.Windows.Forms.CheckBox();
            this.capitalLetter = new System.Windows.Forms.CheckBox();
            this.smallLetter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.letterCountBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generated Password: ";
            // 
            // letterCountBar
            // 
            this.letterCountBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letterCountBar.Location = new System.Drawing.Point(13, 85);
            this.letterCountBar.Name = "letterCountBar";
            this.letterCountBar.Size = new System.Drawing.Size(450, 45);
            this.letterCountBar.TabIndex = 4;
            this.letterCountBar.Value = 8;
            this.letterCountBar.Scroll += new System.EventHandler(this.LetterCountBar_Scroll);
            // 
            // generatedPassword
            // 
            this.generatedPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPassword.Location = new System.Drawing.Point(12, 44);
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.Size = new System.Drawing.Size(451, 26);
            this.generatedPassword.TabIndex = 3;
            // 
            // specialCharacter
            // 
            this.specialCharacter.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharacter.Location = new System.Drawing.Point(356, 146);
            this.specialCharacter.Name = "specialCharacter";
            this.specialCharacter.Size = new System.Drawing.Size(107, 23);
            this.specialCharacter.TabIndex = 9;
            this.specialCharacter.Text = "$@#";
            this.specialCharacter.UseVisualStyleBackColor = true;
            this.specialCharacter.CheckedChanged += new System.EventHandler(this.SpecialCharacter_CheckedChanged);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(241, 146);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(109, 23);
            this.number.TabIndex = 10;
            this.number.Text = "0-9";
            this.number.UseVisualStyleBackColor = true;
            this.number.CheckedChanged += new System.EventHandler(this.Number_CheckedChanged);
            // 
            // capitalLetter
            // 
            this.capitalLetter.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalLetter.Location = new System.Drawing.Point(127, 146);
            this.capitalLetter.Name = "capitalLetter";
            this.capitalLetter.Size = new System.Drawing.Size(108, 23);
            this.capitalLetter.TabIndex = 11;
            this.capitalLetter.Text = "A-Z";
            this.capitalLetter.UseVisualStyleBackColor = true;
            this.capitalLetter.CheckedChanged += new System.EventHandler(this.CapitalLetter_CheckedChanged);
            // 
            // smallLetter
            // 
            this.smallLetter.Checked = true;
            this.smallLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smallLetter.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallLetter.Location = new System.Drawing.Point(12, 146);
            this.smallLetter.Name = "smallLetter";
            this.smallLetter.Size = new System.Drawing.Size(109, 23);
            this.smallLetter.TabIndex = 12;
            this.smallLetter.Text = "a-z";
            this.smallLetter.UseVisualStyleBackColor = true;
            this.smallLetter.CheckedChanged += new System.EventHandler(this.smallLetter_CheckedChanged);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 276);
            this.Controls.Add(this.smallLetter);
            this.Controls.Add(this.capitalLetter);
            this.Controls.Add(this.number);
            this.Controls.Add(this.specialCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterCountBar);
            this.Controls.Add(this.generatedPassword);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Random Password Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordGeneratorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.letterCountBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar letterCountBar;
        private System.Windows.Forms.TextBox generatedPassword;
        private System.Windows.Forms.CheckBox specialCharacter;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.CheckBox capitalLetter;
        private System.Windows.Forms.CheckBox smallLetter;
    }
}