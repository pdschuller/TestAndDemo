using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public partial class ToDoItem
    {
        public int Id { get; set; }
        public string ToDoName { get; set; }
        public string DueDate { get; set; }
        public string ExpectedCost { get; set; }
    }
}
