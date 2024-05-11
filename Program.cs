double gasolina, comparacao, alcool;

Console.WriteLine(">>>>ATIVIDADE 'ALCOOL E GASOLINA'<<<<\n");

Console.Write("Digite o preço do álcool:");
alcool = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o preço da gasolina:");
gasolina = Convert.ToDouble(Console.ReadLine());

comparacao = (alcool / gasolina) * 100;

Console.WriteLine($"O preço do alcool corresponde a {comparacao}% do preço da gasolina.");

if (comparacao <= 73)

  {
     Console.WriteLine("Recomendação: Abasteça com ALCOOL.");
  }

else

  {
   Console.WriteLine( "Recomendação: Abasteça com GASOLINA.");
  }
