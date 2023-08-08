using PropertyChanged;
using sql_lite.MVVM.Models;
using sql_lite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sql_lite.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ClienteDeleteViewModel
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public bool IsLoading { get; set; } = false;

        public ICommand Salvar => new Command( () =>
        {
             DeletarCliente();
        });

        readonly BaseRepository<Cliente> _baseRepository;
        public ClienteDeleteViewModel(BaseRepository<Cliente> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public  void DeletarCliente()
        {
            IsLoading = true;
            _baseRepository.DeleteItem(new Cliente { 
            
            Id = Id,    
            Nome = Nome,
            Endereco = Endereco,
            CPF = CPF,  
            
            });
              IsLoading = false;
        }

    }
}
