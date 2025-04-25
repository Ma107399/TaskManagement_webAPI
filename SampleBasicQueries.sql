Use TaskManagementDB

SELECT * 
FROM TaskItems
WHERE AssignedToUserId = 2; -- Replace 2 with the user's ID


SELECT * 
FROM TaskComments
WHERE TaskId = 1; -- Replace 1 with the task's ID
