using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    public class Personal
    {
        [Key]
        public int PersonalId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string City{ get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Birthday { get; set; }
    }
}
