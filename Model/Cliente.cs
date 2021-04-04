using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Model
{
    public class Cliente
    {

        private String id;
        private String nome;
        private String sobrenome;

        public Cliente()
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        public override bool Equals(object obj)
        {
            var cliente = obj as Cliente;
            return cliente != null &&
                   Id == cliente.Id &&
                   Nome == cliente.Nome &&
                   Sobrenome == cliente.Sobrenome;
        }

        public override int GetHashCode()
        {
            var hashCode = 824207911;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sobrenome);
            return hashCode;
        }
    }
}
