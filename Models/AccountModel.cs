﻿namespace mymvcapp.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}

// /register/account