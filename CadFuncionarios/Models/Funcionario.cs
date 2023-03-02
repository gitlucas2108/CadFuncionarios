using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadFuncionarios.Models
{
    [Table("Funcionario")]
    
    public class Funcionario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("CargoId")]
        [Display(Name = "Código do cargo")]
        [Required(ErrorMessage = "Informe o código do cargo.")]
        public int CargoId { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [StringLength(250)]
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = string.Empty;

        [Column("CPF")]
        [Display(Name = "CPF")]
        [StringLength(14)]
        public string CPF { get; set; } = string.Empty;

        [Column("DataAdmissao")]
        [Display(Name = "Data de Admissão")]
        [Required(ErrorMessage = "Informe a Data de Admissão.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAdmissao { get; set; }

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

        [Column("UtilizaVT")]
        [Display(Name = "Utiliza VT")]
        public bool UtilizaVT { get; set; } 

        //public Cargo cargoFuncionario { get; set; } = null;
    }
}
