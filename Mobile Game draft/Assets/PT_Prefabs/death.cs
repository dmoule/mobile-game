using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject GN;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name.Contains("Red")||col.gameObject.name.Contains("red"))
        {
            GN.GetComponent<GameManager>().dead = true;
            Destroy(gameObject);
            
        }
    }
}
