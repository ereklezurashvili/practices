using practice_14.Enums;
using practice_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;


namespace practice_14.Services;

public class FileService
{
    private readonly string taskPath = "tasks.json";
    private readonly string logPath = "logs.json";

    public List<Models.Task> ReadTasks()
    {   
        if (!File.Exists(taskPath))
        {
            File.Create(taskPath).Close();
            return new List<Models.Task>();
        }

        using (FileStream stream = new FileStream(taskPath, FileMode.Open, FileAccess.Read))
        {
            if (stream.Length == 0)
            {
                return new List<Models.Task>();
            }

            List<Models.Task> tasks = JsonSerializer.Deserialize<List<Models.Task>>(stream);

            if (tasks == null)
            {
                return new List<Models.Task>();
            }

            return tasks;
        }
    }

    public void WriteTasks(List<Models.Task> tasks)
    {
        using (FileStream stream = new FileStream(taskPath, FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize(stream, tasks, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }

    public List<Log> ReadLogs()
    {
        if (!File.Exists(logPath))
        {
            File.Create(logPath).Close();
            return new List<Log>();
        }

        using (FileStream stream = new FileStream(logPath, FileMode.Open, FileAccess.Read))
        {
            if (stream.Length == 0)
            {
                return new List<Log>();
            }

            List<Log> logs = JsonSerializer.Deserialize<List<Log>>(stream);

            if (logs == null)
            {
                return new List<Log>();
            }

            return logs;
        }
    }

    public void WriteLogs(List<Log> logs)
    {
        using (FileStream stream = new FileStream(logPath, FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize(stream, logs, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}
