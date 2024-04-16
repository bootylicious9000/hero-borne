using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddedAge = 1;
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Directional Light").GetComponent<Transform>();

        DirectionLight = GameObject.Find("Directional Light");

        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
        
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        Character hero = new Character();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Character villan = hero;
        villan.name = "Sir Kane the Bold";
        villan.PrintStatsInfo();


        Weapon HuntingBow = new Weapon("HuntingBow", 105);
        HuntingBow.PrintWeaponStats();

        Weapon WarBow = HuntingBow;
        WarBow.name = "WarBow";
        WarBow.damage = 155;
        WarBow.PrintWeaponStats();


        Paladin knight = new Paladin("Sir Arthur", HuntingBow);
        knight.PrintStatsInfo();

        

        ComputeAge();
    }

    /// <summary>
    /// Adding both variables together
    /// </summary>

    void ComputeAge() 
    {
        Debug.Log(CurrentAge + AddedAge);

        //This is where I would put the rest of my code...
        //IF I HAD SOME!
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
