

namespace DefaultNamespace
{
    enum Type
    {
        Int
    }

    public class Node
    {
        public int inputType;
        public int inputCollectionType;
        public int outputType;
        public int outputCollectionType;
        public string operation;
        public List<Node> children;

        public Node(int inputType, int outputType, int inputCollectionType, int outputCollectionType,
            string operation, List<Node> children)
        {
            foreach (var child in children)
            {
                if (child.outputType != inputType)
                {
                    throw new Exception("Children's output type must match Node's input type");
                }
            }

            this.inputType = inputType;
            this.outputType = outputType;
            this.children = children;
            this.inputCollectionType = inputCollectionType;
            this.outputCollectionType = outputCollectionType;
            this.operation = operation;
            this.children = children;
        }

        public object run(object input)
        {
            List<object>  = new List<object>();
            foreach (var child in children)
            {
                inputs.Add(child.run());
            }
            
        }
    }
}