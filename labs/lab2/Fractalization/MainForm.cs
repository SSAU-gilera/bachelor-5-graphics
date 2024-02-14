using System;
using System.Drawing;
using System.Windows.Forms;


namespace Fractalization {
	public partial class MainForm : Form {
		Painter painter;
		Fractal fractal;
		RuleList rulesAssistant;

		public MainForm() 
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			painter = new Painter();
			fractal = new Fractal(painter);
			rulesAssistant = new RuleList();
			rulesAssistant.AddRule(new Rule('F', "F+F++F+FF"));
        }

		int counter = 0;
        private void paintButton_Click(object sender, EventArgs e) 
		{
			string resultString = rulesAssistant.ApplyRules(fractal.Axioma, counter);
			fractal.СheckString(resultString);
			primoPictureBox.Image = painter.Bitmap;
			counter++;
		}
    }
}
