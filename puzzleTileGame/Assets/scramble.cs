using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


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
    Vector3[] locations2 = {
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1},
    new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 1, y = 1, z = 1}};
    private GameObject[] tiles;
    private static System.Random rng = new System.Random();
    int[] list = new int[24];
    int value;
    bool lclick;
    bool rclick;
    float inputLC = 0;
    float inputRC = 0;
    public GameObject canvas2;
    private Vector3 point;
    private GameObject cursorObject;
    private Ray ray;
    private GameObject fullImage;
    bool drag1;
    bool drag2;
    private GameObject currentTile;
    private GameObject newTile;
    private Vector3 storedVec;
    private Vector3 newVec;
    private bool hoverBool;
    private bool win = false;
    private GameObject bg;
    private GameObject gameOver;
    private int counter;
    //private float max = 999999f;
    //private int newRecord;
    // Use this for initialization
    void Start()
    {
        cursorObject = GameObject.Find("pointer");
        fullImage = GameObject.Find("GameObjectFull");
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
        locations2[0] = tile0.transform.position;
        locations2[1] = tile1.transform.position;
        locations2[2] = tile2.transform.position;
        locations2[3] = tile3.transform.position;
        locations2[4] = tile4.transform.position;
        locations2[5] = tile5.transform.position;
        locations2[6] = tile6.transform.position;
        locations2[7] = tile7.transform.position;
        locations2[8] = tile8.transform.position;
        locations2[9] = tile9.transform.position;
        locations2[10] = tile10.transform.position;
        locations2[11] = tile11.transform.position;
        locations2[12] = tile12.transform.position;
        locations2[13] = tile13.transform.position;
        locations2[14] = tile14.transform.position;
        locations2[15] = tile15.transform.position;
        locations2[16] = tile16.transform.position;
        locations2[17] = tile17.transform.position;
        locations2[18] = tile18.transform.position;
        locations2[19] = tile19.transform.position;
        locations2[20] = tile20.transform.position;
        locations2[21] = tile21.transform.position;
        locations2[22] = tile22.transform.position;
        locations2[23] = tile23.transform.position;
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
        tiles = GameObject.FindGameObjectsWithTag("tile").OrderBy(go => go.transform.GetSiblingIndex()).ToArray();
        //for (int i = 0; i < tiles.Length; i++)
        //    print(tiles[i]);
        //tiles[0] = tile0;
        //tiles[1] = tile1; tiles[2] = tile2; tiles[3] = tile3; tiles[4] = tile4; tiles[5] = tile5; tiles[6] = tile6;
        //tiles[7] = tile7; tiles[8] = tile8; tiles[9] = tile9; tiles[10] = tile10; tiles[11] = tile11; tiles[12] = tile12;
        //tiles[13] = tile13; tiles[14] = tile14; tiles[15] = tile15;
        //tiles[16] = tile16; tiles[17] = tile17; tiles[18] = tile18; tiles[19] = tile19; tiles[20] = tile20; tiles[21] = tile21; tiles[22] = tile22;
        //tiles[23] = tile23;
        lclick = false;
        rclick = false;
        canvas2 = GameObject.Find("Canvas2");
        hoverBool = false;
        newTile = GameObject.Find("pointer");
        storedVec = new Vector3(0, 0, 0);
        currentTile = GameObject.Find("pointer");
        bg = GameObject.Find("bg");
        bg.SetActive(false);
        gameOver = GameObject.Find("gameOver");
        gameOver.SetActive(false);
        counter = 0;
        //print(tile0.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        win = true;
        for (int i = 0; i < 24; i++)
            
            if ((Mathf.Abs(locations2[list[i]].x - locations[i].x) > 1) && (Mathf.Abs(locations2[list[i]].y - locations[i].y) > 1))
            {
                win = false;
                //print(i);
                //print(locations2[list[i]]);
                //print(locations[i]);
            }
        while (win) {
            counter += 1;
            if(counter > 120)
            {
                gameOver.SetActive(true);
            }
        }
        //tile1.transform.position = new Vector3(0.0f, 1.5f, 0.0f);
        if (inputRC == 0)
        {
            inputRC = Input.GetAxis("rclick");
            if (inputRC != 0)
            {
                rclick = !rclick;
            }
        }
        if (Input.GetAxis("rclick") == 0)
        {
            inputRC = 0;
        }
        if (rclick)
        {
            print("bargingo");
            Color myColor = fullImage.GetComponent<Image>().color;
            Graphic myGraphic = fullImage.GetComponent<Image>();
            fullImage.GetComponent<Image>().color = new Color(myColor.r, myColor.g, myColor.b, 1);
            canvas2.SetActive(false);
        }
        else
        {
            Color myColor = fullImage.GetComponent<Image>().color;
            Graphic myGraphic = fullImage.GetComponent<Image>();
            fullImage.GetComponent<Image>().color = new Color(myColor.r, myColor.g, myColor.b, 0);
            canvas2.SetActive(true);
            //print("no");
            if (inputLC == 0)
            {
                inputLC = Input.GetAxis("lclick");
                if (inputLC != 0)
                {
                    lclick = !lclick;
                }
            }
            if (Input.GetAxis("lclick") == 0)
            {
                inputLC = 0;
            }
            if (lclick)
            {
               // print("lckic");
                cursorObject.SetActive(true);
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                point = ray.origin + (ray.direction * 1f);
                //Debug.Log( "World point " + point );
                cursorObject.transform.position = point;
                //print("f");
                currentTile = cursorObject.GetComponent<trigger>().obj1;
                if (!hoverBool && cursorObject.GetComponent<trigger>().obj1Bool)
                {
                    hoverBool = true;
                    //bg.SetActive(true);
                    for (int i = 0; i < 24; i++)
                    {
                        //print(currentTile);
                        //print(cursorObject.GetComponent<trigger>().obj1);
                        //print(tiles[i]);
                        if (currentTile == tiles[i])
                        {
                            storedVec = locations2[list[i]];
                            //print(i);
                        }
                    }
                    bg.SetActive(true);
                    bg.transform.position = storedVec;
                    //print(bg);
                    //print(currentTile);
                    //print(storedVec);
                    //bg.SetActive(false);
                }
                currentTile.transform.position = point;
                currentTile.GetComponent<RectTransform>().SetAsLastSibling();

            }
            else if(!lclick && (inputLC > 0))
            {
                if ((inputLC > 0) && hoverBool);
                {
                    hoverBool = false;
                    //bg.SetActive(false);
                    //storedVec = new Vector3(0, 0, 0);
                    newTile = cursorObject.GetComponent<trigger>().obj2;
                    for (int i = 0; i < 24; i++)
                    {
                        if (newTile == tiles[i])
                        {
                            newVec = tiles[i].transform.position;
                            //print("yus");
                        }
                    }
                    if (newTile == GameObject.Find("bg"))
                    {
                        //print(storedVec);
                        currentTile.transform.position = storedVec;
                        newTile.transform.position = storedVec;
                        newVec = storedVec;
                    }
                    else
                    {
                        //print("test");
                        currentTile.transform.position = newVec;
                        newTile.transform.position = storedVec;
                        for (int i = 0; i < 24; i++)
                        {
                            if (newTile == tiles[i])
                            {
                                locations2[list[i]] = newTile.transform.position;
                            }
                            if (currentTile == tiles[i])
                            {
                                locations2[list[i]] = currentTile.transform.position;
                            }
                        }
                    }
                    /*
                    for (int i = 0; i < 24; i++) {
                        if (((currentTile.transform.position.x - locations[i].x) + (currentTile.transform.position.y - locations[i].y)) < max)
                        {
                            newRecord = i;
                            max = ((currentTile.transform.position.x - locations[i].x) + (currentTile.transform.position.y - locations[i].y));
                            print(max);
                        }
                    }
                    print(newRecord);
                    print(tiles[newRecord]);
                    newRecord = 999999;
                    max = 999999f;
                    */
                }
                bg.SetActive(false);
                cursorObject.GetComponent<trigger>().obj1 = cursorObject;
                cursorObject.GetComponent<trigger>().obj1Bool = false;
                cursorObject.GetComponent<trigger>().obj2 = cursorObject;
                cursorObject.GetComponent<trigger>().obj2Bool = false;
                cursorObject.SetActive(false);
            }
        }
    }
 }