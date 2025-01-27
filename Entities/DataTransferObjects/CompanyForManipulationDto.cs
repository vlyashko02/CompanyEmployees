﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulationDto
    {
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Address is 30 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Country is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Country is 30 characters.")]
        public string Country { get; set; }

        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
