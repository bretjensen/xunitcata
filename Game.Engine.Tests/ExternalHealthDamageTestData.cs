using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Game.Engine.Tests
{
    public class ExternalHealthDamageTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                var csvLines = File.ReadAllLines("TestData.csv");
                var testCases = new List<object[]>();

                foreach(var line in csvLines)
                {
                    var values = line.Split(',').Select(int.Parse);
                    var testCase = values.Cast<object>().ToArray();
                    testCases.Add(testCase);
                }

                return testCases;
            }
        }
    }
}