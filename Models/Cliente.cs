using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiViagem.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Display(Name ="IdCliente")]
        [Column("id_cliente")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome")]
        public string? Nome { get; set; }  

        [Display(Name = "Cpf")]
        [Column("cpf")]
        public string? Cpf { get; set; }  

        [Display(Name = "Telefone")]
        [Column("telefone")]
        public string? Telefone { get; set; }  

        [Display(Name = "Email")]
        [Column("email")]
        public string? Email { get; set; }  

        [Display(Name = "Endereco")]
        [Column("endereco")]
        public string? Endereco { get; set; }  

        [Display(Name = "Senha")]
        [Column("senha")]
        public string? Senha { get; set; }  
    }
}
