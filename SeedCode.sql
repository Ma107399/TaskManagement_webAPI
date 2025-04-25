-- Seed Users
INSERT INTO TaskManagementDB..Users (Username, Role) VALUES ('Jane Doe', 'Admin'), ('John Doe', 'User');

-- Seed Tasks
INSERT INTO TaskManagementDB..TaskItems (Title, Description, AssignedToUserId,DateCreated) 
VALUES ( 'Sample Task', 'This task is for testing purposes.', 2, GETDATE());

-- Seed Comments
INSERT INTO TaskManagementDB..TaskComments (TaskId, UserId, Comment, DateCommented) 
VALUES ( 1, 2, 'Looks good.', GETDATE());
