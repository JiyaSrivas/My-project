using UnityEngine;

public class catcher : MonoBehaviour
{   public float speed=10f;
public float limit=8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input= Input.GetAxisRaw("Horizontal");
        transform.Translate(speed*input* Vector3.right*Time.deltaTime);

        Vector3 pos=transform.position;
        pos.x=Mathf.Clamp(pos.x,-limit,limit);
        transform.position=pos;




        
        
    }
}


