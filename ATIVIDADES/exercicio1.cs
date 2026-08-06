using System;
					
public class Program
{
	public static void Main()
	{

	int estoqueMin, estoqueMax, estoqueMed;
		
		
	Console.WriteLine("========MENU DE PEÇAS========");
	Console.WriteLine("Qual a quantidade mínima");
	while(!int.TryParse(Console.ReadLine(),out estoqueMin)){
	
		Console.WriteLine("Escreva denovo número inválido");
		
	}

	Console.WriteLine("Escreva a quantidade máxima");
	while(!int.TryParse(Console.ReadLine(),out estoqueMax)){
	
		Console.WriteLine("Escreva denovo número inválido");
		
	}

	estoqueMed = (estoqueMin + estoqueMax)/2;
		
	Console.WriteLine("Esse é o seu estoque médio: " + estoqueMed);
		
	}
}
