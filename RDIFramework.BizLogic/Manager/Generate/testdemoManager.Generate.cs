#region RDIFramework.NET-generated
//------------------------------------------------------------------------------
//	RDIFramework.NET，是基于.NET的快速信息化系统开发、整合框架，给用户和开发者最佳的.Net框架部署方案。
//	RDIFramework.NET平台包含基础公共类库、强大的权限控制、模块分配、数据字典、自动升级、各商业级控件库、工作流平台、代码生成器、开发辅助
//工具等，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子功能模块按照业务功能组织成单独的程序集文
//件，各子系统开发完成后，由RDIFramework.NET平台进行统一的集成部署。
//
// 框架官网：http://www.rdiframework.net/
// 框架博客：http://blog.rdiframework.net/
// 交流QQ：406590790 
// 邮件交流：406590790@qq.com
// 其他博客：
//      http://www.cnblogs.com/huyong 
//      http://blog.csdn.net/chinahuyong
//------------------------------------------------------------------------------
// <auto-generated>
//	此代码由RDIFramework.NET平台代码生成工具自动生成。
//	运行时版本:4.0.30319.1
//
//	对此文件的更改可能会导致不正确的行为，并且如果
//	重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace RDIFramework.BizLogic
{
    using RDIFramework.BizLogic;
    using RDIFramework.Utilities;

    /// <summary>
    /// testdemoManager
    /// 
    /// 
    /// 修改纪录
    /// 
    /// 2018-04-18 版本：1.0  创建主键。
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    /// <name></name>
    /// <date>2018-04-18</date>
    /// </author>
    /// </summary>
    public partial class testdemoManager : DbCommonManager
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public testdemoManager()
        {
            base.CurrentTableName = testdemoTable.TableName;
            base.PrimaryKey = "ID";
        }

        /// <summary>
        /// 构造函数
        /// <param name="tableName">指定表名</param>
        /// </summary>
        public testdemoManager(string tableName)
        {
            base.CurrentTableName = tableName;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbProvider">数据库连接</param>
        public testdemoManager(IDbProvider dbProvider): this()
        {
            DBProvider = dbProvider;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        public testdemoManager(UserInfo userInfo) : this()
        {
            UserInfo = userInfo;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbProvider">数据库连接</param>
        /// <param name="userInfo">用户信息</param>
        public testdemoManager(IDbProvider dbProvider, UserInfo userInfo) : this(dbProvider)
        {
            UserInfo = userInfo;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbProvider">数据库连接</param>
        /// <param name="userInfo">用户信息</param>
        /// <param name="tableName">指定表名</param>
        public testdemoManager(IDbProvider dbProvider, UserInfo userInfo, string tableName) : this(dbProvider, userInfo)
        {
            base.CurrentTableName = tableName;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="testdemoEntity">实体</param>
        /// <returns>主键</returns>
        public string Add(testdemoEntity testdemoEntity)
        {
            return this.AddEntity(testdemoEntity);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="testdemoEntity">实体</param>
        /// <param name="identity">自增量方式</param>
        /// <param name="returnId">返回主键</param>
        /// <returns>主键</returns>
        public string Add(testdemoEntity testdemoEntity, bool identity, bool returnId)
        {
            this.Identity = identity;
            this.ReturnId = returnId;
            return this.AddEntity(testdemoEntity);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="testdemoEntity">实体</param>
        public int Update(testdemoEntity testdemoEntity)
        {
            return this.UpdateEntity(testdemoEntity);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id">主键</param>
        public testdemoEntity GetEntity(string id)
        {
            return GetEntity(int.Parse(id));
        }

        public testdemoEntity GetEntity(int id)
        {
            return BaseEntity.Create<testdemoEntity>(this.GetDT(testdemoTable.FieldID, id));
        }

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="testdemoEntity">实体</param>
        public string AddEntity(testdemoEntity testdemoEntity)
        {
            string sequence = string.Empty;
            SQLBuilder sqlBuilder = new SQLBuilder(DBProvider, this.Identity, this.ReturnId);
            sqlBuilder.BeginInsert(this.CurrentTableName, testdemoTable.FieldID);
            if (!this.Identity) 
            {
                sqlBuilder.SetValue(testdemoTable.FieldID, testdemoEntity.ID);
            }
            else
            {
                if (!this.ReturnId && (DBProvider.CurrentDbType == CurrentDbType.Oracle || DBProvider.CurrentDbType == CurrentDbType.DB2))
                {
                    if (DBProvider.CurrentDbType == CurrentDbType.Oracle)
                    {
                        sqlBuilder.SetFormula(testdemoTable.FieldID, "SEQ_" + this.CurrentTableName.ToUpper() + ".NEXTVAL ");
                    }
                    if (DBProvider.CurrentDbType == CurrentDbType.DB2)
                    {
                        sqlBuilder.SetFormula(testdemoTable.FieldID, "NEXT VALUE FOR SEQ_" + this.CurrentTableName.ToUpper());
                    }
                }
                else
                {
                    if (this.Identity && (DBProvider.CurrentDbType == CurrentDbType.Oracle || DBProvider.CurrentDbType == CurrentDbType.DB2))
                    {
                        if (testdemoEntity.ID == null)
                        {
                            if (string.IsNullOrEmpty(sequence))
                            {
                                CiSequenceManager sequenceManager = new CiSequenceManager(DBProvider, this.Identity);
                                sequence = sequenceManager.GetSequence(this.CurrentTableName);
                            }
                            testdemoEntity.ID = int.Parse(sequence);
                        }
                        sqlBuilder.SetValue(testdemoTable.FieldID, testdemoEntity.ID);
                    }
                }
            }
            this.SetEntity(sqlBuilder, testdemoEntity);
            if (this.Identity && (DBProvider.CurrentDbType == CurrentDbType.SqlServer || DBProvider.CurrentDbType == CurrentDbType.Access))
            {
                sequence = sqlBuilder.EndInsert().ToString();
            }
            else
            {
                sqlBuilder.EndInsert();
            }
            return sequence;
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="testdemoEntity">实体</param>
        public int UpdateEntity(testdemoEntity testdemoEntity)
        {
            SQLBuilder sqlBuilder = new SQLBuilder(DBProvider);
            sqlBuilder.BeginUpdate(this.CurrentTableName);
            this.SetEntity(sqlBuilder, testdemoEntity);
            sqlBuilder.SetWhere(testdemoTable.FieldID, testdemoEntity.ID);
            return sqlBuilder.EndUpdate();
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="sqlBuilder">sql语句生成器</param>
        /// <param name="testdemoEntity">实体</param>
        private void SetEntity(SQLBuilder sqlBuilder, testdemoEntity testdemoEntity)
        {
            sqlBuilder.SetValue(testdemoTable.FieldID, testdemoEntity.ID);
            sqlBuilder.SetValue(testdemoTable.FieldName, testdemoEntity.Name);
            sqlBuilder.SetValue(testdemoTable.FieldTel, testdemoEntity.Tel);
            sqlBuilder.SetValue(testdemoTable.FieldAddr, testdemoEntity.Addr);
            sqlBuilder.SetValue(testdemoTable.FieldIdcard, testdemoEntity.Idcard);
            sqlBuilder.SetValue(testdemoTable.FieldDellog, testdemoEntity.Dellog);
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return this.Delete(new KeyValuePair<string, object>(testdemoTable.FieldID, id));
        }
    }
}
