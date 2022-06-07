using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class medals : MonoBehaviour
{
    public GameObject brz;
    public GameObject slv;
    public GameObject gld;
    public GameObject plt;

    // Update is called once per frame
    void Update()
    {
        medalclass();
    }


    private void medalclass()
    {
        if (Bird.bScore >= 5 & Bird.bScore <= 15)
        {
            brz.SetActive(true);
        }
        else if (Bird.bScore >= 16 & Bird.bScore <= 30)
        {
            brz.SetActive(false);
            slv.SetActive(true);
        }
        else if (Bird.bScore > 31 & Bird.bScore <= 50)
        {
            slv.SetActive(false);
            gld.SetActive(true);
        }
        else if (Bird.bScore >= 51 )
        {
            gld.SetActive(false);
            plt.SetActive(true);
        }


    }
}
