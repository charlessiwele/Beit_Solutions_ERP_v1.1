using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    //Table Ready
    class Reservation
    {

        public string ReservationId { get; set; }

        public string ProductId { get; set; }

        public string ClientId { get; set; }

        public string ClientName { get; set; }

        public string LocationId { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public string Narration { get; set; }

        public float ReservationPrice { get; set; }

        public int NumberOfRooms { get; set; }

        public float NumberOfExtrabeds { get; set; }

    }
}
