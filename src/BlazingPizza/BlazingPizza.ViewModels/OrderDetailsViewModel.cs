﻿namespace BlazingPizza.ViewModels;
internal class OrderDetailsViewModel : IOrderDetailsViewModel
{
    readonly IOrderDetailsModel Model;

    public OrderDetailsViewModel(IOrderDetailsModel model)
    {
        Model = model;
    }

    public GetOrderDto Order { get; private set; }

    public bool InvalidOrder { get; private set; }

    public async Task GetOrderAsync(int id)
    {
        Order = await Model.GetOrderAsync(id);
        if (Order.Id == 0)
        {
            InvalidOrder = true;
        }
    }
}
