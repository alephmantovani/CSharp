using CRUD.Model;
using CRUD.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new Principal());
            //Application.Run(new NovoUsuario());
            //Application.Run(new ConsultarUsuario());
            //Application.Run(new ConsultarCliente());

        }
    }
}
