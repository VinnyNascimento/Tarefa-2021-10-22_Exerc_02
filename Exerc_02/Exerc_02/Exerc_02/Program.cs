using System;

namespace Exerc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra a Área de um Quadrado");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da aresta de um quadrado: ");
            s.setNum1(int.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("A aresta de valor {0} de um quadrado, tem uma área de: {1}", s.getNum1(), s.getResultado());
            #endregion
        }
    }
}