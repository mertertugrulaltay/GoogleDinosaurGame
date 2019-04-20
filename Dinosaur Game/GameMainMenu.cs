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
    public partial class GameMainMenu : Form
    {
        public GameMainMenu()
        {
            InitializeComponent();
        }

        private void GameMainMenu_Load(object sender, EventArgs e)
        {
            SoundPlayer snPly = new SoundPlayer();
            snPly.SoundLocation = Application.StartupPath + "\\Game Begin Sound Effect.wav";
            snPly.Play();
            snPly.Dispose();

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            GameScreen gmScr = new GameScreen();

            this.Visible = false;

            gmScr.ShowDialog();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHighScoreAciklama_Click(object sender, EventArgs e)
        {
            try
            {
                HighScore highScor = new HighScore();

                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DinosaurGame.mdf;Integrated Security=True;");
                sqlConn.Open();

                SqlCommand sqlComm = new SqlCommand("SELECT* FROM TB_HighScore", sqlConn);
                sqlComm.CommandTimeout = 60;

                SqlDataReader sqlDtRdr = sqlComm.ExecuteReader();

                while(sqlDtRdr.Read())
                    highScor.lblNumberAciklama.Text = "00" + sqlDtRdr["Score"].ToString();

                sqlConn.Close();
                sqlConn.Dispose();
                sqlComm.Dispose();

                highScor.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
