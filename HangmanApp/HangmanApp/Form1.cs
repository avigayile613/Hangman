using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HangmanApp
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> lstwords = File.ReadAllLines("Words.txt").ToList();
        List<string> lstlettersinhiddenword;
        List<string> lstguessedletters;
        List<Button> lstalphabetbuttons;
        List<Label> lstbodyparts;
        string hiddenword;
        int guessesremaining = 6;
        enum GameStatusEnum { NotStarted, Playing, GaveUp, Won, Lost };
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;
        public Form1()
        {
            InitializeComponent();
            lstlettersinhiddenword = new();
            lstguessedletters = new();
            lstalphabetbuttons = new();
            lstbodyparts = new() { lblHead, lblBody, lblLeftArm, lblRightArm, lblLeftLeg, lblRightLeg };
            foreach (Button b in tblAlphabet.Controls)
            {
                lstalphabetbuttons.Add(b);
            }
            lstalphabetbuttons.ForEach(b => b.Click += Letter_Click);
            btnStart.Click += BtnStart_Click;
            btnGiveUp.Click += BtnGiveUp_Click;
        }

        private void Letter_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lstguessedletters.Add(btn.Text);
            BuildWordString();
            if (!lstlettersinhiddenword.Contains(btn.Text))
            {
                AddBodyPart();
                btn.BackColor = Color.LightGray;
                btn.Enabled = false;
                guessesremaining--;
                DetectLoss();

            }
            else
            {
                btn.BackColor = Color.LightGreen;
                btn.Enabled = false;
                DetectWin();
            }
            UpdateMessage();
        }

        private void DetectWin()
        {
            if (lblHiddenWord.Text.Replace(" ", "") == hiddenword)
            {
                ChangeGameStatus(GameStatusEnum.Won);
            }
        }

        private void DetectLoss()
        {
            if (guessesremaining < 0)
            {
                ChangeGameStatus(GameStatusEnum.Lost);
            }
        }

        private void BtnGiveUp_Click(object? sender, EventArgs e)
        {
            lblHiddenWord.Text = hiddenword;
            ChangeGameStatus(GameStatusEnum.GaveUp);
            UpdateMessage();
        }

        private void UpdateMessage()
        {
            string msg = "Click start to begin game.";
            switch (gamestatus)
            {
                case GameStatusEnum.Playing:
                    msg = "Wrong Guesses Remaining: " + guessesremaining;
                    break;
                case GameStatusEnum.Lost:
                case GameStatusEnum.GaveUp:
                    msg = "Game Over";
                    break;
                case GameStatusEnum.Won:
                    msg = "You Won!";
                    break;
            }
            lblMessage.Text = msg;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            ChangeGameStatus(GameStatusEnum.NotStarted);
            ChangeGameStatus(GameStatusEnum.Playing);
            PickHiddenWord();
        }

        private void ChangeGameStatus(GameStatusEnum status)
        {
            gamestatus = status;
            switch (status)
            {
                case GameStatusEnum.NotStarted:
                    btnGiveUp.Text = "Give Up";
                    lstguessedletters.Clear();
                    lstlettersinhiddenword.Clear();
                    guessesremaining = 6;
                    lstbodyparts.ForEach(b => b.Visible = false);
                    lstalphabetbuttons.ForEach(b => b.BackColor = Color.White);
                    break;
                case GameStatusEnum.Playing:
                    btnGiveUp.Enabled = true;
                    btnStart.Enabled = false;
                    lstalphabetbuttons.ForEach(b => b.Enabled = true);
                    break;
                case GameStatusEnum.Lost:
                    lstbodyparts.ForEach(b => b.ForeColor = Color.Red);
                    lblBody.BackColor = Color.Red;
                    btnGiveUp.Text = "Reveal Word";
                    btnStart.Text = "Start New Game";
                    btnStart.Enabled = true;
                    lstalphabetbuttons.ForEach(b => b.Enabled = false);
                    break;
                case GameStatusEnum.GaveUp:
                case GameStatusEnum.Won:
                    lstalphabetbuttons.ForEach(b => b.Enabled = false);
                    btnGiveUp.Enabled = false;
                    btnStart.Text = "Start New Game";
                    btnStart.Enabled = true;
                    break;
            }
            UpdateMessage();
        }

        private void PickHiddenWord()
        {
            hiddenword = lstwords[rnd.Next(lstwords.Count())];
            for (int i = 0; i < hiddenword.Length; i++)
            {
                lstlettersinhiddenword.Add(hiddenword[i].ToString());
            }
            BuildWordString();
        }

        private void BuildWordString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string letter in lstlettersinhiddenword)
            {
                if (lstguessedletters.Contains(letter))
                {
                    sb.Append(letter + " ");
                }
                else
                {
                    sb.Append("__ ");
                }
            }
            lblHiddenWord.Text = sb.ToString();
        }

        private void AddBodyPart()
        {
            lstbodyparts.Where(b => b.Visible == false).ToList().FirstOrDefault(b => b.Visible = true);
        }


    }

}
