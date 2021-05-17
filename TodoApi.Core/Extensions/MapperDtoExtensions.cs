using TodoApi.Core.Dtos;
using TodoApi.Core.Entities;

namespace TodoApi.Core.Extensions
{
	public static class MapperDtoExtensions
	{
		public static TodoItemDto ToDto(this TodoItem todoItem)
		{
			return new TodoItemDto
			{
				Id = todoItem.Id,
				Name = todoItem.Name,
				IsComplete = todoItem.IsComplete
			};
		}
	}
}
