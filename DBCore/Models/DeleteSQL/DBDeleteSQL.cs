using DBCore.Models.BaseSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DBCore.Models.DeleteSQL
{
    public class DBDeleteSQL
    {
        /// <summary>
        /// delete one or More record from DB
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paramerters"></param>
        /// <returns></returns>
        public ModelResult DeleteRecord(string sql, params object[] paramerters)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Database.ExecuteSqlCommand(sql, paramerters);
                    return new ModelResult() { IsSuccess = true };
                }
            }
            catch(Exception e)
            {
                return new ModelResult()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }
    }
}
