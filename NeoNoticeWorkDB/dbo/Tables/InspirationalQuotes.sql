CREATE TABLE [dbo].[InspirationalQuotes] (
    [ID]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (500) NULL,
    CONSTRAINT [PK_InspirationalQuotes] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'励志语录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'InspirationalQuotes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'励志语录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'InspirationalQuotes', @level2type = N'COLUMN', @level2name = N'Name';

