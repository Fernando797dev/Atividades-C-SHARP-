//4. Ler uma temperatura em graus Fahrenheit apresentá-la convertida em graus Celsius . A
//fórmula de conversão de temperatura a ser utilizada é C = (F - 32) ÷ 1,8, em que a
//variável C representa a temperatura em graus Celciuse a variável F representa a
//temperatura em graus Fahrenheit.

using System;
					
public class Program
{
	public static void Main()
	{

	Console.WriteLine("Digite a temperatura em graus celsius que deseja ser convertida: ");
	double celsius = double.Parse(Console.ReadLine());
		
	double convertidoFahrenheit = (9 * celsius + 160) / 5;
		
	Console.Write("Valor convertido em fahrenheits: "+ convertidoFahrenheit);

	}
}
