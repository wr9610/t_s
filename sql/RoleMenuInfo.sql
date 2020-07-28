CREATE TABLE [RoleMenuInfo]
( 
[RM_ID] int identity(1,1) PRIMARY KEY,    -- ����
[RO_ID] int ,        -- ��ɫid
[Me_ID]  int, --�˵�id
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --����ʱ��
foreign key([RO_ID] ) references [Role](R_ID ),
foreign key([Me_ID] ) references [Menu](M_ID )
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'RM_ID'
exec sp_addextendedproperty N'MS_Description', N'��ɫid', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'RO_ID'
exec sp_addextendedproperty N'MS_Description', N'�˵�id', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'Me_ID'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'RoleMenuInfo', N'column', N'CreateTime'
GO