namespace Covid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textcin = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ajout = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.Supp = new System.Windows.Forms.Button();
            this.Affich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcin
            // 
            this.textcin.Location = new System.Drawing.Point(240, 45);
            this.textcin.Name = "textcin";
            this.textcin.Size = new System.Drawing.Size(283, 20);
            this.textcin.TabIndex = 0;
            this.textcin.TextChanged += new System.EventHandler(this.textcin_TextChanged);
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.BackColor = System.Drawing.Color.Transparent;
            this.cin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cin.Location = new System.Drawing.Point(171, 43);
            this.cin.MaximumSize = new System.Drawing.Size(800, 1000);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(72, 22);
            this.cin.TabIndex = 7;
            this.cin.Text = "Cin/ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(549, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // Ajout
            // 
            this.Ajout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ajout.BackColor = System.Drawing.Color.Transparent;
            this.Ajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajout.BackgroundImage")));
            this.Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Ajout.Location = new System.Drawing.Point(261, 99);
            this.Ajout.Name = "Ajout";
            this.Ajout.Size = new System.Drawing.Size(65, 21);
            this.Ajout.TabIndex = 14;
            this.Ajout.Text = "Ajouter";
            this.Ajout.UseVisualStyleBackColor = false;
            this.Ajout.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // Modif
            // 
            this.Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modif.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Modif.Location = new System.Drawing.Point(261, 71);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(65, 21);
            this.Modif.TabIndex = 15;
            this.Modif.Text = "Modif";
            this.Modif.UseVisualStyleBackColor = true;
            // 
            // Supp
            // 
            this.Supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Supp.Image = ((System.Drawing.Image)(resources.GetObject("Supp.Image")));
            this.Supp.Location = new System.Drawing.Point(332, 71);
            this.Supp.Name = "Supp";
            this.Supp.Size = new System.Drawing.Size(65, 21);
            this.Supp.TabIndex = 16;
            this.Supp.Text = "Supp";
            this.Supp.UseVisualStyleBackColor = true;
            this.Supp.Click += new System.EventHandler(this.Supp_Click);
            // 
            // Affich
            // 
            this.Affich.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affich.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Affich.Location = new System.Drawing.Point(332, 98);
            this.Affich.Name = "Affich";
            this.Affich.Size = new System.Drawing.Size(63, 21);
            this.Affich.TabIndex = 17;
            this.Affich.Text = "Chercher";
            this.Affich.UseVisualStyleBackColor = true;
            this.Affich.Click += new System.EventHandler(this.Affich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid.Properties.Resources.ùask;
            this.ClientSize = new System.Drawing.Size(652, 326);
            this.Controls.Add(this.Affich);
            this.Controls.Add(this.Supp);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Ajout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.textcin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Button Supp;
        private System.Windows.Forms.Button Affich;
        private System.Windows.Forms.Button Ajout;
        public System.Windows.Forms.TextBox textcin;
    }
}