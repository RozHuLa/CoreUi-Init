using System;
using System.Collections.Generic;

namespace Arc_CoreUi.ModelViews.Ticket
{
    using Core.ModelViews;
    using Models.Ticket;
    public class TicketIndexViewModel : ArcViewModel
    {
        public IList<TicketModel> Tickets { get; set; }

        public override void initialisation()
        {
            //Do not remove this and do it before anything
            base.initialisation();

            loadTickets();
        }

        private void loadTickets(int nbTicket = 50)
        {
            Tickets = new List<TicketModel>();
            for (int i = 0; i < nbTicket; i++)
            {
                Tickets.Add(new TicketModel
                {
                    id = i,
                    name = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    content = "<p>Voici un ticket</p>",
                    category = "TMA",
                    createdOn = new DateTime(2017, 5, 23, 21, 0, 0),
                    editedOn = new DateTime(2017, 5, 23, 21, 0, 0),
                    deletedOn = null,
                    deleted = false,
                    privated = false,
                    repliedOn = null,
                    statut = "ouvert"

                });
            }
        }


    }
}