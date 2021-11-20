
namespace ClassTypesDemo
{

    sealed class SealedBox
    {
        int length;
        int width;
        int height;

        public override string ToString() => $@"
Length:{length} Width:{width} Height:{height}
";

    }

    // We cannot inherit Sealed Type class
    //class SealedDemo : SealedBox
    //{

    //}
}
