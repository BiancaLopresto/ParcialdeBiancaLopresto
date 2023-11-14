namespace ClaseCubo
{
    public class Cubo
    {
        private double _medidaArista;

        public Cubo(double MedidaArista)
        {
            _medidaArista = MedidaArista;
        }

        public double GetArea => 6 * Math.Pow(_medidaArista, 2);
        public double GetVolumen => Math.Pow(_medidaArista, 3);

        public enum Color
        {
            Azul,
            Amarillo,
            Verde

        }

        public enum Trazos
        {
            Continuo,
            Rayas,
            Puntos
        }

    }
}