
namespace ClassTypesDemo
{
    static class StaticBox
    {
        static int  dimention;
        static StaticBox()
        {
            dimention = 3;
        }
    }

    //we cannot inherit static class
    //class StaticDemo : StaticBox
    //{
    //    public static void main(String[] args)
    //    {

    //        // we cannot create instance of Static class
    //        //StaticBox staticBox = new StaticBox();
    //    }
    //}
}
