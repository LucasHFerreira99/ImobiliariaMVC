namespace ImobiliariaMVC.Models
{
    public class Locatario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Identidade { get; set; }
        public string Atividade { get; set; }

        public Locatario()
        {
        }

        public Locatario(int id, string nome, string cpf, string telefone, string identidade, string atividade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Identidade = identidade;
            Atividade = atividade;
        }


    }
}
