using System.ComponentModel.DataAnnotations;

namespace corregidorApi.Models
{
    public class UserData
    {
        public int Id { get; set; }

        [StringLength (255)]
        public string FirstName { get; set; }

        [StringLength (255)]
        public string LastName { get; set; }

        [StringLength (255)]
        public string BusinessName { get; set; }

        [StringLength (255)]
        [Required]
        public string Email { get; set; }

        [StringLength (25)]
        public string Tel { get; set; }

        [StringLength (5000)]
        public string Comments { get; set; }
    }
}