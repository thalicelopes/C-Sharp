using System;

namespace ExceptionStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try 
            {
                // for(var index = 0; index <10; index++){
                //     Console.WriteLine(arr[index]);
                // }
                Cadastrar("");
            }
            catch(IndexOutOfRangeException ex){
                Console.WriteLine("Não foi encontrado!");
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("Falha ao cadastrar texto");
            }
            catch(MinhaException ex){
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção Customizada");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }
        private static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }
        public class MinhaException: Exception{
            public MinhaException(DateTime date){
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
    
}