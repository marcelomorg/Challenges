namespace TrilhaDotNEt.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public decimal Desconto = .90M;

        
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if ( hospedes.Count <= Suite.Capacidade ) 
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Warning: Capacidade de Hospedes acima da capacidade da Suite.");
            }        
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            Decimal totalPagar = Suite.ValorDiaria * DiasReservados;
            if( DiasReservados >= 10 )
            {
                return totalPagar = totalPagar * Desconto;
            }
            else
            {
                return totalPagar;
            }
        }
    }
}