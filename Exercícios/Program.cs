using Exercícios;

/*    EXERCÍCIO 1 LIVRO     */

//Livro livro1 = new Livro("harry potter e o prisioneiro de azkaban", "jk rowling", "bloomsbury", 1999);
//Livro livro2 = new Livro("o pequeno prícipe", "antoine de saint-exupéry", "harpercollins brasil", 1943);
//Livro livro3 = new Livro("a arte da guerra", "sun tzu", "grupo editorial record", 1772);

//Console.WriteLine($"o seu primeiro livro atende pelo título de: " + livro1.Titulo + ", ele foi escrito pela autora: "
//    + livro1.Autor + ", foi distribuído pela editora: " + livro1.Editora + ", no ano de: " + livro1.Ano);
//Console.WriteLine($"o seu segundoo livro atende pelo título de: " + livro2.Titulo + ", ele foi escrito pela autora: "
//    + livro2.Autor + ", foi distribuído pela editora: " + livro2.Editora + ", no ano de: " + livro2.Ano);
//Console.WriteLine($"o seu terceiro livro atende pelo título de: " + livro3.Titulo + ", ele foi escrito pela autora: "
//    + livro3.Autor + ", foi distribuído pela editora: " + livro3.Editora + ", no ano de: " + livro3.Ano);


/*    EXERCÍCIO 2 ALUNO     */

//Aluno aluno1 = new Aluno(2048, "Luccas F.P Santos", new DateTime(2007, 10, 25), "luccas.santos@gmail.com");
//Aluno aluno2 = new Aluno(2049, "Mariana Arlanch", new DateTime(2007, 07, 16), "Marii.Arlanch@gmail.com");
//Aluno aluno3 = new Aluno(2499, "Lucas Bonfim", new DateTime(2007, 12, 03), "Bonfim.Lucas@gmail.com");

//Console.WriteLine($"O RM do primeiro aluno é: " + aluno1.RM + " o nome dele é :" +aluno1.Nome + " ele nasceu em :" + aluno1.Nascimento
//     + " e seu e-mail é: " + aluno1.Email);
//Console.WriteLine($"O RM da segunda aluna é: " + aluno2.RM + " o nome dela é :" + aluno2.Nome + " ela nasceu em :" + aluno2.Nascimento
//     + " e seu e-mail é: " + aluno2.Email);
//Console.WriteLine($"O RM do terceiro aluno é: " + aluno3.RM + " o nome dele é :" + aluno3.Nome + " ele nasceu em :" + aluno3.Nascimento
//     + " e seu e-mail é: " + aluno3.Email);


/*    EXERCÍCIO 3 PRODUTO     */

//Produto produto1 = new Produto(1234, "Saco de café", 2.50, 7);
//Produto produto2 = new Produto(4321, "Pacote de Chá", 5.75, 12);
//Produto produto3 = new Produto(1010, "Sukita 2L", 8.00, 5);

//Console.WriteLine($"O seu produto é: " + produto1.Nome + ", o código dele é: " + produto1.Codigo + ", ele está custando R$" +
//    produto1.Preco);
//Console.WriteLine($"O seu produto é: " + produto2.Nome + ", o código dele é: " + produto2.Codigo + ", ele está custando R$" +
//    produto2.Preco);
//Console.WriteLine($"O seu produto é: " + produto3.Nome + ", o código dele é: " + produto3.Codigo + ", ele está custando R$" +
//    produto3.Preco);

//produto1.ValorEstoque();
//produto2.ValorEstoque();
//produto3.ValorEstoque();


/*    EXERCÍCIO 4 CARROS     */

Carro carro1 = new Carro("Ford", "Hudson Hornet 1951", 156, 175, 19);
Carro carro2 = new Carro("Dodge", "Charge R/T 1970", 208, 220, 12);
Carro carro3 = new Carro("Toyota", "Supra mk4", 250, 300, 100);

Console.WriteLine($"O carro é um: " + carro1.Modelo + ", da " + carro1.Marca + " com velocidade de: " + carro1.Velocidade + "Km/h");
Console.WriteLine($"O carro é um: " + carro2.Modelo + ", da " + carro2.Marca + " com velocidade de: " + carro2.Velocidade + "Km/h");
Console.WriteLine($"O carro é um: " + carro3.Modelo + ", da " + carro3.Marca + " com velocidade de: " + carro3.Velocidade + "Km/h");

carro1.Acelerar();
carro1.Desacelerar();

carro2.Acelerar();
carro2.Desacelerar();

carro3.Acelerar();
carro3.Desacelerar();

Console.ReadKey();