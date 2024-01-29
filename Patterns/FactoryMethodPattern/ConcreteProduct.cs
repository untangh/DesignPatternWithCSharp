using System;

namespace FactoryMethodPattern{
	//具体的なプロダクトを決めるクラス
	class IDCard : Product{
		string owner;
		public string Owner{ get{ return this.owner; } }
		public IDCard(string owner){
			this.owner = owner;
			Console.WriteLine($"{this.owner}のカードを作成しました");
		}
		public override void Use(){
			Console.WriteLine($"{this.owner}のカードを使用します");
		}
	}
}