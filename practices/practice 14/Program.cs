using practice_14.Models;
using practice_14.Services;
using practice_14.Enums;

TaskService taskService = new TaskService();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("==== TASK MANAGEMENT SYSTEM ====");
    Console.WriteLine("1. Create Task");
    Console.WriteLine("2. Show All Tasks");
    Console.WriteLine("3. Get Task By Id");
    Console.WriteLine("4. Update Task");
    Console.WriteLine("5. Change Task Status");
    Console.WriteLine("6. Delete Task");
    Console.WriteLine("7. Filter By Status");
    Console.WriteLine("8. Show Logs For Task");
    Console.WriteLine("9. Exit");

    Console.Write("Choose option: ");

    string choice = Console.ReadLine();

    Console.WriteLine();

    if (choice == "1")
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        taskService.CreateTask(title, description);
    }
    else if (choice == "2")
    {
        List<practice_14.Models.Task> tasks = taskService.GetAllTasks();

        foreach (practice_14.Models.Task task in tasks)
        {
            Console.WriteLine("Id: " + task.Id);
            Console.WriteLine("Title: " + task.Title);
            Console.WriteLine("Description: " + task.Description);
            Console.WriteLine("Status: " + task.Status);
            Console.WriteLine("Created At: " + task.CreatedAt);
            Console.WriteLine();
        }
    }
    else if (choice == "3")
    {
        Console.Write("Enter Task Id: ");

        Guid id = Guid.Parse(Console.ReadLine());

        practice_14.Models.Task task = taskService.GetTaskById(id);

        if (task == null)
        {
            Console.WriteLine("Task not found");
        }
        else
        {
            Console.WriteLine("Id: " + task.Id);
            Console.WriteLine("Title: " + task.Title);
            Console.WriteLine("Description: " + task.Description);
            Console.WriteLine("Status: " + task.Status);
            Console.WriteLine("Created At: " + task.CreatedAt);
        }
    }
    else if (choice == "4")
    {
        Console.Write("Enter Task Id: ");

        Guid id = Guid.Parse(Console.ReadLine());

        Console.Write("New Title: ");
        string title = Console.ReadLine();

        Console.Write("New Description: ");
        string description = Console.ReadLine();

        taskService.UpdateTask(id, title, description);
    }
    else if (choice == "5")
    {
        Console.Write("Enter Task Id: ");

        Guid id = Guid.Parse(Console.ReadLine());

        Console.WriteLine("0 - ToDo");
        Console.WriteLine("1 - InProgress");
        Console.WriteLine("2 - Done");
        Console.WriteLine("3 - Testing");

        int statusNumber = Convert.ToInt32(Console.ReadLine());

        practice_14.Enums.TaskStatus status = (practice_14.Enums.TaskStatus)statusNumber;

        taskService.ChangeStatus(id, status);
    }
    else if (choice == "6")
    {
        Console.Write("Enter Task Id: ");

        Guid id = Guid.Parse(Console.ReadLine());

        taskService.DeleteTask(id);
    }
    else if (choice == "7")
    {
        Console.WriteLine("0 - ToDo");
        Console.WriteLine("1 - InProgress");
        Console.WriteLine("2 - Done");
        Console.WriteLine("3 - Testing");

        int statusNumber = Convert.ToInt32(Console.ReadLine());

        practice_14.Enums.TaskStatus status = (practice_14.Enums.TaskStatus)statusNumber;

        List<practice_14.Models.Task> tasks = taskService.FilterByStatus(status);

        foreach (practice_14.Models.Task task in tasks)
        {
            Console.WriteLine(task.Title + " - " + task.Status);
        }
    }
    else if (choice == "8")
    {
        Console.Write("Enter Task Id: ");

        Guid id = Guid.Parse(Console.ReadLine());

        List<Log> logs = taskService.GetLogsForTask(id);

        foreach (Log log in logs)
        {
            Console.WriteLine("Action: " + log.ActionType);
            Console.WriteLine("Message: " + log.Message);
            Console.WriteLine("Time: " + log.TimeStamp);
            Console.WriteLine();
        }
    }
    else if (choice == "9")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}
