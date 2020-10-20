namespace RockPaperScissorGame
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
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.computerChoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultMessage = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(12, 12);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(88, 76);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(121, 12);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(88, 76);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorButton.Location = new System.Drawing.Point(232, 12);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(88, 76);
            this.scissorButton.TabIndex = 2;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Your Option !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerChoice
            // 
            this.computerChoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.computerChoice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.computerChoice.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoice.ForeColor = System.Drawing.Color.Brown;
            this.computerChoice.Location = new System.Drawing.Point(124, 138);
            this.computerChoice.Name = "computerChoice";
            this.computerChoice.Size = new System.Drawing.Size(85, 85);
            this.computerChoice.TabIndex = 4;
            this.computerChoice.Text = "R-P-S";
            this.computerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer Choice !";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultMessage
            // 
            this.resultMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessage.BackColor = System.Drawing.Color.Transparent;
            this.resultMessage.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMessage.ForeColor = System.Drawing.Color.Lime;
            this.resultMessage.Location = new System.Drawing.Point(12, 329);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(308, 36);
            this.resultMessage.TabIndex = 7;
            this.resultMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replayButton
            // 
            this.replayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.replayButton.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.ForeColor = System.Drawing.Color.Maroon;
            this.replayButton.Location = new System.Drawing.Point(126, 391);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(75, 38);
            this.replayButton.TabIndex = 8;
            this.replayButton.Text = "Replay";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 441);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.computerChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Name = "MainForm";
            this.Text = "Rock-Paper-Scissor Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computerChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultMessage;
        private System.Windows.Forms.Button replayButton;
    }
}

