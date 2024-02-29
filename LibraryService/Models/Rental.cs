using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Rental
    {
        private int id { get; set; }
        private DateTime initialRentalDate { get; set; }
        private DateTime limitDate { get; set; }
        private DateTime returnDate { get; set; }
        private Book book { get; set; }
        private decimal rentalAmount { get; set; }
        private int fee { get; set; }

        public Rental() { }

        public Rental(int id, DateTime initialRentalDate, DateTime limitDate, DateTime returnDate, Book book, decimal rentalAmount, int fee)
        {
            this.id = id;
            this.initialRentalDate = initialRentalDate;
            this.limitDate = limitDate;
            this.returnDate = returnDate;
            this.book = book;
            this.rentalAmount = rentalAmount;
            this.fee = fee;
        }

        internal virtual string bookReservation()
        {
            return "This method will be overrided";
        }

        private DateTime defineLimitDate(DateTime initialRentalDate)
        {
            return DateTime.Now;
        }

        protected decimal calcFee(decimal rentalAmount, int fee)
        {
            return calcFee(0, fee);
        }

    }
}
