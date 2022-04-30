using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlturaDoPersonagem : MonoBehaviour
{
    public Transform personagem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(personagem.position.y);
    }
}
