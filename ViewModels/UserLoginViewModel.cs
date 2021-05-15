  
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using time_tracker.Models;

namespace time_tracker.ViewModels
{
    public class UserLoginViewModel
    {
    [Required]
    public string Password{get;set;}

    [Required]
    public string EmailAddress {get;set;}
    }        
}