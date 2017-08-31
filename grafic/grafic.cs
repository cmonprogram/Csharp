using System;
using System.Drawing;

namespace graficstd {
    class Program {
		
		
        static void Main(string[] args) {
            Console.WriteLine("Hello, Vladislav! \n");
			
			
			grafic obj = new grafic(1, 2);
			obj.work();
			
        }
		
		
		
		
		public class grafic {
		int num, step;
		
		
        public grafic(int num, int step){
			this.num = num;
            this.step = step;
		
	   }

		public void work(){}

		
		}
		
		
		
		
		
		
		
		
		
		
	}
}