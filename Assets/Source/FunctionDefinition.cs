using System;
using System.Collections.Generic;

namespace Source
{
    public class FunctionDefinition
    {
        private List<Type> _inputTypes;
        private List<Type> _outputTypes;
        private FunctionCall _rootCall;
        private int _builtInOperation;
        
        /*
         * Declares a function definition with the inputTypes and outputTypes for validating calls to the function.
         * Please note that the rootCall is meant to indicate the bottom of the function tree. Please refer to the
         * original slide-show for a view of the function trees.
         */
        public FunctionDefinition(List<Type> inputTypes, List<Type> outputTypes, FunctionCall rootCall)
        {
            this._inputTypes = inputTypes;
            this._outputTypes = outputTypes;
            this._rootCall = rootCall;
        }

        /**
         * Declare a function definition like the last one; however, this one uses a builtIn rather than rootCall.
         * The purpose of this being for built-in functions like add.
         */
        public FunctionDefinition(List<Type> inputTypes, List<Type> outputTypes, int builtIn)
        {
            this._inputTypes = inputTypes;
            this._outputTypes = outputTypes;
            this._builtInOperation = builtIn;
        }

        public FunctionCall CreateFunctionCall(List<object> inputValues)
        {
            return new FunctionCall(inputValues, null, this);
        }
    }
}