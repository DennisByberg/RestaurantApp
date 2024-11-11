﻿using Microsoft.AspNetCore.Identity;

namespace RestaurantApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}