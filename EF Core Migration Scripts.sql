IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [TaskComments] (
    [Id] int NOT NULL IDENTITY,
    [TaskId] int NOT NULL,
    [UserId] int NOT NULL,
    [Comment] nvarchar(max) NULL,
    [DateCommented] datetime2 NOT NULL,
    CONSTRAINT [PK_TaskComments] PRIMARY KEY ([Id])
);

CREATE TABLE [TaskItems] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    [AssignedToUserId] int NOT NULL,
    [DateCreated] datetime2 NOT NULL,
    CONSTRAINT [PK_TaskItems] PRIMARY KEY ([Id])
);

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [Role] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250424143930_First Migration', N'9.0.4');

COMMIT;
GO

