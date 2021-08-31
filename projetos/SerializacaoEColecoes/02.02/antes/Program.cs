using System;
using System.Collections.Generic;

namespace _02._02
{
    class Program
    {
        //Cronologia Star Wars
        //=========================================
        //Episódio I: A Ameaça Fantasma         1999
        //Episódio II: Ataque dos Clones        2002
        //A Guerra dos Clones                   2003
        //Episódio III: A Vingança dos Sith     2005
        //Rebels                                2014
        //Rogue One                             2016
        //Episódio IV -Uma nova esperança       1977
        //Episódio V -O Império Contra-Ataca    1980
        //Episódio VI -O Retorno de Jedi        1983
        //Episódio VII -O Despertar da Força    2015
        //Episódio VIII: Os Últimos Jedi        2017
        static void Main(string[] args)
        {
            //TAREFA PRINCIPAL
            //=================
            //colocar os filmes abaixo na ordem cronológica
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);
            var ataque = new Filme("Episódio II: Ataque dos Clones", 2002);
            var guerraClones = new Filme("A Guerra dos Clones", 2003);
            var vinganca = new Filme("Episódio III: A Vingança dos Sith", 2005);
            var rebels = new Filme("Rebels", 2014);
            var despertar = new Filme("Episódio VII -O Despertar da Força", 2015);
            var rogue = new Filme("Rogue One", 2016);
            var ultimo = new Filme("Episódio VIII: Os Últimos Jedi", 2017);

            ///TAREFA: criar uma coleção vazia, que irá crescer aos poucos

            ///TAREFA: checar a capacidade da lista

            ///TAREFA: adicionar o filme "Episódio IV -Uma nova esperança"

            ///TAREFA: checar novamente a capacidade da lista

            ///TAREFA: Adicionar no final: Império Contra Ataca e Retorno de Jedi

            ///TAREFA: Declarar a lista com inicialização simplificada

            ///TAREFA: checar novamente a capacidade da lista

            ///TAREFA: imprimir a cronologia

            ///TAREFA: inserir Ameaça Fantasma no início da cronologia

            ///TAREFA: Inserir na segunda posição: Ataque dos Clones, Guerra dos Clone, Vingança dos Sith

            ///TAREFA: checar novamente a capacidade da lista

            ///TAREFA: adicionar Despertar da Força no fim da cronologia

            ///TAREFA: inserir Rogue One antes de Uma Nova Esperança

            ///TAREFA: adicionar O Último Jedi ao final da cronologia

            ///TAREFA: exibir a cronologia inversa

            ///TAREFA: voltar a cronologia à ordem original

            ///TAREFA: obter lista de filmes só com atores (sem rebels e guerra dos clones)

            ///TAREFA: obter trilogia original (filmes lançados até 1983)

            ///TAREFA: exibir primeiro filme da cronologia

            ///TAREFA: exibir último filme da cronologia

            ///TAREFA: exibir filmes em ordem alfabética

            ///TAREFA: exibir filmes em ordem de lançamento

            ///TAREFA: exibir filmes da trilogia inicial (posições 4, 5 e 6)
        }
    }

    public class Filme
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}
