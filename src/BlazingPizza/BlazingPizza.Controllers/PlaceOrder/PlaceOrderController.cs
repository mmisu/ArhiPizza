﻿namespace BlazingPizza.Controllers.PlaceOrder;
internal class PlaceOrderController : IPlaceOrderController
{
    readonly IPlaceOrderInputPort InputPort;

    public PlaceOrderController(IPlaceOrderInputPort inputPort)
    {
        InputPort = inputPort;
    }

    public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
    {
        return await InputPort.PlaceOrderAsync(order);
    }
}

