using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangman_ItayShachar.Properties;


namespace Hangman_ItayShachar
{
    public partial class Form1 : Form
    {
        private int m_CurrentLabelLetter = 1;
        private string m_WordToGuess;

        private Image[] m_Images = new Image[6];
        private int m_CountError = 0;

        private bool m_IsFirstPlayer = true;

        private GameOver GameOverMessage = new GameOver();
        private WinnerMessage WinnerMessage_StarWars = new WinnerMessage();

        public Form1()
        {
            InitializeComponent();

            SetImagesArray();
        }

        public void SetImagesArray()
        {
            m_Images[0] = Resources.m1;
            m_Images[1] = Resources.m2;
            m_Images[2] = Resources.m3;
            m_Images[3] = Resources.m4;
            m_Images[4] = Resources.m5;
            m_Images[5] = Resources.m6;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            int match_Count = 0;

            if (m_IsFirstPlayer)
            {
                LabelsBox.Controls["label" + m_CurrentLabelLetter].Text = buttonText;
                m_CurrentLabelLetter++;
            }

            else
            {
                if (m_WordToGuess.Contains(buttonText))
                {
                    for (int i = 0; i < m_WordToGuess.Length; i++)
                        if (m_WordToGuess[i].ToString() == buttonText)
                        {
                            LabelsBox.Controls["label" + (i + 1)].Text = buttonText;
                        }

                }

                else
                {
                    m_CountError++;
                    pictureBox1.Image = m_Images[m_CountError - 1];
                }

                if (m_CountError == 6)
                {
                    GameOverMessage.Show();
                }
              
                (sender as Button).Enabled = false;


            }
        }
    

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (m_CurrentLabelLetter > 1)
            {
                LabelsBox.Controls["label" + (m_CurrentLabelLetter - 1)].Text = "_";

                m_CurrentLabelLetter--;
                OkButton.Enabled = false;

            }

        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            Label curLabel;
            for (int i = 1; i <= 6; i++)
            {
                curLabel = LabelsBox.Controls["label" + i] as Label;
                m_WordToGuess += curLabel.Text;
                curLabel.Text = "_";
            }

            DeleteButton.Visible = false;
            OkButton.Visible = false;

            if (m_CurrentLabelLetter == 6)
                OkButton.Enabled = false;

            m_IsFirstPlayer = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
