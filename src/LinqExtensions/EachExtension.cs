﻿using System;
using System.Collections.Generic;

namespace LinqExtensions
{
	public static class EachExtension
	{
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			foreach (var item in enumerable)
			{
				action(item);
			}
		}
	}
}
