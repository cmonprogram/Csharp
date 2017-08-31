using System; 
 namespace newrep {
 class Program {
 static void Main(string[] args) {
 Console.WriteLine("Hello, Vladislav!");
 newrep obj = new newrep(1, 2);
 obj.work();
 }
 
 public class newrep {
 int num, step;
 public newrep(int num, int step){
 this.num = num;
 this.step = step;
 }
 public void work(){}
 }

}
}