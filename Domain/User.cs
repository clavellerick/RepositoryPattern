using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain
{
    public class User: IIdentityEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private ICollection<TaskToDo> _taskToDo { get; set; }

        public virtual IReadOnlyCollection<TaskToDo> TasksToDo { get { return _taskToDo as Collection<TaskToDo>;  } }

        public User()
        {
            this._taskToDo = new Collection<TaskToDo>();
        }

        public void AddItemToDo(TaskToDo taskToDo)
        {
            _taskToDo.Add(taskToDo);
        }
    }
}
