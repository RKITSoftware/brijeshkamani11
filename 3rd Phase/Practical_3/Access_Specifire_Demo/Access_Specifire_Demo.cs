using System;


namespace Access_Specifire_Demo
{
     public class Access_Specifire
    {
        private string private_member;
        public string public_member;
        internal string internal_member;
        protected string protected_member;
        internal protected string internal_protected_member;
        private protected string private_protected_member;

        public Access_Specifire()
        {
            // All member can be accessed in same class.
            this.private_member = "PRIVATE Member";
            this.public_member = "PUBLIC Member";
            this.protected_member = "PROTECTED Member";
            this.internal_member = "INTERNAL Member";
            this.internal_protected_member = "INTERNAL PROTECTED Member";
            this.private_protected_member = "PRIVATE PROTERCTED Member";

        }
    }

   internal class Access_Specifire_subclass : Access_Specifire
    {
        public Access_Specifire_subclass()
        {
            // this will throw an error because private member cannot be accessed from outside of its class
            // so this line is commented
            //Console.WriteLine(private_member + "Member Accessed From Subclass");

            // rest of members can be accessed from Sub class
            Console.WriteLine(public_member + " Accessed From Subclass");
            Console.WriteLine(internal_member + " Accessed From Subclass");
            Console.WriteLine(protected_member + " Accessed From Subclass");
            Console.WriteLine(internal_protected_member + " Accessed From Subclass");
            Console.WriteLine(private_protected_member + " Accessed From Subclass");
        }
    }
    class Access_Specifire_Demo
    {
        static void Main(string[] args)
        {
            Access_Specifire objAccess_Specifire = new Access_Specifire();

            // private member, protected_member and private protected member cannot be accessed from outside of its class using Object
            // so these line is commented
            // Console.WriteLine(objAccess_Specifire.private_member + "Accessed Using Object");
            // Console.WriteLine(objAccess_Specifire.protected_member + "Accessed Using Object");
            // Console.WriteLine(objAccess_Specifire.private_protected_member + "Accessed Using Object");

            // rest of members can be accessed using Object outside of same class
            Console.WriteLine(objAccess_Specifire.public_member + " Accessed Using Object");
            Console.WriteLine(objAccess_Specifire.internal_member + " Accessed Using Object");
            Console.WriteLine(objAccess_Specifire.internal_protected_member + " Accessed Using Object");

            Access_Specifire_subclass obj_access_Specifire_Subclass = new Access_Specifire_subclass();


        }
    }
}



