using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.StringTask
{
	internal sealed class StringTask
	{
		internal StringTask(string stringValue)
		{
			_value = stringValue;
		}

		private string _value;

		internal string[] GetResultTask()
		{
			IList<string> result = new List<string>();
			for (int i = 1; i <= _value.Length; i += 2)
			{
				if (i + 2 <= _value.Length)
					result.Add($"{_value[i - 1]}{_value[i]}");
				else
				{
					if (_value.Length % 2 != 0)
						result.Add($"{_value[_value.Length - 1]}_");
					else
						result.Add($"{_value[_value.Length - 2]}{_value[_value.Length - 1]}");

				}
			}
			return result.ToArray();
		}
	}
}
