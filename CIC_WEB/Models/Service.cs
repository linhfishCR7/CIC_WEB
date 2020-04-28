namespace CIC_WEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public string Imgaes { get; set; }
    }
}
