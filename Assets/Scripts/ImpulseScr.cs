using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseScr : MonoBehaviour
{
    [SerializeField] float force = 50;
    [SerializeField] float podarok = 4;
    [SerializeField] float dollar = 2;
    [SerializeField] string p;
   

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-1.0f,1.0f) * force, Random.Range(-1.0f,1.0f))*force, ForceMode2D.Impulse);
        StartCoroutine(DestroySurprise());
    }
    IEnumerator DestroySurprise()
    {
        float seconds = 0.2f;
        yield return new WaitForSeconds(4);
        for(int i = 0; i < 5; i++)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            yield return new WaitForSeconds(seconds);
            GetComponent<SpriteRenderer>().color = Color.white;
            yield return new WaitForSeconds(seconds);
        }
        Destroy(gameObject);
        
    }
    private void OnMouseDown()
    {
        CountScr.S.Count( p);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
