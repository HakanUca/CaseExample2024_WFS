using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OyuncuKontrol : MonoBehaviour
{

    public Transform MermiPos;
    public GameObject mermi;
    public GameObject patlama;
    public Image canImaji;
    private float canDegeri = 100f;

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

    private void OnCollisionEnter (Collision c) 
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {
            Debug.Log("Zombi Saldirida.");
            canDegeri -= 10f;
            float x = canDegeri / 100f;
            canImaji.fillAmount = x;
            canImaji.color = Color.Lerp(Color.red, Color.green, x);
        }
    }
}
