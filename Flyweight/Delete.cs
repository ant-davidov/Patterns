using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Sentence
    {

        private string[] massWord;
        private readonly Dictionary<int, EditText> tags = new Dictionary<int, EditText>();

        public Sentence(string text)
        {
            massWord = text.Split(' ');
        }
        public EditText this[int index]
        {
            get
            {
                if(tags.ContainsKey(index) ) return tags[index];
                var et =new EditText();
                tags.Add(index,et);
                return tags[index];
            }
        }

        public override string ToString()
        {
            var bilder = new StringBuilder();

            for (int i = 0; i < massWord.Length; i++)
            {
                if (tags.ContainsKey(i))
                {
                    return " fd";
                };
                return massWord[i];
            }
            return bilder.ToString();   
        }


    }


    public class EditText 
    {
        public bool Capitalize { get; set; }
        public bool Italic { get; set; }

       
    }

    

    
    

}
