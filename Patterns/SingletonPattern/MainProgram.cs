using System;

namespace SingletonPattern{
	class MainProgram{
		public static void MainFunction(){
			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();
			Console.WriteLine(s1 == s2);
		}
	}
}