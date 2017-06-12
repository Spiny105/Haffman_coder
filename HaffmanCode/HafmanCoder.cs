using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace HaffmanCoder
{
    /// <summary>
    /// Статичный класс. Предназначен для работы с кодами Хафмана
    /// </summary>
    public static class HafmanCoder
    {
        /// <summary>
        /// Проверка на то, является ли число степенью числа "2"
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns>true - является, false - не является</returns>
        private static bool is_binary(double number)
        {
            //Если после очередного деления на два получилась ровно 1, значит степень двойки
            if (number == 1)
                return true;
            else 
                if (number < 1) //Если меньше 1 (остаток от деления), значит не степень 2
                    return false;

            //Рекурсивный вызов функции
            return (is_binary(number / 2));
        }

        /// <summary>
        /// Метод кодирования по Хафману
        /// </summary>
        /// <param name="source">Исходное число</param>
        /// <returns>Результат кодирования</returns>
        public static int incode(int source)
        {
            #region Локальные переменные

            int result = 0;
            BitArray source_bits;                      //Двоичный массив (исходное число)
            BitArray in_coded_bits = new BitArray(32); //Двличный массив (после кодирования)

            #endregion

            #region Перевод числа в двоичный массив

            int[] for_convert = new int[1];
            for_convert[0] = source;
            source_bits = new BitArray(for_convert);

            #endregion

            #region Пишем число в кодовый лист без служебных символов

            
            for (int i = 0, code_pointer = 0; i < 26; i++, code_pointer++)
            {
                while (is_binary(code_pointer + 1))
                {
                    in_coded_bits[code_pointer] = false;
                    code_pointer++;
                }

                in_coded_bits[code_pointer] = source_bits[i];
            }

            #endregion

            #region Добавляем служебные биты

            List<byte> for_correction_bits_calculation = new List<byte>();
            int[] correction = new int[1];
            correction[0] = 0;

            for (int i = 0; i < in_coded_bits.Count; i++)
                if (in_coded_bits[i])
                    for_correction_bits_calculation.Add((byte)(i + 1));

            for (int i = 0; i < for_correction_bits_calculation.Count; i++)
                correction[0] ^= for_correction_bits_calculation[i];

            BitArray correction_bits = new BitArray(correction);

            for (int i = 0; i < 5; i++)
                in_coded_bits[(int)(Math.Pow(2, i) - 1)] = correction_bits[i];

            #endregion

            #region Собираем из полученной последовательности исходное число

                for (int i = 0; i < in_coded_bits.Count; i++)
                    result |= ((Convert.ToInt32(in_coded_bits[i])) << i);

            #endregion

            return result;
        }

        /// <summary>
        /// Метод исправления однократной ошибки по Хафману
        /// </summary>
        /// <param name="source">Исходное число</param>
        /// <returns>Результат декодирования</returns>
        public static int correction(int source)
        {
            #region Локальные переменные 

            int result = 0;                                            //результат исправления ошибок
            List<byte> for_invalid_bit_calculation = new List<byte>(); //Для вычисления ошибочного бита
            byte correction_bits = 0;                                  //Сюда заносятся корректирующие биты
            byte number_of_invalid_bit = 0;                            //Номер бита с ошибкой

            #endregion

            #region Перевод исходного числа в массив битов

            int[] for_bit_conversion = new int[1];
            for_bit_conversion[0] = source;
            BitArray source_bits = new BitArray(for_bit_conversion);

            #endregion

            #region Вычисление номера бита с ошибкой и его исправление

            for (int i = 0; i < source_bits.Count; i++)
                if (source_bits[i] == true)
                    if (is_binary(i + 1))
                        continue;
                    else
                        for_invalid_bit_calculation.Add((byte)(i + 1));

            for (int i = 0; i < 5; i++)
                correction_bits |= (byte)(Convert.ToByte(source_bits[(int)(Math.Pow(2,i)) - 1]) << i);

            for_invalid_bit_calculation.Add(correction_bits);

            for (int i = 0; i < for_invalid_bit_calculation.Count; i++)
                number_of_invalid_bit ^= for_invalid_bit_calculation[i];

            if (number_of_invalid_bit != 0)
                source_bits[number_of_invalid_bit - 1] = !source_bits[number_of_invalid_bit - 1];

            #endregion

            #region "Сборка" числа из массива битов

            for (int i = 0; i < source_bits.Count; i++)
                result |= ((Convert.ToInt32(source_bits[i])) << i);

            #endregion

            return result;
        }

        /// <summary>
        /// Декодирование по Хафману
        /// </summary>
        /// <param name="source">Закодированная последовательность</param>
        /// <returns>Декодированная последовательность</returns>
        public static int decode(int source)
        {
            #region Локальные переменные

            BitArray source_bits;
            int result = 0;
            BitArray result_bits = new BitArray(32);

            #endregion

            #region перевод числа в массив битов

            int[] for_convert = new int[1];
            for_convert[0] = source;
            source_bits = new BitArray(for_convert);

            #endregion

            #region Переписать в массив битов декодированного числа

            for (int i = 0, bit_pointer = 0; i < 32; i++)
            {
                if (is_binary(i + 1))
                    continue;

                result_bits[bit_pointer++] = source_bits[i];
            }

            #endregion

            #region "Сборка" числа из массива битов

            for (int i = 0; i < result_bits.Count; i++)
                result |= ((Convert.ToInt32(result_bits[i])) << i);

            #endregion

            return result;
        }
    }
}
