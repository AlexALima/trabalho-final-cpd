using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;

namespace Trabalho_Final
{
    public partial class TF_CPD : Form
    {
        public struct End_Dado
        {
            public string endereco, dado;
        }

        List<string> indice = new List<string>();       // Índice Principal

        List<End_Dado> longitude = new List<End_Dado>();
        List<End_Dado> latitude = new List<End_Dado>();
        List<End_Dado> log = new List<End_Dado>();
        List<End_Dado> local = new List<End_Dado>();
        List<End_Dado> tipo_acid = new List<End_Dado>();
        List<End_Dado> data = new List<End_Dado>();
        List<End_Dado> dia_sem = new List<End_Dado>();
        List<End_Dado> hora = new List<End_Dado>();
        List<End_Dado> feridos = new List<End_Dado>();
        List<End_Dado> mortes = new List<End_Dado>();
        List<End_Dado> carro = new List<End_Dado>();
        List<End_Dado> taxi = new List<End_Dado>();
        List<End_Dado> lotacao = new List<End_Dado>();
        List<End_Dado> bus_urb = new List<End_Dado>();
        List<End_Dado> bus_met = new List<End_Dado>();
        List<End_Dado> bus_int = new List<End_Dado>();
        List<End_Dado> caminhao = new List<End_Dado>();
        List<End_Dado> moto = new List<End_Dado>();
        List<End_Dado> carroca = new List<End_Dado>();
        List<End_Dado> bicicleta = new List<End_Dado>();
        List<End_Dado> outro = new List<End_Dado>();
        List<End_Dado> tempo = new List<End_Dado>();
        List<End_Dado> noite_dia = new List<End_Dado>();

        void atualiza_indices(string[] str_in)
        {
            End_Dado ed = new End_Dado();
            ed.endereco = str_in[0];

            indice.Add(str_in[0]);

            ed.dado = str_in[1]; longitude.Add(ed);
            ed.dado = str_in[2]; latitude.Add(ed);
            ed.dado = str_in[3]; log.Add(ed);
            ed.dado = str_in[6]; local.Add(ed);
            ed.dado = str_in[7]; tipo_acid.Add(ed);
            ed.dado = str_in[10]; data.Add(ed);
            ed.dado = str_in[12]; dia_sem.Add(ed);
            ed.dado = str_in[13]; hora.Add(ed);
            ed.dado = str_in[14]; feridos.Add(ed);
            ed.dado = str_in[18]; mortes.Add(ed);
            ed.dado = str_in[19]; carro.Add(ed);
            ed.dado = str_in[20]; taxi.Add(ed);
            ed.dado = str_in[21]; lotacao.Add(ed);
            ed.dado = str_in[22]; bus_urb.Add(ed);
            ed.dado = str_in[23]; bus_met.Add(ed);
            ed.dado = str_in[24]; bus_int.Add(ed);
            ed.dado = str_in[25]; caminhao.Add(ed);
            ed.dado = str_in[26]; moto.Add(ed);
            ed.dado = str_in[27]; carroca.Add(ed);
            ed.dado = str_in[28]; bicicleta.Add(ed);
            ed.dado = str_in[29]; outro.Add(ed);
            ed.dado = str_in[30]; tempo.Add(ed);
            ed.dado = str_in[31]; noite_dia.Add(ed);
        }

        void atualiza_indices_inicio(string[] aux)
        {
            End_Dado ed = new End_Dado();
            ed.endereco = aux[0];

            indice.Add(aux[0]);

            ed.dado = aux[2]; latitude.Add(ed);
            ed.dado = aux[1]; longitude.Add(ed);
            ed.dado = aux[3]; feridos.Add(ed);
            ed.dado = aux[4]; mortes.Add(ed);
            ed.dado = aux[5]; carro.Add(ed);
            ed.dado = aux[6]; taxi.Add(ed);
            ed.dado = aux[7]; lotacao.Add(ed);
            ed.dado = aux[8]; bus_urb.Add(ed);
            ed.dado = aux[9]; bus_met.Add(ed);
            ed.dado = aux[10]; bus_int.Add(ed);
            ed.dado = aux[11]; caminhao.Add(ed);
            ed.dado = aux[12]; moto.Add(ed);
            ed.dado = aux[13]; carroca.Add(ed);
            ed.dado = aux[14]; bicicleta.Add(ed);
            ed.dado = aux[15]; outro.Add(ed);
            ed.dado = aux[16]; data.Add(ed);
            ed.dado = aux[17]; hora.Add(ed);
            ed.dado = aux[18]; dia_sem.Add(ed);
            ed.dado = aux[19]; tempo.Add(ed);
            ed.dado = aux[20]; noite_dia.Add(ed);
            ed.dado = aux[21]; tipo_acid.Add(ed);
            ed.dado = aux[22]; local.Add(ed);
            ed.dado = aux[23]; log.Add(ed);
        }

        void forma_fila_out(ref Queue<string> fila_out, string[] str_in)
        {
            fila_out.Enqueue(str_in [0]);    // ID
            fila_out.Enqueue(str_in [2]);    // Latitude
            fila_out.Enqueue(str_in [1]);    // Longitude
            fila_out.Enqueue(str_in [14]);   // Feridos
            fila_out.Enqueue(str_in [18]);   // Mortes
            fila_out.Enqueue(str_in [19]);   // Carro (AUTO)
            fila_out.Enqueue(str_in [20]);   // Táxi
            fila_out.Enqueue(str_in [21]);   // Lotação
            fila_out.Enqueue(str_in [22]);   // Ônibus_urb
            fila_out.Enqueue(str_in [23]);   // Ônibus_met
            fila_out.Enqueue(str_in [24]);   // Ônibus_int
            fila_out.Enqueue(str_in [25]);   // Caminhão
            fila_out.Enqueue(str_in [26]);   // Moto
            fila_out.Enqueue(str_in [27]);   // Carroça
            fila_out.Enqueue(str_in [28]);   // Bicicleta
            fila_out.Enqueue(str_in [29]);   // Outro
            fila_out.Enqueue(str_in [10]);   // Data
            fila_out.Enqueue(str_in [13]);   // Hora
            fila_out.Enqueue(str_in [12]);   // Dia da semana
            fila_out.Enqueue(str_in [30]);   // Tempo
            fila_out.Enqueue(str_in [31]);   // Noite/Dia
            fila_out.Enqueue(str_in [7]);    // Tipo de acidente
            fila_out.Enqueue(str_in [6]);    // Local
            fila_out.Enqueue(str_in [3]);    // Endereço

        }
         
    }
}