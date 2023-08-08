using PropertyChanged;
using sql_lite.MVVM.Models;
using sql_lite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sql_lite.MVVM.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class ClienteAddViewModel
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Endereco { get; set; }

        public bool IsLoading { get; set; } = false;

        readonly BaseRepository<Cliente> _baseRepository;
        public ClienteAddViewModel(BaseRepository<Cliente> baseRepository)
        {
            _baseRepository = baseRepository;   
        }

        public ICommand Salvar => new Command(async () =>
        {
             SalvarCliente();
        });

        public void SalvarCliente()
        {
            IsLoading = true;

            _baseRepository.insert(new Cliente { 
            
                CPF = CPF,
                Nome = Nome,
                Endereco = Endereco 
            
            });

            IsLoading = false;
        }

    }
}
