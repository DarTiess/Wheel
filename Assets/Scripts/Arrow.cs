using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private int result = 0;
    PolygonCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        collider= GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log(collision.gameObject.name + " trigger");
            result = collision.gameObject.GetComponent<CirclePiece>().price;
        }
    }

    public void SetTrigger()
    {
        collider.enabled = true; 
        StartCoroutine(OFFTrigger());
    }
    public int GetResult()
    {
       
        return result;
    }

    IEnumerator OFFTrigger()
    {
        yield return new WaitForSeconds(0.3f);
        collider.enabled = false;
    }
}
