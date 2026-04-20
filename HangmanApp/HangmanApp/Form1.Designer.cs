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
            tblMain = new TableLayoutPanel();
            tblToolbar = new TableLayoutPanel();
            btnStart = new Button();
            btnGiveUp = new Button();
            lblMessage = new Label();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlMan = new Panel();
            lblBody = new Label();
            lblRightLeg = new Label();
            lblRightArm = new Label();
            lblLeftLeg = new Label();
            lblLeftArm = new Label();
            lblHead = new Label();
            tblMain.SuspendLayout();
            tblToolbar.SuspendLayout();
            tblAlphabet.SuspendLayout();
            tblHiddenWord.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlMan.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.22038F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7796173F));
            tblMain.Controls.Add(tblToolbar, 0, 0);
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
            tblMain.Size = new Size(1207, 620);
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
            tblToolbar.Size = new Size(1201, 69);
            tblToolbar.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(234, 63);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnGiveUp
            // 
            btnGiveUp.Dock = DockStyle.Fill;
            btnGiveUp.Enabled = false;
            btnGiveUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiveUp.Location = new Point(963, 3);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(235, 63);
            btnGiveUp.TabIndex = 1;
            btnGiveUp.Text = "Give Up";
            btnGiveUp.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(243, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(714, 69);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Click start to begin game.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
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
            tblAlphabet.Location = new Point(3, 120);
            tblAlphabet.Name = "tblAlphabet";
            tblAlphabet.RowCount = 4;
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAlphabet.Size = new Size(745, 270);
            tblAlphabet.TabIndex = 1;
            // 
            // btnA
            // 
            btnA.Dock = DockStyle.Fill;
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI", 12F);
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(87, 61);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            btnB.Dock = DockStyle.Fill;
            btnB.Enabled = false;
            btnB.Font = new Font("Segoe UI", 12F);
            btnB.Location = new Point(96, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(87, 61);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Enabled = false;
            btnC.Font = new Font("Segoe UI", 12F);
            btnC.Location = new Point(189, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(87, 61);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            btnD.Dock = DockStyle.Fill;
            btnD.Enabled = false;
            btnD.Font = new Font("Segoe UI", 12F);
            btnD.Location = new Point(282, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(87, 61);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Dock = DockStyle.Fill;
            btnE.Enabled = false;
            btnE.Font = new Font("Segoe UI", 12F);
            btnE.Location = new Point(375, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(87, 61);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            btnF.Dock = DockStyle.Fill;
            btnF.Enabled = false;
            btnF.Font = new Font("Segoe UI", 12F);
            btnF.Location = new Point(468, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(87, 61);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            btnG.Dock = DockStyle.Fill;
            btnG.Enabled = false;
            btnG.Font = new Font("Segoe UI", 12F);
            btnG.Location = new Point(561, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(87, 61);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            btnH.Dock = DockStyle.Fill;
            btnH.Enabled = false;
            btnH.Font = new Font("Segoe UI", 12F);
            btnH.Location = new Point(654, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(88, 61);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            btnI.Dock = DockStyle.Fill;
            btnI.Enabled = false;
            btnI.Font = new Font("Segoe UI", 12F);
            btnI.Location = new Point(3, 70);
            btnI.Name = "btnI";
            btnI.Size = new Size(87, 61);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            btnJ.Dock = DockStyle.Fill;
            btnJ.Enabled = false;
            btnJ.Font = new Font("Segoe UI", 12F);
            btnJ.Location = new Point(96, 70);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(87, 61);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            btnK.Dock = DockStyle.Fill;
            btnK.Enabled = false;
            btnK.Font = new Font("Segoe UI", 12F);
            btnK.Location = new Point(189, 70);
            btnK.Name = "btnK";
            btnK.Size = new Size(87, 61);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Dock = DockStyle.Fill;
            btnL.Enabled = false;
            btnL.Font = new Font("Segoe UI", 12F);
            btnL.Location = new Point(282, 70);
            btnL.Name = "btnL";
            btnL.Size = new Size(87, 61);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            btnM.Dock = DockStyle.Fill;
            btnM.Enabled = false;
            btnM.Font = new Font("Segoe UI", 12F);
            btnM.Location = new Point(375, 70);
            btnM.Name = "btnM";
            btnM.Size = new Size(87, 61);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            btnN.Dock = DockStyle.Fill;
            btnN.Enabled = false;
            btnN.Font = new Font("Segoe UI", 12F);
            btnN.Location = new Point(468, 70);
            btnN.Name = "btnN";
            btnN.Size = new Size(87, 61);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            btnO.Dock = DockStyle.Fill;
            btnO.Enabled = false;
            btnO.Font = new Font("Segoe UI", 12F);
            btnO.Location = new Point(561, 70);
            btnO.Name = "btnO";
            btnO.Size = new Size(87, 61);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            btnP.Dock = DockStyle.Fill;
            btnP.Enabled = false;
            btnP.Font = new Font("Segoe UI", 12F);
            btnP.Location = new Point(654, 70);
            btnP.Name = "btnP";
            btnP.Size = new Size(88, 61);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            btnQ.Dock = DockStyle.Fill;
            btnQ.Enabled = false;
            btnQ.Font = new Font("Segoe UI", 12F);
            btnQ.Location = new Point(3, 137);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(87, 61);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Dock = DockStyle.Fill;
            btnR.Enabled = false;
            btnR.Font = new Font("Segoe UI", 12F);
            btnR.Location = new Point(96, 137);
            btnR.Name = "btnR";
            btnR.Size = new Size(87, 61);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Dock = DockStyle.Fill;
            btnS.Enabled = false;
            btnS.Font = new Font("Segoe UI", 12F);
            btnS.Location = new Point(189, 137);
            btnS.Name = "btnS";
            btnS.Size = new Size(87, 61);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            btnT.Dock = DockStyle.Fill;
            btnT.Enabled = false;
            btnT.Font = new Font("Segoe UI", 12F);
            btnT.Location = new Point(282, 137);
            btnT.Name = "btnT";
            btnT.Size = new Size(87, 61);
            btnT.TabIndex = 19;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Enabled = false;
            btnU.Font = new Font("Segoe UI", 12F);
            btnU.Location = new Point(375, 137);
            btnU.Name = "btnU";
            btnU.Size = new Size(87, 61);
            btnU.TabIndex = 20;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            btnV.Dock = DockStyle.Fill;
            btnV.Enabled = false;
            btnV.Font = new Font("Segoe UI", 12F);
            btnV.Location = new Point(468, 137);
            btnV.Name = "btnV";
            btnV.Size = new Size(87, 61);
            btnV.TabIndex = 21;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            btnW.Dock = DockStyle.Fill;
            btnW.Enabled = false;
            btnW.Font = new Font("Segoe UI", 12F);
            btnW.Location = new Point(561, 137);
            btnW.Name = "btnW";
            btnW.Size = new Size(87, 61);
            btnW.TabIndex = 22;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.Dock = DockStyle.Fill;
            btnX.Enabled = false;
            btnX.Font = new Font("Segoe UI", 12F);
            btnX.Location = new Point(654, 137);
            btnX.Name = "btnX";
            btnX.Size = new Size(88, 61);
            btnX.TabIndex = 23;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            btnY.Dock = DockStyle.Fill;
            btnY.Enabled = false;
            btnY.Font = new Font("Segoe UI", 12F);
            btnY.Location = new Point(282, 204);
            btnY.Name = "btnY";
            btnY.Size = new Size(87, 63);
            btnY.TabIndex = 24;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            btnZ.Dock = DockStyle.Fill;
            btnZ.Enabled = false;
            btnZ.Font = new Font("Segoe UI", 12F);
            btnZ.Location = new Point(375, 204);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(87, 63);
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
            tblHiddenWord.Location = new Point(3, 396);
            tblHiddenWord.Name = "tblHiddenWord";
            tblHiddenWord.RowCount = 3;
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Percent, 61.29032F));
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            tblHiddenWord.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblHiddenWord.Size = new Size(745, 221);
            tblHiddenWord.TabIndex = 2;
            // 
            // lblHiddenWord
            // 
            lblHiddenWord.AutoSize = true;
            lblHiddenWord.Dock = DockStyle.Fill;
            lblHiddenWord.Font = new Font("Segoe UI", 34.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHiddenWord.Location = new Point(3, 114);
            lblHiddenWord.Name = "lblHiddenWord";
            lblHiddenWord.Size = new Size(739, 72);
            lblHiddenWord.TabIndex = 0;
            lblHiddenWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlMan, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(754, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tblMain.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.43940854F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7122746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.39839F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.43940783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.84304953F));
            tableLayoutPanel1.Size = new Size(450, 497);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(label1, 5);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 440);
            label1.Name = "label1";
            label1.Size = new Size(444, 17);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(294, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            tableLayoutPanel1.SetRowSpan(label2, 3);
            label2.Size = new Size(14, 440);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(154, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(140, 17);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(140, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            tableLayoutPanel1.SetRowSpan(label4, 2);
            label4.Size = new Size(14, 110);
            label4.TabIndex = 4;
            label4.Text = "label4";
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
            pnlMan.Location = new Point(3, 113);
            pnlMan.Name = "pnlMan";
            pnlMan.Size = new Size(288, 324);
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
            ClientSize = new Size(1207, 620);
            Controls.Add(tblMain);
            Name = "Form1";
            Text = "Form1";
            tblMain.ResumeLayout(false);
            tblToolbar.ResumeLayout(false);
            tblToolbar.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlMan;
        private Label lblHead;
        private Label lblLeftLeg;
        private Label lblBody;
        private Label lblRightArm;
        private Label lblLeftArm;
        private Label lblRightLeg;
    }
}
