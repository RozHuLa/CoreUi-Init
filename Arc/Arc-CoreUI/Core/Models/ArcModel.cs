using System;

namespace Arc_CoreUi.Core.Models
{
    public class ArcModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public bool deleted { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime editedOn { get; set; }
        public DateTime? deletedOn { get; set; }
    }
}