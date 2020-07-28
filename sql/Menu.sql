CREATE TABLE [Menu]
( 
[M_ID] int identity(1,1) PRIMARY KEY,    -- ����
[Menu_Name] VARCHAR(20) ,        -- �˵�����
[ParentId] int ,--����ID
[ParentName] VARCHAR(100) ,--��������
[MKey] VARCHAR(100) ,--
[MUrl] VARCHAR(max) NOT NULL DEFAULT (N'��') ,--�˵�·��
[IsTop] int ,--�㼶
[MOrder] int ,--�˵�����
[IsDeleted] int ,--�Ƿ�ɾ�� 
[Creator] VARCHAR(max) ,--������
[Remark] VARCHAR(max) NOT NULL DEFAULT (N'��'), --��ע
[TMDesp] VARCHAR(max) NOT NULL DEFAULT (N'��'), --����˵�
[CreateTime] date NOT NULL DEFAULT (N'sysdate'),  --����ʱ��
) ON [PRIMARY]
GO

exec sp_addextendedproperty N'MS_Description', N'����', N'user', N'dbo', N'table', N'Menu', N'column', N'M_ID'
exec sp_addextendedproperty N'MS_Description', N'�˵�����', N'user', N'dbo', N'table', N'Menu', N'column', N'Menu_Name'
exec sp_addextendedproperty N'MS_Description', N'����ID', N'user', N'dbo', N'table', N'Menu', N'column', N'ParentId'
exec sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'Menu', N'column', N'ParentName'
exec sp_addextendedproperty N'MS_Description', N'�˵�·��', N'user', N'dbo', N'table', N'Menu', N'column', N'MUrl'
exec sp_addextendedproperty N'MS_Description', N'�㼶', N'user', N'dbo', N'table', N'Menu', N'column', N'IsTop'
exec sp_addextendedproperty N'MS_Description', N'�˵�����', N'user', N'dbo', N'table', N'Menu', N'column', N'MOrder'
exec sp_addextendedproperty N'MS_Description', N'�Ƿ�ɾ��', N'user', N'dbo', N'table', N'Menu', N'column', N'IsDeleted'
exec sp_addextendedproperty N'MS_Description', N'������', N'user', N'dbo', N'table', N'Menu', N'column', N'Creator'
exec sp_addextendedproperty N'MS_Description', N'��ע', N'user', N'dbo', N'table', N'Menu', N'column', N'Remark'
exec sp_addextendedproperty N'MS_Description', N'����˵�', N'user', N'dbo', N'table', N'Menu', N'column', N'TMDesp'
exec sp_addextendedproperty N'MS_Description', N'����ʱ��', N'user', N'dbo', N'table', N'Menu', N'column', N'CreateTime'
GO