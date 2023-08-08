using sql_lite.MVVM.Models;
using sql_lite.Repository;

namespace sql_lite.MVVM.Views;

public partial class MenuView : ContentPage
{
    readonly BaseRepository<Cliente> _baseRepository;
    public MenuView(BaseRepository<Cliente> baseRepository)
	{
		InitializeComponent();
        _baseRepository = baseRepository;   

    }
    private async void btnConsultaClientes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClienteSearchView(_baseRepository));
    }
}