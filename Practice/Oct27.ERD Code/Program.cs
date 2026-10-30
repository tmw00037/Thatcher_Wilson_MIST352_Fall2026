namespace Oct27.ERD_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            STUDENT st1 = new STUDENT();
            st1.strFirstName = "Mike";
            st1.strLastName = "Wilson";
            st1.intID = 110;
            st1.dbl1stgrade = 91;

            COURSE MIST352 = new COURSE();
            MIST352.intCRN = 22898;
            MIST352.strName = "Business Appl. Prog.";
            MIST352.strSemester = "Fall";
            MIST352.intYear = 2026;

            Console.WriteLine(MIST352.strName);
            
            CIRCLE WVUCircle = new CIRCLE();
            WVUCircle.dblRadius = 10;

            
            
            
            
            
            
            
            
            
        }
    }
}
