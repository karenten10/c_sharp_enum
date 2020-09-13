using System;
using System.Collections.Generic;

namespace HelloEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 逐一取出列舉中的每個項目
            foreach (SeasonEnum season in Enum.GetValues(typeof(SeasonEnum)))
            { 
            
                Console.WriteLine(season + "===> " + ((Int32) season));
            }

            List<AerobicClass> classes = new List<AerobicClass>() {
                new AerobicClass()
                {
                    Name = "Power Pilates",
                    Season = SeasonEnum.Summer,
                },
                new AerobicClass()
                {
                    Name = "Yoga Pilates",
                    Season = SeasonEnum.Autumn,
                },
                new AerobicClass()
                {
                    Name = "Dance Play",
                    Season = SeasonEnum.Autumn,
                },
            };

            Console.WriteLine("===> 列出全部課程名稱：");
            foreach (AerobicClass currentClass in classes) {

                string seasonName = SeasonEnumExtenstion.getSeasonName(currentClass.Season);
                Console.WriteLine("===> " + currentClass.Name + " : " + seasonName);
            }
        }
    }
}
