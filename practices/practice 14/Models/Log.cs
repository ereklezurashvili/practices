using practice_14.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice_14.Models;

public class Log
{
    public Guid Id { get; set; }

    public Guid TaskId { get; set; }

    public ActionType ActionType { get;  set; }

    public string Message { get;  set; }

    public DateTime TimeStamp { get; set; }
    public Log()
    {
        // ONLY for deserialization
    }



    public Log(Guid taskId, ActionType actionType, string message)
    {
        Id = Guid.NewGuid();
        TaskId = taskId;
        ActionType = actionType;
        Message = message;
        TimeStamp = DateTime.Now;
    }

    public override string ToString()
    {
        return
            "Log Id: " + Id + "\n" +
            "Task Id: " + TaskId + "\n" +
            "Action Type: " + ActionType + "\n" +
            "Message: " + Message + "\n" +
            "Timestamp: " + TimeStamp;
    }
}
