using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoPoo
{
    internal class Player
    {
         public byte Posicao { get; set; }
         public string Aparencia { get; set; }
         public string FacingRight { get; set; }
         public string FacingLeft { get; set; }
         public Boolean Pulando { set; get; }

        public Player(string facingRight, string facingLeft)
        {
            
            Posicao = 0; // para começar na primeira posicao do chao...
            this.FacingRight = facingRight; //letra para direita
            this.FacingLeft = facingLeft; // letra para esquerda
            Aparencia = facingRight;// quero começar a "olhar para direita" exeplo P
            Pulando = false; // começar no chao em vez de a saltar.


        }

        public void saltar()
        {

            Pulando = true;
            Console.Beep(634, 200);

        }

        public void pousar()
        {

            Pulando = false;
            Console.Beep(234, 200);

        }



        public void anda(Boolean direcao,byte limite) //direcao=direita ou esquerda.. limite tamanho do chao....
        {
          
           if (direcao) // if direcao==true;
            {
                if (Posicao < limite) //confirma que tenho chao disponivel... nao estou no limite
                {
                    Posicao++;// posicao para andar para frente
                    Aparencia = FacingRight;// para direita
                }
            }
            else// para quando direcao e false... venho para tras...
            {

                if (Posicao > 0)// se nao estiver no primeiro traço...

                {
                    Posicao--;
                    Aparencia = FacingLeft;

                }

            }

        }




    }
}
