namespace Test.Data.Context
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contato")]
    public partial class Contato
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string TelefoneResidencial { get; set; }

        [Required]
        [StringLength(50)]
        public string TelefoneCelular { get; set; }
    }
}
