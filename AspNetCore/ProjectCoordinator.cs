using System;

namespace AspNetCore{
    public class ProjectCoordinator
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int CoordinatorId { get; set; }

        public Project Project { get; set; }
        public Coordinator Coordinator { get; set;}
    }
}