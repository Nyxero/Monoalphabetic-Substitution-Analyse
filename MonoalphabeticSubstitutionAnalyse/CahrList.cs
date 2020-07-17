using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    /// <summary>
    /// This class will create a unique character list from a string 
    /// to analyse the character percentage corresponding to the string.
    /// </summary>
    public class CharList
    {
        // Array of allowed characters.
        private char[] allowedCharacters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        /// <summary>
        /// List of analysed character object.
        /// </summary>
        public List<CharStat> CharStatList = new List<CharStat>();

        // Cleared (trim, to upper) string.
        private string _text;
        private uint _textLength;

        /// <summary>
        /// Add a character to the character list and will increment the counter 
        /// if the character already exist.
        /// </summary>
        /// <param name="c"></param>
        private void Add(char c)
        {
            if (allowedCharacters.Contains(c))
            {
                if (!ContainChar(c))
                    CharStatList.Add(new CharStat() { Character = c, Counter = 1 });
                else
                    CharStatList.FirstOrDefault(a => a.Character.Equals(c)).Counter += 1;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="text"></param>
        public CharList(string text)
        {
            _text = text.Trim().ToUpper();
            _textLength = Convert.ToUInt32(_text.Length);

            foreach(char c in _text)
                Add(c);

            CalculatePercentage();
            CharStatList.OrderBy(a => a.Percentage);
        }

        /// <summary>
        /// This method will check if a character object already exists in the list.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool ContainChar(char c)
        {
            foreach(CharStat charStat in CharStatList)
                if (charStat.Character.Equals(c))
                    return true;
            return false;
        }


        /// <summary>
        /// This method will calculate the percentag of a character corresponding to the text.
        /// </summary>
        private void CalculatePercentage()
        {
            foreach (CharStat charStat in CharStatList)
                charStat.Percentage = Math.Round((decimal)100 / (decimal)_textLength  * (decimal)charStat.Counter, 4);
        }


        /// <summary>
        /// This method will write the character list in the console.
        /// </summary>
        public void WriteToConsole()
        {
            Console.WriteLine("Character ; Percentage ; Counter");
            Console.WriteLine("--------------------------------");
            foreach (CharStat charStat in CharStatList)
                charStat.WriteToConsole();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Analysed text length: " + _textLength);
        }
    }
}
