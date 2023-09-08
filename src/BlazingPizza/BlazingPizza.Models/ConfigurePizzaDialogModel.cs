﻿namespace BlazingPizza.Models;
internal class ConfigurePizzaDialogModel : IConfigurePizzaDialogModel
{
    readonly IBlazingPizzaWebApiGateway Gateway;

    public ConfigurePizzaDialogModel(IBlazingPizzaWebApiGateway gateway)
    {
        Gateway = gateway;
    }

    public async Task<IReadOnlyCollection<Topping>> GetToppingsAsync()
    {
        return await Gateway.GetToppingsAsync();
    }
}
