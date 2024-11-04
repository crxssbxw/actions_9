namespace Classes;

abstract public class Duck : IDuck
{
    public string Name { get; set; }
    public virtual string Crack(){
        return "Крякает";
    }
    public virtual string Fly(){
        return "Летает";
    }
    public string Swim(){
        return "Плавает";
    }
}

public class MallardDuck : Duck
{
    public MallardDuck(string name){
        Name = name;
    }
}

public class DecoyDuck : Duck
{
    public override string Crack()
    {
        return "Не крякает";
    }
    public override string Fly()
    {
        return "Не летает";
    }
    
    public DecoyDuck(string name){
        Name = name;
    }
}
