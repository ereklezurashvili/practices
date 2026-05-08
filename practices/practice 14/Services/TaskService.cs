using practice_14.Enums;
using practice_14.Models;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace practice_14.Services;


public class TaskService
{
    private readonly FileService fileService;

    public TaskService()
    {
        fileService = new FileService();
    }

    public void CreateTask(string title, string description)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = new Models.Task(title, description);

        tasks.Add(task);

        fileService.WriteTasks(tasks);

        AddLog(task.Id, ActionType.Created, "Task created");

        Console.WriteLine("Task created successfully");
    }

    public List<Models.Task> GetAllTasks()
    {
        return fileService.ReadTasks();
    }

    public Models.Task GetTaskById(Guid id)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

    

        return tasks.FirstOrDefault(t => t.Id == id);
    }

    public void UpdateTask(Guid id, string newTitle, string newDescription)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            Console.WriteLine("Task not found");
            return;
        }

        task.Title = newTitle;
        task.Description = newDescription;

        fileService.WriteTasks(tasks);

        AddLog(task.Id, ActionType.Updated, "Task updated");

        Console.WriteLine("Task updated successfully");
    }

    public void ChangeStatus(Guid id, Enums.TaskStatus newStatus)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            Console.WriteLine("Task not found");
            return;
        }

        task.Status = newStatus;

        fileService.WriteTasks(tasks);

        AddLog(task.Id, ActionType.StatusChanged, "Status changed to " + newStatus);

        Console.WriteLine("Task status updated");
    }

    public void DeleteTask(Guid id)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            Console.WriteLine("Task not found");
            return;
        }

        tasks.Remove(task);

        fileService.WriteTasks(tasks);

        AddLog(task.Id, ActionType.Deleted, "Task deleted");

        Console.WriteLine("Task deleted successfully");
    }

    public List<Models.Task> FilterByStatus(Enums.TaskStatus status)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        return tasks.Where(t => t.Status == status).ToList();
    }

    public List<Log> GetLogsForTask(Guid taskId)
    {
        List<Log> logs = fileService.ReadLogs();

        return logs.Where(l => l.TaskId == taskId).ToList();
    }

    private void AddLog(Guid taskId, ActionType actionType, string message)
    {
        List<Log> logs = fileService.ReadLogs();

        Log log = new Log(taskId, actionType, message);

        logs.Add(log);

        fileService.WriteLogs(logs);

        Console.WriteLine("Log added: " + message);
    }
}
