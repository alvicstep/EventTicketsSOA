﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.AppService.Messages
{
    public class ReservationTicketResponse
    {
        public string TicketId { get; set; }
        public String EventId { get; set; }
        public int NoOfTickets { get; set; }
        public Guid ReservationId { get; internal set; }
    }
}
