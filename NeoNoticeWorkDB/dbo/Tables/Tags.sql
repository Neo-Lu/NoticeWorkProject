CREATE TABLE [dbo].[Tags] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    [Sort] INT           NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'标签表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tags';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'标签名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tags', @level2type = N'COLUMN', @level2name = N'Name';

