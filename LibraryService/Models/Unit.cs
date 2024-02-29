namespace LibraryService.Models
{
    public class Unit
    {
        private int id { get; set; }
        private string name { get; set; }
        private List<Book> books { get; set; }
        private Address address { get; set; }
        private Rental rental { get; set; }

        public Unit() { }

        public Unit(int id, string name, List<Book> books, Address address, Rental rental)
        {
            this.id = id;
            this.name = name;
            this.books = books;
            this.address = address;
            this.rental = rental;
        }
    }

    public class Paulista : Rental
    {

        internal override string bookReservation()
        {
            return base.bookReservation();
        }

    }
    public class VilaOlimpia : Rental
    {

        internal override string bookReservation()
        {
            return base.bookReservation();
        }

    }
    public class Aclimacao : Rental
    {

        internal override string bookReservation()
        {
            return base.bookReservation();
        }

    }

}