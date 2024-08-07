namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Move(@"C:\Users\Brill\Desktop\Report.txt", @"C:\Users\Brill\Desktop\Новая папка 1\Report.txt");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void Move(string originalParth, string newParth)
        {
            if (newParth is null) throw new ArgumentNullException();
            if (originalParth is null) throw new ArgumentNullException();
            if (!File.Exists(originalParth)) throw new FileNotFoundException();
            File.Move(originalParth, newParth, true);
        }
    }
}

//Создайте приложение для перемещения файлов.
//Пользователь вводит путь к оригинальному файлу и путь к тому месту куда нужно переместить файл. 
//Приложение должно сообщить об успешности или неуспешности операции.