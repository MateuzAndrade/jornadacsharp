using CursoBaltaOrientacaoObjetos.ContentContext;

namespace CursoBaltaOrientacaoObjetos;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var pagamentos = new List<Pagamento>();
        pagamentos.Add(new Pagamento(1));
        pagamentos.Add(new Pagamento(2));
        pagamentos.Add(new Pagamento(3));
        pagamentos.Add(new Pagamento(4));
        pagamentos.Add(new Pagamento(5));

        foreach (var pagamento in pagamentos)
        {
            Console.WriteLine(pagamento.Id);
        }

    }
    public class Pagamento {
        public int Id { get; set; }
        public Pagamento (int id)
        {
            Id = id;   
        }
        
        
    }

}
