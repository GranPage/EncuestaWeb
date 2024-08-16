namespace EncuestaWeb.Services
{
    public class EncuestaService
    {
        private readonly List<Encuesta> _encuestas;

        public EncuestaService()
        {
            _encuestas = new List<Encuesta>();
        }

        public void AddEncuesta(Encuesta encuesta)
        {
            _encuestas.Add(encuesta);
        }

        public IEnumerable<Encuesta> GetEncuestas()
        {
            return _encuestas;
        }
    }
}