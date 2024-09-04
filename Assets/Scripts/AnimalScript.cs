using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    public enum AnimalType
    {
        Dog, 
        Corgi, 
        Beagle, 
        Eagle, 
        Seal, 
        Squirrel, 
        Capybara
    }
    public AnimalType ThisIsMyAnimalType;
    public int Health;
    public int Money; 
    // Start is called before the first frame update
    void Start()
    {
        /* Bread 0
         * Milk 1 
         * Dragon Fruit 2 
         * Artichoke Dip 3
         */ 

        //little messages
        for(int i = 0; i < Money; i++)
        {
            //the stuff
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
