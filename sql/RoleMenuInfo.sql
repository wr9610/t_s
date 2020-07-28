CREATE TABLE [RoleMenuInfo]
( 
[RM_ID] int identity(1,1) PRIMARY KEY,    -- 主键
[RO_ID] int ,        -- 角色id
[Me_ID]  int, --菜单id
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --创建时间
foreign key([RO_ID] ) references [Role](R_ID ),
foreign key([Me_ID] ) references [Menu](M_ID )
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'主键', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'RM_ID'
exec sp_addextendedproperty N'MS_Description', N'角色id', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'RO_ID'
exec sp_addextendedproperty N'MS_Description', N'菜单id', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'Me_ID'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'CreateTime'
GO