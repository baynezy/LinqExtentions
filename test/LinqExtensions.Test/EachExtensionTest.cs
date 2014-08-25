using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LinqExtensions.Test
{
	[TestFixture]
	class EachExtensionTest
	{
		[Test]
		public void Each_WhenPresentedWithEnumerable_ThenAllowEachMethod()
		{
			try
			{
				var enmumerable = CreateEnumerable();
				var counter = 0;
				enmumerable.Each(i => counter += i);
			}
			catch (Exception e)
			{
				Assert.Fail("This should not error. Error: {0}", e.Message);
			}
		}

		[Test]
		public void Each_WhenIteratingThroughEnumerable_ThenUpdateCounter()
		{
			var enmumerable = CreateEnumerable();
			var counter = 0;
			enmumerable.Each(i => counter += i);

			Assert.That(counter, Is.EqualTo(10));
		}

		private static IEnumerable<int> CreateEnumerable()
		{
			return new[] {1, 2, 3, 4};
		}
	}
}
