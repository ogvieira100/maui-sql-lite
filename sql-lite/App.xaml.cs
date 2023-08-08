using sql_lite.MVVM.Models;
using sql_lite.MVVM.Views;
using sql_lite.Repository;

namespace sql_lite
{
    public partial class App : Application
    {
        readonly BaseRepository<Cliente> _baseRepository;
    
        public App(BaseRepository<Cliente> baseRepository)
        {
            InitializeComponent();
            _baseRepository = baseRepository;   
            MainPage = new NavigationPage(new MenuView(_baseRepository));
        }
    }
}