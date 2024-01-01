using Blazorise;
using TodoApp.Entities;
using TodoApp.Services.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Services
{
    public class TodoAppService:ApplicationService
    {
        private readonly IRepository<ToDoItem, Guid> repository;

        public TodoAppService(IRepository<ToDoItem,Guid> repository)
        {
            this.repository = repository;
        }

        public async Task<List<TodoItemDTO>> GetListAsync()
        {
            var items=await repository.GetListAsync();
            var result=  items.Select(items => new TodoItemDTO { Text = items.Text, Id = items.Id }).ToList();
            return result;
        }
        public async Task<TodoItemDTO> CreateAsync(string text)
        {
            var items = await repository.InsertAsync(
                new ToDoItem { Text=text}
                );

            return new TodoItemDTO
            {
                Text =items.Text,
                Id = items.Id
            };
        }

        public async Task DeleteList(Guid id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
