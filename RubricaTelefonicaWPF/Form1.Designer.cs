namespace RubricaTelefonicaWPF
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ricerca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ricerca_button = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.numeroTelefonicoDataGridViewTextBoxColumn,
            this.Modifica,
            this.Elimina});
            this.dataGridView1.DataSource = this.contattoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(22, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // numeroTelefonicoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonicoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefonico";
            this.numeroTelefonicoDataGridViewTextBoxColumn.HeaderText = "NumeroTelefonico";
            this.numeroTelefonicoDataGridViewTextBoxColumn.Name = "numeroTelefonicoDataGridViewTextBoxColumn";
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Image = global::RubricaTelefonicaWPF.Properties.Resources.editIcon;
            this.Modifica.Name = "Modifica";
            this.Modifica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Elimina
            // 
            this.Elimina.HeaderText = "Elimina";
            this.Elimina.Image = global::RubricaTelefonicaWPF.Properties.Resources.DeleteIco;
            this.Elimina.Name = "Elimina";
            this.Elimina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataSource = typeof(RubricaTelefonicaWPF.Contatto);
            // 
            // Ricerca
            // 
            this.Ricerca.Location = new System.Drawing.Point(185, 96);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(230, 20);
            this.Ricerca.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cerca :";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modifica";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Elimina";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ricerca_button
            // 
            this.ricerca_button.BackgroundImage = global::RubricaTelefonicaWPF.Properties.Resources.imgCerca;
            this.ricerca_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ricerca_button.Location = new System.Drawing.Point(440, 82);
            this.ricerca_button.Name = "ricerca_button";
            this.ricerca_button.Size = new System.Drawing.Size(41, 39);
            this.ricerca_button.TabIndex = 14;
            this.ricerca_button.UseVisualStyleBackColor = true;
            this.ricerca_button.Click += new System.EventHandler(this.Ricerca_button_Click);
            // 
            // buttonSalva
            // 
            this.buttonSalva.BackColor = System.Drawing.Color.Azure;
            this.buttonSalva.BackgroundImage = global::RubricaTelefonicaWPF.Properties.Resources.AddIcon;
            this.buttonSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalva.Location = new System.Drawing.Point(487, 82);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(42, 39);
            this.buttonSalva.TabIndex = 8;
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RubricaTelefonicaWPF.Properties.Resources.ImgUser;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RubricaTelefonicaWPF.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 329);
            this.Controls.Add(this.ricerca_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rubrica Telefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TextBox Ricerca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ricerca_button;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefonicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Modifica;
        private System.Windows.Forms.DataGridViewImageColumn Elimina;
    }
}

