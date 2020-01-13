using Controllers.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables;

namespace Controllers.Repositorios
{
    //Métodos para o CRUD
  public class DentistaRepositorio
    {
        public void Cadastrar(Dentista obj)
        {
            using(var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }
        }
        public Dentista Buscar(int ID)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Dentistas.Find(ID); //FIND está fazendo uma busca um parâmetro
            }
            return obj;
        }
        public List<Dentista> Listar()
        {
            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
        }
        public void Deletar(int ID)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(ID);
                ctx.Dentistas.Remove(obj); //Após remover o objeto
                ctx.SaveChanges(); //Salvar 
            }
        }
        public void Editar(Dentista objNovo)
        {
            using(var ctx = new SistemaContext())
            {
                Dentista objAntigo = ctx.Dentistas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Celular = objNovo.Celular;
                objAntigo.CRO = objNovo.CRO;
                objAntigo.Email = objNovo.Email;
                ctx.SaveChanges();
            }
        }
    }
}
