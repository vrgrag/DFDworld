//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.U2D;

//public class DayAndNightChanger : MonoBehaviour
//{
//    //using System.Collections;
//    //using System.Collections.Generic;
//    //using UnityEngine;

//    //public class DayAndNightChanger : MonoBehaviour
//    //{
//    [SerializeField] Light2DBase Light;
//    [SerializeField] float day_time;
//    [SerializeField] float nihgt_time;
//    float TimeBeforeDayOrNight;
//    bool isNight;
//    void Start()
//    {
//        TimeBeforeDayOrNight = day_time;
//        isNight = false;
//    }

//    void Update()
//    {
//        if (TimeBeforeDayOrNight > 0)
//        {
//            TimeBeforeDayOrNight -= Time.deltaTime;
//        }

//        if (TimeBeforeDayOrNight <= 0 && !isNight)
//        {
//            TimeBeforeDayOrNight = nihgt_time;
//            isNight = true;
//            Light.intensity = 0.01f;
//        }


//        else if (TimeBeforeDayOrNight <= 0 && isNight)
//        {
//            TimeBeforeDayOrNight = day_time;
//            isNight = false;
//            Light.intensity = 10f;
//        }
//    }
//}

//    [SerializeField] Light Light;  // Лучше переименовать поле, чтобы избежать конфликта
//    [SerializeField] float day_time;
//    [SerializeField] float night_time;  // Исправлено
//    float TimeBeforeDayOrNight;
//    bool isNight;

//    void Start()
//    {
//        TimeBeforeDayOrNight = day_time;
//        isNight = false;
//    }

//    void Update()
//    {
//        if (TimeBeforeDayOrNight > 0)
//        {
//            TimeBeforeDayOrNight -= Time.deltaTime;
//        }

//        if (TimeBeforeDayOrNight <= 0 && !isNight)
//        {
//            // Переход на ночь
//            TimeBeforeDayOrNight = night_time;
//            isNight = true;
//            Light.intensity = 0.1f;
//        }
//        else if (TimeBeforeDayOrNight <= 0 && isNight)
//        {
//            // Переход на день
//            TimeBeforeDayOrNight = day_time;
//            isNight = false;
//            Light.intensity = 1f;
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal; // Add this for Light2D

public class DayAndNightChanger : MonoBehaviour
{
    [SerializeField] Light2D light2D;  // Correct type for 2D lights
    [SerializeField] float dayTime;    // Fix typo (nihgt_time to nightTime)
    [SerializeField] float nightTime;
    [SerializeField] float Changing_time;
    float timeBeforeDayOrNight;
    bool isNight;

    void Start()
    {
        timeBeforeDayOrNight = dayTime;
        isNight = false;
    }

    void Update()
    {
        if (timeBeforeDayOrNight > 0)
        {
            timeBeforeDayOrNight -= Time.deltaTime;
        }

        if (timeBeforeDayOrNight <= 0 && !isNight)
        {
            timeBeforeDayOrNight = nightTime;
            isNight = true;
        }
        else if (timeBeforeDayOrNight <= 0 && isNight)
        {
            timeBeforeDayOrNight = dayTime;
            isNight = false;
        }
        if (light2D.intensity > 0.1f && isNight)
        {
            light2D.intensity -= Time.deltaTime / Changing_time;
        }
        else if (light2D.intensity < 1f && !isNight)
        {
            light2D.intensity += Time.deltaTime / Changing_time;
        }
    }
}
