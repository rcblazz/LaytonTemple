using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Models
{
    public class Timeslots
    {
        public List<ReservedTime> Reservations { get; set; } = new List<ReservedTime>();

        public virtual void AddReservation(Times time)
        {
            ReservedTime reservation = Reservations
                .Where(b => b.Time.TimeId == time.TimeId)
                .FirstOrDefault();

            if (reservation == null)
            {
                Reservations.Add(new ReservedTime
                {
                    Time = time,

                });

            }
            //else
            //{
            //    line.Quantity += qty;
            //}
        }


    }

    public class ReservedTime
    {

        [Key]
        public int ReservationID { get; set; }

        public Times Time { get; set; } //need a times model
    }
}
