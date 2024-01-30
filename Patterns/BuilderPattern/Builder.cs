using System;
using System.Collections.Generic;

namespace BuilderPattern {
	//ドキュメントを作るときは
	//1.始める処理があり
	//2.タイトルを作って
	//3.内容の文字列を書いて
	//4.箇条書きをして
	//5.閉じる処理
	class DocumentBuilder {
		public virtual void Open(){}
		public virtual void MakeTitle(string title){}
		public virtual void MakeString(string str){}
		public virtual void MakeItems(List<string> items){}
		public virtual void Close(){}

		public void CreateDocument(string title,string str,List<string> items){
			Open();
			MakeTitle(title);
			MakeString(str);
			MakeItems(items);
			Close();
		}
	}
}