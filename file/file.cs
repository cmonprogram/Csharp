using System;
using System.IO;
//using System.IO.StreamWriter;
namespace std {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Vladislav! \n" + Directory.GetCurrentDirectory());
			Console.WriteLine("Project name?");
			string name = Console.ReadLine();
			writerer obj = new writerer(name);
			obj.makefile();
        }
		public class writerer {
		string name, fileName, textToAdd,textToAdd2;
                string path = Directory.GetCurrentDirectory();

		//FileStream fs = null;	
        public writerer(string name){
			this.name = name;
			this.fileName = name+".cs";
			this.textToAdd = "using System; "+Environment.NewLine+" namespace "+name+" {"+Environment.NewLine+" class Program {"+Environment.NewLine+" static void Main(string[] args) {"+Environment.NewLine+" Console.WriteLine(\"Hello, Vladislav!\");"+Environment.NewLine+" "+name+" obj = new "+name+"(1, 2);"+Environment.NewLine+" obj.work();"+Environment.NewLine+" }"+Environment.NewLine+" "+Environment.NewLine+" public class "+name+" {"+Environment.NewLine+" int num, step;"+Environment.NewLine+" public "+name+"(int num, int step){"+Environment.NewLine+" this.num = num;"+Environment.NewLine+" this.step = step;"+Environment.NewLine+" }"+Environment.NewLine+" public void work(){}"+Environment.NewLine+" }"+Environment.NewLine+Environment.NewLine+"}"+Environment.NewLine+"}";
			this.textToAdd2 = "csc "+this.fileName+" "+Environment.NewLine+"pause ";
			
			
	   }
		public void makefile(){
			Directory.CreateDirectory(@path+"\\"+name);
			using (FileStream fs = new FileStream(@path+"\\"+ name+"\\"+fileName, FileMode.CreateNew))
			{                
				using (StreamWriter writer = new StreamWriter(fs))
                { writer.Write(textToAdd);
				  writer.Close();
				}
			}
			
			
				using (FileStream fs = new FileStream(@path+"\\"+name+"\\start.bat", FileMode.CreateNew))
			{                
				using (StreamWriter writer = new StreamWriter(fs))
                { writer.Write(textToAdd2);
				  writer.Close();
				}
			}
			
			
			}
		}
	}
}