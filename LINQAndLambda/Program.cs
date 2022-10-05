﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQAndLambda
{
	public static class Program
	{
		public static void Main()
		{
			
			void LINQAndLambda() {
				
				var numbers = new[] { 5, 4, 3, 2, 1 };
				var mixedNumbers = new[] { 5, 6, 8, 13, 9, 12, 70, 3 };
				
				// Using If and Foreach
				var evenNumbers = new List<int>();
				
				Console.Write("Numbers: ");
				foreach (int number in numbers) {
					
					Console.Write($" {number}");
					
					if (number % 2 == 0) {
						
						evenNumbers.Add(number);
						
					}
					
				}
				
				Console.WriteLine();
				
				Console.Write("Even Numbers: ");
				foreach (int even in evenNumbers) {
					
					Console.Write($" {even}");
					
				}
				
				Console.WriteLine();
				
				// Using LINQ
				#region -- LINQ -- 
				
				var evenLinqNumbers = from number in numbers where number % 2 == 0 select number;
				
				Console.Write("LINQ: ");
				foreach (int even in evenLinqNumbers) {
					
					Console.Write($" {even}");
					
				}
				
				Console.WriteLine();
				
				var linqQuery = 
								from number in mixedNumbers
								where number <= 10 
								orderby number 
								select $"LINQ: {number}";
				foreach (var val in linqQuery) 
					Console.WriteLine(val);
				
				#endregion
				
				Console.WriteLine();
				
				// Using Lambda
				#region -- Lambda --
				
				var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0);
				
				Console.Write("Lambda: ");
				foreach (int even in lambdaEvenNumbers) {

					Console.Write($" {even}");
					
				}
				
				Console.WriteLine();
				
				var lambdaQuery = mixedNumbers
											.Where(number => number <= 10)
											.OrderBy(number => number)
											.Select(number => $"Lambda: {number}");
				foreach (var val in lambdaQuery)
					Console.WriteLine(val);
				
				#endregion
				
			}
			
			LINQAndLambda();

		}
	}
}