using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    IAK currentRifle;

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IAK rifle = new BasicAK();
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("q"))
        {
            IAK rifle = new BasicAK();
            rifle = new WithReflexSight(rifle);
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("w"))
        {
            IAK rifle = new BasicAK();
            rifle = new WithReflexSight(new WithStock(rifle));
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("e"))
        {
            IAK rifle = new BasicAK();
            rifle = new WithGrip(new WithStock(new WithReflexSight(rifle)));
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("r"))
        {
            IAK rifle = new BasicAK();
            rifle = new WithSilencer(new WithGrip(new WithStock(new WithReflexSight(rifle))));
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("t"))
        {
            IAK rifle = new BasicAK();
            rifle = new WithDrum(new WithSilencer(new WithGrip(new WithStock(new WithReflexSight(rifle)))));
            currentRifle = rifle;
            Debug.Log("Accuracy: " + rifle.GetAccuracy());
            Debug.Log("Ammo: " + rifle.GetAmmo());
        }

        if (Input.GetKeyDown("d"))
        {
            if (currentRifle != null)
            {
                GameObject.Destroy(currentRifle.GetGameObject());
                currentRifle = null;
            }
        }

        if (Input.GetKeyDown("a"))
        {
            if (currentRifle != null)
            {
                GameObject[] array = GameObject.FindGameObjectsWithTag("AK");
                foreach(GameObject i in array)
                {
                    GameObject.Destroy(i);
                }
                    currentRifle = null;
            }
        }
    }
}