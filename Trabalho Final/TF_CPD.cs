using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Trabalho_Final
{
    public partial class TF_CPD : Form
    {
        string fileName = "Arquivo Principal.axl";

        public TF_CPD()     // Início do programa
        {
            InitializeComponent();
            
            string linha_temp;  // Linha de texto (string) auxiliar
            string[] aux = new string[24];
            bool final_arquivo = false;
            try
            {
                using (BinaryReader leitor = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (!final_arquivo)
                    {
                        for (int i = 0; i < 24; i++)
                        {
                            try
                            {
                                aux[i] = leitor.ReadString(); // Lê uma palavra do arquivo .axl
                            }
                            catch (EndOfStreamException)
                            {
                                final_arquivo = true;
                                break;
                            }
                        }
                        linha_temp = String.Format("{0}     |     {1}     |     {2}     |     {3}     |     {4}     |     {5}     |     {6}     |     {7}     |     {8}     |     {9}     |     {10}     |     {11}     |     {12}     |     {13}     |     {14}     |     {15}     |     {16}     |     {17}     |     {18}     |     {19}     |     {20}     |     {21}     |     {22}     |     {23}", aux[0], aux[1], aux[2], aux[3], aux[4], aux[5], aux[6], aux[7], aux[8], aux[9], aux[10], aux[11], aux[12], aux[13], aux[14], aux[15], aux[16], aux[17], aux[18], aux[19], aux[20], aux[21], aux[22], aux[23]);
                        dados_box.Items.Add(linha_temp);                                                                                                                                                                                                                                                                                                                                               //   índice     lat        long        feridos     mortes      carro      taxi        lotacao       urb       met         int        caminhao      moto        carroça   bike         outro        tempo      hora      sem        tempo            n/d        tipo         local     log                                      
                        atualiza_indices_inicio(aux);
                        add_arq_inv(aux);
                    }
                }
            }
            catch (Exception)
            {}
            
        }
    }
}
