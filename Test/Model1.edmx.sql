
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/06/2016 19:26:13
-- Generated from EDMX file: C:\Users\A\documents\visual studio 2015\Projects\Test\Test\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ESN3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Friends__Profile__3B40CD36]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Friends] DROP CONSTRAINT [FK__Friends__Profile__3B40CD36];
GO
IF OBJECT_ID(N'[dbo].[FK_Photobooks_PhotobookId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Images] DROP CONSTRAINT [FK_Photobooks_PhotobookId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Messages_dbo_Profiles_from]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_dbo_Messages_dbo_Profiles_from];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Messages_dbo_Profiles_to]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_dbo_Messages_dbo_Profiles_to];
GO
IF OBJECT_ID(N'[dbo].[FK__Profiles__Profil__3A4CA8FD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profiles] DROP CONSTRAINT [FK__Profiles__Profil__3A4CA8FD];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Talks_dbo_Profile_Profile1Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Talks] DROP CONSTRAINT [FK_dbo_Talks_dbo_Profile_Profile1Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Talks_dbo_Profile_Profile2Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Talks] DROP CONSTRAINT [FK_dbo_Talks_dbo_Profile_Profile2Id];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[Content]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Content];
GO
IF OBJECT_ID(N'[dbo].[Dislikes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dislikes];
GO
IF OBJECT_ID(N'[dbo].[Friends]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Friends];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Likes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Likes];
GO
IF OBJECT_ID(N'[dbo].[Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Messages];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[Photobooks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photobooks];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[dbo].[Talks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Talks];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [CommentId] uniqueidentifier  NOT NULL,
    [ProfileId] uniqueidentifier  NOT NULL,
    [creationTime] datetime  NOT NULL,
    [text] nvarchar(max)  NOT NULL,
    [TargetId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Content'
CREATE TABLE [dbo].[Content] (
    [ContentId] uniqueidentifier  NOT NULL,
    [type] nvarchar(50)  NULL,
    [annotation] nvarchar(50)  NULL
);
GO

-- Creating table 'Dislikes'
CREATE TABLE [dbo].[Dislikes] (
    [DislikeId] uniqueidentifier  NOT NULL,
    [ProfileId] uniqueidentifier  NOT NULL,
    [TargetId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Friends'
CREATE TABLE [dbo].[Friends] (
    [FriendId] int  NOT NULL,
    [ProfileId] uniqueidentifier  NOT NULL,
    [subscriberId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [ImageId] uniqueidentifier  NOT NULL,
    [PhotobookId] uniqueidentifier  NULL,
    [ImageData] varbinary(max)  NULL,
    [ImageMimeType] nvarchar(50)  NULL,
    [fileName] nvarchar(50)  NULL,
    [DateOfLoad] datetime  NULL
);
GO

-- Creating table 'Likes'
CREATE TABLE [dbo].[Likes] (
    [LikeId] uniqueidentifier  NOT NULL,
    [NewsId] uniqueidentifier  NULL,
    [ProfileId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [MessageId] uniqueidentifier  NOT NULL,
    [from] uniqueidentifier  NOT NULL,
    [to] uniqueidentifier  NOT NULL,
    [creationTime] datetime  NOT NULL,
    [text] nvarchar(max)  NULL,
    [TalkId] uniqueidentifier  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [NewsId] uniqueidentifier  NOT NULL,
    [ProfileId] uniqueidentifier  NULL,
    [creationTime] datetime  NOT NULL,
    [theme] nvarchar(max)  NULL
);
GO

-- Creating table 'Photobooks'
CREATE TABLE [dbo].[Photobooks] (
    [PhotobookId] uniqueidentifier  NOT NULL,
    [ProfileId] uniqueidentifier  NULL,
    [Title] nvarchar(50)  NOT NULL,
    [viewForFriend] int  NOT NULL,
    [viewForAll] int  NOT NULL
);
GO

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
    [ProfileId] uniqueidentifier  NOT NULL,
    [fName] nvarchar(50)  NULL,
    [dob] datetime  NULL,
    [Gender] nvarchar(50)  NULL,
    [ImageData] varbinary(max)  NULL,
    [ImageMimeType] nvarchar(50)  NULL,
    [lName] nvarchar(50)  NULL,
    [mName] nvarchar(50)  NULL,
    [AvatarImageId] uniqueidentifier  NULL,
    [country] nvarchar(50)  NULL,
    [language] nvarchar(50)  NULL,
    [Annotation] nvarchar(max)  NULL
);
GO

-- Creating table 'Talks'
CREATE TABLE [dbo].[Talks] (
    [TalkId] uniqueidentifier  NOT NULL,
    [Profile1Id] uniqueidentifier  NOT NULL,
    [Profile2Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] uniqueidentifier  NOT NULL,
    [login] nvarchar(50)  NULL,
    [password] nvarchar(50)  NULL,
    [email] nvarchar(50)  NULL,
    [role] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CommentId] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- Creating primary key on [ContentId] in table 'Content'
ALTER TABLE [dbo].[Content]
ADD CONSTRAINT [PK_Content]
    PRIMARY KEY CLUSTERED ([ContentId] ASC);
GO

-- Creating primary key on [DislikeId] in table 'Dislikes'
ALTER TABLE [dbo].[Dislikes]
ADD CONSTRAINT [PK_Dislikes]
    PRIMARY KEY CLUSTERED ([DislikeId] ASC);
GO

-- Creating primary key on [FriendId] in table 'Friends'
ALTER TABLE [dbo].[Friends]
ADD CONSTRAINT [PK_Friends]
    PRIMARY KEY CLUSTERED ([FriendId] ASC);
GO

-- Creating primary key on [ImageId] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([ImageId] ASC);
GO

-- Creating primary key on [LikeId] in table 'Likes'
ALTER TABLE [dbo].[Likes]
ADD CONSTRAINT [PK_Likes]
    PRIMARY KEY CLUSTERED ([LikeId] ASC);
GO

-- Creating primary key on [MessageId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([MessageId] ASC);
GO

-- Creating primary key on [NewsId] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([NewsId] ASC);
GO

-- Creating primary key on [PhotobookId] in table 'Photobooks'
ALTER TABLE [dbo].[Photobooks]
ADD CONSTRAINT [PK_Photobooks]
    PRIMARY KEY CLUSTERED ([PhotobookId] ASC);
GO

-- Creating primary key on [ProfileId] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([ProfileId] ASC);
GO

-- Creating primary key on [TalkId] in table 'Talks'
ALTER TABLE [dbo].[Talks]
ADD CONSTRAINT [PK_Talks]
    PRIMARY KEY CLUSTERED ([TalkId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProfileId] in table 'Friends'
ALTER TABLE [dbo].[Friends]
ADD CONSTRAINT [FK__Friends__Profile__3B40CD36]
    FOREIGN KEY ([ProfileId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Friends__Profile__3B40CD36'
CREATE INDEX [IX_FK__Friends__Profile__3B40CD36]
ON [dbo].[Friends]
    ([ProfileId]);
GO

-- Creating foreign key on [PhotobookId] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_Photobooks_PhotobookId]
    FOREIGN KEY ([PhotobookId])
    REFERENCES [dbo].[Photobooks]
        ([PhotobookId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Photobooks_PhotobookId'
CREATE INDEX [IX_FK_Photobooks_PhotobookId]
ON [dbo].[Images]
    ([PhotobookId]);
GO

-- Creating foreign key on [from] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_dbo_Messages_dbo_Profiles_from]
    FOREIGN KEY ([from])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Messages_dbo_Profiles_from'
CREATE INDEX [IX_FK_dbo_Messages_dbo_Profiles_from]
ON [dbo].[Messages]
    ([from]);
GO

-- Creating foreign key on [to] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_dbo_Messages_dbo_Profiles_to]
    FOREIGN KEY ([to])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Messages_dbo_Profiles_to'
CREATE INDEX [IX_FK_dbo_Messages_dbo_Profiles_to]
ON [dbo].[Messages]
    ([to]);
GO

-- Creating foreign key on [ProfileId] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [FK__Profiles__Profil__3A4CA8FD]
    FOREIGN KEY ([ProfileId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Profile1Id] in table 'Talks'
ALTER TABLE [dbo].[Talks]
ADD CONSTRAINT [FK_dbo_Talks_dbo_Profile_Profile1Id]
    FOREIGN KEY ([Profile1Id])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Talks_dbo_Profile_Profile1Id'
CREATE INDEX [IX_FK_dbo_Talks_dbo_Profile_Profile1Id]
ON [dbo].[Talks]
    ([Profile1Id]);
GO

-- Creating foreign key on [Profile2Id] in table 'Talks'
ALTER TABLE [dbo].[Talks]
ADD CONSTRAINT [FK_dbo_Talks_dbo_Profile_Profile2Id]
    FOREIGN KEY ([Profile2Id])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Talks_dbo_Profile_Profile2Id'
CREATE INDEX [IX_FK_dbo_Talks_dbo_Profile_Profile2Id]
ON [dbo].[Talks]
    ([Profile2Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------