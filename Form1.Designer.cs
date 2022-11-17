namespace Final_Minesweeper
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hard = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.easy = new System.Windows.Forms.RadioButton();
            this.board = new System.Windows.Forms.FlowLayoutPanel();
            this.start = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.hard);
            this.panel1.Controls.Add(this.medium);
            this.panel1.Controls.Add(this.easy);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 86);
            this.panel1.TabIndex = 0;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(12, 48);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(48, 17);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(12, 26);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 1;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(12, 3);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(48, 17);
            this.easy.TabIndex = 0;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // board
            // 
            this.board.BackgroundImage = global::Final_Minesweeper.Properties.Resources.lb;
            this.board.Location = new System.Drawing.Point(37, 126);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(443, 383);
            this.board.TabIndex = 1;
            // 
            // start
            // 
            this.start.BackgroundImage = global::Final_Minesweeper.Properties.Resources.smiling_face_with_smiling_eyes_1f60a;
            this.start.Location = new System.Drawing.Point(354, 8);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 57);
            this.start.TabIndex = 3;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 521);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.FlowLayoutPanel board;
    }
}

