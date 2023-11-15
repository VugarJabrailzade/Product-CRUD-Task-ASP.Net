using System.ComponentModel.DataAnnotations;

namespace Task1_asp.Net.ViewModel
{
    public class AddNavbarViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Add Title!")]
        public string Title { get; set; }

        [Range(0, 1, ErrorMessage = "Order must be between 0 & 1")]
        public int OrderCount { get; set; }

        [Required(ErrorMessage = "Add Is Header o not!")]
        public bool IsHeader { get; set; }
        

    }
}
