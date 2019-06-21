using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanacakObjeKontrol : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
        //toplanacak objelerin kendi etrafında dönmesini istiyoruz. aşağıdaki kodda bunu yapıyoruz.
        //Time.deltaTime ile çarpmamızın sebebi dönüş hızını yavaşlatmak. bu değer bize Update metodunun çağırılma süresini veriyor. rotate i bununla çarpınca dönüş hızı yavaşlıyor.
        transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime);
	}
}
