using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Trabalho_Final
{
    public partial class TF_CPD : Form
    {
        struct Lista_Invertida
        {
            public List<string> ponteiro;
            public string palavra;

            public Lista_Invertida(string Palavra)
            {
                palavra = Palavra;
                ponteiro = new List<string>();
            }
        }

        public List<string> l_aux = new List<string>();    // Para verificar se a palavra já foi registrada

        Lista_Invertida[] arquivo_invertido = new Lista_Invertida[99991];   // Número primo próximo a 100.000

        void add_arq_inv(string[] str_in)
        {
            int hash; string elemento;
            foreach (string word in str_in)     // Para cada elemento de str_in (inclusive a chave)
            {
                elemento = word.ToUpper();  // Uniformaliza para letras maiúsculas
                if (elemento == "0" || elemento == "1" || elemento == "") continue;
                hash = elemento.GetHashCode() % 99991;
                if (hash < 0) hash *= -1;
                while (arquivo_invertido[hash].palavra != null) // Enquanto a posição do arquivo estiver ocupada
                {
                    if (arquivo_invertido[hash].palavra == elemento) break;
                    hash += 7;  // Soma 7 no hash
                    if (hash >= 99991) hash -= 99991;
                }
                l_aux.Add(elemento);
                arquivo_invertido[hash].palavra = elemento;
                if (arquivo_invertido[hash].ponteiro == null) arquivo_invertido[hash].ponteiro = new List<string>();
                arquivo_invertido[hash].ponteiro.Add(str_in[0]);
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            string elemento = texto_busca.Text.ToUpper();

            if (!l_aux.Contains(elemento))
            {
                MessageBox.Show("Palavra não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            resultado_busca.Items.Clear();
            int hash = elemento.GetHashCode() % 99991;
            if (hash < 0) hash *= -1;
            while (arquivo_invertido[hash].palavra != elemento) // Enquanto não encontrar a palavra
            {
                hash += 7;  // Soma 7 no hash
                if (hash >= 99991) hash -= 99991;
            }

            int i;
            string[] endereco = arquivo_invertido[hash].ponteiro.ToArray();
            foreach (string a in endereco)
            {
                i = indice.IndexOf(a);
                resultado_busca.Items.Add(dados_box.Items[i]);
            }
        }
    }
}
     
