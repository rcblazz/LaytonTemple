using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LaytonTemple.Models
{
    public class DatetimeDBcontext : DbContext
    {
        public DatetimeDBcontext()
        {
        }

        public DatetimeDBcontext(DbContextOptions<DatetimeDBcontext> options) : base(options)
        {
        }

        public DbSet<TourGroup> TourGroup { get; set; }
        public DbSet<Times> timeslots { get; set; }
        
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Times>().HasData(

                //MARCH 23 TIMESLOTS
                new Times
                {
                    TimeId = 1,
                    Timeslot = "03/23/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 2,
                    Timeslot = "03/23/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 3,
                    Timeslot = "03/23/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 4,
                    Timeslot = "03/23/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 5,
                    Timeslot = "03/23/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 6,
                    Timeslot = "03/23/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 7,
                    Timeslot = "03/23/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 8,
                    Timeslot = "03/23/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 9,
                    Timeslot = "03/23/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 10,
                    Timeslot = "03/23/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 11,
                    Timeslot = "03/23/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 12,
                    Timeslot = "03/23/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 13,
                    Timeslot = "03/23/2022 8 P.M.",
                    Available = true
                },

                //MARCH 24 TIMESLOTS
                new Times
                {
                    TimeId = 14,
                    Timeslot = "03/24/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 15,
                    Timeslot = "03/24/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 16,
                    Timeslot = "03/24/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 17,
                    Timeslot = "03/24/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 18,
                    Timeslot = "03/24/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 19,
                    Timeslot = "03/24/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 20,
                    Timeslot = "03/24/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 21,
                    Timeslot = "03/24/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 22,
                    Timeslot = "03/24/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 23,
                    Timeslot = "03/24/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 24,
                    Timeslot = "03/24/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 25,
                    Timeslot = "03/24/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 26,
                    Timeslot = "03/24/2022 8 P.M.",
                    Available = true
                },

                //MARCH 25 TIMESLOTS
                new Times
                {
                    TimeId = 27,
                    Timeslot = "03/25/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 28,
                    Timeslot = "03/25/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 29,
                    Timeslot = "03/25/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 30,
                    Timeslot = "03/25/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 31,
                    Timeslot = "03/25/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 32,
                    Timeslot = "03/25/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 33,
                    Timeslot = "03/25/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 34,
                    Timeslot = "03/25/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 35,
                    Timeslot = "03/25/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 36,
                    Timeslot = "03/25/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 37,
                    Timeslot = "03/25/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 38,
                    Timeslot = "03/25/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 39,
                    Timeslot = "03/25/2022 8 P.M.",
                    Available = true
                },

                //MARCH 26 TIMESLOTS
                new Times
                {
                    TimeId = 40,
                    Timeslot = "03/26/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 41,
                    Timeslot = "03/26/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 42,
                    Timeslot = "03/26/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 43,
                    Timeslot = "03/26/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 44,
                    Timeslot = "03/26/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 45,
                    Timeslot = "03/26/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 46,
                    Timeslot = "03/26/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 47,
                    Timeslot = "03/26/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 48,
                    Timeslot = "03/26/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 49,
                    Timeslot = "03/26/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 50,
                    Timeslot = "03/26/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 51,
                    Timeslot = "03/26/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 52,
                    Timeslot = "03/26/2022 8 P.M.",
                    Available = true
                },

                //MARCH 27 TIMESLOTS
                new Times
                {
                    TimeId = 53,
                    Timeslot = "03/27/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 54,
                    Timeslot = "03/27/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 55,
                    Timeslot = "03/27/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 56,
                    Timeslot = "03/27/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 57,
                    Timeslot = "03/27/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 58,
                    Timeslot = "03/27/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 59,
                    Timeslot = "03/27/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 60,
                    Timeslot = "03/27/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 61,
                    Timeslot = "03/27/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 62,
                    Timeslot = "03/27/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 63,
                    Timeslot = "03/27/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 64,
                    Timeslot = "03/27/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 65,
                    Timeslot = "03/27/2022 8 P.M.",
                    Available = true
                },

                //MARCH 28 TIMESLOTS
                new Times
                {
                    TimeId = 66,
                    Timeslot = "03/28/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 67,
                    Timeslot = "03/28/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 68,
                    Timeslot = "03/28/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 69,
                    Timeslot = "03/28/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 70,
                    Timeslot = "03/28/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 71,
                    Timeslot = "03/28/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 72,
                    Timeslot = "03/28/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 73,
                    Timeslot = "03/28/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 74,
                    Timeslot = "03/28/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 75,
                    Timeslot = "03/28/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 76,
                    Timeslot = "03/28/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 77,
                    Timeslot = "03/28/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 78,
                    Timeslot = "03/28/2022 8 P.M.",
                    Available = true
                },

                //MARCH 29 TIMESLOTS
                new Times
                {
                    TimeId = 79,
                    Timeslot = "03/29/2022 8 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 80,
                    Timeslot = "03/29/2022 9 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 81,
                    Timeslot = "03/29/2022 10 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 82,
                    Timeslot = "03/29/2022 11 A.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 83,
                    Timeslot = "03/29/2022 12 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 84,
                    Timeslot = "03/29/2022 1 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 85,
                    Timeslot = "03/29/2022 2 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 86,
                    Timeslot = "03/29/2022 3 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 87,
                    Timeslot = "03/29/2022 4 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 88,
                    Timeslot = "03/29/2022 5 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 89,
                    Timeslot = "03/29/2022 6 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 90,
                    Timeslot = "03/29/2022 7 P.M.",
                    Available = true
                },
                new Times
                {
                    TimeId = 91,
                    Timeslot = "03/29/2022 8 P.M.",
                    Available = true
                }
            );
        }
    }
}
