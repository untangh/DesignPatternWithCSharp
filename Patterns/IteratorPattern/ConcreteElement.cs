using System;

namespace IteratorPattern{
	//具体的なAggregateの元のクラス。intとかでもOK
	class Book{
		public string name;
		public Book(string s){
			this.name = s;
		}
		public Book(){
			this.name = "Unknown";
		}
	}
}