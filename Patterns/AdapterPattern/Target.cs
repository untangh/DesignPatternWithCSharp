using System;
namespace AdapterPattern{
	//ターゲットがインターフェースの場合
	interface PrintInterface{
		void printWeak();
		void printStrong();
	}
	//ターゲットがクラスの場合
	class PrintClass{
		public virtual void printWeak(){}
		public virtual void printStrong(){}
	}
}