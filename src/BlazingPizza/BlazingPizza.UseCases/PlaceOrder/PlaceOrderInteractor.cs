﻿namespace BlazingPizza.UseCases.PlaceOrder;
internal class PlaceOrderInteractor : IPlaceOrderInputPort
{
    readonly IBlazingPizzaCommandsRepository Repository;

    public PlaceOrderInteractor(
        IBlazingPizzaCommandsRepository repository)
    {
        Repository = repository;
    }

    public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
    {
        return await Repository.PlaceOrderAsync(order);
    }
}

