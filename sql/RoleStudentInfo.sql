CREATE TABLE [RoleStudentInfo]
( 
[RS_ID] int identity(1,1) PRIMARY KEY,    -- ����
[RO_ID] CHAR(36) ,        -- ��ɫid
[STU_ID]  CHAR(36), --ѧ��id
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --����ʱ��
foreign key([RO_ID] ) references [Role](R_ID ),
foreign key([STU_ID] ) references [Students](Stu_ID )
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'RS_ID'
exec sp_addextendedproperty N'MS_Description', N'��ɫid', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'RO_ID'
exec sp_addextendedproperty N'MS_Description', N'ѧ��id', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'STU_ID'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'RoleStudentInfo', N'column', N'CreateTime'
GO