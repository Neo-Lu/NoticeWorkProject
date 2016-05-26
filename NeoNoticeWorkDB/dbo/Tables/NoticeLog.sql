CREATE TABLE [dbo].[NoticeLog] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [BeginTime]  DATETIME      NULL,
    [EndTime]    DATETIME      NULL,
    [TagID]      INT           NULL,
    [TagName]    NVARCHAR (50) NULL,
    [Remark]     NVARCHAR (50) NULL,
    [CreateTime] DATETIME      CONSTRAINT [DF_NoticeLog_CreateTime] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_NoticeLog] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'提醒日志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NoticeLog';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'标签ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NoticeLog', @level2type = N'COLUMN', @level2name = N'TagID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'标签', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NoticeLog', @level2type = N'COLUMN', @level2name = N'TagName';

