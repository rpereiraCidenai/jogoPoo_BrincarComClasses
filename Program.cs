namespace jogoPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("p", "q"); // letra p para frente letra q para tras
            Cenario c = new Cenario("_", 60); // cenario com _ de tamanho 60
            ConsoleKey tecla; // variavel tecla do tipo consolekey
           
            c.Imprime(p);

            do
            {
                tecla = Console.ReadKey().Key;
                switch (tecla)
                {
                    case ConsoleKey.RightArrow:

                        p.anda(true, c.Tamanho);
                        c.Imprime(p);

                        break;

                    case ConsoleKey.LeftArrow:

                        p.anda(false, c.Tamanho);
                        c.Imprime(p);

                        break;

                    case ConsoleKey.UpArrow:
                        p.saltar();
                        c.Imprime(p);
                        p.pousar();
                        c.Imprime(p);
                       // p.Pulando = false;

                        break;

                    
                }

            }while (tecla != ConsoleKey.Escape);





        }
    }
}
