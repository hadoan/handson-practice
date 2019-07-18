using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;

namespace blazor_todo.Data{
    public class ToDoService{
        private HttpClient client;
        public ToDoService()
        {
            client = new HttpClient();
        }
        // public async Task<List<ToDo>> GetToDoAsync(){
        //     client.
        // }
    }
}