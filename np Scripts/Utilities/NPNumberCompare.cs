using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EndarScripts
{
	public enum NumberCompare { Equal, NotEqual, LessThan, GreaterThan, LessThanEqualTo, GreaterThanEqualTo }
	public class NPNumberCompare
	{
		public static bool CompreNumbers (int num1, int num2, NumberCompare compare)
		{
			bool result = false;
			switch(compare)
			{
				case NumberCompare.Equal:
					result = num1 == num2;
					break;
				case NumberCompare.GreaterThan:
					result = num1 > num2;
					break;
				case NumberCompare.GreaterThanEqualTo:
					result = num1 >= num2;
					break;
				case NumberCompare.LessThan:
					result = num1 < num2;
					break;
				case NumberCompare.LessThanEqualTo:
					result = num1 <= num2;
					break;
				case NumberCompare.NotEqual:
					result = num1 != num2;
					break;
			}

			return result;
		}
		public static bool CompreNumbers(float num1, float num2, NumberCompare compare)
		{
			bool result = false;
			switch (compare)
			{
				case NumberCompare.Equal:
					result = num1 == num2;
					break;
				case NumberCompare.GreaterThan:
					result = num1 > num2;
					break;
				case NumberCompare.GreaterThanEqualTo:
					result = num1 >= num2;
					break;
				case NumberCompare.LessThan:
					result = num1 < num2;
					break;
				case NumberCompare.LessThanEqualTo:
					result = num1 <= num2;
					break;
				case NumberCompare.NotEqual:
					result = num1 != num2;
					break;
			}

			return result;
		}
		public static bool CompreNumbers(double num1, double num2, NumberCompare compare)
		{
			bool result = false;
			switch (compare)
			{
				case NumberCompare.Equal:
					result = num1 == num2;
					break;
				case NumberCompare.GreaterThan:
					result = num1 > num2;
					break;
				case NumberCompare.GreaterThanEqualTo:
					result = num1 >= num2;
					break;
				case NumberCompare.LessThan:
					result = num1 < num2;
					break;
				case NumberCompare.LessThanEqualTo:
					result = num1 <= num2;
					break;
				case NumberCompare.NotEqual:
					result = num1 != num2;
					break;
			}

			return result;
		}
		public static bool CompreNumbers(long num1, long num2, NumberCompare compare)
		{
			bool result = false;
			switch (compare)
			{
				case NumberCompare.Equal:
					result = num1 == num2;
					break;
				case NumberCompare.GreaterThan:
					result = num1 > num2;
					break;
				case NumberCompare.GreaterThanEqualTo:
					result = num1 >= num2;
					break;
				case NumberCompare.LessThan:
					result = num1 < num2;
					break;
				case NumberCompare.LessThanEqualTo:
					result = num1 <= num2;
					break;
				case NumberCompare.NotEqual:
					result = num1 != num2;
					break;
			}

			return result;
		}
		public static bool CompreNumbers(int num1, int num2, NumberCompare compare, int varience)
		{
			bool result = false;
			switch (compare)
			{
				case NumberCompare.Equal:
					result = Mathf.Abs(num1 - num2) <= varience;
					break;
				case NumberCompare.GreaterThan:
					result = num1 > num2;
					break;
				case NumberCompare.GreaterThanEqualTo:
					result = num1 >= num2;
					break;
				case NumberCompare.LessThan:
					result = num1 < num2;
					break;
				case NumberCompare.LessThanEqualTo:
					result = num1 <= num2;
					break;
				case NumberCompare.NotEqual:
					result = num1 != num2;
					break;
			}

			return result;
		}
	}
}
