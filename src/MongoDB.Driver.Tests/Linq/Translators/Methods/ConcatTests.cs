﻿using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MongoDB.Driver.Tests.Linq.Translators.Methods
{
    [TestFixture, Category("Linq"), Category("Linq.Methods.Concat")]
    public class ConcatTests : LinqIntegrationTestBase
    {
        [Test]
        [ExecutionTargetsTestCaseSource]
        [ExpectedException(typeof(MongoLinqException), ExpectedMessage = "The Concat query operator is not supported.")]
        public void TestConcat(ExecutionTarget target)
        {
            var source2 = new C[0];
            var query = (from c in CreateQueryable<C>(target)
                         select c).Concat(source2);
            query.ToList(); // execute query
        }
    }
}