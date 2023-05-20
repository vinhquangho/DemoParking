﻿using System;

namespace DemoParking.Dtos.Employee
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
