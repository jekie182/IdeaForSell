using DBCore.Models.BaseSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DBCore.Models.InsertSQL
{
    class DBInsertSQL<T>
    {

            /// <summary>
            /// Method can insert on o more records
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="parameters"></param>
            /// <returns></returns>
            public ModelResult InsertRecord(string sql, params object[] parameters)
            {
                try
                {
                    using (var context = new DBContext())
                    {
                        context.Database.ExecuteSqlCommand(sql, parameters);
                        return new ModelResult()
                        {
                            IsSuccess = true
                        };
                    }
                }
                catch (Exception e)
                {
                    return new ModelResult()
                    {
                        IsSuccess = false,
                        Message = e.ToString()
                    };
                }
            }

            /// <summary>
            /// insaert single record after select this record
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="parameters"></param>
            /// <returns></returns>
            public ModelResult<T> InsertSelectRecord(string sql, params object[] parameters)
            {
                try
                {
                    var record = ExecuteSQL(ref sql, parameters).FirstOrDefault();
                    return new ModelResult<T>()
                    {
                        Result = record,
                        IsSuccess = true
                    };
                }
                catch (Exception e)
                {
                    return new ModelResult<T>()
                    {
                        IsSuccess = false,
                        Message = e.ToString()
                    };
                }
            }
            
            /// <summary>
            /// insert single record after that select it as Json
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="parameters"></param>
            /// <returns></returns>
            public ModelResult<string> InsertSelectRecordAsJson(string sql, params object[] parameters)
            {
                try
                {
                    var record = new JavaScriptSerializer().Serialize(ExecuteSQL(ref sql, parameters).FirstOrDefault());
                    return new ModelResult<string>()
                    {
                        Result = record,
                        IsSuccess = true
                    };
                }
                catch (Exception e)
                {
                    return new ModelResult<string>()
                    {
                        IsSuccess = false,
                        Message = e.ToString()
                    };
                }
            }
        private List<T> ExecuteSQL(ref string sql, params object[] parameters)
        {
            using (var context = new DBContext())
            {
                return context.Database.SqlQuery<T>(sql, parameters).ToList<T>();
            }
        }
    }
}
