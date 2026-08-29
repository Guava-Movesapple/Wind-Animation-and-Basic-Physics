using UnityEngine;

public class TextureSetter : MonoBehaviour
{

    [SerializeField]
    private Texture grassTexture;
    [SerializeField]
    private Texture leafTexture;
    [SerializeField]
    private Texture leafNormal;
    [SerializeField]
    private Texture barkTexture;
    [SerializeField]
    private Texture barkNormal;
    [SerializeField]
    private Texture alphaTree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Shader.SetGlobalTexture("_grass_tex", grassTexture);
        Shader.SetGlobalTexture("_Base_Color_Leaf", leafTexture);
        Shader.SetGlobalTexture("_Normal_Leaf", leafNormal);
        Shader.SetGlobalTexture("_Base_Color_Bark", barkTexture);
        Shader.SetGlobalTexture("_Normal_Bark", barkNormal);
        Shader.SetGlobalTexture("_Alpha", alphaTree);
    }

    
}
