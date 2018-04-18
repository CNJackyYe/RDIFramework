# RDIFramework生成流程笔记

### 2.代码生成器生成项目代码

1.首先power设计表，SQL代码生成

2.（测试）数据迁移，`insert into [db.list](*,*) select *,* from list`

3.codemarker 生成代码：建立SQL连接，设置项目属性及项目名称

4.在项目下新建一个类库，调整生成到默认目录下。把生成代码复制到类库，调整目录结构（把实体类分文件夹放）。

5.引用类库，Iserver 和service不一定需要

6.生成的业务代码部署到服务中，通过iis的方式，把新项目里的service文件夹的cs文件引用到SOA项目里面。`具体步骤 in web.config add <server> *** </server> change namespace `

7.在SOA里添加引用，添加一个服务

8.调试bug

```c#
public ActionResult GridPageListJson(int page = 1, int rows = 20, string sort = "ID", string order = "desc", string filter = "")
//修改参数调整排列标志sort
```

```c#
public string AddEntity(testdemoEntity testdemoEntity)
        {
            string sequence = string.Empty;
            SQLBuilder sqlBuilder = new SQLBuilder(DBProvider, this.Identity, this.ReturnId);
            sqlBuilder.BeginInsert(this.CurrentTableName, testdemoTable.FieldID);
//修改添加实体
```

```c#
IDbProvider dbProvider
        {
            get
            {  return DbFactoryProvider.GetProvider(SystemInfo.HisDbType,SystemInfo.HisDbConnection);
            //调整数据库字段
            }
        }
```

### 3.基于代码生成器生成MvcUI

1.直接选择表，生成代码

