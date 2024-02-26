namespace AppExemplo1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double CalcularIMC()
        {
            return  Peso / (Altura* Altura);
        }

        public string Classificar() // fazer depois 
        {
            double imc = CalcularIMC();
            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "abaixo do peso ideal.";
            }
            else if (imc < 25)
            {
                classificacao = "com peso normal.";
            }
            else if (imc < 30)
            {
                classificacao = "com sobrepeso.";
            }
            else if (imc < 35)
            {
                classificacao = "com obesidade grau I.";
            }
            else if (imc < 40)
            {
                classificacao = "com obesidade grau II.";
            }
            else
            {
                classificacao = "com obesidade grau III.";
            }

            return Nome + " você está " + classificacao;
        }
    }
    
}
