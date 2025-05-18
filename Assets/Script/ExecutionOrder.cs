using UnityEngine;
using UnityEngine.UI;

public class ExecutionOrder : MonoBehaviour
{
    [Header("Property Mobil")]
    [SerializeField] string namaMobil = "BMW M3";
    [SerializeField] int kecepatanMobil = 300;
    [SerializeField] bool nitroMobil = true;

    [SerializeField] string debugging;
    public GameObject benda;

    // public Text _text;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Type " + namaMobil);
        print("Kecepatan Mobil " + kecepatanMobil + "km/jam");
        print("Nitro Mobil " + nitroMobil);

        Testing();

        benda.SetActive(false);
    }

    void Testing()
    {
        debugging = "Oke berhasil test";
        Debug.Log(debugging);
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    /*void FixedUpdate()
    {

    }

    void LateUpdate()
    {

    }*/
}
