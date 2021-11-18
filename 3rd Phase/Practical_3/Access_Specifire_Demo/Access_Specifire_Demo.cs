using System;

namespace Access_Specifire_Demo
{
    class Access_Specifire
    {
        private string private_member;
        public string public_member;
        internal string internal_member;
        protected string protected_member;


        Access_Specifire()
        {
            this.private_member = "";
            this.private_member = "";
            this.private_member = "";
            this.protected_member = "";

        }
    }

    class Access_Specifire_subclass : Access_Specifire
    {
        Access_Specifire_subclass()
        {

        }
    }
    class Access_Specifire_Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Access_Specifier_Demo objDemo = new Access_Specifier_Demo();

        }
    }
}
