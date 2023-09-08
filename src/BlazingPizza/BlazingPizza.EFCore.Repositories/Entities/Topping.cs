﻿namespace BlazingPizza.EFCore.Repositories.Entities;
internal class Topping
{
    public int Id { get; set; }
    public string Name { get; set; }

    [Precision(8, 2)]
    public decimal Price { get; set; }

}
