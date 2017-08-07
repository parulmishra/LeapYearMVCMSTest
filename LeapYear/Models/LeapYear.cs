using System;
using System.Collections.Generic;

namespace LeapYear.Models
{
	public class LeapYearClass
	{
		private int _year;
		
		public bool IsLeapYear(int year)
		{
		  if (year % 400 == 0)
		  {
			return true;
		  }
		  else if (year % 100 == 0)
		  {
			return false;
		  }
		  else
		  {
			return year % 4 == 0;
		  }
		}
		public void SetLeapYear(int year)
		{
			_year = year;
		}
		public int GetYear()
		{
			return _year;
		}
	}
}