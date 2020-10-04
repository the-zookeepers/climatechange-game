﻿namespace Nasa_Game
{
    partial class Reef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reef));
            this.btn_back = new System.Windows.Forms.Button();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.pnl_reef = new System.Windows.Forms.Panel();
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_challenge = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_c3 = new System.Windows.Forms.Button();
            this.btn_c2 = new System.Windows.Forms.Button();
            this.btn_c1 = new System.Windows.Forms.Button();
            this.lbl_feedBack = new System.Windows.Forms.Label();
            this.lbl_context = new System.Windows.Forms.Label();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.pic_4 = new System.Windows.Forms.PictureBox();
            this.pic_3 = new System.Windows.Forms.PictureBox();
            this.pic_5 = new System.Windows.Forms.PictureBox();
            this.pic_9 = new System.Windows.Forms.PictureBox();
            this.pic_8 = new System.Windows.Forms.PictureBox();
            this.pic_7 = new System.Windows.Forms.PictureBox();
            this.pic_6 = new System.Windows.Forms.PictureBox();
            this.pic_player = new System.Windows.Forms.PictureBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.pnl_reef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1493, 114);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 55);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Leave Area";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pic_1
            // 
            this.pic_1.Image = ((System.Drawing.Image)(resources.GetObject("pic_1.Image")));
            this.pic_1.Location = new System.Drawing.Point(189, 114);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(249, 211);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 1;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // pnl_reef
            // 
            this.pnl_reef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_reef.BackgroundImage")));
            this.pnl_reef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_reef.Controls.Add(this.btn_complete);
            this.pnl_reef.Controls.Add(this.btn_exit);
            this.pnl_reef.Controls.Add(this.btn_challenge);
            this.pnl_reef.Controls.Add(this.btn_previous);
            this.pnl_reef.Controls.Add(this.btn_c3);
            this.pnl_reef.Controls.Add(this.btn_c2);
            this.pnl_reef.Controls.Add(this.btn_c1);
            this.pnl_reef.Controls.Add(this.lbl_feedBack);
            this.pnl_reef.Controls.Add(this.lbl_context);
            this.pnl_reef.Location = new System.Drawing.Point(504, 460);
            this.pnl_reef.Name = "pnl_reef";
            this.pnl_reef.Size = new System.Drawing.Size(809, 468);
            this.pnl_reef.TabIndex = 2;
            this.pnl_reef.Visible = false;
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(671, 423);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(120, 30);
            this.btn_complete.TabIndex = 8;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Visible = false;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(17, 423);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 30);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_challenge
            // 
            this.btn_challenge.Location = new System.Drawing.Point(494, 329);
            this.btn_challenge.Name = "btn_challenge";
            this.btn_challenge.Size = new System.Drawing.Size(104, 34);
            this.btn_challenge.TabIndex = 6;
            this.btn_challenge.Text = "Challenge";
            this.btn_challenge.UseVisualStyleBackColor = true;
            this.btn_challenge.Click += new System.EventHandler(this.btn_challenge_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(211, 329);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(103, 34);
            this.btn_previous.TabIndex = 5;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Visible = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_c3
            // 
            this.btn_c3.Location = new System.Drawing.Point(85, 227);
            this.btn_c3.Name = "btn_c3";
            this.btn_c3.Size = new System.Drawing.Size(642, 46);
            this.btn_c3.TabIndex = 4;
            this.btn_c3.Text = "button3";
            this.btn_c3.UseVisualStyleBackColor = true;
            this.btn_c3.Visible = false;
            this.btn_c3.Click += new System.EventHandler(this.btn_c3_Click);
            // 
            // btn_c2
            // 
            this.btn_c2.Location = new System.Drawing.Point(85, 160);
            this.btn_c2.Name = "btn_c2";
            this.btn_c2.Size = new System.Drawing.Size(642, 46);
            this.btn_c2.TabIndex = 3;
            this.btn_c2.Text = "button2";
            this.btn_c2.UseVisualStyleBackColor = true;
            this.btn_c2.Visible = false;
            this.btn_c2.Click += new System.EventHandler(this.btn_c2_Click);
            // 
            // btn_c1
            // 
            this.btn_c1.Location = new System.Drawing.Point(85, 87);
            this.btn_c1.Name = "btn_c1";
            this.btn_c1.Size = new System.Drawing.Size(642, 46);
            this.btn_c1.TabIndex = 2;
            this.btn_c1.Text = "button1";
            this.btn_c1.UseVisualStyleBackColor = true;
            this.btn_c1.Visible = false;
            this.btn_c1.Click += new System.EventHandler(this.btn_c1_Click);
            // 
            // lbl_feedBack
            // 
            this.lbl_feedBack.AutoSize = true;
            this.lbl_feedBack.Location = new System.Drawing.Point(207, 291);
            this.lbl_feedBack.Name = "lbl_feedBack";
            this.lbl_feedBack.Size = new System.Drawing.Size(75, 20);
            this.lbl_feedBack.TabIndex = 1;
            this.lbl_feedBack.Text = "feedback";
            this.lbl_feedBack.Visible = false;
            // 
            // lbl_context
            // 
            this.lbl_context.AutoSize = true;
            this.lbl_context.Location = new System.Drawing.Point(3, 16);
            this.lbl_context.Name = "lbl_context";
            this.lbl_context.Size = new System.Drawing.Size(35, 20);
            this.lbl_context.TabIndex = 0;
            this.lbl_context.Text = "text";
            // 
            // pic_2
            // 
            this.pic_2.Image = ((System.Drawing.Image)(resources.GetObject("pic_2.Image")));
            this.pic_2.Location = new System.Drawing.Point(586, 114);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(249, 211);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_2.TabIndex = 3;
            this.pic_2.TabStop = false;
            this.pic_2.Click += new System.EventHandler(this.pic_2_Click);
            // 
            // pic_4
            // 
            this.pic_4.Image = ((System.Drawing.Image)(resources.GetObject("pic_4.Image")));
            this.pic_4.Location = new System.Drawing.Point(1373, 419);
            this.pic_4.Name = "pic_4";
            this.pic_4.Size = new System.Drawing.Size(249, 211);
            this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_4.TabIndex = 4;
            this.pic_4.TabStop = false;
            this.pic_4.Click += new System.EventHandler(this.pic_4_Click);
            // 
            // pic_3
            // 
            this.pic_3.Image = ((System.Drawing.Image)(resources.GetObject("pic_3.Image")));
            this.pic_3.Location = new System.Drawing.Point(1013, 114);
            this.pic_3.Name = "pic_3";
            this.pic_3.Size = new System.Drawing.Size(249, 211);
            this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_3.TabIndex = 5;
            this.pic_3.TabStop = false;
            this.pic_3.Click += new System.EventHandler(this.pic_3_Click);
            // 
            // pic_5
            // 
            this.pic_5.Image = ((System.Drawing.Image)(resources.GetObject("pic_5.Image")));
            this.pic_5.Location = new System.Drawing.Point(1373, 717);
            this.pic_5.Name = "pic_5";
            this.pic_5.Size = new System.Drawing.Size(249, 211);
            this.pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_5.TabIndex = 6;
            this.pic_5.TabStop = false;
            this.pic_5.Click += new System.EventHandler(this.pic_5_Click);
            // 
            // pic_9
            // 
            this.pic_9.Image = ((System.Drawing.Image)(resources.GetObject("pic_9.Image")));
            this.pic_9.Location = new System.Drawing.Point(189, 419);
            this.pic_9.Name = "pic_9";
            this.pic_9.Size = new System.Drawing.Size(249, 211);
            this.pic_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_9.TabIndex = 7;
            this.pic_9.TabStop = false;
            this.pic_9.Click += new System.EventHandler(this.pic_9_Click);
            // 
            // pic_8
            // 
            this.pic_8.Image = ((System.Drawing.Image)(resources.GetObject("pic_8.Image")));
            this.pic_8.Location = new System.Drawing.Point(189, 717);
            this.pic_8.Name = "pic_8";
            this.pic_8.Size = new System.Drawing.Size(249, 211);
            this.pic_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_8.TabIndex = 8;
            this.pic_8.TabStop = false;
            this.pic_8.Click += new System.EventHandler(this.pic_8_Click);
            // 
            // pic_7
            // 
            this.pic_7.Image = ((System.Drawing.Image)(resources.GetObject("pic_7.Image")));
            this.pic_7.Location = new System.Drawing.Point(586, 973);
            this.pic_7.Name = "pic_7";
            this.pic_7.Size = new System.Drawing.Size(249, 211);
            this.pic_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_7.TabIndex = 9;
            this.pic_7.TabStop = false;
            this.pic_7.Click += new System.EventHandler(this.pic_7_Click);
            // 
            // pic_6
            // 
            this.pic_6.Image = ((System.Drawing.Image)(resources.GetObject("pic_6.Image")));
            this.pic_6.Location = new System.Drawing.Point(1013, 973);
            this.pic_6.Name = "pic_6";
            this.pic_6.Size = new System.Drawing.Size(249, 211);
            this.pic_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_6.TabIndex = 10;
            this.pic_6.TabStop = false;
            this.pic_6.Click += new System.EventHandler(this.pic_6_Click);
            // 
            // pic_player
            // 
            this.pic_player.Image = ((System.Drawing.Image)(resources.GetObject("pic_player.Image")));
            this.pic_player.Location = new System.Drawing.Point(1356, 175);
            this.pic_player.Name = "pic_player";
            this.pic_player.Size = new System.Drawing.Size(158, 211);
            this.pic_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_player.TabIndex = 11;
            this.pic_player.TabStop = false;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(598, 351);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(104, 25);
            this.lbl_welcome.TabIndex = 9;
            this.lbl_welcome.Text = "welcome";
            // 
            // Reef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1901, 1341);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pic_player);
            this.Controls.Add(this.pic_6);
            this.Controls.Add(this.pic_7);
            this.Controls.Add(this.pic_8);
            this.Controls.Add(this.pic_9);
            this.Controls.Add(this.pic_5);
            this.Controls.Add(this.pic_3);
            this.Controls.Add(this.pic_4);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pnl_reef);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reef";
            this.Text = "Great Barrier Reef";
            this.Load += new System.EventHandler(this.Reef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.pnl_reef.ResumeLayout(false);
            this.pnl_reef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Panel pnl_reef;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.PictureBox pic_4;
        private System.Windows.Forms.PictureBox pic_3;
        private System.Windows.Forms.PictureBox pic_5;
        private System.Windows.Forms.PictureBox pic_9;
        private System.Windows.Forms.PictureBox pic_8;
        private System.Windows.Forms.PictureBox pic_7;
        private System.Windows.Forms.PictureBox pic_6;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_challenge;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_c3;
        private System.Windows.Forms.Button btn_c2;
        private System.Windows.Forms.Button btn_c1;
        private System.Windows.Forms.Label lbl_feedBack;
        private System.Windows.Forms.Label lbl_context;
        private System.Windows.Forms.PictureBox pic_player;
        private System.Windows.Forms.Label lbl_welcome;
    }
}