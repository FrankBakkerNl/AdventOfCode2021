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
        public TestCase(string filename, object result)
        {
            
        }
    }
}