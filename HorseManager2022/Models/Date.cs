using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Models
{
    /*
        In game date class, used to keep track of the date in game. Each year have 4 months, one for each season, each month have 30 days.
     */
    internal class Date
    {
        // Properties
        public int year;
        public int month;
        public int day;

        // Constructor
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        // Constructor for 1ºst day of the calendar
        public Date()
        {
            this.year = 1;
            this.month = 1;
            this.day = 1;
        }


        // Methods

        /*
            Add days to the date
         */
        public void AddDays(int days)
        {
            this.day += days;

            // Check if month has more than 30 days
            if (this.day > 30)
            {
                this.day -= 30;
                this.month += 1;

                // Check if year has more than 4 months
                if (this.month > 4)
                {
                    this.month -= 4;
                    this.year += 1;
                }
            }
        }

        /*
            Get the date as a string
         */
        public override string ToString()
        {
            string date = "";

            // Add year
            date += this.year + " ";

            // Add month
            switch (this.month)
            {
                case 1:
                    date += "Spring";
                    break;
                case 2:
                    date += "Summer";
                    break;
                case 3:
                    date += "Autumn";
                    break;
                case 4:
                    date += "Winter";
                    break;
            }

            // Add day
            date += " " + this.day;

            return date;
        }

        public string ToSaveFormat() => this.year + ";" + this.month + ";" + this.day;
    }
}
