using Volo.Abp.Domain.Entities;

namespace TodoApp.Services.Dtos
{
    public class TodoItemDTO
    {
        public string Text { get; set; }
        public Guid Id { get; set; }
    }
}
