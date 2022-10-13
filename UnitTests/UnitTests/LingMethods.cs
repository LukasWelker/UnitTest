using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinqMethod
{
    public class LinqMethods
    {


        public List<int> LinqMethod1(List<int> numbers1)
        {
            var nQuery = numbers1.Where(x => x % 2 == 0).ToList();
            return nQuery;
        }
        public List<string> LinqMethod2(List<string> cities)
        {
            string s = "Z";
            string e = "h";
            var filteredCities = cities.Where(x => x.StartsWith(s) && x.EndsWith(e));
            return filteredCities.ToList();
        }
        public List<string> LinqMethod3(string value )
        {

            string[] stringAnswer = value.Split(' ');
            var filtered = stringAnswer.Where(x => x == x.ToUpper());
            return filtered.ToList();
        }
        public List<string> LinqMethod4(string value)
        {
            var filtered = value
                
                //Sortiere die einzelnen Zeichen in diesem Fall Buchstaben nach Buchstaben also: Gruppe1 = e, Gruppe2 = a, etc....
                .GroupBy(zeichen => zeichen)
                //Nehme diese in dem Fall sortierte Zeichengruppe und schreibe diese in einen String
                .Select(zeichenGruppenInfo=>$"{zeichenGruppenInfo.Key}:{zeichenGruppenInfo.Count()}")
                //Füge diese sortierten zeichengruppenstrins in eine Liste
                .ToList();
            return filtered;
        }
        public string LinqMethod5(string[] arr1, string filter)
        {
            
            var filtered = arr1.SingleOrDefault(x=>x == filter);
            return filtered;  
        }
        public List<int> LinqMethod6(List<int> startingList)
        {
            var filtered = startingList.Where(x => x % 2 != 0 ).ToList();
            return filtered;
        }
        public List<int> LinqMethod7(List<int> startingList)
        {
            var filtered = startingList.OrderBy(o => o);
            return filtered.ToList();
        }
        public List<string> LinqMethod8(int[] startingArray)
        {
            var filtered = startingArray
                .GroupBy(x => x)
                .Select(y => $"{y.Key}:{y.Count()}");
            return filtered.ToList();
        }
        public List<int> LinqMethod9(List<int> startingList, int inputCondition)
        {
            var filtered = startingList.Where(x => x> inputCondition).ToList();
            return filtered;
        }
        public void LinqMethod10(List<string> listOfString)
        {
            var filtered = listOfString.FirstOrDefault(x =>x == "q");
        }
      
    }
}   

