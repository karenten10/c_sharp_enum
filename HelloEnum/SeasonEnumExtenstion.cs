using System;
namespace HelloEnum
{
    public class SeasonEnumExtenstion
    {
        public SeasonEnumExtenstion()
        {
        }

        public static string getSeasonName(SeasonEnum season)
        {
            if (season == SeasonEnum.Spring)
            {
                return "第1季";
            }
            else if (season == SeasonEnum.Summer)
            {
                return "第2季";
            }
            else if (season == SeasonEnum.Autumn)
            {
                return "第3季";
            }
            else // (season == SeasonEnum.Winter)
            {
                return "第4季";
            }
        }
    }
}
