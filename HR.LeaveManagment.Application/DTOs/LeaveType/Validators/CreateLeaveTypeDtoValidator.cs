﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is requierd.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(x => x.DefaultDays)
               .NotEmpty().WithMessage("{PropertyName} is requierd.")
               .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
               .LessThan(100).WithMessage("{PropertyName} must be less than 100.");
        }
    }
}
