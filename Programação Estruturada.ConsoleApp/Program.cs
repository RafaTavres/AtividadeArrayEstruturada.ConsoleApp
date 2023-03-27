using System;

namespace AtividadeArrayEstruturada.ConsoleApp
{
    internal class Program
    {
        static int numeroDigitado = 10;
        static Array arraySequencia = new int[10];
        static Array arrayDosNegativos = new int[10];
        static Array arrayMaioresvaloresDoArray = new int[10];
        static List<int> listaMaioresvaloresDoArray = new List<int>();
        static int maiorvalor = 0;
        static int media;
        static int valorPraExcluir;
        static int valoresSomados;
        static int menorvalor = Int32.MaxValue;
        static void Main(string[] args)
        {
            PegaValoresDigitados();
            MostraValoresNaTela();
        }

        private static void MostraValoresNaTela()
        {
            Console.WriteLine("______________________________");
            MostraMenorMaiorEMedia();
            MostrarValoresNegativos();
            Mostrar3MaioresValores();
            MostrarSequenciaCompleta();
            ExcluirValorArray();
            MostrarSequenciaCompleta();
            Console.ReadLine();
        }

        private static void MostraMenorMaiorEMedia()
        {
            Console.WriteLine("______________________________");
            Console.Write("Maior Valor: ");
            Console.WriteLine(maiorvalor);
            Console.Write("Menor Valor: ");
            Console.WriteLine(menorvalor);
            Console.Write("Média: ");
            Console.WriteLine(media);
        }

        private static void ExcluirValorArray()
        {
            Console.Write("Valor para Excluir: ");
            valorPraExcluir = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arraySequencia.Length; i++)
            {
                if (arraySequencia.GetValue(i).Equals(valorPraExcluir))
                {
                    arraySequencia.SetValue(null, i);

                }

            }
        }

        private static void MostrarSequenciaCompleta()
        {
            Console.WriteLine("______________________________");
            foreach (int item in arraySequencia)
            {
                if (arraySequencia.GetValue(item) is 0)
                {}
                else 
                { Console.WriteLine(item); }

            }
        }

        private static void Mostrar3MaioresValores()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("3 maiores valores da sequência..");
            for (int i = 0; i < arrayMaioresvaloresDoArray.Length; i++)
            {
                if (i == arrayMaioresvaloresDoArray.Length - 3 || i == arrayMaioresvaloresDoArray.Length - 2 || i == arrayMaioresvaloresDoArray.Length - 1)
                {
                    Console.WriteLine(arrayMaioresvaloresDoArray.GetValue(i));

                }
            }
            Console.WriteLine();
        }

        private static void MostrarValoresNegativos()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("Valores Negativos:");

            for (int i = 0; i < arraySequencia.Length; i++)
            {
                if (arrayDosNegativos.GetValue(i) is 0)
                {
                    arrayDosNegativos.SetValue(null, i);
                }
                else { Console.WriteLine(arrayDosNegativos.GetValue(i)); }
            }
            Console.WriteLine();
        }

        static void PegaValoresDigitados()
        {
            for (int i = 0; i < arraySequencia.Length; i++)
            {
                Console.Write("Digite um valor:  ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                arraySequencia.SetValue(numeroDigitado, i);
                PegaMaiorValorDoArray();
                PegaMenorvalorDoArray();
                PegaOsValoresNegativos(numeroDigitado, i);
                PegaOsMaioresValores(numeroDigitado);
                valoresSomados += numeroDigitado;

            }

            media = valoresSomados / 10;
        }
        private static void PegaMenorvalorDoArray()
        {
            for (int i = 0; i < arraySequencia.Length; i++)
            {

                if (numeroDigitado < menorvalor)
                {
                    menorvalor = numeroDigitado;
                }
            }
        }

        private static void PegaOsValoresNegativos(int numeroDigitado, int i)
        {
            if (numeroDigitado < 0)
            {
                arrayDosNegativos.SetValue(numeroDigitado, i);
            }
        }
        private static void PegaOsMaioresValores(int numeroDigitado)
        {
            listaMaioresvaloresDoArray.Add(numeroDigitado);
            listaMaioresvaloresDoArray.Sort();
            arrayMaioresvaloresDoArray = listaMaioresvaloresDoArray.ToArray();


        }

        private static void PegaMaiorValorDoArray()
        {
            for (int i = 0; i < arraySequencia.Length; i++)
            {
                if (numeroDigitado > maiorvalor)
                {
                    maiorvalor = numeroDigitado;
                }
            }
        }
    }
}