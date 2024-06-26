using UnityEngine;
using System.Collections;

// carries the default resolution sizes to be used in other scripts

public class ResizingDefaultSizes : MonoBehaviour 
{
    private static ResizingDefaultSizes instance = null;
    public float DefaultResolutionWidth = 735;
    public float DefaultResolutionHeight = 550;

    void Awake()
    {
        instance = this;
    }

    public static ResizingDefaultSizes Instance
    {
		//SINGLETON INSTANCE OF ResizingDefaultSizes
        get
        {
            if (instance == null)
            {
                GameObject temp = new GameObject();
                instance = temp.AddComponent<ResizingDefaultSizes>();
                temp.name = "ResizingDefaultSizes";
                DontDestroyOnLoad(temp);
            }

            return instance;
        }
    }
}
