using System;

namespace TemplatePattern{
	class MainProgram{
		public static void MainFunction(){
			Display display = new StringDisplay("ハローC#");
			display.display();
		}
	}
}