using System;

namespace BuilderPattern {
	class MainProgram {
		public static void MainFunction(){
			DocumentBuilder builder = new HtmlBuilder();
			Director director = new Director(builder,"Hello,world!","プログラミングの世界へようこそ");
			director.AddItem("C#");
			director.AddItem("C/C++");
			director.AddItem("Java");
			director.AddItem("Python");
			director.Construct();
		}
	}
}