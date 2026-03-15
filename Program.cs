namespace reverse_only_vowels_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and it will reverse the vowels : ");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int left = 0;
            int right = chars.Length -1;
            

            while (left < right)
            {
                while (left < right && !IsVowel(chars[left]))
                {
                    
                    
                    left++;
                }
                while (left < right && !IsVowel(chars[right]))
                {
                    
                    right--;
                }
                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }
            
            

            Console.WriteLine(new string(chars));
        }
        static bool IsVowel(char c)
        { 
            if (c =='a'|| c == 'e' || c == 'i' || c == 'o' || c == 'u'|| c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                return true;
            }
            else
                return false;
        }




    }
}
