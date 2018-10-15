using Ganss.Excel;
using Npoi.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpoiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Read();

            Console.WriteLine("Enter to Exit");
            Console.ReadLine();
        }

        private static void Read()
        {
            var mapper = new ExcelMapper(@"C:\temp\test.xls");
            var data = mapper.Fetch<JalleData>("newSheet");//.Select(n=>n.Value);
            foreach (var item in data)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Write()
        {
            List<JalleData> data = new List<JalleData>();
            data.Add(new JalleData() { EtStortTall = 234234.2342, LittTekst = "Hei paa meg", OneNumber = 27 });
            data.Add(new JalleData() { EtStortTall = 7655.564, LittTekst = "Hei paa deg", OneNumber = 21 });

            var mapper = new ExcelMapper();
            mapper.Save(@"C:\temp\test.xls", data, "newSheet",false);
        }
    }
}
