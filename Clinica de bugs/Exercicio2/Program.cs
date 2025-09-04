using System;

 Double notaProva = 8.5; //(E1) Tipo de dado incorreto (CS0029)
 int quantidadeAlunos = 42; //(E2) valor de int em aspas dupla(CS0029)
 string nomeCurso = "Fundamentos de C#"; //(E3) valor de string em aspas simples(CS0029)
 bool pagamentoEfetuado = false; //(E4) Valor booleano em aspas duplas(CS0029)
 char digitoVerificador = '7'; //(E5) Valor de char em aspas simples e falta de ; (CS1002)
 Console.WriteLine(notaProva);
 Console.WriteLine(quantidadeAlunos);
 Console.WriteLine(nomeCurso); //(E6) Nome de variavel invalida, c# não é case sensitive (CS0103)
 Console.WriteLine(pagamentoEfetuado);
 Console.WriteLine(digitoVerificador);