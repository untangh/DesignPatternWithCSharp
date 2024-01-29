using System;

namespace IteratorPattern{
	//順番にアクセス可能な集合であることを表すインターフェース。
	interface Aggregate{
		//イテレータを返す関数
		Iterator iterator();
	}
}