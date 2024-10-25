using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1624
{
    public class TicketService : ITicketService
    {
        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(test=>test.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException() : ticket.Price;
        }
        private IEnumerable<Ticket> FakeBaseData
        {
            get
            {
                return new List<Ticket>
                 {
                    new Ticket(1, "Москва - Санкт-Петербург", 3500),
                    new Ticket(2, "Челябинск - Магадан", 3500),
                    new Ticket(3, "Норильск - Уфа", 3500)
                 };
            }
        }
    }
}
