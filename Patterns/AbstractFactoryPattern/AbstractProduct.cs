using System;

namespace AbstractFactoryPattern {
	abstract class Actor{
		public Actor(){}
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