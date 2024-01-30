using System;
using System.Collections.Generic;

namespace BuilderPattern {
	class Director {
		DocumentBuilder documentBuilder;
		string title;
		string str;
		List<string> items;

		public Director(DocumentBuilder builder, string title,string str){
			this.documentBuilder = builder;
			this.title = title;
			this.str = str;
			this.items = new List<string>();
		}

		public void AddItem(string item){
			this.items.Add(item);
		}

		public void Construct(){
			documentBuilder.CreateDocument(this.title, this.str, this.items);
		}


	}
}