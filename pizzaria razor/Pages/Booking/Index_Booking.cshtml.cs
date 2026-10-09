using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria_Lib;
using BookingLib = Pizzaria_Lib.Booking;

namespace pizzaria_razor.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private List<Pizzaria_Lib.Booking> _bookinger;

        private Booking_Service _bookingListe;

        public Index_Booking(Booking_Service bookingListe)
        {
            _bookingListe = bookingListe;
        }

        public List<Pizzaria_Lib.Booking> Bookinger
        {
            get { return _bookinger; }
            set { _bookinger = value; }
        }


        public void OnGet()
        {
            if (_bookingListe.HentAlleBookinger().Count == 0)

            {
                _bookingListe.TilføjBooking(new BookingLib(1, DateTime.Now.AddDays(7), 10));
                _bookingListe.TilføjBooking(new BookingLib(2, DateTime.Now.AddDays(12), 5));
                _bookingListe.TilføjBooking(new BookingLib(3, DateTime.Now.AddDays(22), 8));


            }
            Bookinger = _bookingListe.HentkommendeBookinger();
        }
    }
}
