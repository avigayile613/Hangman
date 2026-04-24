namespace HangmanApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tblMain = new TableLayoutPanel();
            tblToolbar = new TableLayoutPanel();
            btnStart = new Button();
            btnGiveUp = new Button();
            lblMessage = new Label();
            pnlDifficulty = new FlowLayoutPanel();
            lblDifficulty = new Label();
            rdoEasy = new RadioButton();
            rdoMedium = new RadioButton();
            rdoHard = new RadioButton();
            tblAlphabet = new TableLayoutPanel();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnP = new Button();
            btnQ = new Button();
            btnR = new Button();
            btnS = new Button();
            btnT = new Button();
            btnU = new Button();
            btnV = new Button();
            btnW = new Button();
            btnX = new Button();
            btnY = new Button();
            btnZ = new Button();
            tblHiddenWord = new TableLayoutPanel();
            lblHiddenWord = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblBase = new Label();
            lblPole = new Label();
            lblBeam = new Label();
            lblRope = new Label();
            pnlMan = new Panel();
            lblBody = new Label();
            lblRightLeg = new Label();
            lblRightArm = new Label();
            lblLeftLeg = new Label();
            lblLeftArm = new Label();
            lblHead = new Label();
            tblMain.SuspendLayout();
            tblToolbar.SuspendLayout();
            pnlDifficulty.SuspendLayout();
            tblAlphabet.SuspendLayout();
            tblHiddenWord.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlMan.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.FromArgb(128, 255, 255);
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.22038F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7796173F));
            tblMain.Controls.Add(tblToolbar, 0, 0);
            tblMain.Controls.Add(pnlDifficulty, 0, 1);
            tblMain.Controls.Add(tblAlphabet, 0, 2);
            tblMain.Controls.Add(tblHiddenWord, 0, 3);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0967741F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.774194F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6774178F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 36.4516144F));
            tblMain.Size = new Size(1241, 646);
            tblMain.TabIndex = 0;
            // 
            // tblToolbar
            // 
            tblToolbar.ColumnCount = 3;
            tblMain.SetColumnSpan(tblToolbar, 2);
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblToolbar.Controls.Add(btnStart, 0, 0);
            tblToolbar.Controls.Add(btnGiveUp, 2, 0);
            tblToolbar.Controls.Add(lblMessage, 1, 0);
            tblToolbar.Dock = DockStyle.Fill;
            tblToolbar.Location = new Point(3, 3);
            tblToolbar.Name = "tblToolbar";
            tblToolbar.RowCount = 1;
            tblToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblToolbar.Size = new Size(1235, 72);
            tblToolbar.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 128, 0);
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Wide Latin", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Blue;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(241, 66);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnGiveUp
            // 
            btnGiveUp.BackColor = Color.FromArgb(255, 128, 0);
            btnGiveUp.Dock = DockStyle.Fill;
            btnGiveUp.Enabled = false;
            btnGiveUp.Font = new Font("Wide Latin", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiveUp.ForeColor = Color.Blue;
            btnGiveUp.Location = new Point(991, 3);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(241, 66);
            btnGiveUp.TabIndex = 1;
            btnGiveUp.Text = "Give Up";
            btnGiveUp.UseVisualStyleBackColor = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Yellow;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Ink Free", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(192, 0, 0);
            lblMessage.Location = new Point(250, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(735, 72);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Click start to begin game.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDifficulty
            // 
            tblMain.SetColumnSpan(pnlDifficulty, 2);
            pnlDifficulty.Controls.Add(lblDifficulty);
            pnlDifficulty.Controls.Add(rdoEasy);
            pnlDifficulty.Controls.Add(rdoMedium);
            pnlDifficulty.Controls.Add(rdoHard);
            pnlDifficulty.Dock = DockStyle.Fill;
            pnlDifficulty.Location = new Point(3, 81);
            pnlDifficulty.Name = "pnlDifficulty";
            pnlDifficulty.Padding = new Padding(12, 6, 12, 6);
            pnlDifficulty.Size = new Size(1235, 37);
            pnlDifficulty.TabIndex = 4;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Anchor = AnchorStyles.Left;
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(15, 8);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(96, 25);
            lblDifficulty.TabIndex = 0;
            lblDifficulty.Text = "Difficulty:";
            // 
            // rdoEasy
            // 
            rdoEasy.Anchor = AnchorStyles.Left;
            rdoEasy.AutoSize = true;
            rdoEasy.Checked = true;
            rdoEasy.Location = new Point(117, 9);
            rdoEasy.Name = "rdoEasy";
            rdoEasy.Size = new Size(59, 24);
            rdoEasy.TabIndex = 1;
            rdoEasy.TabStop = true;
            rdoEasy.Text = "Easy";
            rdoEasy.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.Anchor = AnchorStyles.Left;
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(182, 9);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(85, 24);
            rdoMedium.TabIndex = 2;
            rdoMedium.Text = "Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoHard
            // 
            rdoHard.Anchor = AnchorStyles.Left;
            rdoHard.AutoSize = true;
            rdoHard.Location = new Point(273, 9);
            rdoHard.Name = "rdoHard";
            rdoHard.Size = new Size(63, 24);
            rdoHard.TabIndex = 3;
            rdoHard.Text = "Hard";
            rdoHard.UseVisualStyleBackColor = true;
            // 
            // tblAlphabet
            // 
            tblAlphabet.ColumnCount = 8;
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblAlphabet.Controls.Add(btnA, 0, 0);
            tblAlphabet.Controls.Add(btnB, 1, 0);
            tblAlphabet.Controls.Add(btnC, 2, 0);
            tblAlphabet.Controls.Add(btnD, 3, 0);
            tblAlphabet.Controls.Add(btnE, 4, 0);
            tblAlphabet.Controls.Add(btnF, 5, 0);
            tblAlphabet.Controls.Add(btnG, 6, 0);
            tblAlphabet.Controls.Add(btnH, 7, 0);
            tblAlphabet.Controls.Add(btnI, 0, 1);
            tblAlphabet.Controls.Add(btnJ, 1, 1);
            tblAlphabet.Controls.Add(btnK, 2, 1);
            tblAlphabet.Controls.Add(btnL, 3, 1);
            tblAlphabet.Controls.Add(btnM, 4, 1);
            tblAlphabet.Controls.Add(btnN, 5, 1);
            tblAlphabet.Controls.Add(btnO, 6, 1);
            tblAlphabet.Controls.Add(btnP, 7, 1);
            tblAlphabet.Controls.Add(btnQ, 0, 2);
            tblAlphabet.Controls.Add(btnR, 1, 2);
            tblAlphabet.Controls.Add(btnS, 2, 2);
            tblAlphabet.Controls.Add(btnT, 3, 2);
            tblAlphabet.Controls.Add(btnU, 4, 2);
            tblAlphabet.Controls.Add(btnV, 5, 2);
            tblAlphabet.Controls.Add(btnW, 6, 2);
            tblAlphabet.Controls.Add(btnX, 7, 2);
            tblAlphabet.Controls.Add(btnY, 3, 3);
            tblAlphabet.Controls.Add(btnZ, 4, 3);
            tblAlphabet.Dock = DockStyle.Fill;
            tblAlphabet.Location = new Point(3, 124);
            tblAlphabet.Name = "tblAlphabet";
            tblAlphabet.RowCount = 4;
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.Size = new Size(766, 282);
            tblAlphabet.TabIndex = 1;
            // 
            // btnA
            // 
            btnA.Dock = DockStyle.Fill;
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI", 12F);
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(89, 64);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            btnB.Dock = DockStyle.Fill;
            btnB.Enabled = false;
            btnB.Font = new Font("Segoe UI", 12F);
            btnB.Location = new Point(98, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(89, 64);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Enabled = false;
            btnC.Font = new Font("Segoe UI", 12F);
            btnC.Location = new Point(193, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(89, 64);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            btnD.Dock = DockStyle.Fill;
            btnD.Enabled = false;
            btnD.Font = new Font("Segoe UI", 12F);
            btnD.Location = new Point(288, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(89, 64);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Dock = DockStyle.Fill;
            btnE.Enabled = false;
            btnE.Font = new Font("Segoe UI", 12F);
            btnE.Location = new Point(383, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(89, 64);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            btnF.Dock = DockStyle.Fill;
            btnF.Enabled = false;
            btnF.Font = new Font("Segoe UI", 12F);
            btnF.Location = new Point(478, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(89, 64);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            btnG.Dock = DockStyle.Fill;
            btnG.Enabled = false;
            btnG.Font = new Font("Segoe UI", 12F);
            btnG.Location = new Point(573, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(89, 64);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            btnH.Dock = DockStyle.Fill;
            btnH.Enabled = false;
            btnH.Font = new Font("Segoe UI", 12F);
            btnH.Location = new Point(668, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(95, 64);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            btnI.Dock = DockStyle.Fill;
            btnI.Enabled = false;
            btnI.Font = new Font("Segoe UI", 12F);
            btnI.Location = new Point(3, 73);
            btnI.Name = "btnI";
            btnI.Size = new Size(89, 64);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            btnJ.Dock = DockStyle.Fill;
            btnJ.Enabled = false;
            btnJ.Font = new Font("Segoe UI", 12F);
            btnJ.Location = new Point(98, 73);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(89, 64);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            btnK.Dock = DockStyle.Fill;
            btnK.Enabled = false;
            btnK.Font = new Font("Segoe UI", 12F);
            btnK.Location = new Point(193, 73);
            btnK.Name = "btnK";
            btnK.Size = new Size(89, 64);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Dock = DockStyle.Fill;
            btnL.Enabled = false;
            btnL.Font = new Font("Segoe UI", 12F);
            btnL.Location = new Point(288, 73);
            btnL.Name = "btnL";
            btnL.Size = new Size(89, 64);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            btnM.Dock = DockStyle.Fill;
            btnM.Enabled = false;
            btnM.Font = new Font("Segoe UI", 12F);
            btnM.Location = new Point(383, 73);
            btnM.Name = "btnM";
            btnM.Size = new Size(89, 64);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            btnN.Dock = DockStyle.Fill;
            btnN.Enabled = false;
            btnN.Font = new Font("Segoe UI", 12F);
            btnN.Location = new Point(478, 73);
            btnN.Name = "btnN";
            btnN.Size = new Size(89, 64);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            btnO.Dock = DockStyle.Fill;
            btnO.Enabled = false;
            btnO.Font = new Font("Segoe UI", 12F);
            btnO.Location = new Point(573, 73);
            btnO.Name = "btnO";
            btnO.Size = new Size(89, 64);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            btnP.Dock = DockStyle.Fill;
            btnP.Enabled = false;
            btnP.Font = new Font("Segoe UI", 12F);
            btnP.Location = new Point(668, 73);
            btnP.Name = "btnP";
            btnP.Size = new Size(95, 64);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            btnQ.Dock = DockStyle.Fill;
            btnQ.Enabled = false;
            btnQ.Font = new Font("Segoe UI", 12F);
            btnQ.Location = new Point(3, 143);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(89, 64);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Dock = DockStyle.Fill;
            btnR.Enabled = false;
            btnR.Font = new Font("Segoe UI", 12F);
            btnR.Location = new Point(98, 143);
            btnR.Name = "btnR";
            btnR.Size = new Size(89, 64);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Dock = DockStyle.Fill;
            btnS.Enabled = false;
            btnS.Font = new Font("Segoe UI", 12F);
            btnS.Location = new Point(193, 143);
            btnS.Name = "btnS";
            btnS.Size = new Size(89, 64);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            btnT.Dock = DockStyle.Fill;
            btnT.Enabled = false;
            btnT.Font = new Font("Segoe UI", 12F);
            btnT.Location = new Point(288, 143);
            btnT.Name = "btnT";
            btnT.Size = new Size(89, 64);
            btnT.TabIndex = 19;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Enabled = false;
            btnU.Font = new Font("Segoe UI", 12F);
            btnU.Location = new Point(383, 143);
            btnU.Name = "btnU";
            btnU.Size = new Size(89, 64);
            btnU.TabIndex = 20;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            btnV.Dock = DockStyle.Fill;
            btnV.Enabled = false;
            btnV.Font = new Font("Segoe UI", 12F);
            btnV.Location = new Point(478, 143);
            btnV.Name = "btnV";
            btnV.Size = new Size(89, 64);
            btnV.TabIndex = 21;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            btnW.Dock = DockStyle.Fill;
            btnW.Enabled = false;
            btnW.Font = new Font("Segoe UI", 12F);
            btnW.Location = new Point(573, 143);
            btnW.Name = "btnW";
            btnW.Size = new Size(89, 64);
            btnW.TabIndex = 22;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.Dock = DockStyle.Fill;
            btnX.Enabled = false;
            btnX.Font = new Font("Segoe UI", 12F);
            btnX.Location = new Point(668, 143);
            btnX.Name = "btnX";
            btnX.Size = new Size(95, 64);
            btnX.TabIndex = 23;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            btnY.Dock = DockStyle.Fill;
            btnY.Enabled = false;
            btnY.Font = new Font("Segoe UI", 12F);
            btnY.Location = new Point(288, 213);
            btnY.Name = "btnY";
            btnY.Size = new Size(89, 66);
            btnY.TabIndex = 24;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            btnZ.Dock = DockStyle.Fill;
            btnZ.Enabled = false;
            btnZ.Font = new Font("Segoe UI", 12F);
            btnZ.Location = new Point(383, 213);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(89, 66);
            btnZ.TabIndex = 25;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = true;
            // 
            // tblHiddenWord
            // 
            tblHiddenWord.ColumnCount = 1;
            tblHiddenWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHiddenWord.Controls.Add(lblHiddenWord, 0, 1);
            tblHiddenWord.Dock = DockStyle.Fill;
            tblHiddenWord.Location = new Point(3, 412);
            tblHiddenWord.Name = "tblHiddenWord";
            tblHiddenWord.RowCount = 3;
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Percent, 61.29032F));
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblHiddenWord.Size = new Size(766, 231);
            tblHiddenWord.TabIndex = 2;
            // 
            // lblHiddenWord
            // 
            lblHiddenWord.AutoSize = true;
            lblHiddenWord.Dock = DockStyle.Fill;
            lblHiddenWord.Font = new Font("Segoe UI", 34.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHiddenWord.Location = new Point(3, 120);
            lblHiddenWord.Name = "lblHiddenWord";
            lblHiddenWord.Size = new Size(760, 75);
            lblHiddenWord.TabIndex = 0;
            lblHiddenWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(128, 255, 255);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.Controls.Add(lblBase, 0, 3);
            tableLayoutPanel1.Controls.Add(lblPole, 3, 0);
            tableLayoutPanel1.Controls.Add(lblBeam, 2, 0);
            tableLayoutPanel1.Controls.Add(lblRope, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlMan, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(775, 124);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tblMain.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.43940854F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7122746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.39839F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.43940783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.84304953F));
            tableLayoutPanel1.Size = new Size(463, 519);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(lblBase, 5);
            lblBase.Dock = DockStyle.Fill;
            lblBase.Location = new Point(3, 459);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(457, 17);
            lblBase.TabIndex = 1;
            lblBase.Text = "label1";
            // 
            // lblPole
            // 
            lblPole.AutoSize = true;
            lblPole.BackColor = Color.Black;
            lblPole.Dock = DockStyle.Fill;
            lblPole.Location = new Point(302, 0);
            lblPole.Margin = new Padding(0);
            lblPole.Name = "lblPole";
            tableLayoutPanel1.SetRowSpan(lblPole, 3);
            lblPole.Size = new Size(14, 459);
            lblPole.TabIndex = 2;
            lblPole.Text = "label2";
            // 
            // lblBeam
            // 
            lblBeam.AutoSize = true;
            lblBeam.BackColor = Color.Black;
            lblBeam.Dock = DockStyle.Fill;
            lblBeam.Location = new Point(158, 0);
            lblBeam.Margin = new Padding(0);
            lblBeam.Name = "lblBeam";
            lblBeam.Size = new Size(144, 17);
            lblBeam.TabIndex = 3;
            lblBeam.Text = "label3";
            // 
            // lblRope
            // 
            lblRope.AutoSize = true;
            lblRope.BackColor = Color.Black;
            lblRope.Dock = DockStyle.Fill;
            lblRope.Location = new Point(144, 0);
            lblRope.Margin = new Padding(0);
            lblRope.Name = "lblRope";
            tableLayoutPanel1.SetRowSpan(lblRope, 2);
            lblRope.Size = new Size(14, 114);
            lblRope.TabIndex = 4;
            lblRope.Text = "label4";
            // 
            // pnlMan
            // 
            pnlMan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.SetColumnSpan(pnlMan, 3);
            pnlMan.Controls.Add(lblBody);
            pnlMan.Controls.Add(lblRightLeg);
            pnlMan.Controls.Add(lblRightArm);
            pnlMan.Controls.Add(lblLeftLeg);
            pnlMan.Controls.Add(lblLeftArm);
            pnlMan.Controls.Add(lblHead);
            pnlMan.Location = new Point(7, 117);
            pnlMan.Name = "pnlMan";
            pnlMan.Size = new Size(288, 339);
            pnlMan.TabIndex = 5;
            // 
            // lblBody
            // 
            lblBody.BackColor = Color.Black;
            lblBody.Location = new Point(141, 72);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(10, 125);
            lblBody.TabIndex = 1;
            lblBody.Visible = false;
            // 
            // lblRightLeg
            // 
            lblRightLeg.AutoSize = true;
            lblRightLeg.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRightLeg.Location = new Point(137, 163);
            lblRightLeg.Name = "lblRightLeg";
            lblRightLeg.Size = new Size(80, 106);
            lblRightLeg.TabIndex = 5;
            lblRightLeg.Text = "\\";
            lblRightLeg.TextAlign = ContentAlignment.TopCenter;
            lblRightLeg.Visible = false;
            // 
            // lblRightArm
            // 
            lblRightArm.AutoSize = true;
            lblRightArm.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRightArm.Location = new Point(137, 72);
            lblRightArm.Name = "lblRightArm";
            lblRightArm.Size = new Size(80, 106);
            lblRightArm.TabIndex = 3;
            lblRightArm.Text = "\\";
            lblRightArm.TextAlign = ContentAlignment.TopCenter;
            lblRightArm.Visible = false;
            // 
            // lblLeftLeg
            // 
            lblLeftLeg.AutoSize = true;
            lblLeftLeg.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeftLeg.Location = new Point(86, 163);
            lblLeftLeg.Name = "lblLeftLeg";
            lblLeftLeg.Size = new Size(80, 106);
            lblLeftLeg.TabIndex = 2;
            lblLeftLeg.Text = "/";
            lblLeftLeg.TextAlign = ContentAlignment.TopCenter;
            lblLeftLeg.Visible = false;
            // 
            // lblLeftArm
            // 
            lblLeftArm.AutoSize = true;
            lblLeftArm.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeftArm.Location = new Point(86, 72);
            lblLeftArm.Name = "lblLeftArm";
            lblLeftArm.Size = new Size(80, 106);
            lblLeftArm.TabIndex = 4;
            lblLeftArm.Text = "/";
            lblLeftArm.TextAlign = ContentAlignment.TopCenter;
            lblLeftArm.Visible = false;
            // 
            // lblHead
            // 
            lblHead.Anchor = AnchorStyles.Top;
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHead.Location = new Point(86, -33);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(132, 133);
            lblHead.TabIndex = 0;
            lblHead.Text = "O";
            lblHead.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1241, 646);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hangman";
            tblMain.ResumeLayout(false);
            tblToolbar.ResumeLayout(false);
            tblToolbar.PerformLayout();
            pnlDifficulty.ResumeLayout(false);
            pnlDifficulty.PerformLayout();
            tblAlphabet.ResumeLayout(false);
            tblHiddenWord.ResumeLayout(false);
            tblHiddenWord.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlMan.ResumeLayout(false);
            pnlMan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblToolbar;
        private TableLayoutPanel tblAlphabet;
        private TableLayoutPanel tblHiddenWord;
        private Label lblHiddenWord;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnStart;
        private Button btnGiveUp;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;
        private Label lblMessage;
        private FlowLayoutPanel pnlDifficulty;
        private Label lblDifficulty;
        private RadioButton rdoEasy;
        private RadioButton rdoMedium;
        private RadioButton rdoHard;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBase;
        private Label lblPole;
        private Label lblBeam;
        private Label lblRope;
        private Panel pnlMan;
        private Label lblHead;
        private Label lblLeftLeg;
        private Label lblBody;
        private Label lblRightArm;
        private Label lblLeftArm;
        private Label lblRightLeg;
    }
}
