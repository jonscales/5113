namespace HexGame_3._0
{
    partial class Jons_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jons_Game));
            this.RedScoreLabel = new System.Windows.Forms.Label();
            this.BlueScoreLabel = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.InstructionsText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedScoreLabel
            // 
            this.RedScoreLabel.AutoSize = true;
            this.RedScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.RedScoreLabel.Location = new System.Drawing.Point(242, 496);
            this.RedScoreLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RedScoreLabel.Name = "RedScoreLabel";
            this.RedScoreLabel.Size = new System.Drawing.Size(116, 37);
            this.RedScoreLabel.TabIndex = 0;
            this.RedScoreLabel.Text = "Red: 0";
            // 
            // BlueScoreLabel
            // 
            this.BlueScoreLabel.AutoSize = true;
            this.BlueScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueScoreLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueScoreLabel.Location = new System.Drawing.Point(642, 496);
            this.BlueScoreLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BlueScoreLabel.Name = "BlueScoreLabel";
            this.BlueScoreLabel.Size = new System.Drawing.Size(123, 37);
            this.BlueScoreLabel.TabIndex = 1;
            this.BlueScoreLabel.Text = "Blue: 0";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(374, 559);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(164, 55);
            this.WinnerLabel.TabIndex = 2;
            this.WinnerLabel.Text = "          ";
            this.WinnerLabel.Visible = false;
            // 
            // InstructionButton
            // 
            this.InstructionButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InstructionButton.ForeColor = System.Drawing.Color.Purple;
            this.InstructionButton.Location = new System.Drawing.Point(19, 598);
            this.InstructionButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(201, 54);
            this.InstructionButton.TabIndex = 3;
            this.InstructionButton.Text = "Instructions\r\n";
            this.InstructionButton.UseVisualStyleBackColor = false;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // InstructionsText
            // 
            this.InstructionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsText.Location = new System.Drawing.Point(19, 544);
            this.InstructionsText.Multiline = true;
            this.InstructionsText.Name = "InstructionsText";
            this.InstructionsText.Size = new System.Drawing.Size(754, 170);
            this.InstructionsText.TabIndex = 4;
            this.InstructionsText.Text = resources.GetString("InstructionsText.Text");
            this.InstructionsText.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackButton.ForeColor = System.Drawing.Color.Purple;
            this.BackButton.Location = new System.Drawing.Point(811, 569);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(151, 93);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back to Game";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.Purple;
            this.PlayAgainButton.Location = new System.Drawing.Point(233, 637);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(125, 77);
            this.PlayAgainButton.TabIndex = 6;
            this.PlayAgainButton.Text = "Play Again?";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Visible = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Purple;
            this.QuitButton.Location = new System.Drawing.Point(659, 648);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(114, 55);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Visible = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Jons_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InstructionsText);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.BlueScoreLabel);
            this.Controls.Add(this.RedScoreLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Jons_Game";
            this.Text = "Jons_Game";
            this.Load += new System.EventHandler(this.Jons_Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label RedScoreLabel;
        private System.Windows.Forms.Label BlueScoreLabel;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.TextBox InstructionsText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

