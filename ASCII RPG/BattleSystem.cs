using System;

class BattleSystem
{
    private Menus menu = new Menus();

    public void BattleMenu(Inimigo inimigo, Jogador jogador)
    {
        int opcaoX = 0, opcaoY = 0;
        int checagem = 0;
        ConsoleKeyInfo opcaoMenu1;
        bool ataque = false;
        bool checar = false;
        bool habilidade = false;
        bool fugir = false;

        while (inimigo.getHp() > 0 && jogador.getHp() > 0 && fugir == false)
        {
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight);
            inimigo.ascDoInimigo();

            if (ataque)
            {
                Console.WriteLine("Você deu " + Ataque(inimigo, jogador) + " de dano");
                Console.ReadKey();
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                Console.WriteLine("                                                 ");
                ataque = false;
                if (inimigo.getHp() <= 0)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.WriteLine("Você derotou um " + inimigo.getName());
                    inimigo.setVivo(false);
                    return;
                }
                inimigo.enemyTurn(inimigo, jogador);
                if (jogador.getHp() <= 0)
                {
                    Console.WriteLine("Você morreu");
                    return;
                }
            }

            else if (checar)
            {
                Checagem(inimigo);
                Console.ReadKey();
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 5);
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                checar = false;
                inimigo.enemyTurn(inimigo, jogador);

            }

            else if (habilidade)
            {
                checagem = Habilidades(inimigo, jogador);
                habilidade = false;
                if (inimigo.getHp() <= 0)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.WriteLine("Você derotou um " + inimigo.getName());
                    inimigo.setVivo(false);
                    return;
                }
                if (checagem != 1)
                {
                    inimigo.enemyTurn(inimigo, jogador);
                }
                if (jogador.getHp() <= 0)
                {
                    Console.WriteLine("Você morreu");
                    Console.ReadKey();
                }
            }

            //HUD (??????)
            Hud(jogador);

            //Serie de ifs que vai "iluminar" as opções a medida que as setas forem apertadas 
            if (opcaoX == 0 && opcaoY == 0)
            {
                menu.Highlight();
            }
            Console.WriteLine("Atacar");
            Console.ResetColor();
            if (opcaoX == 0 && opcaoY == 1)
            {
                menu.Highlight();
            }
            Console.SetCursorPosition(Console.CursorLeft + 15, Console.CursorTop - 1);
            Console.WriteLine("Checar");
            Console.ResetColor();
            if (opcaoX == 1 && opcaoY == 0)
            {
                menu.Highlight();
            }
            if (checagem != -2)
            {
                Console.WriteLine("Habilidades");
            }
            else
            {
                Console.WriteLine("Bloqueado");
            }
            Console.ResetColor();
            if (opcaoX == 1 && opcaoY == 1)
            {
                menu.Highlight();
            }
            Console.SetCursorPosition(Console.CursorLeft + 15, Console.CursorTop - 1);
            Console.WriteLine("Fugir");
            Console.ResetColor();

            //Capturando e checando que tecla do teclado foi apertada
            opcaoMenu1 = Console.ReadKey();

            if (opcaoMenu1.Key == ConsoleKey.DownArrow)
            {
                opcaoX++;
                if (opcaoX > 1)
                {
                    opcaoX = 0;
                }
            }
            if (opcaoMenu1.Key == ConsoleKey.UpArrow)
            {
                opcaoX--;
                if (opcaoX < 0)
                {
                    opcaoX = 1;
                }
            }
            if (opcaoMenu1.Key == ConsoleKey.RightArrow)
            {
                opcaoY++;
                if (opcaoY > 1)
                {
                    opcaoY = 0;
                }
            }
            if (opcaoMenu1.Key == ConsoleKey.LeftArrow)
            {
                opcaoY--;
                if (opcaoY < 0)
                {
                    opcaoY = 1;
                }
            }
            Console.Clear();

            //Checando se o Enter foi apertado
            if (opcaoMenu1.Key == ConsoleKey.Enter)
            {
                if (opcaoX == 0 && opcaoY == 0)
                {
                    ataque = true;
                }
                else if (opcaoX == 0 && opcaoY == 1)
                {
                    checar = true;
                }
                else if (opcaoX == 1 && opcaoY == 0)
                {
                    if (checagem != -2)
                    {
                        habilidade = true;
                    }        
                }
                else if (opcaoX == 1 && opcaoY == 1)
                {
                    Console.WriteLine("Aperte W, A, S ou D para continuar");
                    fugir = true;
                }
            }
        }
    }



    public int Ataque(Inimigo enemy, Jogador player)
    {
        int dano, danoAoHp, hp;
        dano = player.getAtaque() - enemy.getDefesa();

        if (dano <= 0)
        {
            dano = 1;
        }
        hp = enemy.getHp();
        danoAoHp = hp - dano;
        enemy.setHp(danoAoHp);

        return dano;
    }

    public void Checagem(Inimigo i)
    {
        Console.WriteLine(i.getName());
        Console.WriteLine("\nVida: " + i.getHp());
        Console.WriteLine("Ataque: " + i.getAtaque());
        Console.WriteLine("Defesa: " + i.getDefesa());
        Console.WriteLine("Elemento: " + i.getElemento());
    }

    public int Habilidades(Inimigo enemy, Jogador player)
    {
        bool sairDoMenu = true;
        int opcaoX = 0;
        int opcaoY = 0;
        int dano = 0;

        while (sairDoMenu)
        {
            Console.Clear();
            enemy.ascDoInimigo();
            Hud(player);

            //Serie de ifs que vai "iluminar" as opções a medida que as setas forem apertadas 
            if (opcaoX == 0 && opcaoY == 0)
            {
                menu.Highlight();
            }
            player.nomeDaSkill_1();
            Console.ResetColor();
            if (opcaoX == 0 && opcaoY == 1)
            {
                menu.Highlight();
            }
            Console.SetCursorPosition(Console.CursorLeft + 20, Console.CursorTop - 1);
            player.nomeDaSkill_2();
            Console.ResetColor();
            if (opcaoX == 1 && opcaoY == 0)
            {
                menu.Highlight();
            }
            player.nomeDaSkill_3();
            Console.ResetColor();
            if (opcaoX == 1 && opcaoY == 1)
            {
                menu.Highlight();
            }
            Console.SetCursorPosition(Console.CursorLeft + 20, Console.CursorTop - 1);
            Console.WriteLine("Voltar");
            Console.ResetColor();

            //Descrição das habilidades
            if (opcaoX == 0 && opcaoY == 0)
            {
                player.descricaoDaSkill_1();
            }

            if (opcaoX == 0 && opcaoY == 1)
            {
                player.descricaoDaSkill_2();
            }

            if (opcaoX == 1 && opcaoY == 0)
            {
                player.descricaoDaSkill_3();
            }

            //Capturando e checando que tecla do teclado foi apertada
            var opcaoMenu = Console.ReadKey();

            if (opcaoMenu.Key == ConsoleKey.DownArrow)
            {
                opcaoX++;
                if (opcaoX > 1)
                {
                    opcaoX = 0;
                }
            }
            if (opcaoMenu.Key == ConsoleKey.UpArrow)
            {
                opcaoX--;
                if (opcaoX < 0)
                {
                    opcaoX = 1;
                }
            }
            if (opcaoMenu.Key == ConsoleKey.RightArrow)
            {
                opcaoY++;
                if (opcaoY > 1)
                {
                    opcaoY = 0;
                }
            }
            if (opcaoMenu.Key == ConsoleKey.LeftArrow)
            {
                opcaoY--;
                if (opcaoY < 0)
                {
                    opcaoY = 1;
                }
            }
            Console.Clear();

            //Checando se o Enter foi apertado e fim do loop caso positivo
            if (opcaoMenu.Key == ConsoleKey.Enter)
            {
                if (opcaoX == 0 && opcaoY == 0)
                {
                    enemy.ascDoInimigo();
                    dano = player.skill_1(player, enemy);
                    //Checando se deu tudo certo e a habilidade deu dano
                    if (dano > -1)
                    {
                        Console.WriteLine("Você deu " + dano + " de dano");
                        Console.ReadKey();
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Console.WriteLine("                                                 ");
                    }
                    //Checando se houve a passagem do código que indica que as habilidades foram bloqueadas
                    else if (dano <= -2)
                    {
                        return dano;
                    }
                    //Checando se a habilidade falhou
                    else
                    {
                        return 1;
                    }
                }
                else if (opcaoX == 0 && opcaoY == 1)
                {
                    enemy.ascDoInimigo();
                    dano = player.skill_2(player, enemy);
                    //Checando se deu tudo certo e a habilidade deu dano
                    if (dano > -1)
                    {
                        Console.WriteLine("Você deu " + dano + " de dano");
                        Console.ReadKey();
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Console.WriteLine("                                                 ");
                    }
                    //Checando se houve a passagem do código que indica que as habilidades foram bloqueadas
                    else if (dano <= -2)
                    {
                        return dano;
                    }
                    //Checando se a habilidade falhou
                    else
                    {
                        return 1;
                    }
                }
                else if (opcaoX == 1 && opcaoY == 0)
                {
                    enemy.ascDoInimigo();
                    dano = player.skill_3(player, enemy);
                    //Checando se deu tudo certo e a habilidade deu dano
                    if (dano > -1)
                    {
                        Console.WriteLine("Você deu " + dano + " de dano");
                        Console.ReadKey();
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Console.WriteLine("                                                 ");
                    }
                    //Checando se houve a passagem do código que indica que as habilidades foram bloqueadas
                    else if (dano <= -2)
                    {
                        return dano;
                    }
                    //Checando se a habilidade falhou
                    else
                    {
                        return 1;
                    }
                }
                else if (opcaoX == 1 && opcaoY == 1)
                {
                    enemy.ascDoInimigo();
                    return 1;
                }
                sairDoMenu = false;
            }
        }
        return 0;
    }

    public void Hud(Jogador jogador)
    {
        //Life
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("       " + jogador.getHp() + "    ");
        Console.ResetColor();
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        Console.WriteLine("HP: ");
        Console.WriteLine();

        //Mana 
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(Console.CursorLeft + 22, Console.CursorTop - 2);
        Console.WriteLine("        " + jogador.getMana() + "    ");
        Console.ResetColor();
        Console.SetCursorPosition(Console.CursorLeft + 20, Console.CursorTop - 1);
        Console.WriteLine("Mana: ");
        Console.WriteLine();
    }

}

