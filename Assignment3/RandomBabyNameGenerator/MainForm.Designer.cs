namespace RandomBabyNameGenerator
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
            this.generateGirlNameButton = new System.Windows.Forms.Button();
            this.girlNameLabel = new System.Windows.Forms.Label();
            this.generateBoyNameButton = new System.Windows.Forms.Button();
            this.boyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateGirlNameButton
            // 
            this.generateGirlNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateGirlNameButton.BackColor = System.Drawing.Color.DeepPink;
            this.generateGirlNameButton.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGirlNameButton.ForeColor = System.Drawing.Color.White;
            this.generateGirlNameButton.Location = new System.Drawing.Point(348, 56);
            this.generateGirlNameButton.Name = "generateGirlNameButton";
            this.generateGirlNameButton.Size = new System.Drawing.Size(269, 44);
            this.generateGirlNameButton.TabIndex = 7;
            this.generateGirlNameButton.Text = "Generate";
            this.generateGirlNameButton.UseVisualStyleBackColor = false;
            this.generateGirlNameButton.Click += new System.EventHandler(this.GenerateGirlNameButton_Click);
            // 
            // girlNameLabel
            // 
            this.girlNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girlNameLabel.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girlNameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.girlNameLabel.Location = new System.Drawing.Point(348, 9);
            this.girlNameLabel.Name = "girlNameLabel";
            this.girlNameLabel.Size = new System.Drawing.Size(269, 44);
            this.girlNameLabel.TabIndex = 6;
            this.girlNameLabel.Text = "Baby Name - Girl";
            this.girlNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateBoyNameButton
            // 
            this.generateBoyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBoyNameButton.BackColor = System.Drawing.Color.SteelBlue;
            this.generateBoyNameButton.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBoyNameButton.ForeColor = System.Drawing.Color.White;
            this.generateBoyNameButton.Location = new System.Drawing.Point(12, 56);
            this.generateBoyNameButton.Name = "generateBoyNameButton";
            this.generateBoyNameButton.Size = new System.Drawing.Size(269, 44);
            this.generateBoyNameButton.TabIndex = 5;
            this.generateBoyNameButton.Text = "Generate";
            this.generateBoyNameButton.UseVisualStyleBackColor = false;
            this.generateBoyNameButton.Click += new System.EventHandler(this.GenerateBoyNameButton_Click);
            // 
            // boyNameLabel
            // 
            this.boyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boyNameLabel.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boyNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.boyNameLabel.Location = new System.Drawing.Point(12, 9);
            this.boyNameLabel.Name = "boyNameLabel";
            this.boyNameLabel.Size = new System.Drawing.Size(269, 44);
            this.boyNameLabel.TabIndex = 4;
            this.boyNameLabel.Text = "Baby Name - Boy";
            this.boyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 115);
            this.Controls.Add(this.generateGirlNameButton);
            this.Controls.Add(this.girlNameLabel);
            this.Controls.Add(this.generateBoyNameButton);
            this.Controls.Add(this.boyNameLabel);
            this.Name = "MainForm";
            this.Text = "Baby Name Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateGirlNameButton;
        private System.Windows.Forms.Label girlNameLabel;
        private System.Windows.Forms.Button generateBoyNameButton;
        private System.Windows.Forms.Label boyNameLabel;
    }
}

