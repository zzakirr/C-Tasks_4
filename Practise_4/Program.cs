using System;

namespace Practise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size - 1; i++)
                nums[i] = Convert.ToInt32(Console.ReadLine());
            int newNum = Convert.ToInt32(Console.ReadLine());
            int[] result = newArr(ref nums, newNum);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }*/
            #endregion

            #region Task-2
            /*string name = Console.ReadLine();
            string result = newName(ref name);
            Console.WriteLine(result);*/
            #endregion

            #region Task-3
            /*int num = Convert.ToInt32(Console.ReadLine());
            int result = kokAlti(num);
            Console.WriteLine(result);*/
            #endregion


        }

        static int[] newArr(ref int[]  nums, int  newNum )

        {
            nums[nums.Length - 1] = newNum;
            return nums;
        }

        static string newName(ref string name)
        {
            string name2 = "";
            //int j = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    name2 += name[i];
                    //j++;
                }
            }
            return name2;
        }

        static int kokAlti(int num)
        {
            int i = 2, temp=0 ;
            if (num == 0)
                return 0; 
            if (num == 1)
                return 1;  
            
            while(i<num/2)
            {
                if (i * i == num)
                {
                    temp = i;
                    break;
                }
                else if (i * i < num)
                    i++;
                else
                {
                    temp = i - 1;
                    break;
                }
                
            }
            return temp;
        }
    }
}
