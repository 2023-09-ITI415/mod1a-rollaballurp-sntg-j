using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;
    public int instances = 12;
    public float radius = 1.0f;
    Vector3 spin = new Vector3(0, 10, 0);
    private float yLocale = 0.5f;
    private float zLocale;
    private float xLocale;
    private float angle;

    // Start is called before the first frame update
    public int getInstanceNums() { return instances; }
    void Start()
    {
        prefab.GetComponent<GameObject>();
        posFind();
    }
    private void posFind()
    {
        angle = Mathf.Deg2Rad * (360.0f / (float)instances); // finds the sections among all instances around 360 degrees and preps for proper locations converts to radians
        for (int i = 0; i < instances; i++)
        {
            xLocale = (radius) * Mathf.Cos(i * angle);
            zLocale = (radius) * Mathf.Sin(i * angle);
            Vector3 position = new Vector3(xLocale, yLocale, zLocale);
            GameObject.Instantiate<GameObject>(prefab, position, Quaternion.identity, GameObject.FindGameObjectWithTag("PickUpParent").transform);
        }
    }
    void Update()
    {
        transform.Rotate(spin * Time.deltaTime);
    }
}
