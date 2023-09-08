namespace BlazingPizza.Razor.Views.Pages;

public partial class OrderDetails
{
    [Inject]
    IOrderDetailsViewModel ViewModel { get; set; }

    [Parameter]
    public int OrderId { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        await ViewModel.GetOrderAsync(OrderId);
    }

}
