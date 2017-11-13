using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudy.BL.Implement.Implement
{
    public class Data
    {
        Dictionary<string, Word> _dictionary;

        List<string> _list = new List<string>();
        List<string> _currentList;

        Random random = new Random();

        public Data()
        {
            _dictionary = new Dictionary<string, Word>();
            
            _dictionary.Add(@"D:\\1.jpg", new Word("мама", "mother", "[mother]"));
            _dictionary.Add(@"D:\\2.jpg", new Word("кіт", "cat2", "[cat1]"));
            _dictionary.Add(@"D:\\3.jpg", new Word("кіт2", "cat3", "[cat2]"));
            _dictionary.Add(@"D:\\4.jpg", new Word("кіт3", "cat4", "[cat3]"));
            _dictionary.Add(@"D:\\5.jpg", new Word("кіт4", "cat5", "[cat4]"));
            _dictionary.Add(@"D:\\6.jpg", new Word("кіт5", "cat6", "[cat5]"));
            InisiliezeList();
        }

        public Dictionary<string, Word> GetDictionary
        {
            get { return _dictionary; }
        }

        private void InisiliezeList()
        {
            foreach (var item in _dictionary.Values)
            {
                _list.Add(item.WordUkr);
            }
            _currentList = _list;
        }

        public string GetUkrWord()
        {
            string _word = null;
                       

            if (_currentList.Count>0)
            {                
                _word = _currentList.ElementAt(random.Next(0, _currentList.Count()));
                _currentList.Remove(_word);
            }
           
            return _word;
        }
    }
}
