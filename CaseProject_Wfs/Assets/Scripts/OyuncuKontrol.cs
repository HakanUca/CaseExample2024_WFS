using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{

    public Transform MermiPos;
    public GameObject mermi;
    public GameObject patlama
        ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject go = Instantiate(mermi, MermiPos.position, MermiPos.rotation) as GameObject;
            GameObject goPatlama = Instantiate(patlama, MermiPos.position, MermiPos.rotation) as GameObject;

            go.GetComponent<Rigidbody>().velocity = MermiPos.transform.forward * 10f;
            Destroy(go.gameObject, 2f);
            Destroy(goPatlama.gameObject, 2f);

        }
    }
}
