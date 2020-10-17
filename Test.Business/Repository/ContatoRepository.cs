using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Context;

namespace Test.Data.Repository
{
    public class ContatoRepository
    {
        private AppContextDb db = new AppContextDb();

        public void CadastrarUsuario(Contato contato)
        {
            db.Contato.Add(contato);
            db.SaveChanges();
        }

        public List<Contato> ListarUsuarios()
        {
            return db.Contato.ToList();
        }

        public void DeletarUsuario(int id)
        {
            var usuario = db.Contato.Where(x => x.Id == id).FirstOrDefault();
            db.Contato.Attach(usuario);
            db.Contato.Remove(usuario);
            db.SaveChanges();
        }
    }
}
