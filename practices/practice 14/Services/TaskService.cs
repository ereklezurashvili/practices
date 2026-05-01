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



using System;
using System.Collections.Generic;
using System.Linq;

public class TaskService
{
    private FileService fileService = new FileService();

    public void CreateTask(string title, string description)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = new Models.Task();
        task.Id = Guid.NewGuid();
        task.Title = title;
        task.Description = description;
        task.Status = Enums.TaskStatus.ToDo;
        task.CreatedAt = DateTime.Now;

        tasks.Add(task);

        fileService.WriteTasks(tasks);
        AddLog("Task created: " + task.Id);
    }

    public List<Models.Task> GetAllTasks()
    {
        return fileService.ReadTasks();
    }

    public Models.Task GetTaskById(Guid id)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        foreach (Models.Task t in tasks)
        {
            if (t.Id == id)
            {
                return t;
            }
        }

        return null;
    }

 
    public void UpdateTask(Guid id, string title, string description)
    {
        List<Models.Task> tasks = fileService.ReadTasks();
        foreach (Models.Task t in tasks)
        {
            if (t.Id == id)
            {
                t.Title = title;
                t.Description = description;

                fileService.WriteTasks(tasks);
                AddLog("Task updated: " + id);
                return;
            }
        }
    }

    public void ChangeStatus(Guid id, Enums.TaskStatus newStatus)
    {
        List<Models.Task> tasks = fileService.ReadTasks();

        Models.Task task = tasks.FirstOrDefault(t => t.Id == id);

        if (task != null)
        {
            task.Status = newStatus;

            fileService.WriteTasks(tasks);
            AddLog("Status changed: " + id + " -> " + newStatus);
        }
    }

    public void DeleteTask(Guid id)
    {
        List<Models.Task> tasks = fileService.ReadTasks();
        Models.Task found = null;
        foreach (Models.Task t in tasks)
        {
            if (t.Id == id)
            {
                found = t;
                break;
            }
        }

        if (found != null)
        {
            tasks.Remove(found);

            fileService.WriteTasks(tasks);
            AddLog("Task deleted: " + id);
        }
    }

    public List<Models.Task> FilterByStatus(Enums.TaskStatus status)
    {
        List<Models.Task> tasks = fileService.ReadTasks();
        List<Models.Task> result = new List<Models.Task>();

        foreach (Models.Task t in tasks)
        {
            if (t.Status == status)
            {
                result.Add(t);
            }
        }

        return result;
    }

    public List<Log> GetLogsForTask(Guid taskId)
    {
        List<Log> logs = fileService.ReadLogs();
        List<Log> result = new List<Log>();

        foreach (Log l in logs)
        {
            if (l.TaskId == taskId)
            {
                result.Add(l);
            }
        }

        return result;
    }
    private void AddLog(string message)
    {
        List<Log> logs = fileService.ReadLogs();

        Log log = new Log();
        log.Message = message;
        log.TaskId = Guid.NewGuid(); 
        log.TimeStamp = DateTime.Now;

        logs.Add(log);

        fileService.WriteLogs(logs);

        Console.WriteLine(message);
    }
}
