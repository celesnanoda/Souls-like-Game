using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoulsGame;

public class FracturedObject : MonoBehaviour
{

    public List<Transform> child;
    public Vector3[] initialLocalPos;
    public Quaternion[] initialLocalRot;
    public GameObject player;
    public float fractureAmount;
    public float translateAmount;
    public Vector3 rotateEuler;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerManager>().gameObject;
        for(int i = 0; i < transform.childCount; i++)
        {
            child.Add(transform.GetChild(i));
        }

        initialLocalPos = new Vector3[child.Count];
        initialLocalRot = new Quaternion[child.Count];

          for(int i = 0; i < child.Count; i++)
        {
            initialLocalPos[i] = child[i].localPosition;
            initialLocalRot[i] = child[i].localRotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        distance = Mathf.Abs(distance);
        distance -= 31;
        distance = Mathf.Min(1, distance);
        
        for(int i = 0; i < child.Count; i++)
        {
            

            

            Vector3 dir = child[i].localPosition;
            dir.Normalize();
            
            child[i].localPosition = initialLocalPos[i] + dir * translateAmount * distance;
            child[i].localRotation = initialLocalRot[i] * Quaternion.Euler(rotateEuler);

        }
    }
}
