# RDIFramework生成流程笔记

1.首先power设计表，SQL代码生成

2.（测试）数据迁移，`insert into [db.list](*,*) select *,* from list`

3.codemarker 生成代码：建立SQL连接，项目属性县设置