using DEMO_LINQ_1;

namespace DEMO_LINQ_1
{
    class Program
    {
       static void Main()
        {


            #region Anonymous Type
            
            //// create anonymous type
            //var employee = new {Id =  1 , Name = "hesham" , Salary = 8000};
            ////change the value of anonymous type : 
            //employee = new {Id = 99 , employee.Name , employee.Salary};
            //// syntax sugar : [C# 10.0]
            //employee = employee with { Id = 45 };




            #endregion



            #region Extension Method

            int X = 12345;
            int Y = IntExtensions.Reverse(X);

            // extension : 
            Y = X.Reverse();
            Console.WriteLine(Y); // 54321

            #endregion



            #region LINQ Syntax 



            List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9, };

            #region Fluent Syntax
            // Fluent Syntax [Recommended] Extension Method
            var OddNumbers = Numbers.Where((n) => n % 2 == 1).ToList();

            foreach (var odd in OddNumbers)
            {
                Console.WriteLine(odd);
            }
            #endregion

            #region Query Syntax 
            // Queries Like SQL Server 
            //OddNumbers = from n in OddNumbers 
            //             where n % 2 == 1 
            //             select n;




            #endregion

            #region Differed Execution  
            // where => is not immediate execution here ! 
            // but it works after addRange run. 
            var result = Numbers.Where((N) => N % 2 == 1);

            Numbers.AddRange(new int[] { 10, 11, 12, 13, 14 });

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Immediate Execution 
            
            
            // here where run immediate With => [Element , Casting , Aggregate Functions]
            var Result = Numbers.Where((N) => N % 2 == 1).ToList();
            //Result = Numbers.Where((N) => N % 2 == 1).Count();
            //Result = Numbers.Where((N) => N % 2 == 1).First();
            #endregion



            #region Data Setup 
            Console.WriteLine(ListGenerator.ProductsList[0]);
            Console.WriteLine(ListGenerator.CustomersList[0]);


            #endregion

            #endregion









        }
    }
}