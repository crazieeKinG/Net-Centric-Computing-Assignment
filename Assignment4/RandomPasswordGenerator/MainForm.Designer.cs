namespace RandomPasswordGenerator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.letterCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // letterCount
            // 
            this.letterCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letterCount.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.letterCount.Location = new System.Drawing.Point(16, 42);
            this.letterCount.Name = "letterCount";
            this.letterCount.Size = new System.Drawing.Size(398, 26);
            this.letterCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter max range for password:";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Green;
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.continueButton.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(0, 80);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(447, 39);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 119);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterCount);
            this.Name = "MainForm";
            this.Text = "Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

