namespace projv1
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gamePanel = new Panel();
            throwText = new Label();
            holdingItem = new Label();
            pressText = new Label();
            gamePlayer = new PictureBox();
            puszkaZubr = new PictureBox();
            zoltyPojemnik = new PictureBox();
            obstacleOne = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puszkaZubr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zoltyPojemnik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).BeginInit();
            SuspendLayout();
            // 
            // gamePanel
            // 
            gamePanel.BackColor = SystemColors.ActiveCaption;
            gamePanel.Controls.Add(throwText);
            gamePanel.Controls.Add(holdingItem);
            gamePanel.Controls.Add(pressText);
            gamePanel.Controls.Add(gamePlayer);
            gamePanel.Controls.Add(puszkaZubr);
            gamePanel.Controls.Add(zoltyPojemnik);
            gamePanel.Controls.Add(obstacleOne);
            gamePanel.Location = new Point(11, 11);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(1305, 595);
            gamePanel.TabIndex = 0;
            // 
            // throwText
            // 
            throwText.AutoSize = true;
            throwText.Location = new Point(687, 79);
            throwText.Name = "throwText";
            throwText.Size = new Size(38, 15);
            throwText.TabIndex = 8;
            throwText.Text = "label1";
            // 
            // holdingItem
            // 
            holdingItem.AutoSize = true;
            holdingItem.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            holdingItem.Location = new Point(557, 21);
            holdingItem.Name = "holdingItem";
            holdingItem.Size = new Size(0, 27);
            holdingItem.TabIndex = 7;
            // 
            // pressText
            // 
            pressText.AutoSize = true;
            pressText.Location = new Point(702, 81);
            pressText.Name = "pressText";
            pressText.Size = new Size(0, 15);
            pressText.TabIndex = 6;
            // 
            // gamePlayer
            // 
            gamePlayer.BackColor = Color.Transparent;
            gamePlayer.Image = Properties.Resources.malpkaa;
            gamePlayer.Location = new Point(328, 374);
            gamePlayer.Name = "gamePlayer";
            gamePlayer.Size = new Size(110, 99);
            gamePlayer.TabIndex = 5;
            gamePlayer.TabStop = false;
            // 
            // puszkaZubr
            // 
            puszkaZubr.BackColor = Color.Transparent;
            puszkaZubr.Image = Properties.Resources.puszka;
            puszkaZubr.Location = new Point(1048, 448);
            puszkaZubr.Name = "puszkaZubr";
            puszkaZubr.Size = new Size(206, 148);
            puszkaZubr.TabIndex = 4;
            puszkaZubr.TabStop = false;
            // 
            // zoltyPojemnik
            // 
            zoltyPojemnik.BackColor = Color.Yellow;
            zoltyPojemnik.BackgroundImageLayout = ImageLayout.Stretch;
            zoltyPojemnik.Image = Properties.Resources.zzzz;
            zoltyPojemnik.Location = new Point(13, 363);
            zoltyPojemnik.Name = "zoltyPojemnik";
            zoltyPojemnik.Size = new Size(201, 229);
            zoltyPojemnik.TabIndex = 2;
            zoltyPojemnik.TabStop = false;
            // 
            // obstacleOne
            // 
            obstacleOne.BackColor = Color.Red;
            obstacleOne.Location = new Point(469, 522);
            obstacleOne.Name = "obstacleOne";
            obstacleOne.Size = new Size(168, 73);
            obstacleOne.TabIndex = 1;
            obstacleOne.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 619);
            Controls.Add(gamePanel);
            Name = "gameForm";
            Text = "Czysty Świat";
            Load += gameForm_Load;
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamePlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)puszkaZubr).EndInit();
            ((System.ComponentModel.ISupportInitialize)zoltyPojemnik).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gamePanel;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox obstacleOne;
        private PictureBox puszkaZubr;
        private PictureBox gamePlayer;
        private Label pressText;
        private Label holdingItem;
        private Label throwText;
        public PictureBox zoltyPojemnik;
    }
}