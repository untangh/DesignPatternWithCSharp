using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
	abstract class GameFactory {
		public abstract Actor createActor(int id);
		public abstract Environment createEnvironment();
	}


}