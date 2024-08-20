using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird
{
    int wing = 2;
    int legs = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }

    public void voice()
    {
        Debug.Log("Cheep Cheep~~~");
    }
}

public class Cat
{
    int tail = 1;
    int legs = 4;

    public void run()
    {
        Debug.Log("I'm Faster!");
    }

    public void voice()
    {
        Debug.Log("meow meow~");
    }
}

public class AmericanShortHair : Cat
{
    Bomb bomb01 = new Bomb();

    public void attack()
    {
        bomb01.explod();
    }
}


public class Bomb
{
    public void explod()
    {
        Debug.Log("Boommmmmmmmmmmmmmm!!!!");
    }
}

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bird tongchai = new Bird();
        Bird somtavin = new Bird();
        Cat Sky = new Cat();
        Cat Snow = new Cat();

        tongchai.fly();
        somtavin.voice();
        Sky.run();
        Snow.voice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
