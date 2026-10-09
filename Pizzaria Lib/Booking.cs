namespace Pizzaria_Lib
{
    public class Booking
    {
        // Private variabler 

        private int _bookingId;
        private DateTime _Dato;

        private int _antalMennesker;

        


        // konstruktør

        public Booking()
        {
            _bookingId = 0;
            _Dato = DateTime.Now;
            _antalMennesker = 0;
        }

        public Booking(int bookingId, DateTime Dato, int antalMenesker)
        {
        _bookingId = bookingId;
        _Dato = Dato;
        _antalMennesker = antalMenesker;
        }


        // properties
        public int BookingId
        {
            get { return _bookingId; }
            set { _bookingId = value; }
        }

        public DateTime Dato
        {
        get { return _Dato; }
        set { _Dato = value; }
        }


        public int AntalMennesker
        {
        get { return _antalMennesker; }
        set { _antalMennesker = value; }
        }


        // metoder

        public override string ToString()
        {
            return $"BookingId: {BookingId}, Dato: {Dato}, Antal: {AntalMennesker}";
        }
    }
}
