using EnglishStudy.DB.Abstract.Implement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EnglishStudy.BL.Implement.Implement
{
    public class Data
    {
       private Dictionary<string, Word> _dictionary = new Dictionary<string, Word>();

        List<string> _list = new List<string>();

        Random random = new Random();
        
        public Data()
        {
            _dictionary = InisiliezeDictionary();
            InisiliezeList();
        }

        public Dictionary<string, Word> GetDictionary
        {
            get { return _dictionary; }
        }

        private void InisiliezeList()
        {
            _list.Clear();

            foreach (var item in _dictionary.Values)
            {
                _list.Add(item.WordUkr);
            }
        }

        public string GetUkrWord()
        {
            string _word = null;

            if (_list.Count > 0)
            {
                _word = _list.ElementAt(random.Next(0, _list.Count()));
                _list.Remove(_word);

                if (_list.Count == 0)
                {
                    InisiliezeList();
                }
            }



            return _word;
        }

        private Dictionary<string, Word> InisiliezeDictionary()
        {
            DataTable table = EnglishStudyDB.GetTableToDictionary();

             foreach (DataRow item in table.Rows)
            {
                _dictionary.Add( item["sourceImage"].ToString(), 
                    new Word(item["ukrWord"].ToString(), item["englishWord"].ToString(), item["transkription"].ToString()));
                
            }

            return _dictionary;
        }


    }
}
