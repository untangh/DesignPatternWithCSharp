using System;

namespace IteratorPattern {
	interface Iterator{
		bool hasNext();
		object next();
	}
}