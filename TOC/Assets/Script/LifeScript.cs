using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour
{
    public int life;
    public static int remainingLife;
    [SerializeField] Image shuriken;
    void Start()
    {
        remainingLife = life;
        Debug.Log(remainingLife);
        shuriken.fillAmount = 100;
    }

    private void Update()
    {
        if (remainingLife == 0)
        {
            Invoke("loadScene", 0.5f);
        }
    }

    void loadScene()
    {
        SceneManager.LoadScene("LoseScene");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            remainingLife--;
            shuriken.fillAmount -= 0.33f;
            Debug.Log(remainingLife);
        }
        if (shuriken.fillAmount==0.009999931f)
        {
            shuriken.fillAmount = 0;
        }
    }

}
