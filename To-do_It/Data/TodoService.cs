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

        public Todo newTodo(String description)
        {
            Todo newTodoToAdd = new Todo(TodoSequencer.NextTodoId(), description);
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
            Todo[] todoArrayStatus = new Todo[0];
            foreach (Todo todo in todoArray)
            { 
                if(todo.Done==doneStatus)
                {
                    Array.Resize(ref todoArrayStatus, todoArrayStatus.Length + 1);
                    todoArrayStatus[todoArrayStatus.Length - 1] = todo;
                }
                    }
            return todoArrayStatus;
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] todoArrayAssignee = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Id == personId)
                {
                    Array.Resize(ref todoArrayAssignee, todoArrayAssignee.Length + 1);
                    todoArrayAssignee[todoArrayAssignee.Length - 1] = todo;
                }
            }
            return todoArrayAssignee;
        }

        public Todo[] FindByAssignee(Person person)
        {
            Todo[] todoArrayAssigneePerson = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee.Equals(person))
                {
                    Array.Resize(ref todoArrayAssigneePerson, todoArrayAssigneePerson.Length + 1);
                    todoArrayAssigneePerson[todoArrayAssigneePerson.Length - 1] = todo;
                }
            }
            return todoArrayAssigneePerson;
        }

        public Todo[] FindByUnassigned()
        {
            Todo[] todoArrayUnassigned = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee == null)
                {
                    Array.Resize(ref todoArrayUnassigned, todoArrayUnassigned.Length + 1);
                    todoArrayUnassigned[todoArrayUnassigned.Length - 1] = todo;
                }
            }
            return todoArrayUnassigned;
        }

        public void Remove(Todo todoRemove)
        {
            Todo[] newTodoArray = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Equals(todoRemove))
                {
                    
                } else
                {
                    Array.Resize(ref newTodoArray, newTodoArray.Length + 1);
                    newTodoArray[newTodoArray.Length - 1] = todo;
                }
            }
            Clear();
            todoArray = newTodoArray;
        }
    }
}
