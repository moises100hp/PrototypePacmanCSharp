using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePacman
{
    internal class FantasmaPacMan : IFantasmaPrototype
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Comportamento { get; set; }
        public int Velocidade { get; set; }


        public FantasmaPacMan(string nome, string cor, string comportamento, int velocidade)
        {
            Nome = nome;
            Cor = cor;
            Comportamento = comportamento;
            Velocidade = velocidade;
        }

        public IFantasmaPrototype Clone()
        {
            return (IFantasmaPrototype)this.MemberwiseClone();
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Cor: {Cor}, Comportamento: {Comportamento}, Velocidade: {Velocidade}");

        }

        public void Mover()
        {
            Console.WriteLine($"Nome: {Nome} ({Cor}) está se movendo com {Comportamento} a {Velocidade} unidades/seg.");
        }
    }
}
