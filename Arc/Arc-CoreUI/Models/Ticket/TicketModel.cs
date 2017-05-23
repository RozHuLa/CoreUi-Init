namespace Arc_CoreUi.Models.Ticket
{
    using Core.Models;
    using System;

    public class TicketModel : ArcModel
    {
        public string content { get; set; }
        public string category { get; set; }
        public string statut { get; set; }
        public bool privated { get; set; }

        public DateTime? repliedOn { get; set; }
    }
}
