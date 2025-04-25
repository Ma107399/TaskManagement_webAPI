using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPIZimozi.Model
{
    public class TaskItemModel
    {
        public int Id { get; set; }                        // Primary Key

        [MaxLength(100)]
        public required string Title { get; set; }                  // Title of the task

        [MaxLength(500)]
        public string? Description { get; set; }            // I am just putting descrition as nullable for now
        public required int AssignedToUserId { get; set; }          // Foreign key to User
        public DateTime DateCreated { get; set; }            // Timestamp when task was created
    }
}
