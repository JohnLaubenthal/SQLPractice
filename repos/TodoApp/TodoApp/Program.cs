using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        private static object todoId;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            DisplayTodos();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View Details of a Todo");

            var selectedOption = Console.ReadLine();
            if (selectedOption == "1")
            {
                Console.WriteLine("Which todo?");
                var selectedTodo = Console.ReadLine();
                var todoId = int.Parse(selectedTodo);
                DisplayTodoDetails(todoId);
            }

        }

        

        private static void DisplayTodoDetails(int todoId)
        {
            // Get the todo
            var todoRepo = new TodoRepository();
            var todo = todoRepo.GetById(todoId);
            // Print it out
            Console.WriteLine(todo);
            Console.WriteLine(todo.Details);
        }

        private static void DisplayTodos()
        {
            var todoRepo = new TodoRepository();
            foreach (var item in todoRepo.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
