using sql_lite.MVVM.Models;
using sql_lite.MVVM.ViewModels;
using sql_lite.Repository;

namespace sql_lite.MVVM.Views;

public partial class ClienteAddView : ContentPage
{

    readonly BaseRepository<Cliente> _baseRepository;
    ClienteAddViewModel _clienteAddViewModel;

    public ClienteAddView()
    {
            InitializeComponent();
    }
    public ClienteAddView(BaseRepository<Cliente> baseRepository):this()
	{
        _baseRepository = baseRepository;
        _clienteAddViewModel = new ClienteAddViewModel(_baseRepository);
        BindingContext = _clienteAddViewModel;

    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {
        _clienteAddViewModel.SalvarCliente();
        await App.Current.MainPage.DisplayAlert("Mensagem do Sistema", "Dados atualizados com sucesso", "Ok");
        await Navigation.PopAsync();
    }
}