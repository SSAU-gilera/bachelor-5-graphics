using System.Collections.Generic;
using System.Text;

namespace Fractalization 
{ 
	class RuleList    // Строит строку из аксиомы, применяя правила правила
	{
		private List<Rule> rules;
	
		public RuleList() 
		{
			rules = new List<Rule>();
		}

		// Применяет правила к строке определённое количество раз и возвращает получившуюся строку
		public string ApplyRules(string startString, int counter) //в зависимости от нажатий на кнопку "рисовать" определяется сколько раз анализировать строку
		{
			string currentString = startString;
			StringBuilder builder = new StringBuilder();

			for (int currentStep = 0; currentStep < counter; currentStep++) {
				builder.Clear();

				foreach (char c in currentString) //анализируются символы строки, если символ - F, применяется правило
				{ 
					Rule needRule = rules.Find(rule => rule.LeftSide == c); 
					builder.Append(needRule?.RightSide ?? c.ToString());
				}
				currentString = builder.ToString();
			}
			return currentString; //возвращаем получившуюся строку 
		}

        public void AddRule(Rule newRule)
        {
            rules.Add(newRule);
        }
        public List<Rule> Rules => rules;
	}
}
