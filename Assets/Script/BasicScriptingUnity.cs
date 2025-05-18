using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicScriptingUnity : MonoBehaviour
{
    [Header("Property")]
    [SerializeField] string nameCube;
    [SerializeField] float kecepatanCube;
    [SerializeField] bool turboCube;
    [SerializeField] string debugging;

    // Start is called before the first frame update
    void Start()
    {
        debugging = "Test Cube ";
        Debug.Log(debugging + nameCube );
        Debug.Log("Memiliki kecepatan " + kecepatanCube);
        Debug.Log("Apakah memiliki turbo " + turboCube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
