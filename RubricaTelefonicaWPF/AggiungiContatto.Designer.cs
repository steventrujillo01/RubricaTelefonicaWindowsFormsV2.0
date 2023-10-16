namespace RubricaTelefonicaWPF
{
    partial class AggiungiContatto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggiungiContatto));
            this.Numero = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(166, 169);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 20);
            this.Numero.TabIndex = 12;
            // 
            // Cognome
            // 
            this.Cognome.Location = new System.Drawing.Point(166, 129);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(100, 20);
            this.Cognome.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(166, 90);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero di telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalva
            // 
            this.buttonSalva.BackColor = System.Drawing.Color.Blue;
            this.buttonSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalva.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSalva.Location = new System.Drawing.Point(131, 219);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(76, 33);
            this.buttonSalva.TabIndex = 14;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.ButtonSalva_Click);
            // 
            // AggiungiContatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 264);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Cognome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AggiungiContatto";
            this.Text = "AggiungiContatto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalva;
    }
}