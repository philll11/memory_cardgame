namespace displayingCard
{
    partial class PauseWindow
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.unpauseBtn = new System.Windows.Forms.Button();
            this.pauseLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(253, 67);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // unpauseBtn
            // 
            this.unpauseBtn.Location = new System.Drawing.Point(154, 67);
            this.unpauseBtn.Name = "unpauseBtn";
            this.unpauseBtn.Size = new System.Drawing.Size(75, 23);
            this.unpauseBtn.TabIndex = 4;
            this.unpauseBtn.Text = "Unpause";
            this.unpauseBtn.UseVisualStyleBackColor = true;
            this.unpauseBtn.Click += new System.EventHandler(this.unpauseBtn_Click);
            // 
            // pauseLable
            // 
            this.pauseLable.AutoSize = true;
            this.pauseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pauseLable.Location = new System.Drawing.Point(151, 28);
            this.pauseLable.Name = "pauseLable";
            this.pauseLable.Size = new System.Drawing.Size(177, 17);
            this.pauseLable.TabIndex = 3;
            this.pauseLable.Text = "What would you like to do?";
            // 
            // PauseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 122);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.unpauseBtn);
            this.Controls.Add(this.pauseLable);
            this.Name = "PauseWindow";
            this.Text = "PauseWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button unpauseBtn;
        private System.Windows.Forms.Label pauseLable;
    }
}