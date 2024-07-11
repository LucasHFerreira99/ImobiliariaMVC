namespace ImobiliariaMVC.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public double Valor { get; set; }
        public bool Alugado { get; set; }
        public int DonoID { get; set; }
        public Locador Dono { get; set; }

        public Imovel()
        {
        }

        public Imovel(int id, string endereco, double valor)
        {
            Id = id;
            Endereco = endereco;
            Valor = valor;
        }

        public void AumentarValorAlugue(double igpm)
        {
            Valor += Valor * igpm;
        }
    }
}
