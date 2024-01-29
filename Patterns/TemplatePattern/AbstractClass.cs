using System;

namespace TemplatePattern{
	class Display{
		public virtual void open(){}
		public virtual void print(){}
		public virtual void close(){}
		public void display(){
			open();
			for(int i=0;i<5;i++){
				print();
			}
			close();
		}
	}
}