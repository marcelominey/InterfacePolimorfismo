namespace ClasseInterface
{
    public class PF:Cliente, IAcao //Estamos herdando da classe-pai "Cliente", e da Interface "IAcao"
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public PF(){}
        public PF(int id, string email, string telefone, Endereco endereco, string nome, string cpf){
            base.Id = id;
            base.Email = email;
            base.Telefone = telefone;
            
            base.End = endereco;
            
            this.Nome = nome;
            this.CPF = cpf;
        }
        
        public string Cadastro()
        {
            string composicao = "Id do Cliente: "+Id+
                                "\nNome: "+Nome.ToUpper()+
                                "\nCPF: "+CPF+
                                "\nEmail: "+Email+
                                "\nTelefone: "+Telefone+
                                "\nEndereço: "+End.Logradouro + ", "+End.Numero+" - "+End.Bairro;
        
            return "Produto cadastrado \n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}