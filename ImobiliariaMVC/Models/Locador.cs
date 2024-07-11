namespace ImobiliariaMVC.Models
{
    public class Locador
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Identidade { get; set; }
        public string Endereco { get; set; }
        public string Atividade { get; set; }

        public List<Imovel>? Imoveis { get; set; }

        public Locador()
        {
        }

        public Locador(string nome, string cpf, string telefone, string identidade, string endereco, string atividade)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Identidade = identidade;
            Endereco = endereco;
            Atividade = atividade;
        }

        public void AdicionarIMovel(Imovel imovel)
        {
            Imoveis.Add(imovel);
        }
    }
}
