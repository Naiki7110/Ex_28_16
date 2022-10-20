using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUtilitys
{
    /// <summary>
    /// 入力用汎用ライブラリ
    /// </summary>
    class InputUtility
    {
        //入力用に作った汎用的関数
        /// <summary>
        /// Input String
        /// </summary>
        /// <param name="message">Prompt for input</param>
        /// <returns>Entered string</returns>
        static public string Input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        /// <summary>
        /// Enter an integer value
        /// </summary>
        /// <param name="message">Prompt for input</param>
        /// <returns>Entered Integer</returns>
        static public int InputNumber(string message)
        {
            int i = 0;
            while (true)
            {
                if (int.TryParse(Input(message), out i))
                {
                    break;
                }
                else
                {
                    OutputColoredText("異常な入力です、もう一度、入力して下さい", ConsoleColor.Red);
                }
            }
            return i;
        }
        /// <summary>
        /// Enter an integer value
        /// </summary>
        /// <param name="message">Prompt for input</param>
        /// <param name="max">Maximum value allowed</param>
        /// <param name="errorMessage">Messege for invalid value</param>
        /// <returns>Entered Integer</returns>
        static public int InputNumber(string message, int max, string errorMessage = "値が範囲外です")
        {
            return InputNumber(message, 0, max, errorMessage);
        }
        /// <summary>
        /// Enter an integer value
        /// </summary>
        /// <param name="message">Prompt for input</param>
        /// <param name="min">Minimum value allowed</param>
        /// /// <param name="max">Maximum value allowed</param>
        /// <param name="errorMessage">Messege for invalid value</param>
        /// <returns>Entered Integer</returns>
        static public int InputNumber(
            string message,
            int min,
            int max,
            string errorMessage = "値が範囲外です")
        {
            int i;
            while (true)
            {
                i = InputNumber($"{message}\n範囲は{min}から{max}");
                if (i >= min && i < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return i;
        }
        /// <summary>
        /// Enter a floating-point number
        /// </summary>
        /// <param name="message">Prompt for input</param>
        /// <returns>Entered number</returns>    
        static public float InputFloat(string message = "値を入力してください")
        {
            float i = 0;
            while (true)
            {
                if (float.TryParse(Input(message), out i))
                {
                    break;
                }
                else
                {
                    OutputColoredText("異常な入力です、もう一度、入力して下さい", ConsoleColor.Red);
                }
            }
            return i;
        }
        /// <summary>
        /// nter a floating-point number
        /// </summary>
        /// <param name="max">Maximum value allowed</param>
        /// <param name="message">Prompt for input</param>
        /// <param name="errorMessage">Messege for invalid value</param>
        /// <returns>Entered number</returns> 
        static public float InputFloat(string message, float max, string errorMessage = "入力エラー")
        {
            return InputFloat(message, 0, max, errorMessage);
        }
        static public float InputFloat(
            string message,
            float min,
            float max,
            string errorMessage = "入力エラー")
        {
            float i;
            while (true)
            {
                i = InputFloat($"{message}\n範囲は{min}から{max}");
                if (i >= min && i < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return i;
        }
        /// <summary>
        /// Write text with color
        /// </summary>
        /// <param name="s">string</param>
        /// <param name="c">color</param>
        static public void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static public bool IsInRange<T>(T val, T min, T max) where T : IComparable<T>
        {
            return val.CompareTo(min) >= 0 && val.CompareTo(max) < 0;
        }
    }
}

