using Microsoft.AspNetCore.Components;
using TodoApp.Entities;
using TodoApp.Services;
using TodoApp.Services.Dtos;

namespace TodoApp.Pages;

public partial class Index
{
    [Inject]
    private TodoAppService TodoAppService { get; set; }

    public List<TodoItemDTO> Item { get; set; }=new List<TodoItemDTO>();
    private string Text { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Item = await TodoAppService.GetListAsync();
    }
    private async Task Create()
    {
        var result = await TodoAppService.CreateAsync(Text);
        Item.Add(result);
        Text = null;

    }
    private async Task Delete(TodoItemDTO todoItemDTO)
    {
        await TodoAppService.DeleteList(todoItemDTO.Id);
        await Notify.Info("Deleted Todo Item");
        Item.Remove(todoItemDTO);
    }

}
