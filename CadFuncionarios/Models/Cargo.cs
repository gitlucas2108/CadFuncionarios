using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadFuncionarios.Models
{
    [Table("Cargo")]
    public class Cargo    
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Descrição")]
        [StringLength(250)]
        [Required(ErrorMessage = "Informe a Descrição do Cargo.")]
        public string Nome { get; set; } = string.Empty;

        [Column("DataCadastro")]
        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Informe a Data de Cadastro.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }

        [Column("DataAlteracao")]
        [Display(Name = "Data de Alteração")]
        [Required(ErrorMessage = "Informe a Data de Alteração.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAlteracao { get; set; }

        [Column("DataExclusao")]
        [Display(Name = "Data de Exclusão")]
        public DateTime DataExclusao { get; set; }
    }
}
