using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Trabalho_Final
{
    public partial class TF_CPD : Form
    {
        
        public void RadixSort_MSD(ref List<End_Dado> input, int n_digito)
        {
            int index_palavra, n_bucket, index_aux;
            List<End_Dado>[] bucket = new List<End_Dado>[36]; // Listas que servirão de 'caixas' para o ordenamento
            for (n_bucket = 0; n_bucket < 36; n_bucket++) bucket[n_bucket] = new List<End_Dado>(); // Inicializa as listas
            bool ordenado = false;

            while (!ordenado)
            { 
                for (index_palavra = 0; index_palavra < input.Count; index_palavra++) // De 0 até o fim do arquivo
                {
                    if (input[index_palavra].dado != "")
                    {
                        n_bucket = f_bucket(input[index_palavra].dado, n_digito); // Calcula com qual 'caixa' o dígito deve ser posto
                        bucket[n_bucket].Add(input[index_palavra]);     // Adiciona o elemento no bucket
                    } 
                }
                for (index_aux = 0; index_aux < 36; index_aux++)    // Percorre todos os buckets e verifica se estão ordenados
                {
                    if (isArraySorted(bucket[index_aux]) || n_digito >= 10) ordenado = true;
                    else RadixSort_MSD(ref bucket[index_aux], n_digito + 1);    // Se não está ordenado, chama recursivamente
                }
            }
            input.Clear();  
            for (n_bucket = 0; n_bucket < 36; n_bucket++) input.AddRange(bucket[n_bucket]);     // Concatena todos os buckets
        }

        int f_bucket(string palavra, int n_digito)  // Função que retorna o número do bucket para adicionar a palavra
        {
            if (n_digito < palavra.Length)
            {
                switch (palavra[n_digito])
                {
                    case '0': return 0;
                    case '1': return 1;
                    case '2': return 2;
                    case '3': return 3;
                    case '4': return 4;
                    case '5': return 5;
                    case '6': return 6;
                    case '7': return 7;
                    case '8': return 8;
                    case '9': return 9;
                    case 'A': return 10;
                    case 'B': return 11;
                    case 'C': return 12;
                    case 'D': return 13;
                    case 'E': return 14;
                    case 'F': return 15;
                    case 'G': return 16;
                    case 'H': return 17;
                    case 'I': return 18;
                    case 'J': return 19;
                    case 'K': return 20;
                    case 'L': return 21;
                    case 'M': return 22;
                    case 'N': return 23;
                    case 'O': return 24;
                    case 'P': return 25;
                    case 'Q': return 26;
                    case 'R': return 27;
                    case 'S': return 28;
                    case 'T': return 29;
                    case 'U': return 30;
                    case 'V': return 31;
                    case 'W': return 32;
                    case 'X': return 33;
                    case 'Y': return 34;
                    case 'Z': return 35;
                    default: return 0;
                }
            }
            else
                return 0;
        }

        public bool isArraySorted(List<End_Dado> array)     // Teste se o array está ordenado
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                if((String.Compare(array[i].dado, array[i + 1].dado) > 0))
                    return false;
            }
            return true;
        }

        private void b_ordena_Click(object sender, EventArgs e)     // Botão para ordenação
        {
            resultado_busca.Items.Clear();
            List<End_Dado> output = new List<End_Dado>();
            List<int> l_aux = new List<int>();
            output.Clear();

            switch (comboBox1.Text)     // Seleciona o que será ordenado pela ComboBox no Form
            {
                case "ID":
                    indice.Sort();      // Única lista que é ordenada pelo método padrão do C#
                    if (b_decrescente.Checked) indice.Reverse();
                    
                    foreach (string _id in indice)
                    {
                        resultado_busca.Items.Add(dados_box.Items[indice.IndexOf(_id)]);
                    }
                    return;

                case "Latitude":
                    foreach (End_Dado x in latitude)
                        output.Add(x);
                    output.Reverse();
                    break;

                case "Longitude":
                    foreach (End_Dado x in longitude)
                        output.Add(x);
                    break;

                case "Feridos":
                    foreach (End_Dado x in feridos)
                        output.Add(x);
                    break;

                case "Mortes":
                    foreach (End_Dado x in mortes)
                        output.Add(x);
                    break;

                case "Carro":
                    foreach (End_Dado x in carro)
                        output.Add(x);
                    break;

                case "Táxi":
                    foreach (End_Dado x in taxi)
                        output.Add(x);
                    break;

                case "Lotação":
                    foreach (End_Dado x in lotacao)
                        output.Add(x);
                    break;

                case "Ônibus urbano":
                    foreach (End_Dado x in bus_urb)
                        output.Add(x);
                    break;

                case "Ônibus metropolitano":
                    foreach (End_Dado x in bus_met)
                        output.Add(x);
                    break;

                case "Ônibus intermunicipal":
                    foreach (End_Dado x in bus_int)
                        output.Add(x);
                    break;

                case "Caminhão":
                    foreach (End_Dado x in caminhao)
                        output.Add(x);
                    break;

                case "Moto":
                    foreach (End_Dado x in moto)
                        output.Add(x);
                    break;

                case "Carroça":
                    foreach (End_Dado x in carroca)
                        output.Add(x);
                    break;

                case "Bicicleta":
                    foreach (End_Dado x in bicicleta)
                        output.Add(x);
                    break;

                case "Outro":
                    foreach (End_Dado x in outro)
                        output.Add(x);
                    break;

                case "Data":
                    foreach (End_Dado x in data)
                        output.Add(x);
                    break;

                case "Hora":
                    foreach (End_Dado x in hora)
                        output.Add(x);
                    break;

                case "Dia da semana":
                    foreach (End_Dado x in dia_sem)
                        output.Add(x);
                    break;

                case "Tempo":
                    foreach (End_Dado x in tempo)
                        output.Add(x);
                    break;

                case "Noite/Dia":
                    foreach (End_Dado x in noite_dia)
                        output.Add(x);
                    break;

                case "Tipo de acidente":
                    foreach (End_Dado x in tipo_acid)
                        output.Add(x);
                    break;

                case "Local":
                    foreach (End_Dado x in local)
                        output.Add(x);
                    break;

                case "Endereço":
                    foreach (End_Dado x in log)
                        output.Add(x);
                    break;
            }

            RadixSort_MSD(ref output, 0);       // Ordena pelo método RadixSort MSD

            if (b_decrescente.Checked) output.Reverse();

            int i;
            foreach (End_Dado a in output)
            {
                i = indice.IndexOf(a.endereco);
                resultado_busca.Items.Add(dados_box.Items[i]);
            }

        }
    }
}

       
        
