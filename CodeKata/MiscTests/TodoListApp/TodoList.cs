using System.Collections.Generic;

namespace CodeKata.MiscTests.TodoListApp
{
    public class TodoList
    {
        private List<Todo> _items = new List<Todo>();

        public IEnumerable<Todo> Items
        {
            get
            {
                return _items;
            }
        }
        public TodoList()
        {
        }

        public void AddTodo(Todo item)
        {
            _items.Add(item);
        }
    }
}
