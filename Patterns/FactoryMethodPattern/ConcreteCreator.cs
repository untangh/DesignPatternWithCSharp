using System;
using System.Collections.Generic;

namespace FactoryMethodPattern{
	//Creatorの具体的な作成処理を実装するクラス
	//実質Productorのコンストラクタをここでやる（？）
	class IDCardFactory : Factory{
		List<Product> products;
		public IDCardFactory(){
			this.products = new List<Product>();
		}
		public override void RegisterProduct(Product p)
		{
			products.Add(p);
		}
		public override Product CreateProduct(string owner)
		{
			return new IDCard(owner);
		}
	}
}