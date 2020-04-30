namespace CIC_WEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Images { get; set; }

        public string NoiDung { get; set; }

        public string OurMainGoal { get; set; }

        public string OurChallenges { get; set; }
    }
}
