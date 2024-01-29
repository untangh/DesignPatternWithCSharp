using System;

namespace PrototypePattern {
	class MainProgram{
		public static void MainFunction(){
			MonsterCreator monsterCreator = new MonsterCreator();
			monsterCreator.Register("slime",new Monster("スライム",10,10));
			monsterCreator.Register("golem",new Monster("ゴーレム",100,5));
			Monster golem = (Monster)monsterCreator.Create("golem");
			Monster slime = (Monster)monsterCreator.Create("slime");
			golem.ShowParameter();
			slime.ShowParameter();
		}
	}
}