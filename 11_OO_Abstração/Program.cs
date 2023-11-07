using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace _11_OO_Abstração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.  
            //A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
            //Criar um método abstrato Apresentar na classe Pessoa. Em seguida, criar um método Apresentar na classe Aluno que imprime o nome,
            //a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.

            //Aluno aluno = new Aluno();
            //aluno.Nome = "Cayan";
            //aluno.Idade = 26;
            //aluno.Matricula = 7;

            //Professor professor = new Professor();
            //professor.Nome = "Ricardo";
            //professor.Idade = 35;
            //professor.Disciplina = "C#";
            //aluno.Apresentar();
            //professor.Apresentar();



            //2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo.Criar um método abstrato chamado Dirigir.
            //    Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. A classe Carro deve ter uma propriedade adicional QuantidadeDePortas,
            //    enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. Criar um método abstrato Dirigir na classe Veiculo. 
            //    Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas"
            //    e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"

            //Carro carro = new Carro();
            //carro.Marca = "Ford";
            //carro.Modelo = "Focus";
            //carro.QuantidadeDePortas = 4;

            //Moto moto = new Moto();
            //moto.Marca = "Honda";
            //moto.Modelo = "Hornet";
            //moto.Cilindrada = 600;

            //carro.Dirigir();
            //moto.Dirigir();




            //3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
            //Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
            //Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo"
            //calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.

            //Retangulo retangulo = new Retangulo();
            //retangulo.Largura = 10;
            //retangulo.Altura = 20;

            //Circulo circulo = new Circulo();
            //circulo.Raio = 5;

            //Console.WriteLine("Área e Perímetro do Retângulo:");
            //Console.WriteLine($"Área: {retangulo.CalcularArea()}");
            //Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro()}");

            //Console.WriteLine("\nÁrea e Perímetro do Círculo:");
            //Console.WriteLine($"Área: {circulo.CalcularArea()}");
            //Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");




            //4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar".
            //Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.

            //ContaCorrente contaCorrente = new ContaCorrente();
            //contaCorrente.Depositar(1000);
            //contaCorrente.Sacar(500);

            //ContaPoupanca contaPoupanca = new ContaPoupanca();
            //contaPoupanca.Depositar(1500);
            //contaPoupanca.Sacar(2000);




            //5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto".
            //Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto"
            //de acordo com as regras específicas de desconto para cada tipo de produto. Livro – 5 % de desconto Eletrônico - 12.5 % de desconto.

            //Livro livro = new Livro
            //{
            //    Nome = "Tropa de Elite",
            //    Preco = 55
            //};

            //Eletronico eletronico = new Eletronico
            //{
            //    Nome = "Iphone 15 Pro Max",
            //    Preco = 10000
            //};

            //Console.WriteLine($"Desconto de {livro.CalcularDesconto()} para o livro: {livro.Nome}");
            //Console.WriteLine($"Desconto de {eletronico.CalcularDesconto()} para o eletrônico: {eletronico.Nome}");




            //6 - Crie uma classe "ContaBancaria" com propriedades para "Saldo"
            //e métodos "Depositar" e "Sacar".

            //Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca",
            //que implementam os métodos de depósito e saque de acordo com
            //as regras de cada tipo de conta.

            //Regras: 
            //i) Para sacar na conta poupança, cada saque tem um custo de 0,10
            //ii) para depositar na conta poupança, não existe custo
            //iii) Para sacar na conta corrente somente o primeiro saque é gratuito e o restante tem tem um custo de 0,05 centavos
            //iv) Para depositar na conta corrente não existe custo porém deve apresentar a mensgem na tela do valor do saldo.

            //ContaPoupanca poupanca = new ContaPoupanca();
            //poupanca.Depositar(200);
            //poupanca.Sacar(50);
            //Console.WriteLine($"Saldo da Conta Poupança: {poupanca.Saldo}");

            //ContaCorrente corrente = new ContaCorrente();
            //corrente.Depositar(100);
            //corrente.Sacar(20);
            //corrente.Sacar(10);
            //Console.WriteLine($"Saldo da Conta Corrente: {corrente.Saldo}");




            // 7)
            // a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."
            // b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas,
            // como "Número de Portas" para carros e "Cilindrada" para motos.
            // c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto."
            // Use um loop para percorrer a lista e chamar um método "Apresentar" que exibe informações sobre cada veículo, demonstrando o polimorfismo.
            // d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
            // e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.

            // Implementar código...




            // 8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números.
            // Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.

            //Calculadora calculadora = new Calculadora();

            //int resultadoSomaInteiros = calculadora.Somar(1, 2, 3);
            //decimal resultadoSomaDecimais = calculadora.Somar(1.5m, 2.7m, 3.1m);
            //int resultadoSubtracaoInteiros = calculadora.Subtrair(5, 3);
            //decimal resultadoSubtracaoDecimais = calculadora.Subtrair(7.5m, 2.3m);
            //int resultadoMultiplicacaoInteiros = calculadora.Multiplicar(2, 3, 4);
            //decimal resultadoMultiplicacaoDecimais = calculadora.Multiplicar(1.5m, 2.5m);
            //int resultadoDivisaoInteiros = calculadora.Dividir(10, 2);
            //decimal resultadoDivisaoDecimais = calculadora.Dividir(8.5m, 2.1m);

            //Console.WriteLine($"Soma de inteiros: {resultadoSomaInteiros}");
            //Console.WriteLine($"Soma de decimais: {resultadoSomaDecimais}");
            //Console.WriteLine($"Subtração de inteiros: {resultadoSubtracaoInteiros}");
            //Console.WriteLine($"Subtração de decimais: {resultadoSubtracaoDecimais}");
            //Console.WriteLine($"Multiplicação de inteiros: {resultadoMultiplicacaoInteiros}");
            //Console.WriteLine($"Multiplicação de decimais: {resultadoMultiplicacaoDecimais}");
            //Console.WriteLine($"Divisão de inteiros: {resultadoDivisaoInteiros}");
            //Console.WriteLine($"Divisão de decimais: {resultadoDivisaoDecimais}");




            //9 -
            //a) Crie uma classe base "Pessoa" com propriedades como "Nome" e "Idade."
            //b) Crie uma classe derivada "Estudante" que herde de "Pessoa" e adicione propriedades específicas, como "Matricula" e "Curso."
            //c) Certifique - se de que a classe derivada chame o construtor da classe base

            //Aluno aluno = new Aluno("João", 20, 12345, "Engenharia");

            //Console.WriteLine($"Nome: {aluno.Nome}");
            //Console.WriteLine($"Idade: {aluno.Idade}");
            //Console.WriteLine($"Matrícula: {aluno.Matricula}");
            //Console.WriteLine($"Curso: {aluno.Curso}");




            //10 -
            //a) Crie uma classe base "Funcionario" com propriedades como "Nome" e "Salario."
            //b) Crie classes derivadas, como "Gerente" e "Desenvolvedor," que herdem de "Funcionario"
            //e forneçam implementações específicas para calcular bônus ou mostrar funções.

            //Gerente gerente = new Gerente("Carlos", 5000);
            //Desenvolvedor desenvolvedor = new Desenvolvedor("Ana", 4000);

            //Console.WriteLine($"Bônus do Gerente {gerente.Nome}: {gerente.CalcularBonus()}");
            //gerente.MostrarFuncao();

            //Console.WriteLine($"Bônus do Desenvolvedor {desenvolvedor.Nome}: {desenvolvedor.CalcularBonus()}");
            //desenvolvedor.MostrarFuncao();
        }
    }
}