using Context.Razor.Context;
using Machine.Razor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Machine.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly AppDbContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger,AppDbContext appDbContext)
        {
            _logger = logger;
            _dbContext = appDbContext;
        }
        [BindProperty]
        public TaskVm TaskVm { get; set; } = new TaskVm();
        public void OnGet()
        {
            TaskVm.AddTask.Users = _dbContext.Users.ToList();
            TaskVm.TaskList = _dbContext.UsersTask.Where(x => x.IsActive == 1).ToList();
        }
        public IActionResult OnPostAddTaskManage()
        {
            UserTaskModel userTaskModel = new UserTaskModel()
            {
                UserId = TaskVm.AddTask.UserId,
                TaskDesc = TaskVm.AddTask.TaskDesc,
                TaskExpiryDate = TaskVm.AddTask.TaskExpiryDate,
                Important = (byte)(TaskVm.AddTask.Important == true ? 1 : 0),
                CreatedAt = DateTime.Now,
                IsActive = 1,
                IsDelete = 0
            };
            var result = _dbContext.UsersTask.Add(userTaskModel);
            _dbContext.SaveChanges();
            return Redirect("/");
        }
    }
}