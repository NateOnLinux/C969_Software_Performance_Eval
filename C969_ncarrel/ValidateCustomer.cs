using System.ComponentModel.DataAnnotations;

namespace C969_ncarrel
{
    class ValidateCustomer
    {
        [Required, StringLength(45,ErrorMessage = "Customer Name cannot exceed 45 characters",ErrorMessageResourceName = "Customer Name",MinimumLength = 1)]
        public string CustName { get; set; }
        [Required,Phone(ErrorMessage = "Phone number must be in a valid format")]
        public string CustPhone { get; set; }
        [Required, StringLength(50,ErrorMessage = "Address Line 1 cannot exceed 50 characters",MinimumLength = 1)]
        public string CustAddress { get; set; }
        [StringLength(50,ErrorMessage = "Address Line 2 cannot exceed 50 characters",MinimumLength = 0)]
        public string CustAddress2 { get; set; }
        [Required,RegularExpression("([0-9]{1,20})",ErrorMessage = "Postal Code must be numeric and cannot exceed 20 digits")]
        public string CustZip { get; set; }
        [Required, StringLength(50, ErrorMessage = "City cannot exceed 50 characters", MinimumLength = 1)]
        public string CustCity { get; set; }
        [Required, StringLength(50, ErrorMessage = "Address Line 1 cannot exceed 50 characters", MinimumLength = 1)]
        public string CustCountry { get; set; }
    }
}
