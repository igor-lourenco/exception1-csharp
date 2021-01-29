using Exception1.Entidades;
using Exception1.Entidades.Exceptions;
using System;

namespace Exception1 {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Numero do Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Data Check-In (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data Check-Out (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(quarto, checkIn, checkOut);

                Console.WriteLine("Reserva -> " + reserva);

                Console.WriteLine();
                Console.WriteLine("Digite os dados atualizados da reserva: ");
                Console.Write("Data Check-In (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data Check-Out (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.AtualizarDados(checkIn, checkOut);

                Console.WriteLine("Dados atualizados -> " + reserva);
            }
            catch (DominioException e) {
                Console.WriteLine("Erro na reserva -> " + e.Message);
              }
            catch(FormatException e) {
                Console.WriteLine("Formato errado!! " + e.Message);
            }
            catch(Exception e) {
                Console.WriteLine("Erro inesperado!!" + e.Message);
            }
        }
    }
}
