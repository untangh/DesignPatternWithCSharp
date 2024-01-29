using System;

namespace PrototypePattern {
	class Monster : MonsterPrototype{
		string name;
		int hitPoint;
		int attackPower;

		public int HitPoint{ get{ return this.hitPoint; } }
		public int AttackPower{ get{ return this.attackPower; } }

		public Monster(string name,int hitPoint,int attackPower){
			this.name = name;
			this.hitPoint = hitPoint;
			this.attackPower = attackPower;
		}
		public void ReduceHitPoint(int damage){
			this.hitPoint -= damage;
			if(this.hitPoint <= 0){
				this.hitPoint = 0;
			}
		}

		public MonsterPrototype Clone(){
			return new Monster(this.name,this.hitPoint,this.attackPower);
		}
		public void ShowParameter(){
			Console.WriteLine($"名前：{this.name}");
			Console.WriteLine($"体力：{this.hitPoint}");
			Console.WriteLine($"攻撃：{this.attackPower}");
		}
	}
}