using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutCrudExample.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }

    public static class ReservationRepository
    {
        public static List<Reservation> Storage { get; set; }
    }
}