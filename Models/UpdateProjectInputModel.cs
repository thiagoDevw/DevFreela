namespace DevFreela.API.Models
{
    public class UpdateProjectInputModel
    {
        public int IdProject { get; set; }
        public string Title { get; set; }
        public string Descripition { get; set; }
        public decimal TotalCost { get; set; }
    }
}
