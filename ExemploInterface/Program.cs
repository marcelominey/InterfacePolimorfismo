using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto pr = new Produto(){ Id = 30, Nome = "Sabão", Descricao = "Em Pó", Preco = 30 };
                //pr.Id = 30;
                //pr.Nome = "Sabão";
                //pr.Descricao = "Em Pó";
                //pr.Preco = 30;
            
            Endereco ender = new Endereco();
            ender.Logradouro = "Rua Nova Esperança";
            ender.Numero = "42";
            ender.Bairro = "Jardim Alergia";
            
            //PF pf = new PF(10, "Helena", "2356", "helena@email", "4545-3332", ender);
            PF pf = new PF();
                pf.Id = 10;
                pf.Nome = "Helena";
                pf.CPF = "2356";
                pf.Email = "helena@email";
                pf.Telefone = "4545-3332";
                pf.End = ender;

            Console.WriteLine(pf.Cadastro());
        }
    }
}
