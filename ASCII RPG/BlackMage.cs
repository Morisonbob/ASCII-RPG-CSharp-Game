//Classe que herda da classe jogador
//Objetivamente um tipo de jogador

using System;


class BlackMage : Jogador
{

    //Construtor da classe, dá os status iniciais de um Black Mage
    public BlackMage()
    {
        hp = 10;
        mana = 20;
        ataque = 8;
        defesa = 6;
        hpMax = hp;
        manaMax = mana;
        ataqueMax = ataque;
        defesaMax = defesa;
        caracter = "ô";
        linha = 10;
        coluna = 10;
    }

    public override void nomeDaSkill_1()
    {
        Console.WriteLine("Bola de Fogo");
    }

    public override void nomeDaSkill_2()
    {
        Console.WriteLine("Congelar");
    }
    public override void nomeDaSkill_3()
    {
        Console.WriteLine("Trovão");
    }

    public override void descricaoDaSkill_1() //Bola de fogo
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nSolta uma bola de fogo que dá 8 de dano e pode fazer o inimigo queimar.");
        Console.WriteLine("Dá o dobro de dano a inimigos do tipo ar e metade a inimigos do tipo água.");
    }

    public override void descricaoDaSkill_2() //Congelar
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nCongela um inimigo e dá 8 dano de gelo.");
        Console.WriteLine("Dá o dobro de dano a inimigos do tipo fogo e metade a inimigos do tipo água.");
    }

    public override void descricaoDaSkill_3() //Trovão
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nInvoca um trovão que dá 8 de dano e pode paralizar o inimigo.");
        Console.WriteLine("Dá o dobro de dano a inimigos do tipo água e metade a inimigos do tipo ar.");
    }

    public override int skill_1(Jogador j, Inimigo i)  //Bola de fogo
    {
        int dano, hp;
        dano = 8;
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
            if (i.getElemento() == "water")
            {
                dano = dano / 2;
            }
            else if (i.getElemento() == "wind")
            {
                dano = dano * 2;
            }
            hp = i.getHp();
            hp = hp - dano;
            i.setHp(hp);
        }
        else
        {
            Console.WriteLine("Você não tem mana para essa ação");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
            return -1;
        }
        
        return dano;
    }

    public override int skill_2(Jogador j, Inimigo i)  //Congelar
    {
        int dano, hp;
        dano = 8;
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
            if (i.getElemento() == "water")
            {
                dano = dano / 2;
            }
            else if (i.getElemento() == "fire")
            {
                dano = dano * 2;
            }
            hp = i.getHp();
            hp = hp - dano;
            i.setHp(hp);
        }
        else
        {
            Console.WriteLine("Você não tem mana para essa ação");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
            return -1;
        }

        return dano;
    }

    public override int skill_3(Jogador j, Inimigo i)  //Trovão
    {
        int dano, hp;
        dano = 8;
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
            if (i.getElemento() == "earth")
            {
                dano = dano / 2;
            }
            else if (i.getElemento() == "water")
            {
                dano = dano * 2;
            }
            hp = i.getHp();
            hp = hp - dano;
            i.setHp(hp);
        }
        else
        {
            Console.WriteLine("Você não tem mana para essa ação");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
            return -1;
        }

        return dano;
    }
}
