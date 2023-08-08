using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_lite.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ClienteSearchDetailViewModel
    {
        public int Id { get; set; }
        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

    }
}
