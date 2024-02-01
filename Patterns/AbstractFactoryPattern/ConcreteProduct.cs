using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
	class OthelloAction : Action{
		int i;
		int j;
		int stone;
		int height;
		int width;
		//ゲッター：見るだけ
		//セッター：盤面の範囲内ならセット、そうじゃなければエラーメッセージ
		public int I{
			get{ return this.i; }
			set{
				if(value < height) this.i = value;
				else{
					Console.WriteLine($"error : Actionのiを{value}にできません");
				}
			}
		}
		public int J{
			get{ return this.j; }
			set{
				if(value < width) this.j = value;
				else{
					Console.WriteLine($"error : Actionのjを{value}にできません");
				}
			}
		}
		public int Stone{
			get{ return this.stone; }
			set{
				if(value == -1 || value == 0 || value == 1){
					this.stone = value;
				}
				else{
					Console.WriteLine($"error : Actionのstoneを{value}にできません");
				}
			}
		}
	}

	class OthelloEnvironment : Environment{
		int[,] board;
		public OthelloEnvironment(int n){
			board = new int[n,n];
			for(int i=0;i<n;i++){
				for(int j=0;j<n;j++){
					board[i,j] = 0;
				}
			}
		}
		public override void ApplyAction(Action action){
			OthelloAction othelloAction = (OthelloAction)action;
			this.board[othelloAction.I,othelloAction.J] = othelloAction.Stone;
		}
	}

	class OthelloActorRandomPut : Actor {
		public OthelloActorRandomPut(int id):base(id){}
		public override Action ChooseActionOfTurn(Environment environment){
			
		}
	}
}