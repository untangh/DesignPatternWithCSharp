using System;

namespace SingletonPattern{
	class Singleton{
		static Singleton singleton = new Singleton();
		Singleton(){
		}
		public static Singleton GetInstance(){
			return singleton;
		}
	}
}