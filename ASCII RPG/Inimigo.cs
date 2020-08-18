using System;

class Inimigo
{
    Random rand = new Random();
    protected String name;
    protected String caracter;
    protected int hp, mana, ataque, defesa, maxHp;
    protected int linha, coluna;
    protected int hitChance;
    protected bool vivo;
    protected String elemento; //{wind, water, fire, earth }

    //Sets e Gets


    public void setVivo(bool x)
    {
        vivo = x;
    }

    public bool getVivo()
    {
        return vivo;
    }

    public void setName(String nome)
    {
        name = nome;
    }

    public String getName()
    {
        return name;
    }

    public void setElemento(String x)
    {
        elemento = x;
    }

    public String getElemento()
    {
        return elemento;
    }

    public void setCaracter(String x)
    {
        caracter = x;
    }

    public String getCaracter()
    {
        return caracter;
    }

    public void setLinha(int x)
    {
        linha += x;
    }

    public int getLinha()
    {
        return linha;
    }

    public void setHitChance(int x)
    {
        hitChance += x;
    }

    public int getHitChance()
    {
        return hitChance;
    }

    public void setColuna(int x)
    {
        coluna += x;
    }

    public int getColuna()
    {
        return coluna;
    }

    public void setHp(int x)
    {
        hp = x;
    }

    public int getHp()
    {
        return hp;
    }

    public void setMana(int x)
    {
        mana = x;
    }

    public int getMana()
    {
        return mana;
    }

    public void setAtaque(int x)
    {
        ataque = x;
    }

    public int getAtaque()
    {
        return ataque;
    }

    public void setDefesa(int x)
    {
        defesa = x;
    }

    public int getDefesa()
    {
        return defesa;
    }

    public void setMaxHp(int x)
    {
        maxHp = x;
    }

    public int getMaxHp()
    {
        return maxHp;
    }

    //Metodos que serão sobreescritos
    public virtual void nomeDaSkill_1()
    {
        Console.WriteLine("Uma Skill de um inimigo");
    }

    public virtual void nomeDaSkill_2()
    {
        Console.WriteLine("Uma Skill de um inimigo");
    }

    public virtual void ascDoInimigo()
    {

    }

    public virtual int skill_1(Jogador j, Inimigo i)
    {
        return 0;
    }

    public void enemyTurn(Inimigo enemy, Jogador player)
    {
        int opcao = rand.Next(1, 3);
        if (opcao == 1)
        {
            Console.WriteLine("O " + enemy.getName() + " te atacou causando " + enemyAtaque(enemy, player) + " de dano");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
        }
        else if (opcao == 2)
        {
            Console.WriteLine("O " + enemy.getName() + " te atacou causando " + enemy.skill_1(player, enemy) + " de dano");
            Console.ReadKey();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("                                                 ");
        }
    }

    public int enemyAtaque(Inimigo enemy, Jogador player)
    {
        int dano, danoAoHp, hp;
        dano = enemy.getAtaque() - player.getDefesa();

        if (dano <= 0)
        {
            dano = 1;
        }
        hp = player.getHp();
        danoAoHp = hp - dano;
        player.setHp(danoAoHp);

        return dano;
    }
}
