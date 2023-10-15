using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DataManagementService.Domain;

namespace DataManagementService.Application.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string Interactions { get; set; }

        [StringLength(1000)]
        public string Precautions { get; set; }

        [StringLength(500)]
        public string BestTimeToTake { get; set; }

        public IEnumerable<FoodDisease> SideEffects { get; set; }
        public IEnumerable<FoodRelatedAttribute> Attributes { get; set; }
        public IEnumerable<FoodHealtyObjective> RelatedHealtyObjectives { get; set; }
        public IEnumerable<FoodSupplement> Nutrients { get; set; }
        public IEnumerable<DiseaseFood> TreatableDiseases { get; set; }
        public IEnumerable<ExamFood> RelatedExams { get; set; }
        public IEnumerable<MealFood> FoundIn { get; set; }
    }
}