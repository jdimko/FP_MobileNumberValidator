using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ValidatePhoneNumber.Test
{
    class TestData
    {
        public class ValidNumbersAttribute : Attribute, ITestDataSource
        {
            IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
            {
                yield return new object[] { "+355692666767" };
                yield return new object[] { "+355688584567" };
                yield return new object[] { "+355678584567" };
                yield return new object[] { "0692666767" };
                yield return new object[] { "0682666767" };
                yield return new object[] { "0672666767" };
                yield return new object[] { "0672666700" };
            }

            public string GetDisplayName(MethodInfo methodInfo, object[] data)
            {
                return "Valid";
            }
        }

        public class InValidNumbersAttribute : Attribute, ITestDataSource
        {
            IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
            {
                yield return new object[] { "" };
                yield return new object[] { "0" };
                yield return new object[] { "+0" };
                yield return new object[] { "+672525768" };
                yield return new object[] { "0662525768" };
                yield return new object[] { "+355" };
                yield return new object[] { "355000" };
                yield return new object[] { "355692666767" };
                yield return new object[] { "069dasd" };
                yield return new object[] { "069266676a" };
                yield return new object[] { "0+2666767" };
                yield return new object[] { "+35569266676" };
                yield return new object[] { "+335662666768" };
                yield return new object[] { "0672525  8" };
                yield return new object[] { " 672525768" };
                yield return new object[] { "0672kl6767" };
                yield return new object[] { "+35572666700222" };
                yield return new object[] { "++3557266670" };
                yield return new object[] { "++355726667 0" };
            }

            public string GetDisplayName(MethodInfo methodInfo, object[] data)
            {
                return "InValid";
            }
        }
    }
}
