using System;
using System.Collections.Generic;


class BattleSituation{
	private List<Actor> actors;
	public BattleSituation(){
		this.actors = new List<Actor>();
	}
	public void AddActor(Actor actor){
		this.actors.Add(actor);
	}
	public Actor RandomPickupOtherThan(Actor actor){
		List<Actor> canPickupActor = new List<Actor>();
		for(int i=0;i<actors.Count;i++){
			if(this.actors[i] != actor){
				canPickupActor.Add(this.actors[i]);
			}
		}
		Random r = new Random();
		return canPickupActor[r.Next(0,canPickupActor.Count)];
	}
}

class Actor{
	//基本パラメータ
	private string name;
	private int hitPoint;
	private int attackPower;
	private int defencePower;

	public Actor(string name,int hitPoint,int attackPower,int defencePower){
		this.name = name;
		this.hitPoint = hitPoint;
		this.attackPower = attackPower;
		this.defencePower = defencePower;
	}
	public Actor(){
		this.name = "Dummy";
		this.hitPoint = 0;
		this.attackPower = 0;
		this.defencePower = 0;
	}

	//パラメータのフィールド
	public string Name{ get{ return this.name; } }
	public int HitPoint{ get{ return this.hitPoint; } }
	public int AttackPower{ get{ return this.attackPower; } }
	public int DefencePower{ get{ return this.defencePower; } }

	//基礎的な動き
	//自分のターンの流れ
	public virtual void ActionOnMyTurn(IReadOnlyList<Actor> actors){
		Console.WriteLine($"{this.name}のターン開始！");
		Actor targetOfAttack = SelectTargetOfAttack(actors);
		Console.WriteLine($"{targetOfAttack.Name}を攻撃！");
		int damage = DamageTo(targetOfAttack);
		Console.WriteLine($"{targetOfAttack.Name}に{damage}のダメージ！");
		targetOfAttack.ReduceHitPoint(damage);
		Console.WriteLine($"{this.name}のターン終了");
		return;
	}
	//攻撃対象を決める
	public virtual Actor SelectTargetOfAttack(IReadOnlyList<Actor> actors){
		return new Actor();
	}
	//対象のアクターに攻撃するときのダメージ量
	public virtual int DamageTo(Actor targetActor){
		return Math.Max(0, this.attackPower - targetActor.DefencePower);
	}
	//HPを減らす
	public void ReduceHitPoint(int otherAttackPower){
		this.hitPoint -= otherAttackPower;
		if(this.hitPoint <= 0){
			this.hitPoint = 0;
		}
	}
	//死んだかどうかを判定
	public bool IsDeath(){
		//死んでいればtrue
		if(this.hitPoint <= 0){
			return true;
		}
		else{
			return false;
		}
	}
}

class Slime : Actor{
	private int id;
	public Slime(int id) : base($"スライム{id}",10,2,1){}
	public Slime() : base(){}
	public override Actor SelectTargetOfAttack(IReadOnlyList<Actor> actors){
		Actor retActor = new Actor();
		for(int i=0;i<actors.Count;i++){
			if(actors[i] != this){
				retActor = actors[i];
			}
		}
		return retActor;
	}
}