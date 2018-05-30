using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scramble : MonoBehaviour
{
    public GameObject tile0; public GameObject tile1; public GameObject tile2; public GameObject tile3;
    public GameObject tile4; public GameObject tile5; public GameObject tile6; public GameObject tile7;
    public GameObject tile8; public GameObject tile9; public GameObject tile10; public GameObject tile11;
    public GameObject tile12; public GameObject tile13; public GameObject tile14; public GameObject tile15;
    public GameObject tile16; public GameObject tile17; public GameObject tile18; public GameObject tile19;
    public GameObject tile20; public GameObject tile21; public GameObject tile22; public GameObject tile23;
    Vector3[] locations = {
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}};
    private static System.Random rng = new System.Random();
    int[] list = new int[24];
    int value;
    // Use this for initialization
    void Start()
    {
        tile0 = GameObject.Find("GameObject");
        tile1 = GameObject.Find("GameObject (1)");
        tile2 = GameObject.Find("GameObject (2)");
        tile3 = GameObject.Find("GameObject (3)");
        tile4 = GameObject.Find("GameObject (4)");
        tile5 = GameObject.Find("GameObject (5)");
        tile6 = GameObject.Find("GameObject (6)");
        tile7 = GameObject.Find("GameObject (7)");
        tile8 = GameObject.Find("GameObject (8)");
        tile9 = GameObject.Find("GameObject (9)");
        tile10 = GameObject.Find("GameObject (10)");
        tile11 = GameObject.Find("GameObject (11)");
        tile12 = GameObject.Find("GameObject (12)");
        tile13 = GameObject.Find("GameObject (13)");
        tile14 = GameObject.Find("GameObject (14)");
        tile15 = GameObject.Find("GameObject (15)");
        tile16 = GameObject.Find("GameObject (16)");
        tile17 = GameObject.Find("GameObject (17)");
        tile18 = GameObject.Find("GameObject (18)");
        tile19 = GameObject.Find("GameObject (19)");
        tile20 = GameObject.Find("GameObject (20)");
        tile21 = GameObject.Find("GameObject (21)");
        tile22 = GameObject.Find("GameObject (22)");
        tile23 = GameObject.Find("GameObject (23)");
        locations[0] = tile0.transform.position;
        locations[1] = tile1.transform.position;
        locations[2] = tile2.transform.position;
        locations[3] = tile3.transform.position;
        locations[4] = tile4.transform.position;
        locations[5] = tile5.transform.position;
        locations[6] = tile6.transform.position;
        locations[7] = tile7.transform.position;
        locations[8] = tile8.transform.position;
        locations[9] = tile9.transform.position;
        locations[10] = tile10.transform.position;
        locations[11] = tile11.transform.position;
        locations[12] = tile12.transform.position;
        locations[13] = tile13.transform.position;
        locations[14] = tile14.transform.position;
        locations[15] = tile15.transform.position;
        locations[16] = tile16.transform.position;
        locations[17] = tile17.transform.position;
        locations[18] = tile18.transform.position;
        locations[19] = tile19.transform.position;
        locations[20] = tile20.transform.position;
        locations[21] = tile21.transform.position;
        locations[22] = tile22.transform.position;
        locations[23] = tile23.transform.position;
        for (int i = 0; i < 24; i++)
            list[i] = i;
        int n = list.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        for (int i = 0; i < 24; i++)
            print(list[i]);
    }

    // Update is called once per frame
    void Update()
    {
        //tile1.transform.position = new Vector3(0.0f, 1.5f, 0.0f);
        tile0.transform.position = locations[list[0]];
        tile1.transform.position = locations[list[1]];
        tile2.transform.position = locations[list[2]];
        tile3.transform.position = locations[list[3]];
        tile4.transform.position = locations[list[4]];
        tile5.transform.position = locations[list[5]];
        tile6.transform.position = locations[list[6]];
        tile7.transform.position = locations[list[7]];
        tile8.transform.position = locations[list[8]];
        tile9.transform.position = locations[list[9]];
        tile10.transform.position = locations[list[10]];
        tile11.transform.position = locations[list[11]];
        tile12.transform.position = locations[list[12]];
        tile13.transform.position = locations[list[13]];
        tile14.transform.position = locations[list[14]];
        tile15.transform.position = locations[list[15]];
        tile16.transform.position = locations[list[16]];
        tile17.transform.position = locations[list[17]];
        tile18.transform.position = locations[list[18]];
        tile19.transform.position = locations[list[19]];
        tile20.transform.position = locations[list[20]];
        tile21.transform.position = locations[list[21]];
        tile22.transform.position = locations[list[22]];
        tile23.transform.position = locations[list[23]];
    }
}
