using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPIZimozi.Model
{
    public class TaskComment
    {
        public int Id { get; set; }                // Primary Key for the comments table
        public required int TaskId { get; set; }            // FK to TaskItem to which this comment belongs to
        public required int UserId { get; set; }            // FK to User

        [MaxLength(300)]
        public required string Comment { get; set; }        // Comment body
        public DateTime DateCommented { get; set; }
    }
}
