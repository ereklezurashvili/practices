using practice_14.Enums;
using practice_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace practice_14.Services;

public class FileService
{
    private string taskPath = "Tasks.txt";
    private string logPath = "Logs.txt";


    public List<Models.Task> ReadTasks()
    {
        List<Models.Task> tasks = new List<Models.Task>();

        if (!File.Exists(taskPath))
            return tasks;

        string[] lines = File.ReadAllLines(taskPath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Models.Task task = new Models.Task();
            Guid id;
            Guid.TryParse(parts[0], out id);
            task.Id = id;
            task.Title = parts[1];
            task.Description = parts[2];
            task.Status = (Enums.TaskStatus)Enum.Parse(typeof(Enums.TaskStatus), parts[3]);
            task.CreatedAt = DateTime.Parse(parts[4]);

            tasks.Add(task);
        }

        return tasks;
    }

    public void WriteTasks(List<Models.Task> tasks)
    {
        List<string> lines = new List<string>();

        foreach (Models.Task t in tasks)
        {
            string line = t.Id + "|" + t.Title + "|" + t.Description + "|" + t.Status + "|" + t.CreatedAt;
            lines.Add(line);
        }

        File.WriteAllLines(taskPath, lines);
    }

   
    public List<Log> ReadLogs()
    {
        List<Log> logs = new List<Log>();

        if (!File.Exists(logPath))
            return logs;

        string[] lines = File.ReadAllLines(logPath);

        foreach (string line in lines)
        {
            Log log = new Log();
            log.Message = line;
            logs.Add(log);
        }

        return logs;
    }

    public void WriteLogs(List<Log> logs)
    {
        List<string> lines = new List<string>();

        foreach (Log l in logs)
        {
            lines.Add(l.Message);
        }

        File.WriteAllLines(logPath, lines);
    }
}
