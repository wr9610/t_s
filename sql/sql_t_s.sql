--ѧ�����������������
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('��һ', '001','151eb2e3d707adae4edee13710c8ee56',22,'Ů',GETDATE(),'����',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('������', '002','a7efbd8dfba36837526c7496f7a70a22',23,'Ů',GETDATE(),'����',GETDATE())
INSERT INTO [Students] ([Name], [Student_Number],[Psw],[Age],[gender],[birthday],[address],[CreateTime]) VALUES ('������', '003','876807e992fa25079e98127ef838c6b6',18,'Ů',GETDATE(),'�Ϻ�',GETDATE())
--��ɫ�������Ϣ���
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('��ͨѧ��', 'ѧ��',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('�೤', '�༶',GETDATE())
INSERT INTO [Role] ([RoleName], [Remark],[CreateTime]) VALUES ('����', 'ѧ����',GETDATE())
--ѧ����ɫ������Ϣ���
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (3, 2,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleStudentInfo] ([RO_ID], [STU_ID],[CreateTime]) VALUES (1, 4,GETDATE())
--�˵��������Ϣ���

INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('ѧ������', 0,'','',0,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('ϵͳ����', 0,'','',0,2,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('��ʦ����', 0,'','',0,3,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('�������', 0,'','',1,4,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime],[TMDesp]) VALUES('�˳�ϵͳ', 0,'','',1,5,1,'admin', GETDATE(),'ExitSystem')
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime],[TMDesp]) VALUES('�����û�', 0,'','',1,6,1,'admin', GETDATE(),'ChangeActor')
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('�ɼ���ѯ', 13,'','',1,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('ѧ����ѯ', 16,'','',1,1,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('�ɼ�¼��', 16,'','',1,2,1,'admin', GETDATE())
INSERT INTO[Menu] ([Menu_Name], [ParentId],[ParentName],[MKey],[IsTop],[MOrder],[IsDeleted],[Creator],[CreateTime]) VALUES('�༶����', 16,'','',1,3,1,'admin', GETDATE())


--�˵���ɫ�������Ϣ���
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 1,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 2,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 3,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 4,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 5,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (2, 6,GETDATE())
INSERT INTO [RoleMenuInfo] ([RO_ID], [Me_ID],[CreateTime]) VALUES (1, 1,GETDATE())

DELETE FROM RoleMenuInfo
DELETE FROM menu
