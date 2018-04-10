﻿using System;
using HasSurvivingMutants.Implementation;
using NUnit.Framework;

namespace HasSurvivingMutants.MoreTests
{    
    public class MoreTests
    {
        [Test]
        public void DummyTest()
        {
            Assert.That(1+1, Is.EqualTo(2));
        }

        [Test]
        public void PostIncrement2()
        {
            // This test exists to show that coverage analysis handles methods
            // being covered by tests in multiple test projects.
            Assert.That(PartiallyTestedNumberComparison.Postincrement(5), Is.EqualTo(6));
        }

        [TestCase(1, 2)]
        [TestCase(4, 5)]
        public void PreIncrement2(int num, int expected)
        {
            // This test exists to show that coverage analysis handles methods
            // being covered by parameterised tests.
            Assert.That(PartiallyTestedNumberComparison.Preincrement(num), Is.EqualTo(expected));
        }

        [Test]
        public void ThrowingMethod()
        {
            // This test exists to show that coverage analysis handles methods
            // that throw exceptions being covered by tests.
            Assert.Throws<InvalidOperationException>(() => OtherMethods.ThrowingMethod());
        }
    }
}
