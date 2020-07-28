CREATE TABLE [Menu]
( 
[M_ID] int identity(1,1) PRIMARY KEY,    -- 主键
[Menu_Name] VARCHAR(20) ,        -- 菜单名称
[ParentId] int ,--父级ID
[ParentName] VARCHAR(100) ,--父级名称
[MKey] VARCHAR(100) ,--
[MUrl] VARCHAR(max) NOT NULL DEFAULT (N'无') ,--菜单路径
[IsTop] int ,--层级
[MOrder] int ,--菜单分类
[IsDeleted] int ,--是否删除 
[Creator] VARCHAR(max) ,--创建人
[Remark] VARCHAR(max) NOT NULL DEFAULT (N'无'), --备注
[TMDesp] VARCHAR(max) NOT NULL DEFAULT (N'无'), --特殊菜单
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --创建时间
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'主键', N'user', N'dbo', N'table', N'Menu', N'column', N'M_ID'
exec sp_addextendedproperty N'MS_Description', N'菜单名称', N'user', N'dbo', N'table', N'Menu', N'column', N'Menu_Name'
exec sp_addextendedproperty N'MS_Description', N'父级ID', N'user', N'dbo', N'table', N'Menu', N'column', N'ParentId'
exec sp_addextendedproperty N'MS_Description', N'父级名称', N'user', N'dbo', N'table', N'Menu', N'column', N'ParentName'
exec sp_addextendedproperty N'MS_Description', N'菜单路径', N'user', N'dbo', N'table', N'Menu', N'column', N'MUrl'
exec sp_addextendedproperty N'MS_Description', N'层级', N'user', N'dbo', N'table', N'Menu', N'column', N'IsTop'
exec sp_addextendedproperty N'MS_Description', N'菜单分类', N'user', N'dbo', N'table', N'Menu', N'column', N'MOrder'
exec sp_addextendedproperty N'MS_Description', N'是否删除', N'user', N'dbo', N'table', N'Menu', N'column', N'IsDeleted'
exec sp_addextendedproperty N'MS_Description', N'创建人', N'user', N'dbo', N'table', N'Menu', N'column', N'Creator'
exec sp_addextendedproperty N'MS_Description', N'备注', N'user', N'dbo', N'table', N'Menu', N'column', N'Remark'
exec sp_addextendedproperty N'MS_Description', N'特殊菜单', N'user', N'dbo', N'table', N'Menu', N'column', N'TMDesp'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Menu', N'column', N'CreateTime'
GO