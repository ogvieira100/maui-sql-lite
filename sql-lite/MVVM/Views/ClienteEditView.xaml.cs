using sql_lite.MVVM.Models;
using sql_lite.MVVM.ViewModels;
using sql_lite.Repository;

namespace sql_lite.MVVM.Views;

public partial class ClienteEditView : ContentPage
{
	public ClienteEditView()
	{
		InitializeComponent();
	}

    ClienteEditViewModel _clienteEditViewModel;
    public ClienteEditView(ClienteEditViewModel clienteEditViewModel ):this() 
    {
        
        _clienteEditViewModel = clienteEditViewModel;
        BindingContext = _clienteEditViewModel;

    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {

        _clienteEditViewModel.AtualizarCliente();   
        await App.Current.MainPage.DisplayAlert("Mensagem do Sistema", "Dados atualizados com sucesso", "Ok");
        await Navigation.PopAsync();

    }
}