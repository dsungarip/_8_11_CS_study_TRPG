using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_CS_study
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();

			while(true)
			{
				game.Process();
			}
		}
	}
}
