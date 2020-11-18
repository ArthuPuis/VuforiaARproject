using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInNear : MonoBehaviour
{
    public Camera cam = null;

    public GameObject BaseCard = null;
    public GameObject TreeCard = null;
    public GameObject GrassCard = null;
    public GameObject FlowerCard = null;
    public GameObject MushroomCard = null;
    public GameObject CancelCard = null;

    public GameObject Tree3D = null;
    public GameObject Grass3D = null;
    public GameObject Flower3D = null;
    public GameObject Mushroom3D = null;

    Vector3 BaseScreenPos;
    Vector3 TreeScreenPos;
    Vector3 GrassScreenPos;
    Vector3 FlowerScreenPos;
    Vector3 MushroomScreenPos;
    Vector3 CancelScreenPos;

    float distanceTree;
    float distanceGrass;
    float distanceFlower;
    float distanceMushroom;
    float distanceCancel;

    // Use this for initialization
    void Start()
    {

        Tree3D.SetActive(false);
        Grass3D.SetActive(false);
        Flower3D.SetActive(false);
        Mushroom3D.SetActive(false);
        print("assets invisible");
    }

    // Update is called once per frame
    void Update()
    {
        Distance BaseCardPos = BaseCard.GetComponent<Distance>();
        Distance TreePos = TreeCard.GetComponent<Distance>();
        Distance GrassPos = GrassCard.GetComponent<Distance>();
        Distance FlowerPos = FlowerCard.GetComponent<Distance>();
        Distance MushroomPos = MushroomCard.GetComponent<Distance>();
        Distance CancelPos = CancelCard.GetComponent<Distance>();

        BaseScreenPos = cam.WorldToViewportPoint(BaseCard.transform.position);
        TreeScreenPos = cam.WorldToViewportPoint(TreeCard.transform.position);
        GrassScreenPos = cam.WorldToViewportPoint(GrassCard.transform.position);
        FlowerScreenPos = cam.WorldToViewportPoint(FlowerCard.transform.position);
        MushroomScreenPos = cam.WorldToViewportPoint(MushroomCard.transform.position);
        CancelScreenPos = cam.WorldToViewportPoint(CancelCard.transform.position);

        distanceTree = Vector3.Distance(BaseScreenPos, TreeScreenPos);
        distanceGrass = Vector3.Distance(BaseScreenPos, GrassScreenPos);
        distanceFlower = Vector3.Distance(BaseScreenPos, FlowerScreenPos);
        distanceMushroom = Vector3.Distance(BaseScreenPos, MushroomScreenPos);
        distanceCancel = Vector3.Distance(BaseScreenPos, CancelScreenPos);

        if (BaseCardPos.goIn == true && TreePos.goIn == true)
        {
            print("distance vector = " + distanceTree);
            if (distanceTree < 0.37)
            {
                print("Tree visible");
                Tree3D.SetActive(true);
            }
        }

        if (BaseCardPos.goIn == true && GrassPos.goIn == true)
        {
            print("distance vector = " + distanceGrass);
            if (distanceGrass < 0.37)
            {
                print("grass visible");
                Grass3D.SetActive(true);
            }
        }

        if (BaseCardPos.goIn == true && FlowerPos.goIn == true)
        {
            print("distance vector = " + distanceFlower);
            if (distanceFlower < 0.37)
            {
                print("flower visible");
                Flower3D.SetActive(true);
            }
        }

        if (BaseCardPos.goIn == true && MushroomPos.goIn == true)
        {
            print("distance vector = " + distanceMushroom);
            if (distanceMushroom < 0.37)
            {
                print("mushroom visible");
                Mushroom3D.SetActive(true);
            }
        }

        if (BaseCardPos.goIn == true && CancelPos.goIn == true)
        {
            print("distance vector = " + distanceMushroom);
            if (distanceCancel < 0.37)
            {
                print("mushroom visible");
                Mushroom3D.SetActive(false);
                Tree3D.SetActive(false);
                Grass3D.SetActive(false);
                Flower3D.SetActive(false);
            }
        }

    }
}
