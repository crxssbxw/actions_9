namespace Classes;

using System;
using System.Xml.XPath;

public class DuckLake
{
    private List<Duck> ducks = new();

    public List<Duck> Ducks
    {
        get => ducks;
        private set => ducks = value;
    }

    public string PerformFlyLake(){
        string result = "";
        
        foreach(Duck duck in ducks){
            result += $"{duck.Fly()}\n";
        }

        return result;
    }

    public void AddDuck(Duck duck){
        ducks.Add(duck);
    }

    public void RemoveDuck(Duck duck){
        ducks.Remove(duck);
    }

    public void ClearLake(){
        ducks.Clear();
    }
}