using System;

namespace AdapterPattern{
	class MainProgram{
		public static void MainFunction(){
			PrintClass p = new PrintBannerClass("hello");
			p.printWeak();
			p.printStrong();
		}
	}
}