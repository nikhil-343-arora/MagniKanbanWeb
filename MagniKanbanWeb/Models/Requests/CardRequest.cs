using System.ComponentModel.DataAnnotations;

namespace MagniKanbanWeb.Models.Requests
{
    public class CardRequest
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int BoardId { get; set; }
    }
}
