using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectManager
{
    internal class Task
    {
        public enum StatusEnum
        {
            TODO,
            InWork,
            Review,
            Closed
        }
        public enum PriorityEnum
        {
            High,
            Low,
            Mid,
            Critical
        }
            
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Deadline { get; set; }
        public Responsible Responsible { get; set; }
        public StatusEnum Status { get; set; } 
        public PriorityEnum Priority { get; set; }
        public StatusEnum GetStatus(string extStatus)
        {
            StatusEnum status;
            
            switch (extStatus)
            {
                case "В работе":
                    status = StatusEnum.InWork;
                    break;
                case "Рецензирование":
                    status = StatusEnum.Review;
                    break;                        
                case "Закрыто":
                    status = StatusEnum.Closed;
                    break;
                default:
                    status = StatusEnum.TODO;
                    break;
            }
            return status;
        }
        public PriorityEnum GetPriority(string extPriority)
        {
            PriorityEnum priority;
            switch (extPriority)
            {
                case "Критичный":
                    priority = PriorityEnum.Critical;
                    break;
                case "Высокий":
                    priority = PriorityEnum.High;
                    break;
                case "Средний":
                    priority = PriorityEnum.Mid;
                    break;
                default:
                    priority = PriorityEnum.Low;
                    break;
            }
            return priority;
        }
    }
}
