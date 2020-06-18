namespace Arkanoid
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnViewScores = new System.Windows.Forms.Button();
            this.BtnCreatePlayer = new System.Windows.Forms.Button();
            this.CmbPlayer = new System.Windows.Forms.ComboBox();
            this.tloMain = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.tloMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.AutoSize = true;
            this.BtnPlay.BackColor = System.Drawing.Color.LightGray;
            this.BtnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnPlay.Location = new System.Drawing.Point(343, 225);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(114, 52);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Jugar";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnViewScores
            // 
            this.BtnViewScores.AutoSize = true;
            this.BtnViewScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnViewScores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnViewScores.Location = new System.Drawing.Point(343, 281);
            this.BtnViewScores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnViewScores.Name = "BtnViewScores";
            this.BtnViewScores.Size = new System.Drawing.Size(114, 52);
            this.BtnViewScores.TabIndex = 1;
            this.BtnViewScores.Text = "Ver puntajes";
            this.BtnViewScores.UseVisualStyleBackColor = true;
            this.BtnViewScores.Click += new System.EventHandler(this.BtnViewScores_Click);
            // 
            // BtnCreatePlayer
            // 
            this.BtnCreatePlayer.AutoSize = true;
            this.BtnCreatePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreatePlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCreatePlayer.Location = new System.Drawing.Point(343, 337);
            this.BtnCreatePlayer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnCreatePlayer.Name = "BtnCreatePlayer";
            this.BtnCreatePlayer.Size = new System.Drawing.Size(114, 52);
            this.BtnCreatePlayer.TabIndex = 2;
            this.BtnCreatePlayer.Text = "Crear jugador";
            this.BtnCreatePlayer.UseVisualStyleBackColor = true;
            this.BtnCreatePlayer.Click += new System.EventHandler(this.BtnCreatePlayer_Click_1);
            // 
            // CmbPlayer
            // 
            this.CmbPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlayer.FormattingEnabled = true;
            this.CmbPlayer.Location = new System.Drawing.Point(344, 173);
            this.CmbPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbPlayer.Name = "CmbPlayer";
            this.CmbPlayer.Size = new System.Drawing.Size(112, 28);
            this.CmbPlayer.TabIndex = 3;
            // 
            // tloMain
            // 
            this.tloMain.BackColor = System.Drawing.Color.Transparent;
            this.tloMain.ColumnCount = 3;
            this.tloMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tloMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tloMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tloMain.Controls.Add(this.CmbPlayer, 1, 1);
            this.tloMain.Controls.Add(this.BtnCreatePlayer, 1, 4);
            this.tloMain.Controls.Add(this.BtnPlay, 1, 2);
            this.tloMain.Controls.Add(this.BtnViewScores, 1, 3);
            this.tloMain.Controls.Add(this.BtnExit, 1, 5);
            this.tloMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloMain.Location = new System.Drawing.Point(0, 0);
            this.tloMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tloMain.Name = "tloMain";
            this.tloMain.RowCount = 7;
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tloMain.Size = new System.Drawing.Size(800, 561);
            this.tloMain.TabIndex = 4;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnExit.Location = new System.Drawing.Point(343, 394);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(114, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.tloMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arkanoid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tloMain.ResumeLayout(false);
            this.tloMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tloMain;

        #endregion

        private System.Windows.Forms.ComboBox CmbPlayer;
        private System.Windows.Forms.Button BtnCreatePlayer;
        private System.Windows.Forms.Button BtnViewScores;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPlay;
    }
}