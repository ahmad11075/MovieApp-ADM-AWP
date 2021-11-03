using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string EducationLevel { get; set; }
        public string Ownership { get; set; }
        public string InternalConnection { get; set; }
        public string MaritalStatus { get; set; }
        public string MovieSelector { get; set; }
        public double NumBathrooms { get; set; }
        public int NumBedrooms { get; set; }
        public int NumCars { get; set; }
        public int NumChildren { get; set; }
        public int NumTVs { get; set; }
        public string PPVFreq { get; set; }
        public string BuyingFreq { get; set; }
        public string Format { get; set; }
        public string RentingFreq { get; set; }
        public string ViewingFreq { get; set; }
        public string TheaterFreq { get; set; }
        public string TVMovieFreq { get; set; }
        public string TVSignal { get; set; }
        public DateTime SSMA_TimeStamp { get; set; }
        public string Gender { get; set; }

        //Relationships

        public List<Customer_Criteria> Customers_Criterias { get; set; }
        public List<Customer_Technology> Customers_Technologies { get; set; }
        public List<Customer_Hobby> Customers_Hobbies { get; set; }
        public List<Customer_Channel> Customers_Channels { get; set; }


    }
}
