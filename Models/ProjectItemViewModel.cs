using DevFreela.API.Entities;

namespace DevFreela.API.Models
{
    public class ProjectItemViewModel
    {
        public ProjectItemViewModel(int id, string title, string clientName, string freenlancerName, decimal totalCost)
        {
            Id = id;
            Title = title;
            ClientName = clientName;
            FreenlancerName = freenlancerName;
            TotalCost = totalCost;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string ClientName { get; private set; }
        public string FreenlancerName { get; private set; }
        public decimal TotalCost { get; private set; }
    }
}
