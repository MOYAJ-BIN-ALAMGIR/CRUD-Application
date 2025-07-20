namespace FirstCRUDApplication1.Models
{
    public static class Repository
    {
        private static List<Employee> allEmploys = new List<Employee>();
        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmploys; }
        }
        public static void Create (Employee employee)
        {
            allEmploys.Add(employee);
        }


    }
}
