using System.ComponentModel.DataAnnotations;

namespace AngularApi
{
    public class PersonInfo
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }

    }
}
