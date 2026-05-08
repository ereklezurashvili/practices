
using practice_14.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace practice_14.Models;


public class Task
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public  Enums.TaskStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }
    public Task()
    {
        // ONLY for deserialization
    }


    public Task(string title, string description)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Status = Enums.TaskStatus.ToDo;
        CreatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return
            "Id: " + Id + "\n" +
            "Title: " + Title + "\n" +
            "Description: " + Description + "\n" +
            "Status: " + Status + "\n" +
            "Created At: " + CreatedAt;
    }
}

