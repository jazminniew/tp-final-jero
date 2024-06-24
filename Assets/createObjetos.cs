using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObjetos : MonoBehaviour
{
    public GameObject[] newobject;
    public int currentObjectIndex = -1;
    public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (newobject.Length > 0)
        {
            currentObjectIndex = 0;
            newobject[currentObjectIndex].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNextObject();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePreviousObject();
        }
    }

    public void ActivateNextObject()
    {
        if (newobject.Length == 0) return;

        newobject[currentObjectIndex].SetActive(false);
        currentObjectIndex++;
        if (currentObjectIndex >= newobject.Length)
        {
            currentObjectIndex = 0;
        }
        newobject[currentObjectIndex].SetActive(true);
    }

    public void ActivatePreviousObject()
    {
        if (newobject.Length == 0) return;

        newobject[currentObjectIndex].SetActive(false);
        currentObjectIndex--;
        if (currentObjectIndex < 0)
        {
            currentObjectIndex = newobject.Length - 1;
        }
        newobject[currentObjectIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        foreach (GameObject g in newobject)
        {
            g.SetActive(false);
        }
    }
}
