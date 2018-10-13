using System.Collections;
using System.Collections.Generic;
using Source;
using UnityEngine.Assertions;

namespace Tests
{
    public class MultiplyAndDivideTest
    {
        [NUnit.Framework.Test]
        public void MultiplyAndDivideTestSimplePasses()
        {
            // Use the Assert class to test conditions.
            //Set up input Values
            List<object> inputValues = new List<object>();
            inputValues.Add(1);
            inputValues.Add(2);
            inputValues.Add(3);
            //Set up input types for function definition
            List<Type> inputTypes = new List<Type>();
            inputTypes.Add(TypeUtilities.GetIntegerSingleton());
            inputTypes.Add(TypeUtilities.GetIntegerSingleton());
            inputTypes.Add(TypeUtilities.GetIntegerSingleton());
            //Set up output types for function definition
            List<Type> outputTypes = new List<Type>();
            outputTypes.Add(TypeUtilities.GetIntegerSingleton());
            //Function call for addition at second highest level of tree
            FunctionCall addXAndY = new FunctionCall(null, BuiltInFunctionFactory.getAddFunction());
            //Set up sub-calls for multiply operation at root of function tree
            List<FunctionCall> subCallsForMultiply = new List<FunctionCall>();
            subCallsForMultiply.Add(addXAndY);
            //Set up multiply call at root of tree
            FunctionCall multiplyZAndXY = new FunctionCall(subCallsForMultiply, 
                BuiltInFunctionFactory.getMultiplyFunction());
            //Declare function tree
            FunctionDefinition multAndDiv = new FunctionDefinition(inputTypes, outputTypes, multiplyZAndXY);
            //Generate call to function tree
            FunctionCall generateMultAndDivCall = multAndDiv.CreateFunctionCall(inputValues);
            //Run the call and assert the equality
            Assert.AreEqual(6, generateMultAndDivCall.Run());
        }

        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityEngine.TestTools.UnityTest]
        public IEnumerator MultiplyAndDivideTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // yield to skip a frame
            yield return null;
        }
    }
}