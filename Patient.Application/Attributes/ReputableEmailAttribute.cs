using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Attributes;
public class ReputableEmailAttribute : ValidationAttribute
{
    //public string GetErrorMessage() =>
    //    "Email address is rejected because of its reptation";

    //protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    //{
    //    var email = value as string;

    //    var emailRepClient = (IEmailRepClient)validationContext.GetService(typeof(IEmailRepClient))!;

    //    if (IsRisky(email!, emailRepClient).GetAwaiter().GetResult())
    //        return new ValidationResult(GetErrorMessage());

    //    return ValidationResult.Success;
    //}

    //private static async Task<bool> IsRisky(string email, IEmailRepClient emailRepClient)
    //{
    //    var reputation = await emailRepClient.QueryEmailAsync(email);

    //    return reputation.Details.Blacklisted ||
    //        reputation.Details.MaliciousActivity ||
    //        reputation.Details.MaliciousActivityRecent ||
    //        reputation.Details.Spam ||
    //        reputation.Details.SuspiciousTld;
    //}

}