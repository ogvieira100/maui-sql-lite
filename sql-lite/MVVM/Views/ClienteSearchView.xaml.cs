using sql_lite.MVVM.Models;
using sql_lite.MVVM.ViewModels;
using sql_lite.Repository;

namespace sql_lite.MVVM.Views;

public partial class ClienteSearchView : ContentPage
{

    ClienteSearchViewModel _clienteSearchView;

    readonly BaseRepository<Cliente> _baseRepository;
    public ClienteSearchView(BaseRepository<Cliente> baseRepository)
    {
        InitializeComponent();
        _baseRepository = baseRepository;
        _clienteSearchView = new ClienteSearchViewModel(_baseRepository);
        BindingContext = _clienteSearchView;
    }

    private async void btnAdicionarCliente_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClienteAddView(_baseRepository));
    }

    private async void btnExcluirClientes_Clicked(object sender, EventArgs e)
    {
        if (_clienteSearchView.ClienteSelected is null)
        {
            await App.Current.MainPage.DisplayAlert("Mensagem do Sistema", "Atenção selecione um cliente para excluir", "Ok");
            return;
        }

        await Navigation.PushAsync(new ClienteDeleteView(new ClienteDeleteViewModel(_baseRepository)
        {
            CPF = _clienteSearchView.ClienteSelected.CPF,
            Endereco = _clienteSearchView.ClienteSelected.Endereco,
            Nome = _clienteSearchView.ClienteSelected.Nome,
            Id = _clienteSearchView.ClienteSelected.Id
        }));
    }

    private async void btnEditarClientes_Clicked(object sender, EventArgs e)
    {
        if (_clienteSearchView.ClienteSelected is null)
        {
            await App.Current.MainPage.DisplayAlert("Mensagem do Sistema", "Atenção selecione um cliente para editar", "Ok");
            return;
        }

        await Navigation.PushAsync(new ClienteEditView(new ClienteEditViewModel(_baseRepository)
        {
            CPF = _clienteSearchView.ClienteSelected.CPF,
            Endereco = _clienteSearchView.ClienteSelected.Endereco,
            Nome = _clienteSearchView.ClienteSelected.Nome,
            Id = _clienteSearchView.ClienteSelected.Id
        }));

    }
}