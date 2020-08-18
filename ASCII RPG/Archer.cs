//Classe que herda da classe jogador
//Objetivamente um tipo de jogador

using System;

class Archer : Jogador
{

    //Construtor da classe, dá os status iniciais de um Warrior
    public Archer()
    {
        hp = 10;
        mana = 15;
        ataque = 10;
        defesa = 10;
        hpMax = hp;
        manaMax = mana;
        ataqueMax = ataque;
        defesaMax = defesa;
        caracter = "♂";
        linha = 10;
        coluna = 10;
    }

    public override void nomeDaSkill_1()
    {
        Console.WriteLine("Chuva de Flechas");
    }

    public override void nomeDaSkill_2()
    {
        Console.WriteLine("Concentracao");
    }
    public override void nomeDaSkill_3()
    {
        Console.WriteLine("Cegar");
    }

    public override void descricaoDaSkill_1() //Chuva de Flechas
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nSolta uma saraivada de flechas em cima dos inimigos dando 6 de dano");
    }

    public override void descricaoDaSkill_2() //Concentração
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nAumenta a concentração do arqueiro,\nfazendo com que seus ataques básicos deem mais dano");
    }

    public override void descricaoDaSkill_3() //Cegar
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nFaz com que os inimigos errem os ataques");
    }

    public override int skill_1(Jogador j, Inimigo i) //Chuva de Flechas
    {
        int dano, hp;
        dano = 6;
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
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

    public override int skill_2(Jogador j, Inimigo i) //Concentração
    {
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
            j.setAtaque(j.getAtaque() + 3);
            Console.WriteLine("Você esta concentrado, seus golpes estão mais fortes.");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                     ");
            return 0;
        }
        else
        {
            Console.WriteLine("Você não tem mana para essa ação");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
            return -1;
        }
    }
}

