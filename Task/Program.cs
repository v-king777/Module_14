using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // LINQ
            var sortedPhoneBook1 = from c in phoneBook
                                   orderby c.Name, c.LastName
                                   select c;

            // Методы расширения
            var sortedPhoneBook2 = phoneBook
                .OrderBy(c => c.Name)
                .ThenBy(c => c.LastName);

            // Вывод результата
            foreach (var contact in sortedPhoneBook1)
            {
                Console.WriteLine($"{contact.Name} - {contact.LastName}" +
                    $" - {contact.PhoneNumber} - {contact.Email}");
            }
        }
    }
}
