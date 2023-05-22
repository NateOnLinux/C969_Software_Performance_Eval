using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace C969_ncarrel
{
    class ValidateCustomer
    {
        [Required, StringLength(45,ErrorMessage = "Customer Name cannot exceed 45 characters",ErrorMessageResourceName = "Customer Name",MinimumLength = 1)]
        public string CustomerName { get; set; }
        [Required,Phone(ErrorMessage = "Phone number must be in a valid format")]
        public string PhoneNumber { get; set; }
        [Required, StringLength(50, ErrorMessage = "Address Line 1 cannot exceed 50 characters", MinimumLength = 1)]
        public string CustAddress { get; set; }
        [StringLength(50,ErrorMessage = "Address Line 2 cannot exceed 50 characters",MinimumLength = 1)]
        public string CustAddress2 { get; set; }
        [Required,RegularExpression("([0-9]{1,20})",ErrorMessage = "Postal Code must be numeric and cannot exceed 20 digits")]
        public string CustZip { get; set; }
        [Required, StringLength(50, ErrorMessage = "City cannot exceed 50 characters", MinimumLength = 1)]
        public string CustCity { get; set; }
        [Required, StringLength(50, ErrorMessage = "Address Line 1 cannot exceed 50 characters", MinimumLength = 1)]
        public string CustCountry { get; set; }
    }
    class ValidateAppt
    {
        [Required, Url(ErrorMessage = "URL must be a valid URL"), StringLength(255, ErrorMessage = "URL cannot exceed 255 characters", MinimumLength = 1)]
        public string ApptUrl { get; set; }
        [Required, StringLength(255, ErrorMessage = "URL cannot exceed 255 characters", MinimumLength = 1)]
        public string ApptTitle { get; set; }
        [Required]
        public string ApptDescription { get; set; }
        [Required]
        public string ApptType { get; set; }
        [Required]
        public string ApptLocation { get; set; }
        [Required]
        public string ApptContact { get; set; }
    }
}
