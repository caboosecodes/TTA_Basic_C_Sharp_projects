using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// A View Model is a model that is stripped down to only what you need for the View
// Usually in a seperate folder
namespace NewsletterAppMVC.ViewModels
{
    // when creating a view model you need to signify its a view model; end with Vm
    public class SignupVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}

// you would want to create a view model because Models can be very large and you don't want to be sending the whole model
// to a view especially when you're only going to be using select parts
// Also you want to use a view model if there is sensitive information like a social security number or credit card