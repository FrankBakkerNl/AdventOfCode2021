using System;

namespace AdventOfCode2020
{
    class FocusAttribute : Attribute
    {
    }
    class SkipAttribute : Attribute
    {
    }
    
    class TestCase : Attribute
    {
        public string Filename { get; } = "TestInput";
        public object Result { get; }

        public TestCase(object result)
        {
            Result = result;
        }

        
        public TestCase(object result, string filename)
        {
            Filename = filename;
            Result = result;
        }
    }
}