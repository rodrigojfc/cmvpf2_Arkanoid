using System.ComponentModel;

namespace Arkanoid
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBackToMain = new System.Windows.Forms.Button();
            this.BtnPlayerCreated = new System.Windows.Forms.Button();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tloScores = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBackToMain2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tloScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1041, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnBackToMain, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnPlayerCreated, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPlayer, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 682);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnBackToMain
            // 
            this.BtnBackToMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBackToMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBackToMain.Location = new System.Drawing.Point(622, 277);
            this.BtnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBackToMain.Name = "BtnBackToMain";
            this.BtnBackToMain.Size = new System.Drawing.Size(146, 51);
            this.BtnBackToMain.TabIndex = 2;
            this.BtnBackToMain.Text = "Volver";
            this.BtnBackToMain.UseVisualStyleBackColor = true;
            this.BtnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // BtnPlayerCreated
            // 
            this.BtnPlayerCreated.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlayerCreated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnPlayerCreated.Location = new System.Drawing.Point(262, 277);
            this.BtnPlayerCreated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPlayerCreated.Name = "BtnPlayerCreated";
            this.BtnPlayerCreated.Size = new System.Drawing.Size(146, 51);
            this.BtnPlayerCreated.TabIndex = 1;
            this.BtnPlayerCreated.Text = "Crear";
            this.BtnPlayerCreated.UseVisualStyleBackColor = true;
            this.BtnPlayerCreated.Click += new System.EventHandler(this.BtnPlayerCreated_Click);
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNewPlayer.Location = new System.Drawing.Point(416, 104);
            this.txtNewPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(198, 27);
            this.txtNewPlayer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.tloScores);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1041, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Puntajes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tloScores
            // 
            this.tloScores.ColumnCount = 4;
            this.tloScores.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tloScores.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tloScores.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tloScores.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tloScores.Controls.Add(this.dataGridView1, 1, 1);
            this.tloScores.Controls.Add(this.BtnBackToMain2, 3, 0);
            this.tloScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloScores.Location = new System.Drawing.Point(4, 5);
            this.tloScores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tloScores.Name = "tloScores";
            this.tloScores.RowCount = 3;
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tloScores.Size = new System.Drawing.Size(1033, 682);
            this.tloScores.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(365, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 399);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnBackToMain2
            // 
            this.BtnBackToMain2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnBackToMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBackToMain2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBackToMain2.ForeColor = System.Drawing.Color.Black;
            this.BtnBackToMain2.Location = new System.Drawing.Point(911, 5);
            this.BtnBackToMain2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBackToMain2.Name = "BtnBackToMain2";
            this.BtnBackToMain2.Size = new System.Drawing.Size(118, 58);
            this.BtnBackToMain2.TabIndex = 1;
            this.BtnBackToMain2.Text = "Volver";
            this.BtnBackToMain2.UseVisualStyleBackColor = false;
            this.BtnBackToMain2.Click += new System.EventHandler(this.BtnBackToMain2_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1049, 725);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMenu_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tloScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tloScores;
        private System.Windows.Forms.TextBox txtNewPlayer;

        #endregion

        private System.Windows.Forms.Button BtnPlayerCreated;
        private System.Windows.Forms.Button BtnBackToMain2;
        private System.Windows.Forms.Button BtnBackToMain;
    }
}