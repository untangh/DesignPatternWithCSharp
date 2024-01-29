using System;

namespace PrototypePattern {
	class MainProgram{
		public static void MainFunction(){
			Monster monster1 = new Monster("スライム",10,10);
			monster1.ShowParamater();
			monster1.ReduceHitPoint(4);
			Monster monster2 = (Monster)monster1.Clone();
			monster2.ShowParameter();
		}
	}
}