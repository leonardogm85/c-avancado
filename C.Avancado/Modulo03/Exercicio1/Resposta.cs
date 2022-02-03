﻿namespace C.Avancado.Modulo03.Exercicio1
{
    /// <summary>
    /// <para>
    ///     Inicialmente, crie uma lista contendo os seguintes elementos do tipo double: 3, 7, 2, 4, 6. Na
    ///     sequência, chame o método ConvertAll() da lista para retornar uma nova lista de elementos
    ///     double, onde cada um dos elementos originais é dividido por 2. Isto significa que a nova lista
    ///     conterá os elementos 1.5, 3.5, 1, 2, 3.
    /// </para>
    /// <para>
    ///     O método ConvertAll() recebe como parâmetro um delegate do tipo Converter. Este
    ///     delegate é responsável por transformar cada um dos elementos da lista, a fim de serem
    ///     adicionados na nova lista. Use uma expressão lambda, que recebe como parâmetro o
    ///     elemento a ser transformado.
    /// </para>
    /// <para>
    ///     Depois que esta nova lista for gerada, imprima os elementos na tela. A impressão deve ser
    ///     feita através do método ForEach() da lista, que recebe um delegate do tipo Action. Aqui
    ///     também você deve usar uma expressão lambda, que recebe como parâmetro o elemento que
    ///     será exibido na tela.
    /// </para>
    /// </summary>
    public static class Resposta
    {
        public static void Executar()
        {
            List<double> list = new List<double>
            {
                3,
                7,
                2,
                4,
                6
            };

            List<double> newList = list.ConvertAll(item => item / 2);

            newList.ForEach(item => Console.WriteLine(item));
        }
    }
}
