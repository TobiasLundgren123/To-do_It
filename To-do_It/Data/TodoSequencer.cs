using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Data
{
    internal class TodoSequencer
    {
        private static int todoId;

        public static int NextTodoId()
        {
            todoId++;
            return todoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }

    }
}
