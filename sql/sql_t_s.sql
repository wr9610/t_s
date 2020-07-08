INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('吕一', '001','151eb2e3d707adae4edee13710c8ee56',22,'女',GETDATE(),'重庆',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('冯晓菲', '002','a7efbd8dfba36837526c7496f7a70a22',23,'女',GETDATE(),'河南',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('蒋舒婷', '003','876807e992fa25079e98127ef838c6b6',18,'女',GETDATE(),'上海',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('普通学生', '学生',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('班长', '班级',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('部长', '学生会',GETDATE())

INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (3, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 4,GETDATE())

