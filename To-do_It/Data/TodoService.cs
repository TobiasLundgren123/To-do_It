using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    internal class TodoService
    {

        private static Todo[] todoArray = new Todo[0];

        public Todo[] TodoArray
        { get { return todoArray; }
            set { todoArray = value; }
        }

        public int Size()
        {
            return todoArray.Length;
        }

        public Todo[] FindAll()
        {
            return todoArray;
        }

        public Todo FindById(int todoId)
        {
            foreach (Todo todo in todoArray)
            {
                if (todoId == todo.Id)
                {
                    return todo;
                }
            }
            return null;
        }

        public Todo newTodo(String description, Person assignee)
        {
            Todo newTodoToAdd = new Todo(TodoSequencer.NextTodoId(), description, assignee);
            Array.Resize(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = newTodoToAdd;
            return newTodoToAdd;
        }

        public void Clear()
        {
            todoArray = new Todo[0];
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            todoArrayStatus = new Todo[0];
            foreach (Todo todo in todoArray)
            { 
                if(todo.Done==doneStatus)
                {
                    Array.Resize(ref todoArrayStatus, todoArrayStatus + 1);

                }
                    }
        }

    }
}
