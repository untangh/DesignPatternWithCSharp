using System;

namespace AbstractFactoryPattern {
	//「キャラ」が存在するゲーム全般に対応したいため、HPとか特定のゲーム固有の情報は入れなくていい
	abstract class Actor{
		//一意な値でActorを区別できるようにしておく
		int id;
		public Actor(int id){
			this.id = id;
		}
		public abstract Action ChooseActionOfTurn(Environment environment);
	}
	abstract class Environment {
		public Environment(){}
		public abstract void ApplyAction(Action action);
	}
	abstract class Action{
		public Action(){}
	}
}