using System;
using System.Collections.Generic;

namespace Source
{
    public class BuiltInFunctionFactory
    {
        private static List<Type> getPairOfIntegersAsTypeList()
        {
            List<Type> types = new List<Type>();
            types.Add(new Type((int)ValueTypes.Int, (int)CollectionTypes.Singleton));
            types.Add(new Type((int)ValueTypes.Int, (int)CollectionTypes.Singleton));
            return types;
        }

        private static List<Type> getSingletonIntegerAsTypeList()
        {
            List<Type> types = new List<Type>();
            types.Add(new Type((int)ValueTypes.Int, (int)CollectionTypes.Singleton));
            return types;
        }

        private static FunctionDefinition getBinaryOperation(int operation)
        {
            return new FunctionDefinition(getPairOfIntegersAsTypeList(), getSingletonIntegerAsTypeList(), operation);
        }
        
        public static FunctionDefinition getAddFunction()
        {
            return getBinaryOperation((int)BuiltInOperations.Add);
        }

        public static FunctionDefinition getSubtractFunction()
        {
            return getBinaryOperation((int)BuiltInOperations.Subtract);
        }

        public static FunctionDefinition getMultiplyFunction()
        {
            return getBinaryOperation((int)BuiltInOperations.Multiply);
        }

        public static FunctionDefinition getDivideFunction()
        {
            return getBinaryOperation((int)BuiltInOperations.Divide);
        }

        public static FunctionDefinition getRangeFunction()
        {
            List<Type> inputTypes = getSingletonIntegerAsTypeList();
            List<Type> outputTypes = new List<Type>();
            outputTypes.Add(new Type( (int) ValueTypes.Int, (int) CollectionTypes.List));
            return new FunctionDefinition(inputTypes, outputTypes, (int) BuiltInOperations.Range);
        }

        public static FunctionDefinition getReduceFunction()
        {
            List<Type> inputTypes = new List<Type>();
            inputTypes.Add(new Type((int) ValueTypes.Int, (int) CollectionTypes.List));
            inputTypes.Add(new Type((int) ValueTypes.Function, (int) CollectionTypes.Singleton));
            List<Type> outputTypes = new List<Type>();
            outputTypes.Add(new Type((int) ValueTypes.Int, (int) CollectionTypes.Singleton));
            return new FunctionDefinition(inputTypes, outputTypes, (int) BuiltInOperations.Reduce);
        }

        public static FunctionDefinition getEqualsFunction()
        {
            return getBinaryOperation((int)BuiltInOperations.Equals);
        }

        public static FunctionDefinition getIfFunction()
        {
            List<Type> inputTypes = new List<Type>();
            inputTypes.Add(new Type((int) ValueTypes.Int, (int) CollectionTypes.Singleton));
            inputTypes.Add(new Type((int) ValueTypes.Int, (int) CollectionTypes.Singleton));
            inputTypes.Add(new Type((int) ValueTypes.Boolean, (int) CollectionTypes.Singleton));
            List<Type> outputTypes = getSingletonIntegerAsTypeList();
            return new FunctionDefinition(inputTypes, outputTypes, (int) BuiltInOperations.If);
        }

        public static FunctionDefinition getPowerFunction()
        {
            return getBinaryOperation((int) BuiltInOperations.Power);
        }
    }
}