using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\jammer\\Desktop\\mcke";
            

            

            //获取路径下的所有文件

            bool isCheck = true;

            for (; isCheck; )
            {
                Console.WriteLine("请输入文件夹路径");
                string path = Console.ReadLine();

                try
                {
                    

                    DirectoryInfo root = new DirectoryInfo(path);
                    FileInfo[] files = root.GetFiles();
                    List<FileInfo> LstFiles = files.ToList();

                    for (int o = 0; o < LstFiles.Count; o++)
                    {
                        Console.WriteLine(LstFiles[o].Name);
                    
                    }

                    Console.WriteLine("请输入想要删除的文件");

                    string InputFullName = Console.ReadLine();

                    for (int i = 0; i < LstFiles.Count; i++)
                    {
                        if (LstFiles[i].Name == InputFullName)
                        {

                            File.Delete(LstFiles[i].FullName);

                            Console.WriteLine("目标文件已被删除");
                            Console.ReadKey();
                            return;

                        }

                        Console.WriteLine("未能找到目标文件");
                        Console.ReadKey();
                        return;

                    }

                    




                
                    


                   // isCheck = false;

                }
                catch
                {

                    Console.WriteLine("请输入正确的文件路径");
                    isCheck = true;

                }
                
            }


           






            Console.ReadKey();
        }
    }
}
