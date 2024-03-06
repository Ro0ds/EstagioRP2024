namespace EstagioRP2024
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solucoes solucoes = new Solucoes();
			//solucoes.ExercicioUm(); // 91

			int numero = int.Parse(Console.ReadLine()!);
			solucoes.Fibonacci(numero);

			string palavra = Console.ReadLine()!;
            Console.WriteLine(solucoes.Inverter(palavra));
		}
	}

	class Solucoes
	{
		public void ExercicioUm()
		{
			int INDICE = 13, SOMA = 0, K = 0;

			while(K < INDICE)
			{
				K++;
				SOMA += K;
			}

            Console.WriteLine($"SOMA: {SOMA}");
        }

		public void Fibonacci(int numero)
		{
			List<int> sequencia = new List<int>();
			int anterior = 0, proximo = 1, auxiliar = 1;

			sequencia.Add(anterior);
			sequencia.Add(proximo);

			for(int i = 0; i <= numero; i++)
			{
				proximo = anterior + auxiliar;
				sequencia.Add(proximo);

				anterior = auxiliar;
				auxiliar = proximo;
			}

			if(sequencia.Contains(numero))
			{
                Console.WriteLine($"{numero} está presente na sequencia de Fibonacci");
            }
        }

		/*
		3)
			a) a cada 2 printa o numero: 1 3 5 7 9 11 13...
			b) soma o mesmo numero/sequencia de 8 bits:
				64 + 64 = 128
			c) o numero menos o anterior é primo: 49
			d) raizes quadradas perfeitas: 100
			e) fibonacci: 13
			f) ?

		4)
			ligo o interruptor 1 e espero a lampada aquecer, desligo ele
			ligo o interruptor 2 e vou pra uma sala
				se estiver ligada, o 2 controla essa lampada
				se estiver desligada, verifico se esta quente a lampada
					se estiver quente, o 1 controla essa lampada
					se estiver fria, então o 3 controla essa lampada
		 */

		public string Inverter(string palavra)
		{
			string invertida = string.Empty;
			int tamanhoPalavra = palavra.Length - 1;

			for(int i = tamanhoPalavra; i >= 0; i--)
			{
				invertida += palavra[i];
			}

			return invertida;
		}
	}
}
