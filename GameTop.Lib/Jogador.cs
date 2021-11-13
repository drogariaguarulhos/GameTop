using GameTop.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTop.Lib
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; } = string.Empty;

        public Jogador() => Nome = string.Empty;

        public Jogador(string nome) => Nome = nome;

        public string Chuta() => $"{Nome} esta Chutando!";

        public string Corre() => $"{Nome} esta Correndo!";

        public string Passe() => $"{Nome} esta Passando!";
    }
}
