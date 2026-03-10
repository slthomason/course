namespace _11_methods
{
    public class _2_parameters
    {

        // addstr contain three parameters
        public void addstr(string s1, string s2, string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine("Final string is: " + result);
        }

        public void CompareValue(ref string val1)
        {
            // Compare the value
            if (val1 == "Dog")
            {
                Console.WriteLine("Matched!");
            }

            // Assigning new value
            val1 = "Cat";
        }


        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public void AddNum(out int num)
        {
            num = 40;
            num += num;
        }

        // This method contains two regular 
        // parameters, i.e. ename and eid
        // And two optional parameters, i.e. 
        // bgrp and dept 
        public void detail(string ename,
                                   int eid,
                                   string bgrp = "A+",
                        string dept = "Review-Team")

        {
            Console.WriteLine("Employee name: {0}", ename);
            Console.WriteLine("Employee ID: {0}", eid);
            Console.WriteLine("Blood Group: {0}", bgrp);
            Console.WriteLine("Department: {0}", dept);
        }


        // function containing params parameters
        public int mulval(params int[] num)
        {
            int res = 1;

            // foreach loop
            foreach (int j in num)
            {
                res *= j;
            }
            return res;
        }
    }
}
