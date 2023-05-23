using System;
using System.ComponentModel.DataAnnotations;

namespace C969_ncarrel
{
    class ValidateAppt
    {
        [Required, Url(ErrorMessage = "URL must be in the correct format (e.g. https://google.com/"), StringLength(255, ErrorMessage = "URL cannot exceed 255 characters", MinimumLength = 1)]
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
        [Required]
        public DateTime ApptStart { get; set; }
        [Required]
        public DateTime ApptEnd { get; set; }
    }
}
