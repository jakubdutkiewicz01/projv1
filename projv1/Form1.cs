namespace projv1
{
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
        }


        bool moveLeft, moveRight, moveJump;

        bool inHand;

        int speed = 15;
        int gravity = 25;
        int force;



        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { moveLeft = true; }
            if (e.KeyCode == Keys.D) { moveRight = true; }
            if (moveJump == false)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W)
                {
                    moveJump = true;
                    force = gravity;
                }

            }
            if (e.KeyCode == Keys.E) { inHand = true; }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { moveLeft = false; }
            if (e.KeyCode == Keys.D) { moveRight = false; }
            if (e.KeyCode == Keys.E) { inHand = false; }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            if (gamePlayer.Right >= obstacleOne.Left && gamePlayer.Right <= obstacleOne.Right &&
                gamePlayer.Bottom > obstacleOne.Top)
            {
                moveRight = false;

            }

            if (gamePlayer.Left <= obstacleOne.Right && gamePlayer.Left >= obstacleOne.Left &&
                gamePlayer.Bottom > obstacleOne.Top)
            {
                moveLeft = false;

            }

            if (moveLeft == true && gamePlayer.Left > 0)
            {
                gamePlayer.Left -= speed;
            }
            if (moveRight == true && gamePlayer.Right < gamePanel.Width)
            {

                gamePlayer.Left += speed;

            }
            if (moveJump == true)
            {
                gamePlayer.Top -= force;
                force -= 1;
            }

            if (gamePlayer.Bottom >= gamePanel.Height)
            {
                gamePlayer.Top = gamePanel.Height - gamePlayer.Height;
                moveJump = false;
            }
            else
            {
                gamePlayer.Top += 5;
            }

            if (gamePlayer.Right > obstacleOne.Left && gamePlayer.Left < obstacleOne.Right &&
                gamePlayer.Bottom >= obstacleOne.Top && gamePlayer.Top < obstacleOne.Top)
            {
                gamePlayer.Top = gamePanel.Height - obstacleOne.Height - gamePlayer.Height;
                force = 0;
                moveJump = false;
            }


            if (gamePlayer.Left < zoltyPojemnik.Right && gamePlayer.Right > zoltyPojemnik.Left)
            {


                throwText.Text = "Naciœnij E aby wyrzuciæ przedmiot";
                if (inHand)
                {
                    holdingItem.Text = "";
                }
            }
            else
            {

                throwText.Text = "";
                zoltyPojemnik.BackColor = Color.Yellow;
            }

            if (gamePlayer.Left > puszkaZubr.Left && gamePlayer.Right < puszkaZubr.Right && puszkaZubr.Visible)
            {
                pressText.Text = "Naciœnij E aby podnieœæ przedmiot";




                if (inHand)
                {
                    puszkaZubr.Visible = false;
                    holdingItem.Text = "PUSZKA PO PIWIE";
                }
            }
            else
            {
                pressText.Text = "";
            }



        }

        private void gamePlayer_Click(object sender, EventArgs e)
        {

        }

        private void gameForm_Load(object sender, EventArgs e)
        {

        }
    }
}