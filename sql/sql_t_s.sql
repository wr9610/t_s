INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('��һ', '001','151eb2e3d707adae4edee13710c8ee56',22,'Ů',GETDATE(),'����',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('������', '002','a7efbd8dfba36837526c7496f7a70a22',23,'Ů',GETDATE(),'����',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('������', '003','876807e992fa25079e98127ef838c6b6',18,'Ů',GETDATE(),'�Ϻ�',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('��ͨѧ��', 'ѧ��',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('�೤', '�༶',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('����', 'ѧ����',GETDATE())

INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (3, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 4,GETDATE())

