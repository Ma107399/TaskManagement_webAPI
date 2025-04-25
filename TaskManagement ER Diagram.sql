CREATE TABLE [Users] (
  [Id] int PRIMARY KEY,
  [Username] nvarchar(255),
  [UserRole] nvarchar(255)
)
GO

CREATE TABLE [TaskItems] (
  [Id] int PRIMARY KEY,
  [Title] nvarchar(255),
  [Description] nvarchar(255),
  [AssignedToUserId] int,
  [DateCreated] datetime
)
GO

CREATE TABLE [TaskComments] (
  [Id] int PRIMARY KEY,
  [TaskId] int,
  [UserId] int,
  [Comment] nvarchar(255),
  [DateCommented] datetime
)
GO

ALTER TABLE [TaskItems] ADD FOREIGN KEY ([AssignedToUserId]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [TaskComments] ADD FOREIGN KEY ([TaskId]) REFERENCES [TaskItems] ([Id])
GO

ALTER TABLE [TaskComments] ADD FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
GO
