using System;
using System.IO;

namespace Определение_слова_с_максимальной_долей_гласных_букв
{
    class Program
    {
        static int AllVowels(string stroka)
        {
            const string glas_lett = "АаУуОоЫыЭэЯяЮюЁёИиЕе";
            int cnt = 0;
            for (int i = 0; i < stroka.Length; ++i)
                for (int j = 0; j < glas_lett.Length; ++j)
                    if (stroka[i] == glas_lett[j])
                        ++cnt;
            return cnt;
        }
        static string[] FileRead(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str = sr.ReadToEnd();
            string[] words = str.Split(' ', ',', '?', '.', '\n');
            return words;
        }
       
        static void Calculation(string[] words)
        {
            string vowels = "АаУуОоЫыЭэЯяЮюЁёИиЕе";
            string consonants = "БбВвГгДдМмЗзЙйКкЛлНнПпРрСсТтФфХхЦцЧчШшЩщ";
            int vowels_count = 0, consonants_count = 0;
            foreach (string word in words)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (word.Contains(vowels[i]))
                    {
                        vowels_count++;
                    }
                }
                for (int i = 0; i < consonants.Length; i++)
                {
                    if (word.Contains(consonants[i]))
                    {
                        consonants_count++;
                    }
                }
                if (calculation_procent(vowels_count, consonants_count))
                {
                    Console.WriteLine($"{word}");
                }
            }
            static bool calculation_procent(int vowels, int consonants)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            //б, в, г, д, ж,з,й,к,л,м,н,п,р,с,т,ф,х,ц,ч,ш,щ.
            //АаУуОоЫыЭэЯяЮюЁёИиЕе
            try
            {
                StreamReader sr = new StreamReader("C:\\Users/user/Desktop/Исходные данные.txt");
                string str = sr.ReadToEnd();
                //string[] words = FileRead(@"C:\\Users\user\Desktop\Исходные данные.txt");
                AllVowels(str);
                int allcountvowels = AllVowels(str);
                //Calculation(words);
                Console.WriteLine(str);
                Console.WriteLine(" ");
                Console.WriteLine($"Общее количество гласных:{allcountvowels}");
                Console.ReadLine();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Выполнение: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Выполнение финального блока.");
            }


            
        }

    }
}
