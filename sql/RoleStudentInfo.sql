CREATE TABLE [RoleStudentInfo]
( 
[RS_ID] int identity(1,1) PRIMARY KEY,    -- 主键
[RO_ID] int ,        -- 角色id
[STU_ID]  int, --学生id
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --创建时间
foreign key([RO_ID] ) references [Role](R_ID ),
foreign key([STU_ID] ) references [Students](Stu_ID )
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'主键', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'RS_ID'
exec sp_addextendedproperty N'MS_Description', N'角色id', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'RO_ID'
exec sp_addextendedproperty N'MS_Description', N'学生id', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'STU_ID'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'CreateTime'
GO