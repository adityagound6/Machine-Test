using Context.Razor.Context;

namespace Machine.Razor.ViewModel
{
    public class TaskVm
    {
        public AddTaskVm AddTask { get; set; } = new AddTaskVm();
        public List<UserTaskModel>? TaskList { get; set; }
    }
}
