
namespace shakespeare
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
            this.lblDarab = new System.Windows.Forms.Label();
            this.btnUtolsoMuve = new System.Windows.Forms.Button();
            this.lblUtolsoMuve = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNemKomediak = new System.Windows.Forms.Button();
            this.tbEvSzam = new System.Windows.Forms.TextBox();
            this.lblEvSzam = new System.Windows.Forms.Label();
            this.btnKereses = new System.Windows.Forms.Button();
            this.lblTalalat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDarab
            // 
            this.lblDarab.AutoSize = true;
            this.lblDarab.Location = new System.Drawing.Point(13, 13);
            this.lblDarab.Name = "lblDarab";
            this.lblDarab.Size = new System.Drawing.Size(288, 20);
            this.lblDarab.TabIndex = 0;
            this.lblDarab.Text = "0 Shakespeare dráma adatait eltároltuk";
            // 
            // btnUtolsoMuve
            // 
            this.btnUtolsoMuve.Location = new System.Drawing.Point(12, 43);
            this.btnUtolsoMuve.Name = "btnUtolsoMuve";
            this.btnUtolsoMuve.Size = new System.Drawing.Size(140, 40);
            this.btnUtolsoMuve.TabIndex = 1;
            this.btnUtolsoMuve.Text = "Utolsó műve";
            this.btnUtolsoMuve.UseVisualStyleBackColor = true;
            this.btnUtolsoMuve.Click += new System.EventHandler(this.btnUtolsoMuve_Click);
            // 
            // lblUtolsoMuve
            // 
            this.lblUtolsoMuve.AutoSize = true;
            this.lblUtolsoMuve.Location = new System.Drawing.Point(184, 53);
            this.lblUtolsoMuve.Name = "lblUtolsoMuve";
            this.lblUtolsoMuve.Size = new System.Drawing.Size(52, 20);
            this.lblUtolsoMuve.TabIndex = 0;
            this.lblUtolsoMuve.Text = "Valaki";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shakespeare.Properties.Resources.kep;
            this.pictureBox1.Location = new System.Drawing.Point(17, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNemKomediak
            // 
            this.btnNemKomediak.Location = new System.Drawing.Point(12, 485);
            this.btnNemKomediak.Name = "btnNemKomediak";
            this.btnNemKomediak.Size = new System.Drawing.Size(140, 40);
            this.btnNemKomediak.TabIndex = 1;
            this.btnNemKomediak.Text = "Nem komédiák";
            this.btnNemKomediak.UseVisualStyleBackColor = true;
            this.btnNemKomediak.Click += new System.EventHandler(this.btnNemKomediak_Click);
            // 
            // tbEvSzam
            // 
            this.tbEvSzam.Location = new System.Drawing.Point(495, 146);
            this.tbEvSzam.Name = "tbEvSzam";
            this.tbEvSzam.Size = new System.Drawing.Size(100, 26);
            this.tbEvSzam.TabIndex = 3;
            // 
            // lblEvSzam
            // 
            this.lblEvSzam.AutoSize = true;
            this.lblEvSzam.Location = new System.Drawing.Point(491, 99);
            this.lblEvSzam.Name = "lblEvSzam";
            this.lblEvSzam.Size = new System.Drawing.Size(69, 20);
            this.lblEvSzam.TabIndex = 0;
            this.lblEvSzam.Text = "Évszám:";
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(625, 139);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(140, 40);
            this.btnKereses.TabIndex = 1;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // lblTalalat
            // 
            this.lblTalalat.AutoSize = true;
            this.lblTalalat.Location = new System.Drawing.Point(491, 211);
            this.lblTalalat.Name = "lblTalalat";
            this.lblTalalat.Size = new System.Drawing.Size(56, 20);
            this.lblTalalat.TabIndex = 0;
            this.lblTalalat.Text = "Találat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 537);
            this.Controls.Add(this.tbEvSzam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNemKomediak);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnUtolsoMuve);
            this.Controls.Add(this.lblTalalat);
            this.Controls.Add(this.lblEvSzam);
            this.Controls.Add(this.lblUtolsoMuve);
            this.Controls.Add(this.lblDarab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "William Shakespeare";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDarab;
        private System.Windows.Forms.Button btnUtolsoMuve;
        private System.Windows.Forms.Label lblUtolsoMuve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNemKomediak;
        private System.Windows.Forms.TextBox tbEvSzam;
        private System.Windows.Forms.Label lblEvSzam;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Label lblTalalat;
    }
}

