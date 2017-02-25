using DBCore.Models.BaseSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
namespace DBCore.Models.SeletcSQL
{
    public class DBSelect<T>
    {
        /// <summary>
        /// return list of some object type of T
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<List<T>> ExecuteSQLList(string sql, params object[] parameters)
        {
            var result = new ModelResult<List<T>>();
            try
            {
                result.Result = ExecuteSQL(ref sql, parameters);
                result.IsSuccess = true;
                return result;
            }
            catch(Exception e)
            {
                result.IsSuccess = false;
                result.Message = e.ToString();
                return result;
            }                        
        }

        /// <summary>
        /// resurtn klist of object as jsin string
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<string> ExecuteSQLListAsJson(string sql, params object[] parameters)
        {
            var result = new ModelResult<string>();
            try
            {
                var list = ExecuteSQL(ref sql, parameters);
                result.Result = new JavaScriptSerializer().Serialize(list);
                result.IsSuccess = true;
                return result;
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.Message = e.ToString();
                return result;
            }
        }
        /// <summary>
        /// Return single object type of T
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<T> ExecuteSQLSingle(string sql, params object[] parameters)
        {
            var result = new ModelResult<T>();
            try
            {
                result.Result = ExecuteSQL(ref sql, parameters).FirstOrDefault();
                result.IsSuccess = true;
                return result;
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.Message = e.ToString();
                return result;
            }
        }

        /// <summary>
        /// return object type of t as Json
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<string> ExecuteSQLSingleAsJson(string sql, params object[] parameters)
        {
            var result = new ModelResult<string>();
            try
            {
                var tempResult = ExecuteSQL(ref sql, parameters).FirstOrDefault();

                var json = new JavaScriptSerializer().Serialize(tempResult);

                result.IsSuccess = true;
                result.Result = json;
                return result;
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.Message = e.ToString();
                return result;
            }
        }

        /// <summary>
        /// Nethod return list of record from data base
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private List<T> ExecuteSQL(ref string sql, params object[] parameters)
        {
            using (var context = new DBContext())
            {
                return context.Database.SqlQuery<T>(sql, parameters).ToList<T>();
            }
        }
    }
}
