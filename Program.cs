﻿using System;
using System.Collections.Generic;

namespace Kontur.Courses.Git
{
	class Program
	{
		private static void Main()
		{
			Calculator calculator = new Calculator();
			RunLoop(calculator);
		}

		private static void RunLoop(Calculator calculator)
		{
			while (true)
			{
				var line = Console.ReadLine();
				if (line == null) break;
				var args = SplitInput(line);
				var result = calculator.Calculate(args);
				Console.WriteLine("> " + result);
			}
		}

		private static string[] SplitInput(string line)
		{
			if (line.Length == 0) return new string[0];
			List<string> res = new List<string> {""};
			bool isDigit = char.IsDigit(line[0]);
			foreach (var ch in line)
			{
                if (ch == ' ')
                    continue;
				if (char.IsDigit(ch) != isDigit)
				{
					res.Add("");
					isDigit = !isDigit;
				}
				res[res.Count - 1] += ch;
			}
			return res.ToArray();
		}
	}
}
