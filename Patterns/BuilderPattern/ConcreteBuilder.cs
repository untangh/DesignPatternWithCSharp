using System;
using System.Collections.Generic;

namespace BuilderPattern {
	class TextBuilder : DocumentBuilder {
		public override void Open(){
			Console.WriteLine("========================================");
		}
		public override void Close(){
			Console.WriteLine("========================================");
		}
		public override void MakeTitle(string title){
			Console.WriteLine($"【{title}】");
		}
		public override void MakeString(string str){
			Console.WriteLine($"■{str}");
		}
		public override void MakeItems(List<string> items){
			foreach(string s in items){
				Console.WriteLine($"・{s}");
			}
		}
	}

	class HtmlBuilder : DocumentBuilder{
		public override void Open(){
			Console.WriteLine("<html>");
		}
		public override void Close(){
			Console.WriteLine("</body></html>");
		}
		public override void MakeTitle(string title){
			Console.WriteLine($"<head><title>{title}</title></head><body>");
		}
		public override void MakeString(string str){
			Console.WriteLine($"■{str}");
		}
		public override void MakeItems(List<string> items){
			Console.WriteLine("<ul>");
			foreach(string s in items){
				Console.WriteLine($"<li>{s}</li>");
			}
			Console.WriteLine("</ul>");
		}
	}
}