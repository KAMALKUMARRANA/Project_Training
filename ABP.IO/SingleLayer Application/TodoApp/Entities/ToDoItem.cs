using Volo.Abp.Domain.Entities;

namespace TodoApp.Entities
{
    public class ToDoItem: BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
