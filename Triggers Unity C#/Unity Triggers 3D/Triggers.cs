using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Triggers : MonoBehaviour
{
    public PlayableDirector NameYouGiveIt; // public = makes it see able in the inspector in Unity // PlayableDirector = adds the Timeline to the inspector // NameYouGiveIt = the name you want to name the Timeline
    public bool OneTimeTrigger = false; // True if you wanna use the trigger once // Puts it in the inspector

    private void OnTriggerEnter(Collider other) // Adds the trigger to enter 
    {
        NameYouGiveIt.Play();// Plays the Timeline ( public PlayableDirector "name of the timeline"
    }

    private void OnTriggerExit(Collider other) // Adds Exit Trigger
    {  
        NameYouGiveIt.Stop(); // Stop the timeline
    }

    private void OnTriggerStay(Collider other) // Adds trigger Enter and Exit
    {
        NameYouGiveIt.Play(); 
        // You can add to it
    }

    private void OnParticleTrigger()//Add the particle) // Adds a Trigger to a particle    
    {
        NameYouGiveIt.Play();
        //Put your code in for the particle
    }

    // You can add enter and exit trigger to any method ^ the 4 main triggers for 3D 

    private void OnTriggerEnter2D(Collider2D collision) // Adds a 2D Enter Trigger
    {
        NameYouGiveIt.Play();
    }

    private void OnTriggerExit2D(Collider2D collision) // Adds a 2D Exit Trigger
    {
        NameYouGiveIt.Stop();
    }

    private void OnTriggerStay2D(Collider2D collision) // Adds a 2D Enter and Exit Trigger
    {
        NameYouGiveIt.Play();
    }
}
