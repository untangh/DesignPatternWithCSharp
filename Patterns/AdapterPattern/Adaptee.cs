using System;

namespace AdapterPattern{
	//こいつがアダプティーで、すでに提供されている奴
	class Banner{
		private string name;
		public Banner(string s){
			this.name = s;
		}
		public void showWithParen(){
			Console.WriteLine($"({this.name})");
		}
		public void showWithAster(){
			Console.WriteLine($"*{this.name}*");
		}
	}
}