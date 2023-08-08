using PropertyChanged;
using sql_lite.MVVM.Models;
using sql_lite.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sql_lite.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ClienteSearchViewModel
    {
        readonly BaseRepository<Cliente> _baseRepository;
        public ClienteSearchViewModel(BaseRepository<Cliente> baseRepository)
        {
            _baseRepository = baseRepository;   
        }

        public ObservableCollection<ClienteSearchDetailViewModel> Clientes { get; set; } =
                       new ObservableCollection<ClienteSearchDetailViewModel>();

        public ClienteSearchDetailViewModel ClienteSelected { get; set; }

        public string NameSearch { get; set; }

        public bool IsLoading { get; set; }

        public ICommand SearchCommand =>
        new Command( () =>
        {
            IsLoading = true;
            Clientes.Clear();
            var items =  _baseRepository.GetItems();
            foreach (var item in items)
            {
                Clientes.Add(new ClienteSearchDetailViewModel
                {
                    Id = item.Id,   
                    Nome    = item.Nome,    
                    Endereco = item.Endereco,   
                    CPF=  item.CPF
                });
            }
            IsLoading = false;
        });
    }
}
