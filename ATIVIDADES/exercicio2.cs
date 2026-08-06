//2. Faça um programa que:
//● Leia a cotação do dólar
//● Leia um valor em dólares
//● Converta esse valor para Real
//● Mostre o resultado

using System;
					
public class Program
{
	public static void Main()
	{

	

	
	Console.WriteLine("Escreva a cotação do dolar");
	double cotacaoDolar = double.Parse(Console.ReadLine());
	
	Console.WriteLine("Escreva o valor em dólares que deseja ser convertido para real");
	double dolar = double.Parse(Console.ReadLine());
	
	double convertidoDolar = cotacaoDolar * dolar;
		
	Console.WriteLine("Esse é o seu resultado: " + convertidoDolar);
	}
}
