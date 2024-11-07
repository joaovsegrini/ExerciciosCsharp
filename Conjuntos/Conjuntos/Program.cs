/* Um site de internet registra um log de acessos dos usuários. Umregistro de log consiste no nome de usuário e o instante em que ousuário 
 * acessou o site no padrão ISO 8601, separados por espaço. Fazer um programa que leia o log de acessos apartir de um arquivo, e daí informe 
 * quantos usuários distintosacessaram o site. */


using Conjuntos.Entities;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}