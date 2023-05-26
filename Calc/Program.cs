using System.Globalization;
using System;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Bem vindo a Calculadora!");
Console.WriteLine("Aqui você poderá tirar suas duvidas");
Console.WriteLine("Vou te apresentar as opções que temos!");
Console.WriteLine();
Console.WriteLine("Digite 1 para Adição(+)");
Console.WriteLine("Digite 2 para Subtração(-)");
Console.WriteLine("Digite 3 para Mulplicação(*)");
Console.WriteLine("Digite 4 para Divisão(/)");
Console.WriteLine();
Console.WriteLine("Calculos especiais: ");
Console.WriteLine("Digite 5 para calcular o seu IMC");
Console.WriteLine("Digite 6 para Tranformar Graus Celsius em Fahrenheit");
Console.WriteLine("Digite 7 para calculos e dados de um triângulo");
Console.WriteLine("Digite 8 para calculos de um circulo");      
Console.WriteLine("Digite 9 para conversão de moedas: ");
Console.WriteLine();

int Opção;
Opção = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.WriteLine();
if (Opção == 1) // Adição
{

    Console.WriteLine("Os números que você deseja somar são numeros inteiros ou decimais?");
    Console.WriteLine("Digite 1 para Inteiros e 2 para Decimais");
    int DecimalouInteiro = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Red;
    if (DecimalouInteiro == 1)
    {
        Console.WriteLine("Digite dois valores a ser adicionados :");
        Console.WriteLine("Primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor ");
        int valor2 = int.Parse(Console.ReadLine());
        int soma = valor1 + valor2;
        Console.WriteLine("O Resultado dessa soma é " + soma);

    }
    else if (DecimalouInteiro == 2)
    {
        Console.WriteLine("Digite dois valores a ser adicionados :");
        Console.WriteLine("Primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Segundo valor ");
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double soma = valor1 + valor2;
        Console.WriteLine("O Resultado dessa soma é " + soma.ToString("F2", CultureInfo.InvariantCulture));

    }
    Console.ResetColor();

}

else if (Opção == 2) // Subtração
{
    Console.WriteLine("Os números que você deseja subtrair são numeros inteiros ou decimais?");
    Console.WriteLine("Digite 1 para Inteiros e 2 para Decimais");
    int DecimalouInteiro = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Blue;
    if (DecimalouInteiro == 1)
    {
        Console.WriteLine("Digite dois valores a ser subtraido :");
        Console.WriteLine("Primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor ");
        int valor2 = int.Parse(Console.ReadLine());
        int sub = valor1 - valor2;
        Console.WriteLine("O Resultado dessa subtração é " + sub);
    }
    else if (DecimalouInteiro == 2)
    {
        Console.WriteLine("Digite dois valores a ser subtraido :");
        Console.WriteLine("Primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Segundo valor ");
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double sub = valor1 - valor2;
        Console.WriteLine("O Resultado dessa subtração é " + sub.ToString("F2", CultureInfo.InvariantCulture));

    }
    Console.ResetColor();
}
else if (Opção == 3) // Multiplicação
{
    Console.WriteLine("Os números que você deseja multiplicar são numeros inteiros ou decimais?");
    Console.WriteLine("Digite 1 para Inteiros e 2 para Decimais");
    int DecimalouInteiro = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkRed;

    if (DecimalouInteiro == 1)
    {
        Console.WriteLine("Digite dois valores a ser multiplicado :");
        Console.WriteLine("Primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor ");
        int valor2 = int.Parse(Console.ReadLine());
        int mult = valor1 * valor2;
        Console.WriteLine("O Resultado dessa multiplicação é " + mult);
    }
    else if (DecimalouInteiro == 2)
    {
        Console.WriteLine("Digite dois valores a ser multiplicado :");
        Console.WriteLine("Primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Segundo valor ");
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double mult = valor1 * valor2;
        Console.WriteLine("O Resultado dessa multiplicação é " + mult.ToString("F2", CultureInfo.InvariantCulture));
    }
    Console.ResetColor();
}

else if (Opção == 4) //Divisão 
{
    Console.WriteLine("Os números que você deseja diividir são numeros inteiros ou decimais?");
    Console.WriteLine("Digite 1 para Inteiros e 2 para Decimais");
    int DecimalouInteiro = int.Parse(Console.ReadLine());

    if (DecimalouInteiro == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Digite dois valores a ser dividos :");
        Console.WriteLine("Primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor ");
        int valor2 = int.Parse(Console.ReadLine());
        int div = valor1 / valor2;
        Console.WriteLine("O Resultado dessa divisão é " + div);
    }
    else if (DecimalouInteiro == 2)
    {
        Console.WriteLine("Digite dois valores a ser dividos :");
        Console.WriteLine("Primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Segundo valor ");
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double div = valor1 / valor2;
        Console.WriteLine("O Resultado dessa divisão é " + div.ToString("F2", CultureInfo.InvariantCulture));
    }
    Console.ResetColor();

}

else if (Opção == 5) // IMC 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Começe digitando a sua altura :");
    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Agora digite o seu peso:");
    double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double imc = peso / (altura * altura);

    Console.WriteLine("O seu IMC é :" + imc.ToString("F2", CultureInfo.InvariantCulture));

    if (imc <= 18.5)
    {
        Console.WriteLine("Classificação: MAGREZA, Grau de Obesidade: 0");
    }
    else if ((imc > 18.5) && (imc <= 24.9))
    {
        Console.WriteLine("Classificação: NORMAL, Grau de Obesidade: 0");
    }
    else if ((imc > 24.9) && (imc <= 29.9))
    {
        Console.WriteLine("Classificação: SOBREPESO, Grau de Obesidade: 1");
    }
    else if ((imc > 29.9) && (imc <= 39.9))
    {
        Console.WriteLine("Classificação: OBESIDADE, Grau de Obesidade: 2");
    }
    else if (imc >= 40.0)
    {
        Console.WriteLine("Classificação: OBESIDADE GRAVE, Grau de Obesidade: 3");
    }

    Console.ResetColor();
}
else if (Opção == 6)// Celsius para Fahrenheit
{
    Console.WriteLine("Você deseja saber os Graus Celsius ou Fahrenheit? ");
    Console.WriteLine("Digite 1 para Saber os Fahrenheit e 2 para Celsius ");
    int CelFah = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    if (CelFah == 1)
    {
        Console.WriteLine("Digite o Grau Celsius : ");
        double Celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Fahrenheit = (Celsius * 1.8) + 32.0;

        Console.WriteLine("O resultado em Fahrenheit é " + Fahrenheit.ToString("F2", CultureInfo.InvariantCulture));
    }
    else if (CelFah == 2)
    {
        Console.WriteLine("Digite o Grau Fahrenheit : ");
        double Fahrenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Celsius = (Fahrenheit - 32) * 5 / 9;

        Console.WriteLine("O resultado em Celsius é " + Celsius.ToString("F1", CultureInfo.InvariantCulture));
    }
    Console.ResetColor();
}
else if (Opção == 7)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Digite as informações do triângulo");
    Console.WriteLine("Base: ");
    double Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Cateto 1: ");
    double Cat1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Cateto 2: ");
    double Cat2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Altura:");
    double altura = double.Parse(Console.ReadLine());

    double area = (Base * altura) / 2;

    Console.WriteLine("A área desse triângulo é: " + area.ToString("f2", CultureInfo.InvariantCulture));

    if ((Base == Cat1) && (Base == Cat2) && (Cat1 == Cat2))
    {
        Console.WriteLine("Esse triângulo é : Equilátero");
    }
    else if ((Base != Cat1) && (Base != Cat2) && (Cat1 != Cat2))
    {
        Console.WriteLine("Esse triângulo é : Escaleno");
    }
    else if ((Base == Cat1) || (Base == Cat2) || (Cat1 == Cat2))
    {
        Console.WriteLine("Esse triângulo é : Isósceles ");
    }
    Console.ResetColor();
}
else if (Opção == 8)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Digite o valor do Raio do seu circulo por favor");
    double raio = double.Parse(Console.ReadLine());
    double pi = 3.14;

    double diametro = raio * 2;
    double area = Math.Pow(raio, 2.0) * pi;
    double perimetro = (pi * 2) * raio;
    double circuferencia = pi * diametro;

    Console.WriteLine("A área desse circulo é " + area.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine("A perímetro desse circulo é " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("O diâmetro desse circulo é " + diametro.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("a circuferência desse circulo é " + circuferencia.ToString("F2", CultureInfo.InvariantCulture));

}
else if (Opção == 9)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Primeiro digite que moeda Você quer saber ");
    Console.WriteLine("Digite 1 para Dolar ($), digite 2 para Euro (€), 3 para Libra Esterlina(£) ou 4 para Iene (¥)");
    Console.WriteLine("AVISO: TODOS OS VALORES SÃO CALCULADOS COM NUMEROS APROXIMADOS, PODE NÃO SER EXATAMENTE O PREÇO QUE " +
        "VOCÊ IRA PAGAR NO DIA");
    int Moeda = int.Parse(Console.ReadLine());

    if (Moeda == 1)
    {
        double dolar = 5.04;
        
        Console.WriteLine("quantos dolares você precisa?");
        double notas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double preco = notas * dolar;

        Console.WriteLine("Em reais, o valor a ser pago será de: " + preco.ToString("F2",CultureInfo.InvariantCulture));
       
    }
    if (Moeda == 2)
    {
        double euro = 5.40;

        Console.WriteLine("quantos euros você precisa?");
        double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double preco = notas * euro;

        Console.WriteLine("Em reais, o valor a ser pago será de: " + preco.ToString("F2", CultureInfo.InvariantCulture));
    }
    if (Moeda == 3)
    {
        double libraEsterlina = 6.20;

        Console.WriteLine("quantos Libras esterlinas você precisa?");
        double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double preco = notas * libraEsterlina;

        Console.WriteLine("Em reais, o valor a ser pago será de: " + preco.ToString("F2", CultureInfo.InvariantCulture));
    }
    if (Moeda == 4)
    {
        double iene = 0.036;

        Console.WriteLine("quantos ienes você precisa?");
        double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double preco = notas * iene;

        Console.WriteLine("Em reais, o valor a ser pago será de: " + preco.ToString("F2", CultureInfo.InvariantCulture));
    }

}