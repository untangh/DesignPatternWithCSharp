using System;
using System.Collections.Generic;

namespace IteratorPattern{
	class MainProgram{
		public static void MainFunction(){
			BookShelf bookShelf = new BookShelf();
			Iterator it = bookShelf.iterator();
			bookShelf.AddBook("Java言語で学ぶデザインパターン");
			bookShelf.AddBook("ベーシック圏論");
			while(it.hasNext()){
				Book book = (Book)it.next();
				Console.WriteLine(book.name);
			}
		}
	}
}