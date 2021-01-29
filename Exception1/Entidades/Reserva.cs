using Exception1.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exception1.Entidades {
    class Reserva {

        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut) {
            if (checkOut < checkIn)
                throw new DominioException("Data do Check-Out deve ser depois do Check-in");

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao() {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizarDados(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
                throw new DominioException("As datas de reserva para atualizacao devem ser datas futuras");
            if (checkOut < checkIn)
                throw new DominioException("Data do Check-Out deve ser depois do Check-in");
            
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return "Quarto: " + NumeroQuarto + ", Check-In: " + CheckIn.ToString("dd/MM/yyyy") + 
                ", Ckech-Out: " + CheckOut.ToString("dd/MM/yyyy") + " -> " + Duracao() + " noites;" ;
        }
    }
}
