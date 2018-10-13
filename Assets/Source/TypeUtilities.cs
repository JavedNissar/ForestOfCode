namespace Source
{
    public class TypeUtilities
    {
        public static Type GetIntegerSingleton()
        {
           return new Type((int) ValueTypes.Int, (int) CollectionTypes.Singleton); 
        }
    }
}