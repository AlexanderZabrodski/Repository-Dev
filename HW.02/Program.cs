using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true); // объявление класса StreamReader который прочтет файл по указанному пути
            
            string textReaderResult = textReader.ReadToEnd(); // Чтение файла как строковой переменной
            
            textReader.Dispose(); // высвобождает ресурсы, которые используются объектом 
            
            string[] arrayOfTextResult = textReaderResult.Split(' '); // Разбивает полученную строку на подстроки указанным разделителем
            
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1]; // объявляем массив типа Byte размер которого соответствует длине считанных данных бит

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++) // Объявление цикла "i = 0, пока i < длины размера массива с постинкрементом +1
            {
                byte bynary = Convert.ToByte(arrayOfTextResult[i], 2); //конвертация строкового массива по очередности в переменную типа Byte
               
                imageBytes[i] = bynary; //запись этой переменной в элемент массива с индексом i
            } 
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes); //запись всех данных типа Byte в файл по указанному пути

        }
    }
}