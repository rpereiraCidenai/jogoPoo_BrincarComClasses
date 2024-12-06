using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoPoo
{
    internal class Cenario
    {

        public string Chao { get; set; } // CARACTER PARA CHAO...
        public byte Tamanho { get; set; } // TAMANHO DO CHAO...

        public Cenario(string chao, byte tamanho) //construtor do cenario.
        {
            this.Chao = chao;
            this.Tamanho = tamanho;
        }

        public void Imprime(Player p)
        {
            Console.Clear();//limpa o ecra;
            Console.WriteLine(); // deixa uma linha em branco

            if (p.Pulando)//p.pulando==true
            {
                for (byte i = 0; i < p.Posicao; i++)
                {
                    Console.Write(" ");// para escrever um espaco em branco ate posicao
                }
                Console.WriteLine(p.Aparencia);//escreve o caractere associado p ou q
            }
            else
            {
                Console.WriteLine();// quando nao salto apeans fica linha em branco
            }

            for (byte i = 0; i < p.Posicao; i++)
            {
                Console.Write(Chao);// Console.WriteLine("_")

            }
            if (p.Pulando)
            {
            
                Console.Write(Chao); // quando estou a saltar quero que aparece o chao para dar sensacao de salto
            }
            else
            {
                Console.Write(p.Aparencia);
            }

            for (byte i = 0; i < Tamanho-p.Posicao; i++)//
            {
                Console.Write(Chao);
            }




            








        }



    }
}
