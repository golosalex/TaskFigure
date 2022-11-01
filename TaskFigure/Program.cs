﻿
//Задание:

//Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и
//треугольника по трем сторонам. Дополнительно к работоспособности оценим:

//Юнит-тесты  <= есть

//Легкость добавления других фигур  <= есть (как я понял полиморфизм нужен)

//Вычисление площади фигуры без знания типа фигуры в compile-time <= не понял, что надо хотелось бы другую формулировку

//Проверку на то, является ли треугольник прямоугольным <= есть


using FigureLib;

internal class Program
{
    private static void Main(string[] args)
    {
        var listOfFigure = new List<Figure>();
        listOfFigure.Add(new Triangle(3,4,5));
        listOfFigure.Add(new Triangle(4,5,6));
        listOfFigure.Add(new Circle(5));

        foreach(Figure f in listOfFigure)
        {
            Console.WriteLine(f.GetAreaOfFigure());
        }

        try
        {
            listOfFigure.Add(new Triangle(1, 1, 10));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        
     
    }
}

//В базе данных MS SQL Server есть продукты и категории. 
//    Одному продукту может соответствовать много категорий, 
//    в одной категории может быть много продуктов. 
//    Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
//    Если у продукта нет категорий, то его имя все равно должно выводиться.

//Также без выполненного задания отклик не будет рассмотрен. <= было бы здорово иметь условие в виде заданых таблиц базы данных
//не уверен что правильно понял. обычно связь многие ко многим выполняются через третью таблицу, которую и нидо вывесть,
//тогда что дано не понятно, а фраза "В базе данных MS SQL Server есть продукты и категории" меня тревожит.


// Table Prod :  ProdName CategoryName    <= к какой категории относится продукт (поле продукт обязательно, задается во много строк)
// Table Category: CategoryName ProdName  <= к какой продукт содержится в категории (категория обязательна)
// составные ключи и там и там.

// select Prod.ProdName, Category.CategoryName from Left Join Prod,Category on Prod.ProdName=Category.ProdName

// каков вопрос - таков ответ.