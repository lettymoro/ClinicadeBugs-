 using System;
 using System.Globalization;

 Console.Write("Por favor, digite seu primeiro nome: ");
 string primeiroNome = Console.ReadLine() ?? string.Empty; //(E1) ; esperado (CS1002)
 Console.Write("Agora, digite sua idade: ");
 int idade = int.Parse(Console.ReadLine()!); // (E2) Não é possível converter implicitamente o tipo 'string' em 'int (CS0029)
 Console.Write("Por fim, digite sua altura em metros (ex: 1.80): ");
 float altura = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture); // (E3) Adicionamos CultureInfo.InvariantCulture 
                                                                                // para usar ponto como separador decimal. (CS0103)
 Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura.ToString("0.00", CultureInfo.InvariantCulture)} m.");
 //(E4 Linha 11) 'PrimeiroNome' não existe no contexto atual (CS0103)