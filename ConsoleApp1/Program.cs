using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fim = Console.ReadLine().ToString();
            var cep = ObterCep(fim).Result;
            Console.WriteLine($"{cep.cep} - {cep.state} - {cep.city} - {cep.neighborhood} - {cep.street} - {cep.service}");
        }
        public static async Task<Cep> ObterCep(string cep)
        {
            using (var http = new HttpClient())
            {
                var result = await http.GetAsync("https://brasilapi.com.br/api/cep/v1/"+cep);
                if (result.IsSuccessStatusCode)
                {
                    string conteudo = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Cep>(conteudo);
                }
                else
                {
                    return new Cep();
                }
            }
        }
        public class Cep
        {
            public string cep { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public string neighborhood { get; set; }
            public string street { get; set; }
            public string service { get; set; }
        }
    }
}
