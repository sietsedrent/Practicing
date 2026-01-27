using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.SQL.Basic_Joins
{
    internal class BasicJoins
    {
        //Inner join (Return rows die hetzelfde zijn in beide tabellen)
        //Alleen de waarden die ON in elke tabel staan worden in de nieuwe tabel getoond
        public List<int> InnerJoin(ISqlExecutor db)
        {
            var query = "SELECT * FROM Employee_demographics e INNER JOIN employee_salary s ON e.employee_id = s.employee_id";

            return db.Query<int>(query).ToList();
        }

        //Outer join
        public List<int> Outerjoin(ISqlExecutor db)
        {
            //LEFT OUTER JOIN
            //Left join neemt alles van de linker tabel ook al zijn er geen matches en returnt dan alles van tabel 1 alleen de matches van de right table
            var query = "SELECT * From Employee_demographics e LEFT OUTER JOIN employee_salary s ON e.employee_id = s.employee_id";

            //RIGHT OUTER JOIN
            //Right join neemt alles van de rechter tabel ook al zijn er geen matches en returnt dan alles van tabel 2 alleen de matches van de left table
            var query2 = "SELECT * From Employee_demographics e RIGHT OUTER JOIN employee_salary s ON e.employee_id = s.employee_id";
            
            //FULL OUTER JOIN
            //Full join maakt een tabel met alles van beide tabellen
            var query3 = "SELECT * From Employee_demographics e FULL OUTER JOIN employee_salary s ON e.employee_id = s.employee_id";


            return db.Query<int>(query).ToList();
        }

        //Self join bijvoorbeeld secret santa
        public List<int> SelfJoin(ISqlExecutor db)
        {
            var query = "SELECT e1.employee_id AS emp_sante, e2.first_name AS first_name_santa FROM Employee e1 JOIN Employee e2 ON e1.id + 1 = e2.id";

            return db.Query<int>(query).ToList();
        }

        //Joining multiple tables

    }
}
