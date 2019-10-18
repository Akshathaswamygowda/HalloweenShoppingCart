using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ch24ShoppingCartMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace Ch24ShoppingCartMVC.Models {
    public class CartViewModel
    {
        public List<ProductViewModel> Cart { get; set; }
        public ProductViewModel AddedProduct { get; set; }

        

        //[RegularExpression(@"[0-9/]+", ErrorMessage = "The Expiration Date must be at least 6 - 7 "
        // + "digits and slashes long.")]
        //[Display(Name = "Expiration Date")]
        //[Required]
        //[StringLength(7, MinimumLength = 6, ErrorMessage = "The Expiration Date must be at least 6 - 7 "
        // + "digits and slashes long.")]

     


        [Display(Name = "First Name")]
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "The Name must be at least 4 - 100 "
        + "characters long.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "The Last Name must be at least 4 - 100 "
        + "characters long.")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "The Address must be at least 4 - 100 "
         + "characters long.")]
        public string Address { get; set; }


        [Display(Name = "City")]
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The City must be at least 2 - 100 "
         + "characters long.")]
        public string City { get; set; }


        [Display(Name = "State")]
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The State must be at least 2 - 50 "
         + "characters long.")]
        public string State { get; set; }


        [RegularExpression(@"[0-9-]+", ErrorMessage = "The Postal Code must be at least 5 - 11 digits "
         + "and dashes long.")]
        [Display(Name = "Postal Code")]
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "The Postal Code must be at least 5 - 11 "
         + "digits and dashes long.")]
        public string PostalCode { get; set; }


        [Display(Name = "Country")]
        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "The Country must be at least 2 - 60 "
         + "characters long.")]
        public string Country { get; set; }


        [RegularExpression(@"[0-9]+", ErrorMessage = "The Phone Number must be at least 10 - 12 "
         + "digits, parenthesis, and dashes long.")]
        [Display(Name = "Phone Number")]
        [Required]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "The Phone Number must be at least 10 - 12 "
         + "digits, parenthesis, and dashes long.")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Email Address")]
        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "The Email Address must be at least 6 - "
         + "100 characters long.")]
        public string Email { get; set; }

        [RegularExpression(@"[0-9-]+", ErrorMessage = "The Credit Card number must be 16 digits and "
       )]
        [Display(Name = "Credit Card Number")]
        [StringLength(19, MinimumLength = 16, ErrorMessage = "The Credit Card number must be 16 digits "
       )]
        public string CreditCardNumber { get; set; }

        [Display(Name = "Cardholder Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The Cardholder Name must be at least 2 "
      + "- 100 characters long.")]
        public string CardholderName { get; set; }

        [Display(Name = "Card Type")]
        [StringLength(6, MinimumLength = 5)]
        public string CardType { get; set; }

        [Display(Name = "Card Provider")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "The Card Provider must be at least 4 - 30 "
       + "characters long.")]
        public string CardProvider { get; set; }

        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-YYYY}")]
        public DateTime ExpirationDate { get; set; }

    }
}