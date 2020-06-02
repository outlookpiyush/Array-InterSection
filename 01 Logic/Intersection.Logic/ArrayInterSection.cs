using System.Collections.Generic;
using System.Linq;

namespace Intersection.Logic
{
    public class ArrayInterSection
    {
        public string GetInterSection(string[] stringArray)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (var strElement in stringArray)
            {
                var listElement = strElement.Split(',').ToList();
                for (int i = 0; i < listElement.Count(); i++)
                {
                    if (dictionary.ContainsKey(listElement[i].Trim()))
                    {
                        dictionary[listElement[i].Trim()] = (int)dictionary[listElement[i].Trim()] + 1;
                    }
                    else
                        dictionary.Add(listElement[i].Trim(), 1);
                }
            }
            var finalList = dictionary.Where(c => c.Value > 1).Select(x => x.Key).ToList();
            return string.Join(",", finalList);
        }
    }
}
