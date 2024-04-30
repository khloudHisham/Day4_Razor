
using System.Net.Http.Json;

namespace Day4WASMConsumer.Services
{
    //API url:10.0.0.1
    public class DeptService : IServices<Department>
    {
        private readonly HttpClient httpClient;

        public DeptService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"api/Department/{id}");
        }

        public async Task<List<Department>> GetAll()
        {
            List<Department>? Depts =
                await httpClient.GetFromJsonAsync<List<Department>>("api/Department");
            return Depts;
        }

        public async Task<Department> GetByID(int id)
        {
            Department dep = await httpClient.GetFromJsonAsync<Department>($"api/Department/{id}");
            return dep;
        }

        public async Task Insert(Department item)
        {
            var response = await httpClient.PostAsJsonAsync<Department>("api/Department", item);
            //response.Content.read
        }

        public async Task Update(int id, Department item)
        {
            await httpClient.PutAsJsonAsync<Department>($"api/Department/{id}", item);
        }
    }
}
