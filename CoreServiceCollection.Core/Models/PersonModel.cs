﻿using System;

namespace CoreServiceCollection.Core.Models
{
    public class PersonModel
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string AdditionalInfo { get; set; }
    }
}