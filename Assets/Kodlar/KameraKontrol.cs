using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    //şimdi amacımız kameranın top hareket ettikçe topla birlikte gitmesini sağlamak
    //bunun için önce topla kamera arasındaki mesafeyi buluyoruz
    //ardından topun ve kameranın pozisyonlarını aradaki mesafeyi koruyacak şekilde eşitliyoruz (update içindeki kısım)
    public GameObject top;
    Vector3 aradakiMesafe;
	void Start ()
    {
        aradakiMesafe = transform.position - top.transform.position;
        //mesafeyi 1 defa buldurmak yeterli
	}
	
	void LateUpdate () //LateUpdate tüm update lerden sonra çalışır. genelde kamera işlemlerinde bu tercih edilir. diğer update lerde görüntü titremesi gibi sıkıntılar oluşabilir
    {
        transform.position = top.transform.position + aradakiMesafe;
	}
}
