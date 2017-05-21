namespace displayingCard
{
    partial class GameWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.displayCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hightScoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePictureBox = new System.Windows.Forms.PictureBox();
            this.plyOneNmeLbl = new System.Windows.Forms.Label();
            this.plyOneScrLbl = new System.Windows.Forms.Label();
            this.plyOneCntLbl = new System.Windows.Forms.Label();
            this.plyTwoCntLbl = new System.Windows.Forms.Label();
            this.plyTwoScrLbl = new System.Windows.Forms.Label();
            this.plyTwoNmeLbl = new System.Windows.Forms.Label();
            this.turnLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLbl = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 19;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayCardsToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.gameRulesToolStripMenuItem,
            this.hightScoreMenu,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // displayCardsToolStripMenuItem
            // 
            this.displayCardsToolStripMenuItem.Name = "displayCardsToolStripMenuItem";
            this.displayCardsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.displayCardsToolStripMenuItem.Text = "Display Cards";
            this.displayCardsToolStripMenuItem.Click += new System.EventHandler(this.displayCardsToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.pauseToolStripMenuItem.Text = "Pause Game";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click_1);
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click_1);
            // 
            // hightScoreMenu
            // 
            this.hightScoreMenu.Name = "hightScoreMenu";
            this.hightScoreMenu.Size = new System.Drawing.Size(82, 20);
            this.hightScoreMenu.Text = "High Scores";
            this.hightScoreMenu.Click += new System.EventHandler(this.hightScoreMenu_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // tablePictureBox
            // 
            this.tablePictureBox.Location = new System.Drawing.Point(12, 27);
            this.tablePictureBox.Name = "tablePictureBox";
            this.tablePictureBox.Size = new System.Drawing.Size(1210, 557);
            this.tablePictureBox.TabIndex = 0;
            this.tablePictureBox.TabStop = false;
            this.tablePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tablePictureBox_MouseClick);
            // 
            // plyOneNmeLbl
            // 
            this.plyOneNmeLbl.AutoSize = true;
            this.plyOneNmeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.plyOneNmeLbl.Location = new System.Drawing.Point(255, 608);
            this.plyOneNmeLbl.Name = "plyOneNmeLbl";
            this.plyOneNmeLbl.Size = new System.Drawing.Size(70, 25);
            this.plyOneNmeLbl.TabIndex = 4;
            this.plyOneNmeLbl.Text = "label1";
            // 
            // plyOneScrLbl
            // 
            this.plyOneScrLbl.AutoSize = true;
            this.plyOneScrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plyOneScrLbl.Location = new System.Drawing.Point(276, 645);
            this.plyOneScrLbl.Name = "plyOneScrLbl";
            this.plyOneScrLbl.Size = new System.Drawing.Size(20, 22);
            this.plyOneScrLbl.TabIndex = 6;
            this.plyOneScrLbl.Text = "0";
            // 
            // plyOneCntLbl
            // 
            this.plyOneCntLbl.AutoSize = true;
            this.plyOneCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plyOneCntLbl.Location = new System.Drawing.Point(276, 684);
            this.plyOneCntLbl.Name = "plyOneCntLbl";
            this.plyOneCntLbl.Size = new System.Drawing.Size(20, 22);
            this.plyOneCntLbl.TabIndex = 10;
            this.plyOneCntLbl.Text = "5";
            // 
            // plyTwoCntLbl
            // 
            this.plyTwoCntLbl.AutoSize = true;
            this.plyTwoCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plyTwoCntLbl.Location = new System.Drawing.Point(936, 684);
            this.plyTwoCntLbl.Name = "plyTwoCntLbl";
            this.plyTwoCntLbl.Size = new System.Drawing.Size(20, 22);
            this.plyTwoCntLbl.TabIndex = 15;
            this.plyTwoCntLbl.Text = "0";
            // 
            // plyTwoScrLbl
            // 
            this.plyTwoScrLbl.AutoSize = true;
            this.plyTwoScrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.plyTwoScrLbl.Location = new System.Drawing.Point(936, 645);
            this.plyTwoScrLbl.Name = "plyTwoScrLbl";
            this.plyTwoScrLbl.Size = new System.Drawing.Size(20, 22);
            this.plyTwoScrLbl.TabIndex = 13;
            this.plyTwoScrLbl.Text = "0";
            // 
            // plyTwoNmeLbl
            // 
            this.plyTwoNmeLbl.AutoSize = true;
            this.plyTwoNmeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.plyTwoNmeLbl.Location = new System.Drawing.Point(910, 608);
            this.plyTwoNmeLbl.Name = "plyTwoNmeLbl";
            this.plyTwoNmeLbl.Size = new System.Drawing.Size(70, 25);
            this.plyTwoNmeLbl.TabIndex = 12;
            this.plyTwoNmeLbl.Text = "label1";
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.turnLbl.Location = new System.Drawing.Point(545, 682);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(165, 25);
            this.turnLbl.TabIndex = 18;
            this.turnLbl.Text = "Number of turns";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label10.Location = new System.Drawing.Point(597, 642);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Score";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.timerLbl.Location = new System.Drawing.Point(12, 608);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(100, 24);
            this.timerLbl.TabIndex = 20;
            this.timerLbl.Text = "00 : 00 : 00";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.turnLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.plyTwoCntLbl);
            this.Controls.Add(this.plyTwoScrLbl);
            this.Controls.Add(this.plyTwoNmeLbl);
            this.Controls.Add(this.plyOneCntLbl);
            this.Controls.Add(this.plyOneScrLbl);
            this.Controls.Add(this.plyOneNmeLbl);
            this.Controls.Add(this.tablePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameWindow";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tablePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label plyOneNmeLbl;
        private System.Windows.Forms.Label plyOneScrLbl;
        private System.Windows.Forms.Label plyOneCntLbl;
        private System.Windows.Forms.Label plyTwoCntLbl;
        private System.Windows.Forms.Label plyTwoScrLbl;
        private System.Windows.Forms.Label plyTwoNmeLbl;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem displayCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hightScoreMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLbl;
    }
}

