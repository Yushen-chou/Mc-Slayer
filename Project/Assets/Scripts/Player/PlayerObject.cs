using UnityEngine;


[DisallowMultipleComponent]
public class PlayerObject : MonoBehaviour
{
    public static PlayerObject instance;

    #region Unity Inspector Fields
    public int hp;
    public int hpMax = 10;
    #endregion


    private void Awake()
    {
        
    }

    private void Start()
    {
        hp = hpMax;
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {

    }
}
