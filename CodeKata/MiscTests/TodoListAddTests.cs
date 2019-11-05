using CodeKata.MiscTests.TodoListApp;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodeKata.MiscTests
{
    public class TodoListAddTests
    {
        [Fact]
        public void ItAddsTodoItemToTheTodoList()
        {
            // Arrange
            var todo = new TodoList();
            var item = new Todo();

            // Act
            todo.AddTodo(item);

            //Assert
            Assert.Single(todo.Items);
        }
    }
}
