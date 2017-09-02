using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.TheStringCombat
{
	public class DuelDecider
	{
		private readonly List<int> _left;
		private readonly List<int> _right;

		public DuelDecider(string left, string right)
		{
			_left = InputConverter.Convert(left).ToList();
			_right = InputConverter.Convert(right).ToList();
		}

		public string Decide()
		{
			Fight();

			return FormatResult();
		}

		private void Fight()
		{
			while (WarriorsAlive())
			{
				FightRound();
			}
		}

		private bool WarriorsAlive()
		{
			return !IsDead(_left) && !IsDead(_right);
		}

		private void FightRound()
		{
			var result = _left[0] - _right[0];
			if (result == 0)
			{
				Remove(_left);
				Remove(_right);
			}
			else if (result > 0)
			{
				Hurt(_left);
				Remove(_right);
			}
			else
			{
				Remove(_left);
				Hurt(_right);
			}
		}

		private static void Hurt(IList<int> warriors)
		{
			warriors[0] = (int)Math.Round((float)warriors[0] / 3);
		}

		private static void Remove(IList warriors)
		{
			warriors.RemoveAt(0);
		}

		private static bool IsDead(IReadOnlyCollection<int> warrior)
		{
			return warrior.Count == 0;
		}

		private string FormatResult()
		{
			if (IsDead(_left) && IsDead(_right))
			{
				return "Draw";
			}

			return IsDead(_left) ? $"Winner: s2({OutputConverter.Convert(_right)})" : $"Winner: s1({OutputConverter.Convert(_left)})";
		}
	}
}