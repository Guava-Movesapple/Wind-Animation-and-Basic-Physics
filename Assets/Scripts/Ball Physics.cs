using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

public class BallPhysics : MonoBehaviour
{

    private Rigidbody rb;

    [SerializeField]
    private Vector2 windDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(windDirection.x/5,0, windDirection.y/5));
    }

    public void onXUpdate(string input)
    {
        float x;
        
        try{
        x = float.Parse(input);
        }
        catch
        {
            return;
        }
        if(x > 25 || x < -25)
        {
            x = 0;
        }

        windDirection = new Vector2(x, windDirection.y);

        
    }

    public void onYUpdate(string input)
    {
        float y ;
        
        {
            
        }
        try{
        y = float.Parse(input);
        }
        catch
        {
            return;
        }

        if(y > 25 || y < -25)
        {
            y = 0;
        }

        windDirection = new Vector2(windDirection.x,y);

    
    }

    public void ResetBallPosition()
    {
        gameObject.transform.position = new Vector3(25, 101, 120);
    }
}
