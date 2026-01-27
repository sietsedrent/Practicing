using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.SQL.SELECT
{
    public class select : ISqlExecutor
    {


        //private readonly SqlConnection _connection = new(DatabaseConstants.ConnectionString);

        public List<int> ReturnRecyclableAndLowFatProducts(ISqlExecutor db)
        {
            var query =
                "SELECT product_id FROM Products WHERE low_fats = 'Y' AND recyclable = 'Y'";


            return db.Query<int>(query).ToList();
        }

        public List<string> FindCustomerReferee(ISqlExecutor db)
        {
            var query = "SELECT name FROM Customer WHERE referee_id IS NULL OR referee_id != 2";
            
            return db.Query<string>(query).ToList();
        } 

        public List<Countries> FindBigCountries(ISqlExecutor db)
        {
            var query = "SELECT name, population, area FROM World WHERE area >= 3000000 OR population >= 250000000";

            return db.Query<Countries>(query).ToList();
        }












        public IEnumerable<T> Query<T>(string sql)
        {
            throw new NotImplementedException();
        }
    }
}


public interface ISqlExecutor
{
    IEnumerable<T> Query<T>(string sql);
}

public class Countries
{
    public string name { get; set; }
    public int population { get; set; }
    public int area {  get; set; }
}