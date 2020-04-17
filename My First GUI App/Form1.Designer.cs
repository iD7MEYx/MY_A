namespace My_First_GUI_App
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.LblPW = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.linkLblForgotPassword);
            this.groupBox1.Controls.Add(this.LblPW);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(341, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLblForgotPassword
            // 
            this.linkLblForgotPassword.AutoSize = true;
            this.linkLblForgotPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linkLblForgotPassword.Location = new System.Drawing.Point(20, 168);
            this.linkLblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblForgotPassword.Name = "linkLblForgotPassword";
            this.linkLblForgotPassword.Size = new System.Drawing.Size(118, 17);
            this.linkLblForgotPassword.TabIndex = 7;
            this.linkLblForgotPassword.TabStop = true;
            this.linkLblForgotPassword.Text = "Forgot Password?";
            this.linkLblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblForgotPassword_LinkClicked);
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblPW.Location = new System.Drawing.Point(79, 86);
            this.LblPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(81, 21);
            this.LblPW.TabIndex = 6;
            this.LblPW.Text = "Password";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblUser.Location = new System.Drawing.Point(76, 45);
            this.LblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(85, 21);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "Username";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(196, 86);
            this.TxtPW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(113, 32);
            this.TxtPW.TabIndex = 4;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(196, 42);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(113, 32);
            this.TxtUser.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnLogin.Location = new System.Drawing.Point(196, 159);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(115, 31);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseCompatibleTextRendering = true;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1072, 459);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(332, 102);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.BtnCheckBox);
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(395, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(237, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnCheckBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnCheckBox.Location = new System.Drawing.Point(41, 89);
            this.BtnCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(151, 34);
            this.BtnCheckBox.TabIndex = 2;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseCompatibleTextRendering = true;
            this.BtnCheckBox.UseVisualStyleBackColor = false;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnCombo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnCombo.Location = new System.Drawing.Point(41, 138);
            this.BtnCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(151, 34);
            this.BtnCombo.TabIndex = 1;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseCompatibleTextRendering = true;
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRadio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRadio.Location = new System.Drawing.Point(41, 41);
            this.BtnRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(151, 34);
            this.BtnRadio.TabIndex = 0;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseCompatibleTextRendering = true;
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.BtnSelfieApp);
            this.groupBox3.Controls.Add(this.BtnPictureBox2);
            this.groupBox3.Controls.Add(this.BtnGroupieApp);
            this.groupBox3.Controls.Add(this.BtnPictureBox);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(1072, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(420, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnSelfieApp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSelfieApp.Location = new System.Drawing.Point(219, 159);
            this.BtnSelfieApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(176, 71);
            this.BtnSelfieApp.TabIndex = 3;
            this.BtnSelfieApp.Text = "Selfie App";
            this.BtnSelfieApp.UseCompatibleTextRendering = true;
            this.BtnSelfieApp.UseVisualStyleBackColor = false;
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnPictureBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnPictureBox2.Location = new System.Drawing.Point(219, 51);
            this.BtnPictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(176, 71);
            this.BtnPictureBox2.TabIndex = 2;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseCompatibleTextRendering = true;
            this.BtnPictureBox2.UseVisualStyleBackColor = false;
            this.BtnPictureBox2.Click += new System.EventHandler(this.BtnPictureBox2_Click);
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnGroupieApp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnGroupieApp.Location = new System.Drawing.Point(8, 159);
            this.BtnGroupieApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(176, 71);
            this.BtnGroupieApp.TabIndex = 1;
            this.BtnGroupieApp.Text = "Groupie App";
            this.BtnGroupieApp.UseCompatibleTextRendering = true;
            this.BtnGroupieApp.UseVisualStyleBackColor = false;
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnPictureBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnPictureBox.Location = new System.Drawing.Point(8, 47);
            this.BtnPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(176, 71);
            this.BtnPictureBox.TabIndex = 0;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseCompatibleTextRendering = true;
            this.BtnPictureBox.UseVisualStyleBackColor = false;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Wheat;
            this.groupBox4.Controls.Add(this.BtnProgress);
            this.groupBox4.Controls.Add(this.BtnTimer);
            this.groupBox4.Controls.Add(this.BtnRandomCombo);
            this.groupBox4.Controls.Add(this.BtnRandom);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox4.Location = new System.Drawing.Point(320, 242);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(356, 167);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnProgress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnProgress.Location = new System.Drawing.Point(178, 23);
            this.BtnProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(151, 49);
            this.BtnProgress.TabIndex = 3;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseCompatibleTextRendering = true;
            this.BtnProgress.UseVisualStyleBackColor = false;
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnTimer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnTimer.Location = new System.Drawing.Point(20, 23);
            this.BtnTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(151, 49);
            this.BtnTimer.TabIndex = 2;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseCompatibleTextRendering = true;
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRandomCombo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRandomCombo.Location = new System.Drawing.Point(20, 112);
            this.BtnRandomCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(151, 49);
            this.BtnRandomCombo.TabIndex = 1;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseCompatibleTextRendering = true;
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRandom.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRandom.Location = new System.Drawing.Point(178, 112);
            this.BtnRandom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(151, 49);
            this.BtnRandom.TabIndex = 0;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseCompatibleTextRendering = true;
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Wheat;
            this.groupBox5.Controls.Add(this.BtnDraw);
            this.groupBox5.Controls.Add(this.BtnTalk);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox5.Location = new System.Drawing.Point(3, 242);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(310, 167);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnDraw.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnDraw.Location = new System.Drawing.Point(173, 49);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(111, 53);
            this.BtnDraw.TabIndex = 2;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseCompatibleTextRendering = true;
            this.BtnDraw.UseVisualStyleBackColor = false;
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnTalk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnTalk.Location = new System.Drawing.Point(10, 49);
            this.BtnTalk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(111, 53);
            this.BtnTalk.TabIndex = 1;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseCompatibleTextRendering = true;
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Wheat;
            this.groupBox6.Controls.Add(this.BtnABCAnalysis);
            this.groupBox6.Controls.Add(this.BtnRoboticCell);
            this.groupBox6.Controls.Add(this.BtnJohari);
            this.groupBox6.Controls.Add(this.BtnManufacturingCell);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox6.Location = new System.Drawing.Point(697, 22);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(338, 322);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnABCAnalysis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnABCAnalysis.Location = new System.Drawing.Point(65, 238);
            this.BtnABCAnalysis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(180, 59);
            this.BtnABCAnalysis.TabIndex = 3;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseCompatibleTextRendering = true;
            this.BtnABCAnalysis.UseVisualStyleBackColor = false;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRoboticCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRoboticCell.Location = new System.Drawing.Point(66, 162);
            this.BtnRoboticCell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(179, 57);
            this.BtnRoboticCell.TabIndex = 2;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseCompatibleTextRendering = true;
            this.BtnRoboticCell.UseVisualStyleBackColor = false;
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnJohari.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnJohari.Location = new System.Drawing.Point(66, 99);
            this.BtnJohari.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(180, 57);
            this.BtnJohari.TabIndex = 1;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseCompatibleTextRendering = true;
            this.BtnJohari.UseVisualStyleBackColor = false;
            this.BtnJohari.Click += new System.EventHandler(this.button14_Click);
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnManufacturingCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnManufacturingCell.Location = new System.Drawing.Point(66, 29);
            this.BtnManufacturingCell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(180, 59);
            this.BtnManufacturingCell.TabIndex = 0;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseCompatibleTextRendering = true;
            this.BtnManufacturingCell.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Wheat;
            this.groupBox7.Controls.Add(this.BtnArduino);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox7.Location = new System.Drawing.Point(697, 370);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(255, 93);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Macro Controler";
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnArduino.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnArduino.Location = new System.Drawing.Point(44, 35);
            this.BtnArduino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(179, 46);
            this.BtnArduino.TabIndex = 2;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAbout.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Location = new System.Drawing.Point(36, 470);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(188, 58);
            this.BtnAbout.TabIndex = 4;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 593);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.LinkLabel linkLblForgotPassword;
    }
}

