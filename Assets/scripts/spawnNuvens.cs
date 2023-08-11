using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawNuvens : MonoBehaviour
{
    public GameObject nuvem;
    public float height;
    public float maxTime=1f;
    private float timer=0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newNuvem =Instantiate(nuvem);
        newNuvem.transform.position=transform.position+new Vector3(0, Random.Range(-height,height),0);
        Destroy(newNuvem, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxTime){
            GameObject newNuvem=Instantiate(nuvem);
            newNuvem.transform.position=transform.position+new Vector3(0, Random.Range(-height,height),0);
            Destroy(newNuvem, 10f);
            timer=0;
        }
        timer+=Time.deltaTime;
    }
}
