using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DTO;

namespace TodoApp.Repository
{
    public interface ITodoAppService
    {
        Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
