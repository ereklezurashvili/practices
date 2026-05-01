using practice_14.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_14.Models;


internal class Task
{
    public Guid Id { get; set; }
    public Guid TaskId { get; set; }
    public ActionType ActionType { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }
}

