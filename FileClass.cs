using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace myGame
{
    public class FileClass
    {
        private string path = @"C:\Users\Константин\Desktop\Game#\myGame\CountFlowers.dat";
        public FileClass() { }

        public void WriteToFile(int count)
        {
            int currentValue, newValue = 0;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            { 
                currentValue = reader.ReadInt32();
            }
            newValue = currentValue + count;
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(newValue);
            }
        }
        public int ReadFromFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
            { 
                int count = reader.ReadInt32();
                return count;
            }
            
        }
        
    }
}
