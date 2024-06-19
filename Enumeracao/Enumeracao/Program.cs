using Enumeracao.Entites;
using Enumeracao.Entites.Enums;


namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();
            //Converter em string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
        }
}

