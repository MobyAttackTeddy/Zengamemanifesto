
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/01/2017 13:47:11
-- Generated from EDMX file: C:\Users\musk0\onedrive\dokument\visual studio 2017\Projects\Zengamemanifesto\zengamemanifesto\Models\zengame.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BuyListBuyGrosierys]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BuyGrosierysSet] DROP CONSTRAINT [FK_BuyListBuyGrosierys];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookSet];
GO
IF OBJECT_ID(N'[dbo].[BuyGrosierysSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BuyGrosierysSet];
GO
IF OBJECT_ID(N'[dbo].[BuyListSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BuyListSet];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[FoodCategorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoodCategorySet];
GO
IF OBJECT_ID(N'[dbo].[Grosiery_KSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grosiery_KSet];
GO
IF OBJECT_ID(N'[dbo].[NutritionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NutritionSet];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[StartPagePostsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StartPagePostsSet];
GO
IF OBJECT_ID(N'[dbo].[VideoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VideoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int  NOT NULL,
    [BookTitle] nvarchar(max)  NULL,
    [ImgUrl] nvarchar(max)  NULL,
    [BuyUrl] nvarchar(max)  NULL,
    [PreviewUrl] nvarchar(max)  NULL,
    [AboutText] nvarchar(max)  NULL,
    [Price] nvarchar(max)  NULL
);
GO

-- Creating table 'StartPagePostsSet'
CREATE TABLE [dbo].[StartPagePostsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Heading] nvarchar(max)  NOT NULL,
    [TextHtml] nvarchar(max)  NOT NULL,
    [ImgLink] nvarchar(max)  NULL
);
GO

-- Creating table 'VideoSet'
CREATE TABLE [dbo].[VideoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Heading] nvarchar(max)  NOT NULL,
    [PreText] nvarchar(max)  NOT NULL,
    [EmbededUrl] nvarchar(max)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ImgUrl] nchar(100)  NULL
);
GO

-- Creating table 'Entity1Set'
CREATE TABLE [dbo].[Entity1Set] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [PasswordSalt] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StartPagePostsSet'
ALTER TABLE [dbo].[StartPagePostsSet]
ADD CONSTRAINT [PK_StartPagePostsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VideoSet'
ALTER TABLE [dbo].[VideoSet]
ADD CONSTRAINT [PK_VideoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entity1Set'
ALTER TABLE [dbo].[Entity1Set]
ADD CONSTRAINT [PK_Entity1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------