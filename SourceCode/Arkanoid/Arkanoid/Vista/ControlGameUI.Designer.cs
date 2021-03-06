﻿using System.ComponentModel;

namespace Arkanoid
{
    partial class ControlGameUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.playerPb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.playerPb)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPb
            // 
            this.playerPb.Location = new System.Drawing.Point(52, 475);
            this.playerPb.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.playerPb.Name = "playerPb";
            this.playerPb.Size = new System.Drawing.Size(165, 39);
            this.playerPb.TabIndex = 0;
            this.playerPb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ControlGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (72)))));
            this.Controls.Add(this.playerPb);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ControlGameUI";
            this.Size = new System.Drawing.Size(860, 561);
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameUI_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameUI_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.playerPb)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox playerPb;
    }
}