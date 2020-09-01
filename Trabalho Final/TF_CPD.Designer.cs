namespace Trabalho_Final
{
    partial class TF_CPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TF_CPD));
            this.tab_dados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_ordena = new System.Windows.Forms.Button();
            this.b_decrescente = new System.Windows.Forms.RadioButton();
            this.b_crescente = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.resultado_busca = new System.Windows.Forms.ListBox();
            this.botao_buscar = new System.Windows.Forms.Button();
            this.texto_busca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buscar = new System.Windows.Forms.Button();
            this.b_insercao = new System.Windows.Forms.Button();
            this.nome_arquivo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dados_box = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tab_dados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_dados
            // 
            this.tab_dados.Controls.Add(this.tabPage1);
            this.tab_dados.Controls.Add(this.tabPage2);
            this.tab_dados.Controls.Add(this.tabPage3);
            this.tab_dados.Location = new System.Drawing.Point(12, 12);
            this.tab_dados.Name = "tab_dados";
            this.tab_dados.SelectedIndex = 0;
            this.tab_dados.Size = new System.Drawing.Size(1571, 730);
            this.tab_dados.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1563, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manipulação de dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://www.inf.ufrgs.br/site/wp-content/uploads/2014/07/marca-principal.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1365, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(846, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(513, 110);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "UNIVERSIDADE FEDERAL DO RIO GRANDE DO SUL\r\nInstituto de Informática\r\nINF01124 - C" +
    "lassificação e Pesquisa de Dados - Turma B\r\nProf. Renan Maffei\r\n\r\nTRABALHO FINAL" +
    " DE CLASSIFICAÇÃO E PESQUISA DE DADOS";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_ordena);
            this.groupBox3.Controls.Add(this.b_decrescente);
            this.groupBox3.Controls.Add(this.b_crescente);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(618, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 110);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenação de dados";
            // 
            // b_ordena
            // 
            this.b_ordena.Location = new System.Drawing.Point(120, 58);
            this.b_ordena.Name = "b_ordena";
            this.b_ordena.Size = new System.Drawing.Size(75, 23);
            this.b_ordena.TabIndex = 4;
            this.b_ordena.Text = "Ordenar";
            this.b_ordena.UseVisualStyleBackColor = true;
            this.b_ordena.Click += new System.EventHandler(this.b_ordena_Click);
            // 
            // b_decrescente
            // 
            this.b_decrescente.AutoSize = true;
            this.b_decrescente.Checked = true;
            this.b_decrescente.Location = new System.Drawing.Point(22, 56);
            this.b_decrescente.Name = "b_decrescente";
            this.b_decrescente.Size = new System.Drawing.Size(86, 17);
            this.b_decrescente.TabIndex = 3;
            this.b_decrescente.TabStop = true;
            this.b_decrescente.Text = "Decrescente";
            this.b_decrescente.UseVisualStyleBackColor = true;
            // 
            // b_crescente
            // 
            this.b_crescente.AutoSize = true;
            this.b_crescente.Location = new System.Drawing.Point(22, 79);
            this.b_crescente.Name = "b_crescente";
            this.b_crescente.Size = new System.Drawing.Size(73, 17);
            this.b_crescente.TabIndex = 2;
            this.b_crescente.Text = "Crescente";
            this.b_crescente.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Latitude",
            "Longitude",
            "Feridos",
            "Mortes",
            "Carro",
            "Táxi",
            "Lotação",
            "Ônibus urbano",
            "Ônibus metropolitano",
            "Ônibus intermunicipal",
            "Caminhão",
            "Moto",
            "Carroça",
            "Bicicleta",
            "Outro",
            "Data",
            "Hora",
            "Dia da semana",
            "Tempo",
            "Noite/Dia",
            "Tipo de acidente",
            "Local",
            "Endereço"});
            this.comboBox1.Location = new System.Drawing.Point(22, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.resultado_busca);
            this.groupBox2.Controls.Add(this.botao_buscar);
            this.groupBox2.Controls.Add(this.texto_busca);
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1551, 579);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de dados";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(11, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1550, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // resultado_busca
            // 
            this.resultado_busca.FormattingEnabled = true;
            this.resultado_busca.Location = new System.Drawing.Point(10, 101);
            this.resultado_busca.Name = "resultado_busca";
            this.resultado_busca.Size = new System.Drawing.Size(1535, 472);
            this.resultado_busca.TabIndex = 2;
            this.resultado_busca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultado_busca_MouseDoubleClick);
            // 
            // botao_buscar
            // 
            this.botao_buscar.Location = new System.Drawing.Point(519, 46);
            this.botao_buscar.Name = "botao_buscar";
            this.botao_buscar.Size = new System.Drawing.Size(75, 23);
            this.botao_buscar.TabIndex = 1;
            this.botao_buscar.Text = "Buscar";
            this.botao_buscar.UseVisualStyleBackColor = true;
            this.botao_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto_busca
            // 
            this.texto_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_busca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.texto_busca.Location = new System.Drawing.Point(6, 20);
            this.texto_busca.Name = "texto_busca";
            this.texto_busca.Size = new System.Drawing.Size(588, 20);
            this.texto_busca.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_limpar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.b_insercao);
            this.groupBox1.Controls.Add(this.nome_arquivo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo no computador";
            // 
            // b_limpar
            // 
            this.b_limpar.Location = new System.Drawing.Point(519, 48);
            this.b_limpar.Name = "b_limpar";
            this.b_limpar.Size = new System.Drawing.Size(75, 23);
            this.b_limpar.TabIndex = 4;
            this.b_limpar.Text = "Limpar";
            this.b_limpar.UseVisualStyleBackColor = true;
            this.b_limpar.Click += new System.EventHandler(this.b_limpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UPLOAD COMPLETO";
            this.label2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(6, 77);
            this.progressBar1.Maximum = 100000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 2;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(6, 19);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Explorar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // b_insercao
            // 
            this.b_insercao.Location = new System.Drawing.Point(519, 19);
            this.b_insercao.Name = "b_insercao";
            this.b_insercao.Size = new System.Drawing.Size(75, 23);
            this.b_insercao.TabIndex = 1;
            this.b_insercao.Text = "OK";
            this.b_insercao.UseVisualStyleBackColor = true;
            this.b_insercao.Click += new System.EventHandler(this.b_insercao_Click);
            // 
            // nome_arquivo
            // 
            this.nome_arquivo.Location = new System.Drawing.Point(87, 19);
            this.nome_arquivo.Name = "nome_arquivo";
            this.nome_arquivo.Size = new System.Drawing.Size(417, 20);
            this.nome_arquivo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dados_box);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1563, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela de dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1550, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dados_box
            // 
            this.dados_box.FormattingEnabled = true;
            this.dados_box.HorizontalExtent = 200;
            this.dados_box.HorizontalScrollbar = true;
            this.dados_box.Location = new System.Drawing.Point(6, 29);
            this.dados_box.Name = "dados_box";
            this.dados_box.Size = new System.Drawing.Size(1550, 680);
            this.dados_box.TabIndex = 0;
            this.dados_box.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dados_box_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1563, 704);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mapa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1557, 698);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("https://www.google.es/maps/@-30.0710241,-51.1193434,15z", System.UriKind.Absolute);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "TabelaModificada.csv";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\xandi\\Documents\\UFRGS\\Classificação e Pesquisa de Dados - 2018_2\\Trabalh" +
    "o Final - CPD";
            this.openFileDialog1.Title = "Abrir";
            // 
            // TF_CPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1595, 759);
            this.Controls.Add(this.tab_dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TF_CPD";
            this.Text = "Trabalho Final - Alexandre Lima";
            this.tab_dados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_dados;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button b_insercao;
        private System.Windows.Forms.TextBox nome_arquivo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox dados_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox resultado_busca;
        private System.Windows.Forms.Button botao_buscar;
        private System.Windows.Forms.TextBox texto_busca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton b_decrescente;
        private System.Windows.Forms.RadioButton b_crescente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button b_ordena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

