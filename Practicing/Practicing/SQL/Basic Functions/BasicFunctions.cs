using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.SQL.Basic_Functions
{
    internal class BasicFunctions
    {
        //<---------------------STRING FUNCTIONS-------------------------------------------
        //LENGTH en CHAR-LENGTH (Lengte string)
        public List<int> ReturnIdIfStringLengthLessThan15(ISqlExecutor db)
        {
            //CHAR (totale aantal chars
            var query = "SELECT tweet_id FROM Tweets WHERE CHAR_LENGTH(content) < 15";

            //CHAR-LENGTH (totale aantal bytes
            var query2 = "SELECT tweet_id FROM Tweets WHERE LENGTH(content) < 15";

            return db.Query<int>(query).ToList();
        }

        //CONCAT Waarden aan elkaar plakken (+ lower/upper)
        public List<int> SelecterenStringsAsOne(ISqlExecutor db)
        {
            var query = "SELECT CONCAT(LOWER(first_name), ' ', last_name, ' - ' UPPER(job_title)) AS full_details";

            return db.Query<int>(query).ToList();
        }
    }
}
