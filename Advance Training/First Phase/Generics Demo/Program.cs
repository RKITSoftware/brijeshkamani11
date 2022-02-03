namespace GenericsDemo
{
    public class GenericClass<T>
    {
        #region Public Fields

        /// <summary>
        /// define an Array of Generic type with length 5
        /// </summary>
        T[] Obj = new T[5];

        /// <summary>
        /// Store lendth of the List
        /// </summary>
        int Count;

        #endregion Public Fields

        #region Public Methods

        /// <summary>
        /// adding items mechanism into generic type
        /// </summary>
        /// <param name="item">
        /// refer oject of Type T
        /// </param>
        public void Add(T item)
        {
            //checking length
            if (Count + 1 < 6)
            {
                Obj[Count] = item;

            }
            Count++;
        }
        #endregion Public Methods

        #region Indexer

        /// <summary>
        /// indexer for foreach statement iteration
        /// </summary>
        /// <param name="index">
        /// Index as Integer
        /// </param>
        /// <returns>
        /// Object of Type T at specified indexs
        /// </returns>
        public T this[int index]
        {
            get { return Obj[index]; }
            set { Obj[index] = value; }
        }

        #endregion Indexer
    }
    class Program
    {
        #region Static mehods

        /// <summary>
        /// Starting point of This Project
        /// </summary>
        /// <param name="args">
        /// list of string that passed during Main calls.
        /// </param>
        static void Main(string[] args)
        {
            //instantiate generic with Integer
            GenericClass<int> objGenericClass = new GenericClass<int>();

            //adding integer values into collection
            objGenericClass.Add(1);
            objGenericClass.Add(2);
            objGenericClass.Add(3);
            objGenericClass.Add(4);
            objGenericClass.Add(5);

            //displaying values
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(objGenericClass[i]);
            }

        }
        #endregion Static mehods
    }
}
