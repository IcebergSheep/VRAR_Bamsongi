using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BamsongiGernerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 worldDir = ray.direction;

           bamsongiPrefab.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000);
           
           //bamsongiPrefab.GetComponent<BamsongiController>().Shoot(new Vector3(0, 200, 2000));
        }
    }
}
