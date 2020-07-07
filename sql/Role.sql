CREATE TABLE [Role]
( 
[R_ID] int identity(1,1) PRIMARY KEY,    -- ����
[RoleName] VARCHAR(20) ,        -- ��ɫ����
[Remark] nvarchar(max) NOT NULL DEFAULT (N'��'), --��ע
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --����ʱ��
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Role', N'column', N'R_ID'
exec sp_addextendedproperty N'MS_Description', N'��ɫ����', N'user', N'dbo', N'table', N'Role', N'column', N'RoleName'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'Role', N'column', N'Remark'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Role', N'column', N'CreateTime'
GO