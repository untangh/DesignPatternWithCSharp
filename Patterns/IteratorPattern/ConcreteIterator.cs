using System;
using System.Collections.Generic;

namespace IteratorPattern{
	//イテレータの具体的なクラス
	class BookShelfIterator : Iterator{
		//集合インターフェース
		BookShelf bookShelf;

		//今回は配列かリストに対してint型のindexをインクリメントすることでイテレータを進める
		int index;
		public BookShelfIterator(BookShelf bs){
			this.bookShelf = bs;
			this.index = 0;
		}
		public bool hasNext(){
			//オーバーしてればfalse
			if(bookShelf.Size() <= this.index){
				return false;
			}
			//イテレータが集合内ならtrue
			else{
				return true;
			}
		}
		public object next(){
			//nextがあればそれを返す
			if(hasNext()){
				object ret = this.bookShelf.getAt(this.index);
				this.index++;
				return ret;
			}
			//すでにイテレータが外に出てたらnullを返す
			else{
				return null;
			}
		}
	}
}