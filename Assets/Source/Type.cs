namespace Source
{
    public enum ValueTypes
    {
        Int,Double,String,Character,Function,Boolean
    }

    public enum CollectionTypes
    {
        Singleton,List,Set,Array
    }

    public class Type
    {
        public int valueType;
        public int collectionType;

        public Type(int initialValueType, int initialCollectionType)
        {
            this.valueType = initialValueType;
            this.collectionType = initialCollectionType;
        }
    }
}