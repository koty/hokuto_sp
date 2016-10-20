using NUnit.Framework;
using System;
using hokuto_sp;

namespace hokuto_smp.Test
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			var vm = new MainPageViewModel();
			Assert.AreEqual(vm.ToString(), "");
		}
	}
}
