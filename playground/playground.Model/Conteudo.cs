using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memcached.ClientLibrary;

namespace playground.Model
{
    [Serializable]
    public class Conteudo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal nota { get; set; }

        public List<Conteudo> fill()
        {

            var lista = new List<Conteudo>();
            for (int i = 0; i < 2000; i++)
            {
                lista.Add(new Conteudo() { id = i, nome = "Conteúdo " + i.ToString(), nota = 5 * new System.Random().Next(10)});
            }

            return lista;
            
        }

        public Conteudo getConteudo(int id)
        {
            System.Threading.Thread.Sleep(10);
            return new Conteudo().fill().Where(c => c.id == id).Single();
        }

        public Conteudo getConteudoComCache(int id)
        {

            string[] servidores = { "127.0.0.1:11211" };

            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(servidores);
            pool.Initialize();

            var cache = new MemcachedClient();

            if (cache.KeyExists(id.ToString()))
                return (Conteudo)cache.Get(id.ToString());
            else
            {
                Conteudo conteudo = new Conteudo().fill().Where(c => c.id == id).Single();
                cache.Add(id.ToString(), conteudo, DateTime.Now.AddSeconds(30));
                return conteudo;
            }

        }

    }


}
