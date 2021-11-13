using GameTop.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTop.Lib
{
    public class GameTopAction
    {
        private IJogador _Jogador = new Jogador();

        public GameTopAction(IJogador jogador) => _Jogador = jogador;

        public void Acao(int acao)
        {
            switch (acao)
            {
                case 1:
                    Console.WriteLine(_Jogador.Passe());
                    break;
                case 2:
                    Console.WriteLine(_Jogador.Chuta());
                    break;
                case 0:
                default:
                    Console.WriteLine(_Jogador.Corre());
                    break;
            }
        }
    }
}
