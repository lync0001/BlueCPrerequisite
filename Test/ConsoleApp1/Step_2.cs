using System;

public class Step_2
{
    private string school;
    private bool gender;
    private string name;
    private int age;

    public Step_2(string name, int age, bool gender)
    {
        this.name = "Jordy";
        this.age = 22;
        this.gender = 1;
    }

    public string getName()
    {
        return this.name;
    }

    public int getAge()
    {
        return this.age;
    }

    public bool getGender()
    {
        return this.gender;
    }
}
