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
        List<string> lstguessedletters;
        List<Button> lstalphabetbuttons;
        List<Label> lstbodyparts;
        List<Label> lstgallowsparts;
        string hiddenword;
        int guessesremaining = 7;
        bool gallowsDrawn;
        enum DifficultyLevel { Easy, Medium, Hard }
        enum GameStatusEnum { NotStarted, Playing, GaveUp, Won, Lost };
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;
        public Form1()
        {
            InitializeComponent();
            lstguessedletters = new();
            lstalphabetbuttons = new();
            lstbodyparts = new() { lblHead, lblBody, lblLeftArm, lblRightArm, lblLeftLeg, lblRightLeg };
            lstgallowsparts = new() { lblBase, lblPole, lblBeam, lblRope };
            foreach (Button b in tblAlphabet.Controls)
            {
                lstalphabetbuttons.Add(b);
            }
            lstalphabetbuttons.ForEach(b => b.Click += Letter_Click);
            btnStart.Click += BtnStart_Click;
            btnGiveUp.Click += BtnGiveUp_Click;
            ChangeGameStatus(GameStatusEnum.NotStarted);
        }

        private void Letter_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lstguessedletters.Add(btn.Text);//record guess

            BuildWordString();//rebuild and display the hidden word label 

            bool iscorrect = hiddenword.Contains(btn.Text);
            if (iscorrect)//Check if hidden word included the letter guessed
            {//if it did:
                DisableButton(btn, true);
                DetectWin();
            }
            else
            { //If it did not:
                AddBodyPart();
                DisableButton(btn, false);
                guessesremaining--;//decrease number of wrong guesses remaining
                DetectLoss();
            }

            UpdateMessage();
        }

        private void DisableButton(Button btn, bool iscorrect)
        {
            btn.BackColor = iscorrect ? Color.LightGreen : Color.LightGray;
            btn.Enabled = false;
        }

        private void DetectWin()
        {
            if (lblHiddenWord.Text.Replace(" ", "") == hiddenword) //check if hidden word label contains the full hidden word
            {
                ChangeGameStatus(GameStatusEnum.Won);
            }
        }

        private void DetectLoss()
        {
            if (guessesremaining <= 0)
            {
                ChangeGameStatus(GameStatusEnum.Lost);
            }
        }

        private void BtnGiveUp_Click(object? sender, EventArgs e)
        {
            lblHiddenWord.Text = hiddenword;//Display the full hidden word
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
                    msg = "You Win!";
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
                    btnStart.Text = "Start";
                    btnGiveUp.Text = "Give Up";
                    lstguessedletters.Clear();
                    guessesremaining = 7;
                    gallowsDrawn = false;
                    lstgallowsparts.ForEach(b => b.Visible = false);
                    lstbodyparts.ForEach(b => { b.Visible = false; b.ForeColor = Color.Black; });
                    lblBody.BackColor = Color.Black;
                    lstalphabetbuttons.ForEach(b => b.BackColor = Color.White);
                    SetDifficultySelectionEnabled(true);
                    break;
                case GameStatusEnum.Playing:
                    btnGiveUp.Enabled = true;
                    btnStart.Enabled = false;
                    SetAlphabetButtonsEnabled(true);
                    SetDifficultySelectionEnabled(false);
                    break;
                case GameStatusEnum.Lost:
                    lstbodyparts.ForEach(b => b.ForeColor = Color.Red);
                    lblBody.BackColor = Color.Red;
                    btnGiveUp.Text = "Reveal Word";
                    ResetStartButton();
                    SetAlphabetButtonsEnabled(false);
                    SetDifficultySelectionEnabled(true);
                    break;
                case GameStatusEnum.GaveUp:
                case GameStatusEnum.Won:
                    ResetStartButton();
                    SetAlphabetButtonsEnabled(false);
                    btnGiveUp.Enabled = false;
                    SetDifficultySelectionEnabled(true);
                    break;
            }
            UpdateMessage();
        }

        private void SetAlphabetButtonsEnabled(bool enabled)
        {
            lstalphabetbuttons.ForEach(b => b.Enabled = enabled);
        }

        private void ResetStartButton()
        {
            btnStart.Text = "Start New Game";
            btnStart.Enabled = true;
        }

        private void SetDifficultySelectionEnabled(bool enabled)
        {
            rdoEasy.Enabled = enabled;
            rdoMedium.Enabled = enabled;
            rdoHard.Enabled = enabled;
        }

        private void PickHiddenWord()
        {
            List<string> wordsForDifficulty = GetWordsForDifficulty(GetSelectedDifficulty());
            hiddenword = wordsForDifficulty[rnd.Next(wordsForDifficulty.Count)];
            BuildWordString();
        }

        private DifficultyLevel GetSelectedDifficulty()
        {
            if (rdoHard.Checked)
            {
                return DifficultyLevel.Hard;
            }

            if (rdoMedium.Checked)
            {
                return DifficultyLevel.Medium;
            }

            return DifficultyLevel.Easy;
        }

        private List<string> GetWordsForDifficulty(DifficultyLevel difficulty)
        {
            List<string> filteredWords = lstwords
                .Where(word => difficulty switch
                {
                    DifficultyLevel.Easy => word.Length >= 3 && word.Length <= 4,
                    DifficultyLevel.Medium => word.Length >= 5 && word.Length <= 6,
                    DifficultyLevel.Hard => word.Length >= 7 && word.Length <= 10,
                    _ => false
                })
                .OrderBy(word => word.Length)
                .ThenBy(word => word)
                .ToList();

            if (filteredWords.Count == 0)
            {
                return lstwords;
            }

            return filteredWords;
        }

        private void BuildWordString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in hiddenword)//go through each letter in hidden word
            {
                string letter = c.ToString();
                if (lstguessedletters.Contains(letter))//check if guessed letter is contained in hidden word
                {
                    sb.Append(letter + " ");//if hidden word contains the letter, reveal it
                }
                else
                {
                    sb.Append("__ ");//if it does not, put _ in the place of the letter
                }
            }
            lblHiddenWord.Text = sb.ToString();
        }

        private void AddBodyPart()
        {//show gallows first, then reveal body parts one at a time
            if (!gallowsDrawn)
            {
                lstgallowsparts.ForEach(b => b.Visible = true);
                gallowsDrawn = true;
                return;
            }

            var parttoshow = lstbodyparts.FirstOrDefault(b => !b.Visible);
            if (parttoshow != null) { parttoshow.Visible = true; }
        }

    }

}
