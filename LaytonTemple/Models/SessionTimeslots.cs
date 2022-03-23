using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LaytonTemple.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LaytonTemple.Models
{
    public class SessionTimeslots : Timeslots
    {
        public static Timeslots GetTimeslots (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionTimeslots reservation = session?.GetJson<SessionTimeslots>("Timeslots") ?? new SessionTimeslots();

            reservation.Session = session;

            return reservation;
        }
       
       [JsonIgnore]
       public ISession Session { get; set; }

       public override void AddReservation(Times time)
       {
           base.AddReservation(time);
           Session.SetJson("Timeslots", this);
       }
    }
}
