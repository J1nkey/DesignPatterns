// Factory Pattern là 1 loại Creational pattern pattern, liên quan đến việc tạo ra các object tuỳ theo ngữ cảnh
// Trong factory pattern, chúng ta sẽ tạo ra các object mà không cần phải expose ra các creation logic để client và refer đến object được tạo ra bằng cách dùng 1 interface chung.

// Implementation


using FactoryPatternTraning.Abstracts;
using FactoryPatternTraning.Factories;
/**
* We're going to create a Shape interface and concrete classes implements this interface.
* A Factory class ShapeFactory is defined as a next step
* 
* Program, this main class will use ShapeFactory to get a Shape object.
* It will pass information (CIRCLE / RECTANGLE / SQUARE) to ShapeFactory to get the type of object it needs.
*/
var shapeFactory = new ShapeFactory();


IShape shape1 = shapeFactory.GetShape("circle");
// Call draw method of Circle
shape1.Draw();


IShape shape2 = shapeFactory.GetShape("Rectangle");
// Call draw method of Rectangle
shape2.Draw();


IShape shape3 = shapeFactory.GetShape("SQUARE");
// Call draw method of Square
shape3.Draw();


IShape shape4 = shapeFactory.GetShape(null);
// Call draw method of null (Error)
//shape4.Draw();

//IShape shape5 = shapeFactory.GetShape("triangles");
// Call draw method of null (Throw an Exception and error);
//shape5.Draw();


// Getting create more logic (Demo creating DbContextFactory)
DbContextFactory factory = new();
var dbContext1 = factory.CreateDbContext("this is an object type db context has optional connection string");
var dbContext2 = factory.CreateDbContext();

Console.WriteLine(dbContext1.GetConnectionString()); 
Console.WriteLine(dbContext2.GetConnectionString());


/*
 * Explaining:
 * I have a base DbContext with its constructor has a param with type DbContextOptions for getting connection string.
 * Now i'm wanting make a factory that generates a DbContext object.
 * 
 * I tried to make factory class with function is CreateDbContext that accepts connection string,
 * if not pass anything, this will use internal connection string that config inside appsettings.json.
 * 
 * Let's look above example, we just call CreateDbContext function in factory for creating DbContext object
 * based on connection string input.
 */
