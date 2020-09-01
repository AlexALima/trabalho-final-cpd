using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Trabalho_Final
{
    public partial class TF_CPD : Form
    {
        private void buscar_Click(object sender, EventArgs e)   // Botão "Buscar"
        {
            openFileDialog1.ShowDialog();
            nome_arquivo.Text = openFileDialog1.FileName;
        }

        private void b_insercao_Click(object sender, EventArgs e)   // Botão "OK"
        {
            /***   Validação do arquivo   ***/

            if (nome_arquivo.Text.Substring(nome_arquivo.Text.Length - 4) != ".csv")    // Testa se é da extensão correta (.csv)
                MessageBox.Show("Arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (StreamReader leitor = File.OpenText(nome_arquivo.Text))  // Abre arquivo .csv (se comporta como texto) para leitura
                {
                    //using (System.IO.StreamWriter gravador = new System.IO.StreamWriter("Arquivo Texto.txt"))   // Abre arquivo para escrita textual (somente para testes)
                    using (BinaryWriter gravador = new BinaryWriter(File.Open(fileName, FileMode.Create))) // Abre arquivo para escrita binária
                    {
                        string linha_temp;  // Linha de texto (string) auxiliar
                        string[] str_in, saux;    // Conjunto de string para separar os dados da linha de texto (Split)
                        Queue<string> fila_out = new Queue<string>(); // Fila pra concatenar os dados que serão gravados no arquivo binário

                        linha_temp = leitor.ReadLine(); // Pula a primeira linha (legenda)
                        dados_box.Items.Clear();
                        progressBar1.Value = 0;
                        label2.Visible = false;
                        while (!leitor.EndOfStream) // Percorre todo o arquivo .csv
                        {
                            linha_temp = leitor.ReadLine(); // Lê uma linha do arquivo fonte .csv  (
                            str_in = linha_temp.Split(';'); // Separa as palavras da linha de texto

                            saux = str_in[10].Split('-');       // Modifica a estrutura da Data
                            str_in[10] = saux[2] + '/' + saux[1] + '/' + saux[0];

                            add_arq_inv(str_in);    // Adiciona dados no arquivo invertido
                            atualiza_indices(str_in);   // Atualiza os arquivos de índice
                            forma_fila_out(ref fila_out, str_in);    //  Forma os dados que serão gravados

                            while (fila_out.Count != 0)  // Até escrever todos os dados no arquivo binário...
                            {
                                gravador.Write(fila_out.Dequeue());   // Tira dado da fila e grava no arquivo
                            }
                            progressBar1.Value++;
                            linha_temp = String.Format("{0}     |     {1}     |     {2}     |     {3}     |     {4}     |     {5}     |     {6}     |     {7}     |     {8}     |     {9}     |     {10}     |     {11}     |     {12}     |     {13}     |     {14}     |     {15}     |     {16}     |     {17}     |     {18}     |     {19}     |     {20}     |     {21}     |     {22}     |     {23}", str_in[0], str_in[2], str_in[1], str_in[14], str_in[18], str_in[19], str_in[20], str_in[21], str_in[22], str_in[23], str_in[24], str_in[25], str_in[26], str_in[27], str_in[28], str_in[29], str_in[10], str_in[13], str_in[12], str_in[30], str_in[31], str_in[7], str_in[6], str_in[3]);
                            dados_box.Items.Add(linha_temp);                                                                                                                                                                                                                                                                                                                                               //   índice     lat        long        feridos     mortes      carro      taxi        lotacao       urb       met         int        caminhao      moto        carroça   bike         outro        data      hora      sem        tempo            n/d        tipo         local     log                                                           
                        }
                        progressBar1.Value = progressBar1.Maximum;
                        label2.Visible = true;
                    }
                }
            }
        }

        private void b_limpar_Click(object sender, EventArgs e)     // Limpa o GroupBox "Arquivo no computador"
        {
            nome_arquivo.Clear();
            progressBar1.Value = 0;
            label2.Visible = false;
        }

        private void dados_box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string lat, lon;
            string s = dados_box.SelectedItem.ToString();
            string id = s.Substring(0, 6);
            int index = indice.IndexOf(id);
            lat = latitude[index].dado;
            lon = longitude[index].dado;
            string link = "https://www.google.es/maps/@" + lat + "," + lon + ",18z";
            webBrowser2.Url = new System.Uri(link);
        }

        private void resultado_busca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string lat, lon;
            string s = resultado_busca.SelectedItem.ToString();
            string id = s.Substring(0, 6);
            int index = indice.IndexOf(id);
            lat = latitude[index].dado;
            lon = longitude[index].dado;
            string link = "https://www.google.es/maps/@" + lat + "," + lon + ",18z";
            webBrowser2.Url = new System.Uri(link);
        }
    }
}