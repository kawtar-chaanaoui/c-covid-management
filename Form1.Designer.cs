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
            this.textcin = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.textmalad = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.textadress = new System.Windows.Forms.TextBox();
            this.textetat = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ajout = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.Supp = new System.Windows.Forms.Button();
            this.Affich = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textcin
            // 
            this.textcin.Location = new System.Drawing.Point(591, 12);
            this.textcin.Name = "textcin";
            this.textcin.Size = new System.Drawing.Size(197, 20);
            this.textcin.TabIndex = 0;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(591, 42);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(197, 20);
            this.textnom.TabIndex = 1;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(591, 68);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(197, 20);
            this.textprenom.TabIndex = 2;
            // 
            // textmalad
            // 
            this.textmalad.Location = new System.Drawing.Point(591, 94);
            this.textmalad.Name = "textmalad";
            this.textmalad.Size = new System.Drawing.Size(197, 20);
            this.textmalad.TabIndex = 3;
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(591, 119);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(197, 20);
            this.textage.TabIndex = 4;
            // 
            // textadress
            // 
            this.textadress.Location = new System.Drawing.Point(591, 142);
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(197, 20);
            this.textadress.TabIndex = 5;
            // 
            // textetat
            // 
            this.textetat.Location = new System.Drawing.Point(591, 168);
            this.textetat.Name = "textetat";
            this.textetat.Size = new System.Drawing.Size(197, 20);
            this.textetat.TabIndex = 6;
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.Location = new System.Drawing.Point(564, 15);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(21, 13);
            this.cin.TabIndex = 7;
            this.cin.Text = "cin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "malad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "age";
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
            this.Ajout.Location = new System.Drawing.Point(577, 230);
            this.Ajout.Name = "Ajout";
            this.Ajout.Size = new System.Drawing.Size(65, 21);
            this.Ajout.TabIndex = 14;
            this.Ajout.Text = "Ajouter";
            this.Ajout.UseVisualStyleBackColor = true;
            this.Ajout.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // Modif
            // 
            this.Modif.Location = new System.Drawing.Point(577, 203);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(65, 21);
            this.Modif.TabIndex = 15;
            this.Modif.Text = "Modif";
            this.Modif.UseVisualStyleBackColor = true;
            // 
            // Supp
            // 
            this.Supp.Location = new System.Drawing.Point(710, 203);
            this.Supp.Name = "Supp";
            this.Supp.Size = new System.Drawing.Size(60, 21);
            this.Supp.TabIndex = 16;
            this.Supp.Text = "Supp";
            this.Supp.UseVisualStyleBackColor = true;
            this.Supp.Click += new System.EventHandler(this.Supp_Click);
            // 
            // Affich
            // 
            this.Affich.Location = new System.Drawing.Point(648, 203);
            this.Affich.Name = "Affich";
            this.Affich.Size = new System.Drawing.Size(56, 21);
            this.Affich.TabIndex = 17;
            this.Affich.Text = "Affich";
            this.Affich.UseVisualStyleBackColor = true;
            this.Affich.Click += new System.EventHandler(this.Affich_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 305);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "etat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Affich);
            this.Controls.Add(this.Supp);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Ajout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.textetat);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.textmalad);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.textcin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcin;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox textmalad;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.TextBox textetat;
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Ajout;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Button Supp;
        private System.Windows.Forms.Button Affich;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}