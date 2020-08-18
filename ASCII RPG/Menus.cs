using System;


class Menus
{

    //Função que dá as opções de personagens disponiveis a serem criados e retorna o que foi selecionado em forma de int
    public int EscolhaDePersonagem()
    {
        int opcao = 0;
        ConsoleKeyInfo opcaoMenu1;
        bool sairDoMenu1 = false;

        //Loop pra continuar no menu enquanto nenhuma opção for selecionada
        while (sairDoMenu1 == false)
        {
            Console.WriteLine("Escolha a classe do seu personagem: \n");
            //Serie de ifs que vai "iluminar" as opções a medida que as setas forem apertadas 
            if (opcao == 0)
            {
                Highlight();
            }
            Console.WriteLine("Mago");
            Console.ResetColor();
            if (opcao == 1)
            {
                Highlight();
            }
            Console.WriteLine("Arqueiro");
            Console.ResetColor();
            if (opcao == 2)
            {
                Highlight();
            }
            Console.WriteLine("Guerreiro");
            Console.ResetColor();

            //Capturando e checando que tecla do teclado foi apertada
            opcaoMenu1 = Console.ReadKey();

            if (opcaoMenu1.Key == ConsoleKey.DownArrow)
            {
                opcao++;
                if (opcao > 2)
                {
                    opcao = 0;
                }
            }
            if (opcaoMenu1.Key == ConsoleKey.UpArrow)
            {
                opcao--;
                if (opcao < 0)
                {
                    opcao = 2;
                }
            }
            Console.Clear();

            //Checando se o Enter foi apertado e fim do loop caso positivo
            if (opcaoMenu1.Key == ConsoleKey.Enter)
            {
                if (opcao == 0) //Mago
                {
                    Console.WriteLine("O mago tem mana alta, vida e defesa baixas, porém dá muito dano com suas magias.");
                    Console.WriteLine("\nMagias que possui: \nBola de fogo\nCongelar\nTrovão");
                    Console.WriteLine("\nConfirma a criação de um personagem Mago:");
                    sairDoMenu1 = SimOuNao();
                    Console.Clear();
                }
                else if (opcao == 1) //Arqueiro
                {
                    Console.WriteLine("O arqueiro tem vida, defesa e mana equilibradas e dá um dano moderado.");
                    Console.WriteLine("\nHabilidades que possui: \nChuva de Flechas\nConcentração\nCegar");
                    Console.WriteLine("\nConfirma a criação de um personagem Arqueiro:");
                    sairDoMenu1 = SimOuNao();
                    Console.Clear();
                }
                else if (opcao == 2) //Guerreiro
                {
                    Console.WriteLine("O guerreiro tem muita vida e defesa, porém pouca mana.\nSeu uso de habilidades é limitado.");
                    Console.WriteLine("\nMagias que possui: \nExecutar\nRaiva\nGolpe Colossal");
                    Console.WriteLine("\nConfirma a criação de um personagem Guerreiro:");
                    sairDoMenu1 = SimOuNao();
                    Console.Clear();
                }
            }
        }

        return opcao;
    }


    //Função que deixa o texto com um aspecto de "selecionado"
    public void Highlight()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
    }

    //Função que cria uma caixa de dialogo de sim ou não e retorna o que foi selecionado em forma de booleano
    public bool SimOuNao()
    {
        ConsoleKeyInfo opcaoSN;
        int opcao = 0;
        bool SN = true;

        while (SN)
        {
            if (opcao == 0) //Sim
            {
                Highlight();
            }
            Console.WriteLine("Sim");
            Console.ResetColor();
            if (opcao == 1) //Não
            {
                Highlight();
            }
            Console.SetCursorPosition(Console.CursorLeft + 4, Console.CursorTop - 1);
            Console.WriteLine("Não");
            Console.ResetColor();


            opcaoSN = Console.ReadKey();
            if (opcaoSN.Key == ConsoleKey.RightArrow)
            {
                opcao++;
                if (opcao > 1)
                {
                    opcao = 0;
                }
            }
            if (opcaoSN.Key == ConsoleKey.LeftArrow)
            {
                opcao--;
                if (opcao < 0)
                {
                    opcao = 1;
                }
            }

            if (opcaoSN.Key == ConsoleKey.Enter)
            {
                if (opcao == 0) //Sim
                {
                    Console.WriteLine("Sim");
                    return true; // retorna que a confirmação foi ok
                }
                else if (opcao == 1) //Não
                {
                    Console.WriteLine("Não");
                    return false;
                }
                SN = false;
            }

            //Só reseta a linha do console caso não tenha saido do loop
            //Evita erro de argument out of range
            if (SN)
            {
                //Reseta a posição do cursor na tela, fazendo com a frase seja sobreescrita
                //Assim, apagando apenas a ultima linha escrita
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
            }

        }
        return false;
    }

    
}
