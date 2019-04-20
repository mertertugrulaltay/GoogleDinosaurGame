using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Dinosaur_Game
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }


        #region Nesne ve Değişken Tanımlamaları

        Random rnd = new Random();

        string basilanTus;

        public int skorSayi = 0;
        public int veritabanindanCekilenSkor;

        #endregion


        void VeritabanınaHighScoreEkleme()
        {

            #region Veritabanından Skor'u öğrenme

            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DinosaurGame.mdf;Integrated Security=True;");
            sqlConn.Open();

            SqlCommand sqlComm1 = new SqlCommand("SELECT* FROM TB_HighScore", sqlConn);
            sqlComm1.CommandTimeout = 60;

            SqlDataReader sqlDtRdr1 = sqlComm1.ExecuteReader();

            while (sqlDtRdr1.Read())
                veritabanindanCekilenSkor = Convert.ToInt32(sqlDtRdr1["Score"]);

            sqlConn.Close();
            sqlConn.Dispose();
            sqlComm1.Dispose();

            #endregion

            #region Skor'un Veritabanındaki Skor'dan büyük olması durumda

            if (skorSayi > veritabanindanCekilenSkor)
            {

                HighScore hgScr = new HighScore();

                SqlConnection sqlConn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DinosaurGame.mdf;Integrated Security=True;");
                sqlConn2.Open();

                SqlCommand sqlComm2 = new SqlCommand("UPDATE TB_HighScore SET Score = '"+skorSayi+"'", sqlConn2);
                sqlComm2.CommandTimeout = 60;
                sqlComm2.ExecuteNonQuery();

                sqlConn2.Close();
                sqlConn2.Dispose();
                sqlComm2.Dispose();

                //-----------------------------------------------------------------------------------------

                SqlConnection sqlConn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DinosaurGame.mdf;Integrated Security=True;");
                sqlConn3.Open();

                SqlCommand sqlComm3 = new SqlCommand("SELECT* FROM TB_HighScore", sqlConn3);
                sqlComm3.CommandTimeout = 60;

                SqlDataReader sqlDtRdr2 = sqlComm3.ExecuteReader();

                while (sqlDtRdr2.Read())
                    hgScr.lblNumberAciklama.Text = Convert.ToInt32(sqlDtRdr2["Score"]).ToString();

                sqlConn3.Close();
                sqlConn3.Dispose();
                sqlComm3.Dispose();

            }


            #endregion


        }

        void EngellerinDinozorileTemasınınKontrolü()
        {
            if (picBoxDinozor.Bounds.IntersectsWith(picBoxDinozorEngel1.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus1.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus2.Bounds))
            {
                SoundPlayer snPly = new SoundPlayer();
                snPly.SoundLocation = Application.StartupPath + "\\Game Over Sound Effect.wav";
                snPly.Play();

                snPly.Dispose();

                timerPicBoxEngel1.Enabled = false;
                timerPicBoxEngel2.Enabled = false;
                timerPicBoxEngel3.Enabled = false;
                timerPicBoxEngel4.Enabled = false;

                timerPicBoxBulut1.Enabled = false;
                timerPicBoxBulut2.Enabled = false;
                timerPicBoxBulut3.Enabled = false;
                timerPicBoxBulut4.Enabled = false;
                timerPicBoxBulut5.Enabled = false;
                timerPicBoxBulut6.Enabled = false;

                timerKus1.Enabled = false;
                timerKus2.Enabled = false;

                timerPicBoxDinozorLocationDefaultAyarlama.Enabled = false;
                timerSkorSayi.Enabled = false;

                picBoxGameOver.Visible = true;
                picBoxGameOver.BringToFront();

                picBoxDinozor.BringToFront();

                picBoxDinozor.Image = Image.FromFile(Application.StartupPath + "\\Dinozor Image.jpg");

                picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");
                picBoxKus2.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");

                VeritabanınaHighScoreEkleme();

                timerStartAgain.Enabled = true;

            }

            else if (picBoxDinozor.Bounds.IntersectsWith(picBoxEngel2.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus1.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus2.Bounds))
            {
                SoundPlayer snPly = new SoundPlayer();
                snPly.SoundLocation = Application.StartupPath + "\\Game Over Sound Effect.wav";
                snPly.Play();

                snPly.Dispose();

                timerPicBoxEngel1.Enabled = false;
                timerPicBoxEngel2.Enabled = false;
                timerPicBoxEngel3.Enabled = false;
                timerPicBoxEngel4.Enabled = false;

                timerPicBoxBulut1.Enabled = false;
                timerPicBoxBulut2.Enabled = false;
                timerPicBoxBulut3.Enabled = false;
                timerPicBoxBulut4.Enabled = false;
                timerPicBoxBulut5.Enabled = false;
                timerPicBoxBulut6.Enabled = false;

                timerKus1.Enabled = false;
                timerKus2.Enabled = false;

                timerPicBoxDinozorLocationDefaultAyarlama.Enabled = false;
                timerSkorSayi.Enabled = false;

                picBoxGameOver.Visible = true;
                picBoxGameOver.BringToFront();

                picBoxDinozor.BringToFront();

                picBoxDinozor.Image = Image.FromFile(Application.StartupPath + "\\Dinozor Image.jpg");

                picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");
                picBoxKus2.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");

                VeritabanınaHighScoreEkleme();

                timerStartAgain.Enabled = true;

            }

            else if (picBoxDinozor.Bounds.IntersectsWith(picBoxEngel3.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus1.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus2.Bounds))
            {
                SoundPlayer snPly = new SoundPlayer();
                snPly.SoundLocation = Application.StartupPath + "\\Game Over Sound Effect.wav";
                snPly.Play();

                snPly.Dispose();

                timerPicBoxEngel1.Enabled = false;
                timerPicBoxEngel2.Enabled = false;
                timerPicBoxEngel3.Enabled = false;
                timerPicBoxEngel4.Enabled = false;

                timerPicBoxBulut1.Enabled = false;
                timerPicBoxBulut2.Enabled = false;
                timerPicBoxBulut3.Enabled = false;
                timerPicBoxBulut4.Enabled = false;
                timerPicBoxBulut5.Enabled = false;
                timerPicBoxBulut6.Enabled = false;

                timerKus1.Enabled = false;
                timerKus2.Enabled = false;

                timerPicBoxDinozorLocationDefaultAyarlama.Enabled = false;
                timerSkorSayi.Enabled = false;

                picBoxGameOver.Visible = true;
                picBoxGameOver.BringToFront();

                picBoxDinozor.BringToFront();

                picBoxDinozor.Image = Image.FromFile(Application.StartupPath + "\\Dinozor Image.jpg");

                picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");
                picBoxKus2.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");

                VeritabanınaHighScoreEkleme();

                timerStartAgain.Enabled = true;

            }

            else if (picBoxDinozor.Bounds.IntersectsWith(picBoxEngel4.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus1.Bounds) || picBoxDinozor.Bounds.IntersectsWith(picBoxKus2.Bounds))
            {
                SoundPlayer snPly = new SoundPlayer();
                snPly.SoundLocation = Application.StartupPath + "\\Game Over Sound Effect.wav";
                snPly.Play();

                snPly.Dispose();

                timerPicBoxEngel1.Enabled = false;
                timerPicBoxEngel2.Enabled = false;
                timerPicBoxEngel3.Enabled = false;
                timerPicBoxEngel4.Enabled = false;

                timerPicBoxBulut1.Enabled = false;
                timerPicBoxBulut2.Enabled = false;
                timerPicBoxBulut3.Enabled = false;
                timerPicBoxBulut4.Enabled = false;
                timerPicBoxBulut5.Enabled = false;
                timerPicBoxBulut6.Enabled = false;

                timerKus1.Enabled = false;
                timerKus2.Enabled = false;

                timerPicBoxDinozorLocationDefaultAyarlama.Enabled = false;
                timerSkorSayi.Enabled = false;

                picBoxGameOver.Visible = true;
                picBoxGameOver.BringToFront();

                picBoxDinozor.BringToFront();

                picBoxDinozor.Image = Image.FromFile(Application.StartupPath + "\\Dinozor Image.jpg");

                picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");
                picBoxKus2.Image = Image.FromFile(Application.StartupPath + "\\Siyah Kuş Image.jpg");

                VeritabanınaHighScoreEkleme();

                timerStartAgain.Enabled = true;

            }
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {

            #region PicBox'ların ve Timer'ların Genel Ayarlamaları

            //picBoxEngel1.Location.X -20 olursa picBoxEngel1.Location.X 1100 olsun.
            //picBoxEngel2.Location.X -20 olursa picBoxEngel1.Location.X 1200 olsun.
            //picBoxEngel3.Location.X -20 olursa picBoxEngel1.Location.X 1320 olsun.
            //picBoxEngel4.Location.X -20 olursa picBoxEngel1.Location.X 1540 olsun.

            //picBoxBulut1.Location.X -20 olursa picBoxBulut1.Location.X 750 olsun.
            //picBoxBulut2.Location.X -20 olursa picBoxBulut2.Location.X 750 olsun.
            //picBoxBulut3.Location.X -20 olursa picBoxBulut3.Location.X 750 olsun.
            //picBoxBulut4.Location.X -20 olursa picBoxBulut4.Location.X 750 olsun.
            //picBoxBulut5.Location.X -20 olursa picBoxBulut5.Location.X 750 olsun.
            //picBoxBulut6.Location.X -20 olursa picBoxBulut5.Location.X 750 olsun.

            //picBoxKus1.Location.X -20 olursa picBoxKus1.Location.X 850 olsun.
            //picBoxKus2.Location.X -20 olursa picBoxKus2.Location.X 1200 olsun.
      


            picBoxYol.SendToBack();

            picBoxBulut1.SendToBack();
            picBoxBulut2.SendToBack();
            picBoxBulut3.SendToBack();
            picBoxBulut4.SendToBack();
            picBoxBulut5.SendToBack();
            picBoxBulut6.SendToBack();

            timerPicBoxEngel1.Enabled = true;
            timerPicBoxEngel2.Enabled = true;
            timerPicBoxEngel3.Enabled = true;
            timerPicBoxEngel4.Enabled = true;

            timerPicBoxBulut1.Enabled = true;
            timerPicBoxBulut2.Enabled = true;
            timerPicBoxBulut3.Enabled = true;
            timerPicBoxBulut4.Enabled = true;
            timerPicBoxBulut5.Enabled = true;
            timerPicBoxBulut6.Enabled = true;

            timerSkorSayi.Enabled = true;




            #endregion

        }


        #region timerPicBoxEngeller

        private void timerPicBoxEngel1_Tick_1(object sender, EventArgs e)
        {
            picBoxDinozorEngel1.Location = new Point(picBoxDinozorEngel1.Location.X - 28, picBoxDinozorEngel1.Location.Y);

            if (picBoxDinozorEngel1.Location.X <= -20)
                picBoxDinozorEngel1.Location = new Point(1100, picBoxDinozorEngel1.Location.Y);

            EngellerinDinozorileTemasınınKontrolü();
        }

        private void timerPicBoxEngel2_Tick_1(object sender, EventArgs e)
        {
            picBoxEngel2.Location = new Point(picBoxEngel2.Location.X - 28, picBoxEngel2.Location.Y);

            if (picBoxEngel2.Location.X <= -20)
                picBoxEngel2.Location = new Point(1200, picBoxEngel2.Location.Y);

            EngellerinDinozorileTemasınınKontrolü();
        }

        private void timerPicBoxEngel3_Tick_1(object sender, EventArgs e)
        {
            picBoxEngel3.Location = new Point(picBoxEngel3.Location.X - 28, picBoxDinozorEngel1.Location.Y);

            if (picBoxEngel3.Location.X <= -20)
                picBoxEngel3.Location = new Point(1320, picBoxEngel3.Location.Y);

            EngellerinDinozorileTemasınınKontrolü();
        }

        private void timerPicBoxEngel4_Tick_1(object sender, EventArgs e)
        {
            picBoxEngel4.Location = new Point(picBoxEngel4.Location.X - 28, picBoxEngel2.Location.Y);

            if (picBoxEngel4.Location.X <= -20)
                picBoxEngel4.Location = new Point(1540, picBoxEngel4.Location.Y);

            EngellerinDinozorileTemasınınKontrolü();
        }

        #endregion


        #region timerPicBoxBulutlar

        private void timerPicBoxBulut1_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut1.Location = new Point(picBoxBulut1.Location.X - 15, picBoxBulut1.Location.Y);

            if (picBoxBulut1.Location.X <= -20)
                picBoxBulut1.Location = new Point(750, picBoxBulut1.Location.Y);
        }

        private void timerPicBoxBulut2_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut2.Location = new Point(picBoxBulut2.Location.X - 15, picBoxBulut2.Location.Y);

            if (picBoxBulut2.Location.X <= -20)
                picBoxBulut2.Location = new Point(750, picBoxBulut2.Location.Y);
        }

        private void timerPicBoxBulut3_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut3.Location = new Point(picBoxBulut3.Location.X - 15, picBoxBulut3.Location.Y);

            if (picBoxBulut3.Location.X <= -20)
                picBoxBulut3.Location = new Point(750, picBoxBulut3.Location.Y);
        }

        private void timerPicBoxBulut4_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut4.Location = new Point(picBoxBulut4.Location.X - 15, picBoxBulut4.Location.Y);

            if (picBoxBulut4.Location.X <= -20)
                picBoxBulut4.Location = new Point(750, picBoxBulut4.Location.Y);
        }

        private void timerPicBoxBulut5_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut5.Location = new Point(picBoxBulut5.Location.X - 15, picBoxBulut5.Location.Y);

            if (picBoxBulut5.Location.X <= -20)
                picBoxBulut5.Location = new Point(750, picBoxBulut5.Location.Y);
        }

        private void timerPicBoxBulut6_Tick_1(object sender, EventArgs e)
        {
            picBoxBulut6.Location = new Point(picBoxBulut6.Location.X - 15, picBoxBulut6.Location.Y);

            if (picBoxBulut6.Location.X <= -20)
                picBoxBulut6.Location = new Point(750, picBoxBulut6.Location.Y);
        }

        #endregion


        #region timerKuslar


        private void timerKus1_Tick(object sender, EventArgs e)
        {
            int üretilenRastgeleSayi = rnd.Next(1, 5);

            picBoxKus1.Location = new Point(picBoxKus1.Location.X - 32, picBoxKus1.Location.Y);

            if (picBoxKus1.Location.X <= -20)
            {

                picBoxKus1.Location = new Point(850, 30);

                if (üretilenRastgeleSayi == 1)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 1.gif");
                else if (üretilenRastgeleSayi == 2)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 2.gif");
                else if (üretilenRastgeleSayi == 3)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 3.gif");
                else if (üretilenRastgeleSayi == 4)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 4.gif");
                else if (üretilenRastgeleSayi == 5)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 5.gif");
            }
        }

        private void timerKus2_Tick(object sender, EventArgs e)
        {
            int üretilenRastgeleSayi = rnd.Next(1, 5);

            picBoxKus2.Location = new Point(picBoxKus2.Location.X - 32, picBoxKus2.Location.Y);

            if (picBoxKus2.Location.X <= -20)
            {
                picBoxKus2.Location = new Point(1250, 54);

                if (üretilenRastgeleSayi == 1)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 1.gif");
                else if (üretilenRastgeleSayi == 2)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 2.gif");
                else if (üretilenRastgeleSayi == 3)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 3.gif");
                else if (üretilenRastgeleSayi == 4)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 4.gif");
                else if (üretilenRastgeleSayi == 5)
                    picBoxKus1.Image = Image.FromFile(Application.StartupPath + "\\Kuş GIF 5.gif");
            }

        }

        #endregion


        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                picBoxDinozor.Location = new Point(picBoxDinozor.Location.X + 100, 64);

                SoundPlayer snPly = new SoundPlayer();
                snPly.SoundLocation = Application.StartupPath + "\\Windows Information Bar Sound Effect.wav";
                snPly.Play();

                timerPicBoxDinozorLocationDefaultAyarlama.Enabled = true;

            }



            //----------------------------------------------------------------------------

            if ((e.KeyCode == Keys.A) || (e.KeyCode == Keys.Left))
            {
                if (picBoxDinozor.Location.X > 15)
                {
                    picBoxDinozor.Location = new Point(picBoxDinozor.Location.X - 15, picBoxDinozor.Location.Y);
                }
            }

            else if ((e.KeyCode == Keys.D) || (e.KeyCode == Keys.Right))
            {
                if (picBoxDinozor.Location.X < 605)
                {
                    picBoxDinozor.Location = new Point(picBoxDinozor.Location.X + 15, picBoxDinozor.Location.Y);
                }
            }


            basilanTus = e.KeyCode.ToString();

            
        }

        private void timerPicBoxDinozorLocationDefaultAyarlama_Tick(object sender, EventArgs e)
        {
            if ((basilanTus == "Space") || (basilanTus == "Left") || (basilanTus == "Right"))
            {
                picBoxDinozor.Location = new Point(picBoxDinozor.Location.X, 124);
            }

            basilanTus = null;

            timerPicBoxDinozorLocationDefaultAyarlama.Enabled = false;

        }

        private void timerSkorSayi_Tick(object sender, EventArgs e)
        {
            ++skorSayi;

            lblSkorSayi.Text = "00" + skorSayi.ToString();

            if (skorSayi == 70)
                timerKus1.Enabled = true;
            else if (skorSayi == 90)
                timerKus2.Enabled = true;

            for (int i = 100; i <= 100000000; i += 100)
            {
                if (skorSayi == i)
                {
                    SoundPlayer snPly = new SoundPlayer();
                    snPly.SoundLocation = Application.StartupPath + "\\Score Sound Effect.wav";
                    snPly.Play();
                }
            }


        }

        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerStartAgain_Tick(object sender, EventArgs e)
        {
            if ((basilanTus == "Space") || (basilanTus == "Right") || (basilanTus == "Left"))
            {
                GameScreen gmScr = (GameScreen)Application.OpenForms["GameScreen"];

                gmScr.Close();
                gmScr.Dispose();

                GameScreen gmScrRetry = new GameScreen();
                gmScrRetry.ShowDialog();

                timerStartAgain.Enabled = false;
                
            }
        }

    }
}
