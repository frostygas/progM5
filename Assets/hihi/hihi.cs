using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class hihi : MonoBehaviour
{
    void Start()
    {
        Instantiate(this);
        Instantiate(this);
        Task.Run(run);
    }

    private async Task run()
    {
        //await Task.Delay(1000);

        Instantiate(this);
        Instantiate(this);
    }
}
