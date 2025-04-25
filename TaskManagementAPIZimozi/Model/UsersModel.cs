namespace TaskManagementAPIZimozi.Model
{
    public class UsersModel
    {
        public int Id { get; set; }                 // Primary Key
        public required string Username { get; set; }        // Unique username for login/display
        public required string UserRole { get; set; }            // "Admin" or "User"
    }
}
