// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Factories;

AbstractFactory shapeFactory = FactoryProducer.GetFactory(false);
var rectangleInst = shapeFactory.GetShape("rectangle");
rectangleInst.Draw();

var squareInst = shapeFactory.GetShape("SQUARE");
squareInst.Draw();

var circleInst = shapeFactory.GetShape("Circle");
circleInst.Draw();

var roundedRecInst = shapeFactory.GetShape("triangle"); // this will be null because this shape is invalid
//roundedRecInst.Draw();  // Error


// Get rounded factory
var roundedFactory = FactoryProducer.GetFactory(true);
roundedFactory.GetShape("rectangle").Draw();
roundedFactory.GetShape("circle").Draw();   // error, null

