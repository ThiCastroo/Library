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
        internal DateTime limitDate { get; set; }
        private DateTime returnDate { get; set; }
        internal Book book { get; set; }
        internal decimal rentalAmount { get; set; }

        public Rental() { }

        public Rental(int id, DateTime initialRentalDate, DateTime limitDate, DateTime returnDate, Book book, decimal rentalAmount)
        {
            this.id = id;
            this.initialRentalDate = initialRentalDate;
            this.limitDate = limitDate;
            this.returnDate = returnDate;
            this.book = book;
            this.rentalAmount = rentalAmount;
        }

        internal virtual string bookReservation()
        {
            return "This method will be overwritten.";
        }

        private DateTime defineLimitDate(DateTime initialRentalDate)
        {
            return initialRentalDate.AddDays(30);
        }

        protected decimal calcFee(decimal rentalPrice, int daysLate)
        {
            return daysLate > 0 ? rentalPrice * 0.05m * daysLate : 0; // Example: 5% of the rental price per day of delay
        }

        public decimal applyFee(int daysLate)
        {
            return calcFee(rentalPrice, daysLate);
        }
    }
}
