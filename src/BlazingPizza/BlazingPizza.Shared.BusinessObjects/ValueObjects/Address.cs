﻿namespace BlazingPizza.Shared.BusinessObjects.ValueObjects;

public class Address
{
    public string Name { get; set; }
    public string AddressLine1 { get; set; } 
    public string AddressLine2 { get; set;}
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
}
