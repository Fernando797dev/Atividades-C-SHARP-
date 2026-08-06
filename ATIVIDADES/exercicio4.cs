//4. Ler uma temperatura em graus Fahrenheit apresentá-la convertida em graus Celsius . A
//fórmula de conversão de temperatura a ser utilizada é C = (F - 32) ÷ 1,8, em que a
//variável C representa a temperatura em graus Celciuse a variável F representa a
//temperatura em graus Fahrenheit.

using System;
					
public class Program
{
	public static void Main()
	{

		Console.WriteLine("Digite a temperatura em Fahrenheit para ser convertida");
		double fahrenheit = double.Parse(Console.ReadLine());
		
		double convertidoCelsius =  (fahrenheit - 32) / 1.8; 
		
		Console.Write("Esse é a conversão de fahrenheit para celsius: "+ convertidoCelsius);	
	
	}
}
