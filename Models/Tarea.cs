namespace TareasBlazor.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        private bool completada;
        public bool Completada
        {
            get => completada;
            set
            {
                completada = value;
                OnCompletadaChanged?.Invoke(this);
            }
        }

        public event Action<Tarea>? OnCompletadaChanged;

        public DateTime FechaVencimiento { get; set; }
    }
}
