using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Material[] materials;
    private bool first = true;
    

    private void Start()
    {
        int initialState = Random.Range(0, 3);

        switch(initialState)
        {
            case 0:
                StartCoroutine(Green());
                break;
            case 1:
                StartCoroutine(Yellow());
                break;
            case 2:
                StartCoroutine(Red());
                break;
        }

    }

    IEnumerator Green()
    {
        float time = Random.Range(5f, 10f);
        gameObject.GetComponent<MeshRenderer>().material = materials[0];
        gameObject.tag = "Green";
        yield return new WaitForSeconds(time);
        StartCoroutine(Yellow());
    }
    IEnumerator Yellow()
    {
        int time = 4;
        gameObject.GetComponent<MeshRenderer>().material = materials[1];
        gameObject.tag = "Yellow";
        yield return new WaitForSeconds(time);
        StartCoroutine(Red());
    }
    IEnumerator Red()
    {
        float time = Random.Range(5f, 10f);
        gameObject.GetComponent<MeshRenderer>().material = materials[2];
        gameObject.tag = "Red";
        yield return new WaitForSeconds(time);
        StartCoroutine(Green());
    }
}
