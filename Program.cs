using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Abstraindo_um_jogo_de_RPG__utilizando_orientação_a_objetos_com_C_;
using Abstraindo_um_jogo_de_RPG__utilizando_orientação_a_objetos_com_C_.src.src;
using Abstraindo_um_jogo_de_RPG__utilizando_orientação_a_objetos_com_C_.src.src.Entities;



class HeroTeam
{
    static void Main(string[] args)
    {
        Knight Artorias = new Knight("Artorias", 10, "Guerreiro");
        Wizard Frieren = new Wizard("Frieren", 1, "Mago");
        Archer Legolas = new Archer("Legolas", 5, "Arqueiro");

        System.Console.WriteLine(Artorias.attack());
        System.Console.WriteLine(Frieren.attack());
        System.Console.WriteLine(Legolas.attack());
    }
}