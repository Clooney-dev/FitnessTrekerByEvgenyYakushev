﻿using FitnesTrekerByEvgenyYakushev.Bl.Controller;
using FitnesTrekerByEvgenyYakushev.Bl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesTrekerByEvgenyYakushev.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение FitnesTrekerByEvgenyYakushev");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();


            var userController = new UserController(name);
            if (userController.IsNewUser)
            {

                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weight = ParseDouble("вес");
                var height = ParseDouble("рост");

                

                userController.SetNewUserData(gender, birthDate, weight, height);
            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();



            
        }

        private static double ParseDouble(string name)
        {


            while (true)
            {


                Console.Write($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;

                }
                else
                {
                    Console.WriteLine($"Неверный формат{name}");
                }
            }















        }
        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {


                Console.Write("Введите дату рождения  (dd.MM.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения");
                }
            }

            return birthDate;
        }
    }
}