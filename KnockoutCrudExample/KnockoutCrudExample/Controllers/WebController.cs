using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using KnockoutCrudExample.Models;

namespace KnockoutCrudExample.Controllers
{
    public class WebController : ApiController
    {
        // GET api/values
        public IEnumerable<Reservation> GetAllReservations()
        {
            return ReservationRepository.Storage;
        }


        public Reservation GetReservation(int id)
        {
            return ReservationRepository.Storage.FirstOrDefault(r => r.ReservationId == id);
        }

        // POST api/values
        public Reservation PostReservation(Reservation item)
        {
            var newId = 1;
            var itemsCount = ReservationRepository.Storage.Count;

            if (itemsCount != 0)
            {
                newId = ReservationRepository.Storage[itemsCount - 1].ReservationId + 1;
            }

            item.ReservationId = newId;
            ReservationRepository.Storage.Add(item);
            return item;
        }

        // PUT api/values/5
        public void PutReservation(Reservation item)
        {
            var res = ReservationRepository.Storage.FirstOrDefault(r => r.ReservationId == item.ReservationId);

            if (res != null)
            {
                ReservationRepository.Storage.Remove(res);
                ReservationRepository.Storage.Add(item);
            }
        }

        // DELETE api/values/5
        public void DeleteReservation(int id)
        {
            var res = ReservationRepository.Storage.FirstOrDefault(r => r.ReservationId == id);

            if (res != null)
            {
                ReservationRepository.Storage.Remove(res);
            }
        }
    }
}
