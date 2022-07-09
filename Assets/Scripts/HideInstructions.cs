using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInstructions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HideInstructionsCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator HideInstructionsCoroutine()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }

    public void hideInstructions() 
    {
        StartCoroutine(HideInstructionsCoroutine());
    }

}
