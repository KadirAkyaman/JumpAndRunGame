using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementRTL : MonoBehaviour
{
    public float destroyTime;
    float randomNumber;
    public GameObject obsMainObject;



    void Start()
    {
        randomNumber = Random.Range(5, 8);
    }

    private void Update()
    {

        if (randomNumber != 0)
        {
            if (randomNumber > 0)
            {
                randomNumber -= Time.deltaTime;
                if (randomNumber < 1 && randomNumber > 0)
                {
                    randomNumber = 0;
                }

            }
        }
        else
        {
            StartCoroutine(creator());
            randomNumber = Random.Range(5, 8);
        }

    }



    IEnumerator creator()
    {

        GameObject clone = Instantiate(obsMainObject);
        yield return new WaitForSeconds(destroyTime);
        Destroy(clone);

    }
}
