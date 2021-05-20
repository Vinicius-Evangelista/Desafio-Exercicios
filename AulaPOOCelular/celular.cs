namespace ExercícioCelular
{
    public class celular
    {
        public string marca;

        public string modelo;

        public string cor;

        public double tela;

        public string memoria;

        public string ram;

        public string bateria;

        public bool ligado = false;

        // variaveis para especificações

        public string Ligar ()
        {   
            ligado = true;

            return "\nLigando...\n";
        }

        public string Desligar ()
        {
            ligado = false;

            return "\nDesligando.....\n";
        }

        public string Mensagem ()
        {
            return "mesagem enviada com sucesso !";
            
        }

        public string Ligacao ()
        {
           return "Caixa postal\n";
        }


        



    }
}