namespace EmployeeAdministration.Models
{
    public class Repository
    {
        public Repository(EmployeeDBContext employeeContext, TaskDBContext taskContext) 
        {
            employee_context = employeeContext;
            task_context = taskContext;
        }

        public EmployeeDBContext employee_context { get; set; }
        public TaskDBContext task_context { get; set; }


        public List<Task> GetTasksOfEmployee(Employee employee)
        {
            var id = employee.Id;

            var employee_tasks = task_context.Tasks.Where(task => task.EmployeeId == id).ToList();

            return employee_tasks != null ? employee_tasks : new List<Task>() ;
        }
    }
}
