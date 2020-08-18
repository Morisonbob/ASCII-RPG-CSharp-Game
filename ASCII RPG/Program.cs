using System;



class Program
{
    static void Main(string[] args)
    {
        int escolhaClasse;
        Jogador player = new Jogador();
        Menus menu = new Menus();
        BattleSystem batalha = new BattleSystem();
        string[,] tela = new string[20, 30];
        bool tutorialCompleto = false;
        SlimeAzul slime = new SlimeAzul();

        escolhaClasse = menu.EscolhaDePersonagem();


        //Checagem de que classe foi escolhida
        if (escolhaClasse == 0)
        {
            BlackMage jogador = new BlackMage();
            player = jogador;
        }
        else if (escolhaClasse == 1)
        {
            Archer jogador = new Archer();
            player = jogador;
        }
        else if (escolhaClasse == 2)
        {
            Warrior jogador = new Warrior();
            player = jogador;
        }


        Console.WriteLine("\nDigite o nome do seu personagem: ");
        player.setName(Console.ReadLine());
        Console.WriteLine("\nO nome do seu personagem e: " + player.getName());
        Console.WriteLine("\nOs status iniciais dele sao:");
        Console.Write("Vida: " + player.getHp());
        Console.Write("\nMana: " + player.getMana());
        Console.Write("\nAtaque: " + player.getAtaque());
        Console.Write("\nDefesa: " + player.getDefesa());
        Console.WriteLine("\n\nEle possui as skills:");
        player.nomeDaSkill_1();
        player.nomeDaSkill_2();
        player.nomeDaSkill_3();
        Console.ReadKey();
        Console.Clear();


        //Imprimir a tela inicial do jogo
        while (tutorialCompleto == false && player.getHp() > 0)
        {
            // Limpeza da Tela
            for (int l = 0; l < 20; l++)
            {
                for (int c = 0; c < 30; c++)
                {
                    tela[l, c] = " ";
                }
            }

            tela[player.getLinha(), player.getColuna()] = player.getCaracter();
            if (slime.getVivo())
            {
                tela[slime.getLinha(), slime.getColuna()] = slime.getCaracter();

            }

            //Criando a primeira tela

            for (int i = 1; i < 29; i++)
            {
                tela[0, i] = "_";
                tela[19, i] = "_";
            }

            for (int i = 1; i < 20; i++)
            {
                tela[i, 0] = "|";
                tela[i, 29] = "|";
            }

            //Imprimindo a tela
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(tela[i, j]);
                    if (i == (player.getLinha()) && j == (player.getColuna() - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (i == (slime.getLinha()) && j == (slime.getColuna() - 1) && slime.getVivo())
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }

            //Checando se o jogador e o inimigo se encontraram
            if (player.getLinha() == slime.getLinha() && player.getColuna() == slime.getColuna() && slime.getVivo())
            {
                Console.Clear();
                batalha.BattleMenu(slime, player);
                //Console.WriteLine("Faliceu");
            }

            // Captura e Verificacao de Tecla
            ConsoleKeyInfo tecla = Console.ReadKey();

            // Atualiza Coordenada do jogador
            if (tecla.KeyChar == 's' || tecla.KeyChar == 'S')
            {
                player.setLinha(1);
            }
            if (tecla.KeyChar == 'w' || tecla.KeyChar == 'W')
            {
                player.setLinha(-1);
            }
            if (tecla.KeyChar == 'a' || tecla.KeyChar == 'A')
            {
                player.setColuna(-1);
            }
            if (tecla.KeyChar == 'd' || tecla.KeyChar == 'D')
            {
                player.setColuna(1);
            }
            Console.Clear();
        }

        Console.WriteLine("Você morreu");
        Console.ReadKey();
    }

}
