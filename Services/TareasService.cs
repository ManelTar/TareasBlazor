using System.Net.Http.Json;
using TareasBlazor.Models;

namespace TareasBlazor.Services
{
    public class TareasService
    {
        private readonly HttpClient _http;

        public TareasService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Tarea>> ObtenerTareas()
        {
            return await _http.GetFromJsonAsync<List<Tarea>>("api/tareas") ?? new List<Tarea>();
        }

        public async Task AgregarTarea(Tarea tarea)
        {
            await _http.PostAsJsonAsync("api/tareas", tarea);
        }

        public async Task ActualizarTarea(Tarea tarea)
        {
            await _http.PutAsJsonAsync($"api/tareas/{tarea.Id}", tarea);
        }

        public async Task EliminarTarea(int id)
        {
            await _http.DeleteAsync($"api/tareas/{id}");
        }
    }
}
