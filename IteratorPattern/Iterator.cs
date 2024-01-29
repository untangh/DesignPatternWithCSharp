using System;

namespace IteratorPattern {
	//次に行ったりできるイテレータ
	//双方向イテレータとかを作るときはこいつを変えればいいね
	interface Iterator{
		bool hasNext();
		object next();
	}
}