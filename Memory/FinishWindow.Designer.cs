namespace displayingCard
{
    partial class FinishWindow
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
            this.finishNGBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finishNGBtn
            // 
            this.finishNGBtn.Location = new System.Drawing.Point(233, 388);
            this.finishNGBtn.Name = "finishNGBtn";
            this.finishNGBtn.Size = new System.Drawing.Size(75, 23);
            this.finishNGBtn.TabIndex = 0;
            this.finishNGBtn.Text = "New Game";
            this.finishNGBtn.UseVisualStyleBackColor = true;
            this.finishNGBtn.Click += new System.EventHandler(this.finishNGBtn_Click);
            // 
            // FinishWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 446);
            this.Controls.Add(this.finishNGBtn);
            this.Name = "FinishWindow";
            this.Text = "FinishWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button finishNGBtn;
    }
}