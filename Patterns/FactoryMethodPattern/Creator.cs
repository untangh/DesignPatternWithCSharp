using System;

namespace FactoryMethodPattern{
	//Creatorは文字列からProductを作ることのみを規定する
	//その他の具体的な処理はサブクラスに任せる
	class Factory{
		public Product Create(string owner){
			Product p = CreateProduct(owner);
			RegisterProduct(p);
			return p;
		}
		public virtual void RegisterProduct(Product p){}
		public virtual Product CreateProduct(string owner){ return new Product(); }
	}
}