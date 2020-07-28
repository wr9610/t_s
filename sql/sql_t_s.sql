--学生姓名测试数据添加
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('吕一', '001','151eb2e3d707adae4edee13710c8ee56',22,'女',GETDATE(),'重庆',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('冯晓菲', '002','a7efbd8dfba36837526c7496f7a70a22',23,'女',GETDATE(),'河南',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('蒋舒婷', '003','876807e992fa25079e98127ef838c6b6',18,'女',GETDATE(),'上海',GETDATE())
--角色表测试信息添加
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('普通学生', '学生',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('班长', '班级',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('部长', '学生会',GETDATE())
--学生角色测试信息添加
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (3, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 4,GETDATE())
--菜单表测试信息添加

INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('学生管理', 0,'','',0,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('系统管理', 0,'','',0,2,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('教师管理', 0,'','',0,3,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('教务管理', 0,'','',1,4,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime],[TMDesp]) VALUES('退出系统', 0,'','',1,5,1,'admin', GETDATE(),'ExitSystem')
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime],[TMDesp]) VALUES('更换用户', 0,'','',1,6,1,'admin', GETDATE(),'ChangeActor')
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('成绩查询', 13,'','',1,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('学生查询', 16,'','',1,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('成绩录入', 16,'','',1,2,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('班级管理', 16,'','',1,3,1,'admin', GETDATE())


--菜单角色表测试信息添加
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 1,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 4,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 5,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 6,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (1, 1,GETDATE())

DELETE FROM RoleMenuInfo
DELETE FROM menu
