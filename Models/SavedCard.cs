﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Book_My_Table.Controllers.SavedCardsController;

namespace Book_My_Table.Models
{
    
    public class SavedCard
    {
        [Key]
        public int CardId { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        [CardValidate]
        [DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }

        [Required]
        [DateValidate(ErrorMessage = "Invalid expiry date")]
        //[DataType(DataType.Date)]
        [Display(Name="Expiry Date (MM/YYYY)")]
        [DisplayFormat(DataFormatString = "{0:M}", ApplyFormatInEditMode = true)]
        public string ExpiryDate { get; set; }

        [Required]
        [StringLength(4)]
        public string CVV { get; set; }

        [Required]
        [Display(Name = "Name on the card")]
        public string NameOnCard { get; set; }

        
        public string CustomerId { get; set; }
        [Required]
        public string CardType { get; set; }

       // public ICollection<Booking> Bookings { get; set; }
        //public string[] CardTypes = new[] { "Amex", "Visa", "Master Card" };

    }
}
