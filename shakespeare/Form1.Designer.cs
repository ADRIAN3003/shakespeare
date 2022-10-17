
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNemKomediak = new System.Windows.Forms.Button();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valaki";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNemKomediak);
            this.Controls.Add(this.btnUtolsoMuve);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNemKomediak;
    }
}

