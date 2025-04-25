public class TaskService
{
    private readonly DbContext _dbContext;

    public TaskService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Method to get a single task by its ID
    // CHANGES MADE:
    // 1. Added 'async' keyword — because we are calling an asynchronous method.Since you're awaiting an async method, your method should also be async.
    // 2. Changed return type from Task<Task> to Task<TaskItem> — because Task is a built-in class in C# and using it as a model name creates confusion.
    // 3. Used '_dbContext.Set<TaskItem>()' instead of '_dbContext.Tasks' — safer generic way in case Tasks is not directly declared as a DbSet property.
    // 4. Used 'await' with FirstOrDefaultAsync() — ToListAsync() is async, so you must await it.async methods must be awaited to get the result.
    public async Task<TaskItem> GetTask(int id)
    {
        try
        {
            return await _dbContext.Set<TaskItem>().FirstOrDefaultAsync(t => t.Id == id);
        }
        catch (Exception ex)
        {
           
            return null; // Return null if something goes wrong
        }
    }

    // Method to get a list of all tasks
    // CHANGES MADE:
    // 1. Added 'async' keyword — because ToListAsync() is an async method.
    // 2. Changed return type from List<Task> to Task<List<TaskItem>> — we need to wrap the result in Task<> because of async.
    // 3. Used 'await' — to properly execute and wait for the async result.
    // 4. Used '_dbContext.Set<TaskItem>()' instead of '_dbContext.Tasks' — more general way to access the DbSet for TaskItem.
    public async Task<List<TaskItem>> GetAllTasks()
    {
        try
        {
            return await _dbContext.Set<TaskItem>().ToListAsync();
        }
        catch (Exception ex)
        {
            
            return new List<TaskItem>(); // Return empty list on failure
        }
    }
}
