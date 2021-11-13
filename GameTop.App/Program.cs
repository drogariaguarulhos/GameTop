// See https://aka.ms/new-console-template for more information
using GameTop.Lib;

var jogo01 = new GameTopAction(new Jogador("Carlos"));

var jogo02 = new GameTopAction(new Jogador("Jose"));

var jogo03 = new GameTopAction(new Jogador("Julio"));


jogo01.Acao(0);
jogo02.Acao(2);
jogo03.Acao(1);
