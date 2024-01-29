using System;
using System.Collections.Generic;
using FactoryMethodPattern;

namespace FactoryMethodPattern{
	class MainProgram{
		public static void MainFunction(){
			Factory factory = new IDCardFactory();
			Product product1 = factory.Create("hoppii");
			Product Product2 = factory.Create("Grothendieck");
			product1.Use();
			Product2.Use();
		}
	}
}