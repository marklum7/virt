using System;

 public class Human
{
    protected internal string lang;
    public virtual void mySkills()
    {
        Console.WriteLine("Язык:"+lang);
    }
}

public class Worker : Human
{
    protected internal string profession;
    public override void mySkills()
    {
        base.mySkills();
        Console.WriteLine("Профуссия:"+ profession);
    }
}
public class Director : Worker
{
    public override void mySkills()
    {
        base.mySkills();
        Console.WriteLine("Получить деньги!!!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        director.lang = "Нем";
        director.profession = "Директор";
        director.mySkills();
    }
}