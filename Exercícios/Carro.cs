namespace Exercícios
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Aceleracao { get; set; }
        public int Desaceleracao { get; set; }

        public Carro(string marca, string modelo, int velocidade, int aceleracao, int desaceleracao) 
        {
            Marca = marca;        
            Modelo = modelo;
            Velocidade = velocidade;
            Aceleracao = aceleracao;
            Desaceleracao = desaceleracao;
        }
        public void Acelerar()
        {
            Console.WriteLine($"ele acelerou " + Aceleracao + "Km/h");
        }
        public void Desacelerar()
        {
            Console.WriteLine($"ele desacelerou " + Desaceleracao + "Km/h");
        }
    }
}
