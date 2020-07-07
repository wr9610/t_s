CREATE TABLE [Role]
( 
[R_ID] int identity(1,1) PRIMARY KEY,    -- 主键
[RoleName] VARCHAR(20) ,        -- 角色名称
[Remark] nvarchar(max) NOT NULL DEFAULT (N'无'), --备注
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --创建时间
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'主键', N'user', N'dbo', N'table', N'Role', N'column', N'R_ID'
exec sp_addextendedproperty N'MS_Description', N'角色名称', N'user', N'dbo', N'table', N'Role', N'column', N'RoleName'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'Role', N'column', N'Remark'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Role', N'column', N'CreateTime'
GO