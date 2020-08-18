using System;


class Jogador
{
    protected String name;
    protected String caracter;
    protected int hp, mana, ataque, defesa;
    protected int hpMax, manaMax, ataqueMax, defesaMax;
    protected int linha, coluna;

    //Sets e Gets

    public void setName(String nome)
    {
        name = nome;
    }

    public String getName()
    {
        return name;
    }

    public void setCaracter(String x)
    {
        caracter = x;
    }

    public String getCaracter()
    {
        return caracter;
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

    public void setHpMax(int x)
    {
        hpMax = x;
    }

    public int getHpMax()
    {
        return hpMax;
    }

    public void setManaMax(int x)
    {
        manaMax = x;
    }

    public int getManaMax()
    {
        return manaMax;
    }

    public void setAtaqueMax(int x)
    {
        ataqueMax = x;
    }

    public int getAtaqueMax()
    {
        return ataqueMax;
    }

    public void setDefesaMax(int x)
    {
        defesaMax = x;
    }

    public int getDefesaMax()
    {
        return defesaMax;
    }

    public void setColuna(int x)
    {
        coluna += x;
    }

    public int getColuna()
    {
        return coluna;
    }

    public void setLinha(int x)
    {
        linha += x;
    }

    public int getLinha()
    {
        return linha;
    }


    //Metodos que serão sobreescritos
    public virtual void nomeDaSkill_1()
    {
        Console.WriteLine("Uma Skill");
    }

    public virtual void nomeDaSkill_2()
    {
        Console.WriteLine("Uma Skill");
    }

    public virtual void nomeDaSkill_3()
    {
        Console.WriteLine("Uma Skill");
    }

    public virtual void descricaoDaSkill_1()
    {
        Console.WriteLine("\nUma Skill que da dano");
    }

    public virtual void descricaoDaSkill_2()
    {
        Console.WriteLine("\nUma Skill que da dano");
    }

    public virtual void descricaoDaSkill_3()
    {
        Console.WriteLine("\nUma Skill que da dano");
    }

    public virtual int skill_1(Jogador j, Inimigo i)
    {
        return 0;
    }

    public virtual int skill_2(Jogador j, Inimigo i)
    {
        return 0;
    }

    public virtual int skill_3(Jogador j, Inimigo i)
    {
        return 0;
    }
}
