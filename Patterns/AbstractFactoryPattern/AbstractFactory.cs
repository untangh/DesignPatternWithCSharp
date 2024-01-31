using System;

namespace AbstractFactory {
	abstract class Factory {
		public abstract Actor createActor();
		public abstract Environment createEnvironment();
	}
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

	class MainProgram {
		public static void MainFunction(){
			
		}
	}


}