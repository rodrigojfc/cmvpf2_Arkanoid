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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnPlayerCreated = new System.Windows.Forms.Button();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tloScores = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackToMain2 = new System.Windows.Forms.Button();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnBackToMain, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPlayerCreated, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPlayer, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 439);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackToMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackToMain.Location = new System.Drawing.Point(465, 177);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(109, 33);
            this.btnBackToMain.TabIndex = 2;
            this.btnBackToMain.Text = "Volver";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnPlayerCreated
            // 
            this.btnPlayerCreated.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayerCreated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlayerCreated.Location = new System.Drawing.Point(196, 177);
            this.btnPlayerCreated.Name = "btnPlayerCreated";
            this.btnPlayerCreated.Size = new System.Drawing.Size(109, 33);
            this.btnPlayerCreated.TabIndex = 1;
            this.btnPlayerCreated.Text = "Crear";
            this.btnPlayerCreated.UseVisualStyleBackColor = true;
            this.btnPlayerCreated.Click += new System.EventHandler(this.btnPlayerCreated_Click);
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNewPlayer.Location = new System.Drawing.Point(311, 64);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(148, 20);
            this.txtNewPlayer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.tloScores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Puntajes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tloScores
            // 
            this.tloScores.ColumnCount = 4;
            this.tloScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tloScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tloScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tloScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tloScores.Controls.Add(this.dataGridView1, 1, 1);
            this.tloScores.Controls.Add(this.btnBackToMain2, 3, 0);
            this.tloScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloScores.Location = new System.Drawing.Point(3, 3);
            this.tloScores.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tloScores.Name = "tloScores";
            this.tloScores.RowCount = 3;
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tloScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tloScores.Size = new System.Drawing.Size(773, 439);
            this.tloScores.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(273, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnBackToMain2
            // 
            this.btnBackToMain2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBackToMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackToMain2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToMain2.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMain2.Location = new System.Drawing.Point(681, 3);
            this.btnBackToMain2.Name = "btnBackToMain2";
            this.btnBackToMain2.Size = new System.Drawing.Size(89, 37);
            this.btnBackToMain2.TabIndex = 1;
            this.btnBackToMain2.Text = "Volver";
            this.btnBackToMain2.UseVisualStyleBackColor = false;
            this.btnBackToMain2.Click += new System.EventHandler(this.btnBackToMain2_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(787, 471);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tloScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnBackToMain2;
        private System.Windows.Forms.Button btnPlayerCreated;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tloScores;
        private System.Windows.Forms.TextBox txtNewPlayer;

        #endregion
    }
}