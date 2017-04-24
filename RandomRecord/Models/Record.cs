﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomRecords.Models
{
    public class Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Record(Dictionary<string, int> dict, int randomNumber)
        {
            // TODO add random year generator
            Year = 2000;
            FirstName = new FirstNameField(dict, randomNumber).Name;
            LastName = new LastNameField().Name;

        }

    }
}