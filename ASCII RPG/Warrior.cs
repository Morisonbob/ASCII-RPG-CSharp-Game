//Classe que herda da classe jogador
//Objetivamente um tipo de jogador

using System;

class Warrior : Jogador
{

    //Construtor da classe, dá os status iniciais de um Warrior
    public Warrior()
    {
        hp = 15;
        mana = 10;
        ataque = 12;
        defesa = 15;
        hpMax = hp;
        manaMax = mana;
        ataqueMax = ataque;
        defesaMax = defesa;
        caracter = "ö";
        linha = 10;
        coluna = 10;
    }

    public override void nomeDaSkill_1()
    {
        Console.WriteLine("Executar");
    }

    public override void nomeDaSkill_2()
    {
        Console.WriteLine("Raiva");
    }
    public override void nomeDaSkill_3()
    {
        Console.WriteLine("Golpe Colossal");
    }

    public override void descricaoDaSkill_1() //Executar
    {
        Console.WriteLine("\nUso de mana : 10");
        Console.WriteLine("\nSe o inimigo estiver com metade da vida ou menos, mata ele instantaneamente");
    }

    public override void descricaoDaSkill_2() //Raiva
    {
        Console.WriteLine("\nUso de mana : 5");
        Console.WriteLine("\nEntra em estado de raiva, aumentando o ataque e\nimpedindo o personagem de usar habilidades");
    }

    public override void descricaoDaSkill_3() //Golpe Colossal
    {
        Console.WriteLine("\nUso de mana : 10");
        Console.WriteLine("\nAtaca o inimigo com toda sua força, ignorando defesa e causando 12 de dano");
    }

    public override int skill_1(Jogador j, Inimigo i)//Executar
    {
        int hpTotal = i.getMaxHp();
        int dano = 0;
        if(j.getMana() >= 10)
        {
            j.setMana(j.getMana() - 10);
            if (i.getHp() <= hpTotal / 2)
            {
                dano = i.getHp();
                i.setHp(0);
            }
            else
            {
                Console.WriteLine("A habilidade falhou");
            }
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
    public override int skill_2(Jogador j, Inimigo i) //Raiva
    {
        if (j.getMana() >= 5)
        {
            j.setMana(j.getMana() - 5);
            j.setAtaque(j.getAtaque() + 3);
            Console.WriteLine("Você entrou em estado de furia, sua força aumentou.");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                     ");
            return -2;
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

    public override int skill_3(Jogador j, Inimigo i) //Golpe Colossal
    {
        int dano, hp;
        dano = 12;
        if (j.getMana() >= 10)
        {
            j.setMana(j.getMana() - 10);
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

