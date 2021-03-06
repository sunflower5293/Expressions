﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Expressions.Test.VisualBasicLanguage.Compilation
{
    [TestFixture]
    internal class ResultCasting : TestBase
    {
        [Test]
        public void CastIntToLong()
        {
            Resolve(
                "1",
                1L,
                new BoundExpressionOptions { ResultType = typeof(long) }
            );
        }

        [Test]
        public void CastCharToDecimal()
        {
            Resolve(
                "'a'",
                97m,
                new BoundExpressionOptions { ResultType = typeof(decimal) }
            );
        }
    }
}
