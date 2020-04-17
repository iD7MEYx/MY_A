namespace My_First_GUI_App
{
    partial class frmPic01
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.btnFromF = new System.Windows.Forms.Button();
            this.btnFromR = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.PicTry);
            this.groupBox1.Location = new System.Drawing.Point(276, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1239, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(640, 66);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(591, 430);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(8, 66);
            this.PicTry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(591, 430);
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            // 
            // btnFromF
            // 
            this.btnFromF.Location = new System.Drawing.Point(51, 51);
            this.btnFromF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFromF.Name = "btnFromF";
            this.btnFromF.Size = new System.Drawing.Size(201, 58);
            this.btnFromF.TabIndex = 1;
            this.btnFromF.Text = "Image From File";
            this.btnFromF.UseVisualStyleBackColor = true;
            this.btnFromF.Click += new System.EventHandler(this.btnFromF_Click);
            // 
            // btnFromR
            // 
            this.btnFromR.Location = new System.Drawing.Point(51, 141);
            this.btnFromR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFromR.Name = "btnFromR";
            this.btnFromR.Size = new System.Drawing.Size(201, 58);
            this.btnFromR.TabIndex = 1;
            this.btnFromR.Text = "Image From Resource";
            this.btnFromR.UseVisualStyleBackColor = true;
            this.btnFromR.Click += new System.EventHandler(this.btnFromR_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1306, 639);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 58);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFromR);
            this.Controls.Add(this.btnFromF);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPic01";
            this.Text = "frmPic01";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button btnFromF;
        private System.Windows.Forms.Button btnFromR;
        private System.Windows.Forms.Button btnBack;
    }
}