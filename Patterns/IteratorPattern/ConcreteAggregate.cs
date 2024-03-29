using System;
using System.Collections.Generic;

namespace IteratorPattern{
	//具体的な集合のクラス
	class BookShelf : Aggregate{
		private List<Book> books;
		public BookShelf(){
			this.books = new List<Book>();
		}
		public Iterator iterator(){
			return new BookShelfIterator(this);
		}
		public void AddBook(string s){
			this.books.Add(new Book(s));
		}
		public void AddBook(){
			this.books.Add(new Book());
		}
		public int Size(){
			return this.books.Count;
		}
		public Book getAt(int i){
			return this.books[i];
		}
	}
}