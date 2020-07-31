using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int ImageUrl { get; set; }
    }
}
