using System;

namespace AbstractFactoryPattern {
	//役割：
	class OthelloFactory : GameFactory {
		public const int BoardSize = 8;
		public override Actor createActor(int id){
			return new Actor(id);
		}
		public override Environment createEnvironment(){
			return new Environment(BoardSize);
		}
	}
}