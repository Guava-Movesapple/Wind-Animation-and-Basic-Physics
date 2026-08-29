using UnityEngine;

public class WindControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private Vector2 windDirection;

    public GameObject menu;
    private bool menuActive = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        menu.SetActive(menuActive);
        Shader.SetGlobalVector("_Wind_Direction", windDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if(Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            Cursor.visible = !menuActive;
            menu.SetActive(!menuActive);
            menuActive = !menuActive; 
        }
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

        WindDirectionSetter();
    }

    public void onYUpdate(string input)
    {
        float y ;
        
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

        WindDirectionSetter();
    }

    void WindDirectionSetter()
    {
        Shader.SetGlobalVector("_Wind_Direction", windDirection);
    }
}
