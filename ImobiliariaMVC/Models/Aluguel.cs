namespace ImobiliariaMVC.Models
{
    public class Aluguel
    {
        public int Id { get; set; }
        public Locatario Locatario { get; set; }
        public Imovel Imovel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataSaida { get; set; }

        public Aluguel()
        {
        }

        public Aluguel(Locatario locatario, Imovel imovel, DateTime dataInicio, DateTime dataSaida)
        {
            Locatario = locatario;
            Imovel = imovel;
            DataInicio = dataInicio;
            DataSaida = dataSaida;
        }

    }
}
