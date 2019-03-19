using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public interface IRepository<T> where T:class
    {
        /// <summary>
        /// 开始事务
        /// </summary>
        void BeginTrains();
        /// <summary>
        /// 提交事务
        /// </summary>
        int Commit();
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Insert(T entity);
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Delete(T entity);
        /// <summary>
        /// 根据表达式获取实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T GetModel(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// 根据表达式获取实体列表
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// 根据查询语句获取实体
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns></returns>
        IEnumerable<T> GetList(string sql);

    }
}
