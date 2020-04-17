﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_GUI_App
{
    public partial class frmMain : Form
    {
        string username = "d7om";
        string myPassword = "1234";
        bool loggedIn = false;
        int attempt = 1;
        int MaxAttempts = 3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "d7om" && TxtPW.Text == "1234")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                if ( TxtUser.Text != "d7om")
                {
                    MessageBox.Show("Incorrect username");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made my @Abdulrahman");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void linkLblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("pls contact the admin to help you ");
        }
    }
}
