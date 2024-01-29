using System;
using System.Collections.Generic;

namespace PrototypePattern{
	interface MonsterPrototype {
		void ShowParameter();
		MonsterPrototype Clone();
	}

	class MonsterCreator{
		Dictionary<string,MonsterPrototype> monsterPrototypes;
		public MonsterCreator(){
			this.monsterPrototypes = new Dictionary<string, MonsterPrototype>();
		}
		public void Register(string id,MonsterPrototype monster){
			monsterPrototypes.Add(id,monster);
		}
		public MonsterPrototype Create(string id){
			return this.monsterPrototypes[id].Clone();
		}
	}
}