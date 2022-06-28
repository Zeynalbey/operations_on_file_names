using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations_on_file_names
{
    internal class ValidationForFiles
    {
        private string _language;
        private string _fileName;

        public ValidationForFiles(string language, string fileName)
        {
            _language = language;
            _fileName = fileName;
        }

        public string FindLanguage(string text)
        {
            text = _language;

            if (text == "English")
            {
                return "This file ends with: ";
            }
            else if (text == "Russian")
            {
                return "Этот файл заканчивается следующим образом: ";
            }
            else if (text == "Azerbaijani")
            {
                return "Bu faylin sonlugu: ";
            }

            return "Dili duzgun secmesez de, neticeni deyirem:))))";
        }

        public string SplitToExtention(string text)
        {
            text = _fileName;

            string newtext = "";
            for (int i = text.Length - 1; i > 0; i--)
            {
                if (text[i] == '.')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        newtext += text[j];
                    }
                    break;
                }
            }
            return newtext;
        }

        public string CheckExtention(string text)
        {
            if (SplitToExtention(text) != ".jpg" && SplitToExtention(text) != ".mp3" && SplitToExtention(text) != ".pdf")
            {
                return "Faylin uzantisini duzgun yazin. ";
            }
            return "";
        }
    }
}