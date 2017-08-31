using System;

namespace neiro {
    class Program {
		
		
        static void Main(string[] args) {
            Console.WriteLine("Hello, Vladislav! \n");

			Console.WriteLine("step=");
			int step = int.Parse(Console.ReadLine());
			Console.WriteLine("num=");
			int num = int.Parse(Console.ReadLine()) + step;
			
			
		Console.WriteLine("\n"+num+" better? ");
		string ansver = Console.ReadLine();
			
			
			neiro obj = new neiro(num, step, 1, ansver);
			while (obj.workpr == 1){obj.work();}
			
        }
		
		
		
		
		public class neiro {
		int num, step;
		public int workpr = 1;
		int prev_act;
		string prev_answ;
		
        public neiro(int num, int step, int prev_act, string prev_answ){
			this.num = num;
            this.step = step;
			this.prev_act = prev_act;
			this.prev_answ = prev_answ;
			
		if(prev_answ != "y") {
		this.prev_act = this.prev_act * -1; 
		}
		this.num = this.num + (this.step * this.prev_act);
		
	   }

		public void work(){
			
		Console.WriteLine("\n"+num+" better? ");
		//Console.WriteLine(num+" "+step+" "+prev_act+" "+prev_answ+" ");
		string ansver = Console.ReadLine();
		if(ansver != "end"){
			
			

		
		if(ansver != "y") {
		prev_act = prev_act * -1;
		//if( prev_answ == "y"){prev_answ= "n";}
		//if(ansver == "n"){prev_answ= "y";} 
		}
		
		num = num + (step * prev_act);
		workpr = 1;
		
		
		}else{
		Console.WriteLine("ended");
		workpr = 0;
		}
		
		}

		
		}
		
		
		
		
		
		
		
		
		
		
	}
}