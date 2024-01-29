using System;
using System.Text;

namespace TemplatePattern{
	class CharDisplay : Display {
		char c;
		public CharDisplay(char c){
			this.c = c;
		}
		public override void open(){
			Console.Write("<<");
		}
		public override void print(){
			Console.Write(c);
		}
		public override void close(){
			Console.WriteLine(">>");
		}
	}

	class StringDisplay : Display {
		string s;
		int width;
		public StringDisplay(string s){
			this.s = s;
			this.width = Encoding.GetEncoding("utf-8").GetBytes(this.s).Length;
		}
		public override void open(){
			printLine();
		}
		public override void print(){
			Console.WriteLine($"| {this.s} |");
		}
		public override void close(){
			printLine();
		}

		private void printLine(){
			Console.Write("*");
			for(int i=0;i<this.width;i++){
				Console.Write("-");
			}
			Console.WriteLine("*");
		}

	}
}