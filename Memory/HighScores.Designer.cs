using System;
using System.IO;

namespace displayingCard
{
    partial class HighScores
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
            this.returnHS = new System.Windows.Forms.Button();
            this.highScore8 = new System.Windows.Forms.Label();
            this.highScore7 = new System.Windows.Forms.Label();
            this.highScore5 = new System.Windows.Forms.Label();
            this.highScore6 = new System.Windows.Forms.Label();
            this.highScore1 = new System.Windows.Forms.Label();
            this.highScore2 = new System.Windows.Forms.Label();
            this.highScore3 = new System.Windows.Forms.Label();
            this.highScore4 = new System.Windows.Forms.Label();
            this.highScore9 = new System.Windows.Forms.Label();
            this.highScore10 = new System.Windows.Forms.Label();
            this.ng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnHS
            // 
            this.returnHS.Location = new System.Drawing.Point(252, 346);
            this.returnHS.Name = "returnHS";
            this.returnHS.Size = new System.Drawing.Size(75, 23);
            this.returnHS.TabIndex = 0;
            this.returnHS.Text = "Return";
            this.returnHS.UseVisualStyleBackColor = true;
            this.returnHS.Click += new System.EventHandler(this.returnHS_Click);
            // 
            // highScore8
            // 
            this.highScore8.AutoSize = true;
            this.highScore8.Location = new System.Drawing.Point(237, 235);
            this.highScore8.Name = "highScore8";
            this.highScore8.Size = new System.Drawing.Size(24, 13);
            this.highScore8.TabIndex = 2;
            this.highScore8.Text = "n/a";
            // 
            // highScore7
            // 
            this.highScore7.AutoSize = true;
            this.highScore7.Location = new System.Drawing.Point(237, 207);
            this.highScore7.Name = "highScore7";
            this.highScore7.Size = new System.Drawing.Size(24, 13);
            this.highScore7.TabIndex = 4;
            this.highScore7.Text = "n/a";
            // 
            // highScore5
            // 
            this.highScore5.AutoSize = true;
            this.highScore5.Location = new System.Drawing.Point(237, 151);
            this.highScore5.Name = "highScore5";
            this.highScore5.Size = new System.Drawing.Size(24, 13);
            this.highScore5.TabIndex = 9;
            this.highScore5.Text = "n/a";
            // 
            // highScore6
            // 
            this.highScore6.AutoSize = true;
            this.highScore6.Location = new System.Drawing.Point(237, 179);
            this.highScore6.Name = "highScore6";
            this.highScore6.Size = new System.Drawing.Size(24, 13);
            this.highScore6.TabIndex = 8;
            this.highScore6.Text = "n/a";
            // 
            // highScore1
            // 
            this.highScore1.AutoSize = true;
            this.highScore1.Location = new System.Drawing.Point(237, 39);
            this.highScore1.Name = "highScore1";
            this.highScore1.Size = new System.Drawing.Size(24, 13);
            this.highScore1.TabIndex = 13;
            this.highScore1.Text = "n/a";
            // 
            // highScore2
            // 
            this.highScore2.AutoSize = true;
            this.highScore2.Location = new System.Drawing.Point(237, 67);
            this.highScore2.Name = "highScore2";
            this.highScore2.Size = new System.Drawing.Size(24, 13);
            this.highScore2.TabIndex = 12;
            this.highScore2.Text = "n/a";
            // 
            // highScore3
            // 
            this.highScore3.AutoSize = true;
            this.highScore3.Location = new System.Drawing.Point(237, 95);
            this.highScore3.Name = "highScore3";
            this.highScore3.Size = new System.Drawing.Size(24, 13);
            this.highScore3.TabIndex = 11;
            this.highScore3.Text = "n/a";
            // 
            // highScore4
            // 
            this.highScore4.AutoSize = true;
            this.highScore4.Location = new System.Drawing.Point(237, 123);
            this.highScore4.Name = "highScore4";
            this.highScore4.Size = new System.Drawing.Size(24, 13);
            this.highScore4.TabIndex = 10;
            this.highScore4.Text = "n/a";
            // 
            // highScore9
            // 
            this.highScore9.AutoSize = true;
            this.highScore9.Location = new System.Drawing.Point(237, 263);
            this.highScore9.Name = "highScore9";
            this.highScore9.Size = new System.Drawing.Size(24, 13);
            this.highScore9.TabIndex = 15;
            this.highScore9.Text = "n/a";
            // 
            // highScore10
            // 
            this.highScore10.AutoSize = true;
            this.highScore10.Location = new System.Drawing.Point(237, 291);
            this.highScore10.Name = "highScore10";
            this.highScore10.Size = new System.Drawing.Size(24, 13);
            this.highScore10.TabIndex = 14;
            this.highScore10.Text = "n/a";
            // 
            // ng
            // 
            this.ng.Location = new System.Drawing.Point(171, 346);
            this.ng.Name = "ng";
            this.ng.Size = new System.Drawing.Size(75, 23);
            this.ng.TabIndex = 16;
            this.ng.Text = "New Game";
            this.ng.UseVisualStyleBackColor = true;
            this.ng.Click += new System.EventHandler(this.ng_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 412);
            this.Controls.Add(this.ng);
            this.Controls.Add(this.highScore9);
            this.Controls.Add(this.highScore10);
            this.Controls.Add(this.highScore1);
            this.Controls.Add(this.highScore2);
            this.Controls.Add(this.highScore3);
            this.Controls.Add(this.highScore4);
            this.Controls.Add(this.highScore5);
            this.Controls.Add(this.highScore6);
            this.Controls.Add(this.highScore7);
            this.Controls.Add(this.highScore8);
            this.Controls.Add(this.returnHS);
            this.plyName = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnHS;
        private System.Windows.Forms.Label highScore8;
        private System.Windows.Forms.Label highScore7;
        private System.Windows.Forms.Label highScore5;
        private System.Windows.Forms.Label highScore6;
        private System.Windows.Forms.Label highScore1;
        private System.Windows.Forms.Label highScore2;
        private System.Windows.Forms.Label highScore3;
        private System.Windows.Forms.Label highScore4;
        private System.Windows.Forms.Label highScore9;
        private System.Windows.Forms.Label highScore10;
        private System.Windows.Forms.Button ng;
    }
}