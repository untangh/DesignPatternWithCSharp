using System;

namespace AdapterPattern{

	//ターゲットがインターフェースの場合のアダプター
	class PrintBannerInterface : PrintInterface{
		private Banner banner;
		public PrintBannerInterface(string s){
			this.banner = new Banner(s);
		}
		public void printWeak(){
			this.banner.showWithParen();
		}
		public void printStrong(){
			this.banner.showWithAster();
		}
	}

	//ターゲットがクラスの場合のアダプター
	class PrintBannerClass : PrintClass{
		private Banner banner;
		public PrintBannerClass(string s){
			this.banner = new Banner(s);
		}
		public override void printWeak(){
			this.banner.showWithParen();
		}
		public override void printStrong(){
			this.banner.showWithAster();
		}
	}
}