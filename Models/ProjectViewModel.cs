﻿using DevFreela.API.Entities;

namespace DevFreela.API.Models
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, string descripition, int idClient, int idFreelancer, string clientName, string freenlancerName, decimal totalCost, List<ProjectComment> comments)
        {
            Id = id;
            Title = title;
            Descripition = descripition;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            ClientName = clientName;
            FreenlancerName = freenlancerName;
            TotalCost = totalCost;
            Comments = comments.Select(c => c.Content).ToList();
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Descripition { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public string ClientName { get; private set; }
        public string FreenlancerName { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<string> Comments { get; private set; }

        public static ProjectViewModel FromEntity(Project entity)
            => new (entity.Id, entity.Title, entity.Description,
                entity.IdClient, entity.IdFreelancer, entity.Client.FullName,
                entity.Freelancer.FullName, entity.TotalCost, entity.Comments);
    }
}
