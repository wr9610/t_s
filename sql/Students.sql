CREATE TABLE [Students]
( 
[Stu_ID] int identity(1,1) PRIMARY KEY,    -- 主键
[Name] VARCHAR(20) ,        -- 姓名
[Student_Number] VARCHAR(100) ,  --学号
[Psw] VARCHAR(100),            --  登录密码 
[Age] int,    -- 年龄
[gender] nvarchar(max) NOT NULL DEFAULT (N'无'), --性别
[birthday] date NOT NULL DEFAULT (N'1900-01-01'),  --生日
[address] nvarchar(max) NOT NULL DEFAULT (N'无'),--地址
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --创建时间
  CHECK ([gender]=N'男' OR [gender]=N'女' OR [gender]=N'无')
) ON [PRIMARY]
GO
 

exec sp_addextendedproperty N'MS_Description', N'主键', N'user', N'dbo', N'table', N'Students', N'column', N'Stu_ID'
exec sp_addextendedproperty N'MS_Description', N'姓名', N'user', N'dbo', N'table', N'Students', N'column', N'Name'
exec sp_addextendedproperty N'MS_Description', N'学号', N'user', N'dbo', N'table', N'Students', N'column', N'Student_Number'
exec sp_addextendedproperty N'MS_Description', N'登录密码', N'user', N'dbo', N'table', N'Students', N'column', N'Psw'
exec sp_addextendedproperty N'MS_Description', N'年龄', N'user', N'dbo', N'table', N'Students', N'column', N'Age'
exec sp_addextendedproperty N'MS_Description', N'性别', N'user', N'dbo', N'table', N'Students', N'column', N'gender'
exec sp_addextendedproperty N'MS_Description', N'生日，数据取T_PERIODICAL', N'user', N'dbo', N'table', N'Students', N'column', N'birthday'
exec sp_addextendedproperty N'MS_Description', N'地址', N'user', N'dbo', N'table', N'Students', N'column', N'address'
exec sp_addextendedproperty N'MS_Description', N'创建时间', N'user', N'dbo', N'table', N'Students', N'column', N'CreateTime'
GO