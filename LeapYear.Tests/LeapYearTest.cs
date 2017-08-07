using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear.Models;

namespace LeapYear.Tests
{
	[TestClass]
	public class LeapYearTest
	{
		[TestMethod]
		public void isLeapYear_ForNumber_DivisibleByFour_True()
		{
			LeapYearClass testLeapYear = new LeapYearClass();
			Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));	
		}
		
		[TestMethod]
		public void IsLeapYear_ForNumberNotDivisibleByFour_False()
		{
		  LeapYearClass testLeapYear = new LeapYearClass();
		  Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
		}
		[TestMethod]
		public void IsLeapYear_ForMultiplesOfOneHundreds_False()
		{
			LeapYearClass testLeapYear = new LeapYearClass();
			Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
		}
		[TestMethod]
		public void IsLeapYear_ForMultiplesOfFourHundred_True()
		{
		  LeapYearClass testLeapYear = new LeapYearClass();
		  Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
		}
	}
}