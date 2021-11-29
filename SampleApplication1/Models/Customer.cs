using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleApplication1.Models
{
    public class Customer
    {
       [Display(Name = "Customer ID")]
     public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }

        [Display(Name = "DOB")]
        //[DataType(DataType.Date)]
    
        public DateTime DOB { get; set; }

        [Display(Name = "EmailID")]
        public string EmailID { get; set; }

    }
}