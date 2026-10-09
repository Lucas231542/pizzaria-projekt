using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria_Lib
{
    public class Booking_Service
    {
        private List<Booking> _alleBookinger;

        public Booking_Service()
        {
        _alleBookinger = new List<Booking>();
        }

        public Booking_Service(List<Booking> alleBookinger)
        {
            _alleBookinger = alleBookinger;
        }

        public List<Booking> AlleBookinger
        {
            get {  return _alleBookinger; }
            set {  _alleBookinger = value; }
        }



    public List<Booking> HentAlleBookinger()
    {
    return _alleBookinger;
    }


    public List<Booking> HentkommendeBookinger()
    {
            List<Booking> KommendeBookinger = new List<Booking>();
            foreach (Booking b in _alleBookinger)
            if (b.Dato > DateTime.Now)
            {
                    KommendeBookinger.Add(b);
            }
            return KommendeBookinger;
    }

    public void TilføjBooking(Booking booking)
    {
    _alleBookinger.Add(booking);
    }

    public void SletBooking(int BookingId)
    {
    _alleBookinger.RemoveAll(b => b.BookingId == BookingId);
    }

        public void RedigerBooking(int BookingId, DateTime nyDato, int NytAntalMennesker)
        {
        foreach (Booking b in _alleBookinger)
        {
            if (b.BookingId == BookingId)
            {
                b.Dato = nyDato;
                b.AntalMennesker = NytAntalMennesker;
            }
        }

        }
    }
}
