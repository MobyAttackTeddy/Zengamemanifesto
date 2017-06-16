
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/10/2017 11:26:41
-- Generated from EDMX file: C:\Users\musk0\onedrive\dokument\visual studio 2017\Projects\Zengamemanifesto\zengamemanifesto\Models\zengame.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Zengamemanifesto.Models.ZenDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[StartPagePostsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StartPagePostsSet];
GO
IF OBJECT_ID(N'[dbo].[BookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StartPagePostsSet'
CREATE TABLE [dbo].[StartPagePostsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Heading] nvarchar(max)  NOT NULL,
    [TextHtml] nvarchar(max)  NOT NULL,
    [ImgLink] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BookTitle] nvarchar(max)  NOT NULL,
    [ImgUrl] nvarchar(max)  NOT NULL,
    [BuyUrl] nvarchar(max)  NOT NULL,
    [PreviewUrl] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StartPagePostsSet'
ALTER TABLE [dbo].[StartPagePostsSet]
ADD CONSTRAINT [PK_StartPagePostsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------