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
    public class ClienteEditViewModel
    {

        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public bool IsLoading { get; set; } = false;


        public ICommand Salvar => new Command( () =>
        {
             AtualizarCliente();
        });

        readonly BaseRepository<Cliente> _baseRepository;
        public ClienteEditViewModel(BaseRepository<Cliente> baseRepository)
        {
            _baseRepository = baseRepository;
        }


        public void AtualizarCliente()
        {
;
            IsLoading = true;

            _baseRepository.Update(new Cliente { 
                
                Id = Id, 
                CPF = CPF,  
                Nome = Nome,    
                Endereco = Endereco,    

            
            });

            IsLoading = false;
        }

    }
}
