using System;
using System.Collections.Generic;

namespace IteratorPattern{
	//イテレータの具体的なクラス
	class BookShelfIterator : Iterator{
		//こいつは具体的なBookShelfクラスの情報が必要
		public BookShelf bookShelf;
		int index;
		public BookShelfIterator(BookShelf bs){
			this.bookShelf = bs;
			this.index = 0;
		}
		public bool hasNext(){
			if(this.index < this.bookShelf.books.Count){
				return true;
			}
			else{
				return false;
			}
		}
		public object next(){
			if(hasNext()){
				Book ret = this.bookShelf.books[this.index];
				this.index++;
				return ret;
			}
			else{
				return null;
			}
		}
	}
}