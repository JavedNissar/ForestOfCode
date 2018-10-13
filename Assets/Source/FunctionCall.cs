using System.Collections.Generic;

namespace Source
{
    public class FunctionCall
    {
        private List<object> _inputValues;
        private List<FunctionCall> _subCalls;
        private FunctionDefinition _combineOperation;
        
        /*
         *  Construct a function call. This class is meant to define the call of a function defined by
         *  a FunctionDefinition. That's why we take inputValues through this instances of this class. Also, subCalls
         *  is meant to be all the functions that this function needs to run on the input values.
         *  The combine operation is the function that's ultimately being called.
         */
        public FunctionCall(List<object> inputValues, List<FunctionCall> subCalls, FunctionDefinition combineOperation)
        {
            this._inputValues = inputValues;
            this._subCalls = subCalls;
            this._combineOperation = combineOperation;
        }
        
        /**
         * Construct a function call that doesn't have input values yet
         */
        public FunctionCall(List<FunctionCall> subCalls, FunctionDefinition combineOperation)
        {
            this._subCalls = subCalls;
            this._combineOperation = combineOperation;
        }

        public void setInputValues(List<object> inputValues)
        {
            this._inputValues = inputValues;
        }

        //Return the output of the function call
        public object Run()
        {
            //TODO: Implement run
            return null;
        }
    }
}