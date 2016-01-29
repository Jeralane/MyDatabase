using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyDatabase
{
    public abstract class ActiveRecord<T> where T : ActiveRecord<T>, new()
    {
        public abstract string TableName { get; }

        public int ID { get; set; }

        protected abstract void SetProperties(DataTable dataTable);

        public static T Find(int id)
        {
            return new T();
        }

        public static List<T> FindBy(string columnName, object value)
        {
            T model = new T();
            var sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT * FROM ");
            sqlBuilder.AppendLine(model.TableName);
            sqlBuilder.AppendFormat("WHERE {0} = ?{0}", columnName);
            return new List<T>();
        }

        public virtual int Delete()
        {
            Console.WriteLine("DELETE FROM {0} WHERE ID = ?ID", TableName);
            return 0;
        }
    }

    public class User : ActiveRecord<User>
    {
        public override string TableName {get { return "users"; }}

        protected override void SetProperties(DataTable dataTable)
        {
            ID = 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                // set properties
            }
        }
    }


}