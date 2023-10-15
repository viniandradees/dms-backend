using System.ComponentModel.DataAnnotations;
using DataManagementService.Domain.Enum;

namespace DataManagementService.Application.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Acronym { get; set; }

        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }
        
        public Continent Continent { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}