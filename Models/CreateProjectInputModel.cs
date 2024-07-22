namespace DevFreela.API.Models
{
    public class CreateProjectInputModel
    {
        public string Title { get; set; }
        public string Descripition { get; set; }
        public int IdClient { get; set; }
        public int IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }
    }
}
