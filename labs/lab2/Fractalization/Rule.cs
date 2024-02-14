
namespace Fractalization {

	// Хранит данные об одном правиле для вывода строки

	class Rule {
		private char leftSide;
		private string rightSide;
		
		public Rule(char leftSide, string rightSide) 
		{
			this.leftSide = leftSide;
			this.rightSide = rightSide;
		}
	
		public char LeftSide => leftSide;
		public string RightSide => rightSide;
	}
}
