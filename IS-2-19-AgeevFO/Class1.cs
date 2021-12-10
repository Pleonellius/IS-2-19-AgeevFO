using System;

namespace ClassLibrary3
{
    public class Class1
    {
        public string connDB = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

        public string Connect()
        {
            return connDB;
        }
    }
}
