using System;

class SlimeAzul : Inimigo
{
    public SlimeAzul()
    {
        name = "Slime Azul";
        maxHp = 6;
        hp = 6;
        ataque = 8;
        defesa = 8;
        mana = 0;
        caracter = "o"; //Plotar em azul
        linha = 5;
        coluna = 20;
        elemento = "water";
        vivo = true;
        hitChance = 100;
    }

    public override void ascDoInimigo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" .........................................7O");
        Console.WriteLine(" ........................................+DM");
        Console.WriteLine(" ........................................8I7M");
        Console.WriteLine(" ...................................   D87IIZ,");
        Console.WriteLine(" ................................... ,M77II??M,");
        Console.WriteLine(" ................................ .,M7$7I????ID");
        Console.WriteLine(" ................................=MI$77I?++++??8O");
        Console.WriteLine(" ......................... . ..NM7$$7II??+=~==+?IM~.");
        Console.WriteLine(" .........................  7N7$$$77I????+=~~~=+??IM+");
        Console.WriteLine(" ...................   ..DN$$$$$$7II?????+=~~~~==+?IIMO");
        Console.WriteLine(" ...................  IM7$ZZ$$$7II???????++=~~:~~~=+?IIZM~");
        Console.WriteLine(" ................ .=M7$ZZZ$$77II??????++++++==~:::~~=+?IIIOO.");
        Console.WriteLine(" ................DN$ZZZZ$$77III??????++++++++==~~:::~~=+??I77MI");
        Console.WriteLine(" ......... ....+M$ZZZ$$$77III???????+++++++++++==~~:::~~=+?III7N,");
        Console.WriteLine(" ........... ~M$ZZZZ$$77III??????+++++++++++++++++==~~:~~=+???II7N,");
        Console.WriteLine(" ...........M$ZZZZ$$777DDOI?+???++++++++++++++++?+++==~~~=++????II7N");
        Console.WriteLine(" .........,8$ZZZ$$7OM......7M+++++++++++++?++??+=++++++==+++??????I?D,");
        Console.WriteLine(" ........MZZZZZ$$7D .,,++..  MI++++++++=+7M,..  .M7++++++++++++?????IZD");
        Console.WriteLine(" .......M7ZZZ$$77N=. MMMMMM  .M+?+++++++M....... ..M?+++++++++++????IIIZ");
        Console.WriteLine(" ....  M7ZZ$$77IIM..?MMMMMM,..Z++++++++M.. MMMMM8 . M++++++++++++????II$N");
        Console.WriteLine(" ...  Z7Z$$77II??M..:MMMMMM...8++++++++:..MMMMMMM,  ~+++++++++++++????IIZ~");
        Console.WriteLine(" ....+D$$7I??+++?N~..7MMMM?. :N+++++++I ..MMMMMMM= ..?+++=======+++???IIIM,");
        Console.WriteLine(" ....MI7I?+~~~==++Z+.. .   ,,Z=++++++++O ..MMMMMN. .D=+==~~:::~~==+????IIIM");
        Console.WriteLine(" ....O77I=~:,:~==+++OMZ=:?DN+++++++++++IN.    . ...M?+==~::,,,,:~=++???III8");
        Console.WriteLine(" ...:7$7I=~:,:~==+??++?++++++++++++++++++DN  .. .ND+++=~~:,,..,::==+???II77+");
        Console.WriteLine(" ...+7$$7?=~~~~=+?++?+++++++++++++++++++++++?Z$?+??+++==~:,,.,,:~==+???II77O");
        Console.WriteLine(" ...+7$$$7I?++++??N8???++++++++++++++++++++++++++++++++=~~:::::~==+???II77$O");
        Console.WriteLine(" ....ZZZZ$77I????$MMMM8+++++?++++++++++++++++++++8MMN+++==~~~~~==++??II77$7?");
        Console.WriteLine(" ....M$ZZZZ$77III?MMMMMMMMMOI++++++++++=+I$DMMMMMMMMM+++++====+++????II7$$$,");
        Console.WriteLine(" ....NZZOZZZ$77III?MMMMMMMMMN88OOOOOOZZZZZZZZOZ8MMMMN+?+++++++++????II77$$N");
        Console.WriteLine(" ....,MZOOZZ$$77IIINMMMMMDO88OOOOZZZZZ$$$Z$$$ZZZONMM+++++++++??????III77$$M");
        Console.WriteLine(" .....7$ZZOZZ$$77II?7MM8O8OOOZZZZ$$$$$77777$$$$Z$$M+++++++????????III7$$$N,");
        Console.WriteLine(" .... .M7ZOOZZZ$$7II?IMOOOOZZ$$$$$7777IIIII77777$O=++++?????????IIII7$$$$?");
        Console.WriteLine(" .......M7ZOOZZ$$777II?ONZZZZ$7$77777III?II77IO8=++????????????III777$$$M");
        Console.WriteLine(" ........M7ZOOOZZ$$$7IIII7MZI$777777IIIII??DM+++I??????????IIIII77$$$$$8");
        Console.WriteLine(" ......  .N7$OOOZZZ$$77III???ONNO777Z8MMO+???????????????IIIII777$$ZZNZ");
        Console.WriteLine();
        Console.ResetColor();
    }

    public override void nomeDaSkill_1() //Bolhas
    {
        Console.WriteLine("Bolhas de agua");
    }

    public override int skill_1(Jogador j, Inimigo i)
    {
        int dano, hp;
        dano = 6;
        /*if (i.getElemento() == "wind")
        {
            dano = dano / 2;
        }
        else if (i.getElemento() == "fire")
        {
            dano = dano * 2;
        }*/
        hp = j.getHp();
        hp = hp - dano;
        j.setHp(hp);
        return dano;
    }
}
