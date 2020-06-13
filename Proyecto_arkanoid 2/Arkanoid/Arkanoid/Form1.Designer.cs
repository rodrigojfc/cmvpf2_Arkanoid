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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnViewScores = new System.Windows.Forms.Button();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.cmbPlayer = new System.Windows.Forms.ComboBox();
            this.tloMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tloMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.LightGray;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.Location = new System.Drawing.Point(343, 225);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 52);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jugar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnViewScores
            // 
            this.btnViewScores.AutoSize = true;
            this.btnViewScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewScores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewScores.Location = new System.Drawing.Point(343, 281);
            this.btnViewScores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(114, 52);
            this.btnViewScores.TabIndex = 1;
            this.btnViewScores.Text = "Ver puntajes";
            this.btnViewScores.UseVisualStyleBackColor = true;
            this.btnViewScores.Click += new System.EventHandler(this.btnViewScores_Click);
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.AutoSize = true;
            this.btnCreatePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreatePlayer.Location = new System.Drawing.Point(343, 337);
            this.btnCreatePlayer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(114, 52);
            this.btnCreatePlayer.TabIndex = 2;
            this.btnCreatePlayer.Text = "Crear jugador";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click_1);
            // 
            // cmbPlayer
            // 
            this.cmbPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer.FormattingEnabled = true;
            this.cmbPlayer.Location = new System.Drawing.Point(344, 173);
            this.cmbPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPlayer.Name = "cmbPlayer";
            this.cmbPlayer.Size = new System.Drawing.Size(112, 28);
            this.cmbPlayer.TabIndex = 3;
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
            this.tloMain.Controls.Add(this.cmbPlayer, 1, 1);
            this.tloMain.Controls.Add(this.btnCreatePlayer, 1, 4);
            this.tloMain.Controls.Add(this.btnPlay, 1, 2);
            this.tloMain.Controls.Add(this.btnViewScores, 1, 3);
            this.tloMain.Controls.Add(this.btnExit, 1, 5);
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
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(343, 394);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tloMain.ResumeLayout(false);
            this.tloMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TableLayoutPanel tloMain;

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewScores;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.ComboBox cmbPlayer;
    }
}