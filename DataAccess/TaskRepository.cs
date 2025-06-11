using System.Collections.Generic;
using System.Linq;
using NTierTodoApp.Models;

namespace NTierTodoApp.DataAccess
{
    /// <summary>
    /// مستودع البيانات لإدارة المهام باستخدام قائمة في الذاكرة.
    /// </summary>
    public class TaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "مهمة أولى", IsComplete = false },
            new TaskItem { Id = 2, Title = "مهمة ثانية", IsComplete = false }
        };

        public List<TaskItem> GetAll() => tasks;

        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        public TaskItem GetById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        // TODO: تنفيذ دالة حذف المهمة
        public void DeleteTask(int id)
{
    // استدعاء دالة الحذف في طبقة DataAccess
    repository.Delete(id);
}

        public void Delete(int id)
        {
            // ابحث عن المهمة باستخدام id
            var taskToRemove = tasks.FirstOrDefault(t => t.Id == id);

            // إذا كانت المهمة موجودة، قم بإزالتها من القائمة
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
            }
        }

    }
}
