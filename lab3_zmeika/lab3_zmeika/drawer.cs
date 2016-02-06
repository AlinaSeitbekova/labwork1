using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Example3.Models
{   [Serializable]
    public class Drawer
    {
        public List<Point> body = new List<Point>();//массив точек 
        public ConsoleColor color;
        public char sign;
        public int score=0;
        public int cnt=1;
        public Drawer()
        {
            color = ConsoleColor.Blue;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)// для каждой точки из массива выполнить след операции
            {
        
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
     /*   
        public void Save()
        {
            Type t = GetType();
            FileStream fs = new FileStream(string.Format("{0}.xml", t.Name), FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(t);
            xs.Serialize(fs, this);
            fs.Close();
        }

        public void Resume()
        {
            Type t = GetType();
            FileStream fs = new FileStream(string.Format("{0}.dat", t.Name), FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(t);
            if (t == typeof(Wall)) Game.wall = xs.Deserialize(fs) as Wall;
            if (t == typeof(Snake)) Game.snake = xs.Deserialize(fs) as Snake;
            if (t == typeof(Food)) Game.food = xs.Deserialize(fs) as Food;
            fs.Close();
        }
      */
        

//ЗАДАНИЕ 5!
//бинарная сериализация и десериализация
//
        
        public void Save2()
        {
            Type t = GetType();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(string.Format(@"C:\Users\Home\Source\Repos\labwork1\lab3_zmeika\lab3_zmeika\bin\Debug\{0}.dat", t.Name), FileMode.Create, FileAccess.Write);
                        
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void Resume2()
        {
            Type t = GetType();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(string.Format(@"C:\Users\Home\Source\Repos\labwork1\lab3_zmeika\lab3_zmeika\bin\Debug\{0}.dat", t.Name), FileMode.Open, FileAccess.Read);
            //BinaryFormatter bf = new BinaryFormatter();

            if (t == typeof(Wall)) Game.wall = bf.Deserialize(fs) as Wall;
            if (t == typeof(Snake)) Game.snake = bf.Deserialize(fs) as Snake;
            if (t == typeof(Food)) Game.food = bf.Deserialize(fs) as Food;
            fs.Close();
         }
        
         
    }
}