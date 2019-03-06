using System;

class Dog : IAnimal
{
    private string m_name;
    // On implémente la propriété Name accessible en lecture.
    public string Name
    {
        get { return m_name; }
    }

    public Dog(string name)
    {
        m_name = name;
    }

    // On implémente la méthode Move.
    public void Move()
    {
        Console.WriteLine("{0} bouge.", m_name);
    }
}