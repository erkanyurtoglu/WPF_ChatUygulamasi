using Chat_Uygulamasi.MVVM.Core;
using Chat_Uygulamasi.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Uygulamasi.MVVM.ViewModel
{
    class MainViewModel
    {
        public RelayCommand ConnectToServerCommand { get; set; }

        private readonly Server _server;

        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer());
        }
    }
}
