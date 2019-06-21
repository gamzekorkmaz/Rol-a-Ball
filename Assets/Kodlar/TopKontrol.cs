#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz = 1;
    public int sayac = 0;
    public int toplanacakObjeSayisi;
    public Text sayacText;
    public Text oyunBittiText;
    //public Button yeniOyunButon;
    //public Button cikisButon;
    //public Material yerMateryal;
	void Start ()
    {
        fizik = GetComponent<Rigidbody>();
        //rigitbody component i oluşturuldu

        //yeniOyunButon.gameObject.SetActive(false);
        //cikisButon.gameObject.SetActive(false);
    }
	
	void FixedUpdate ()
    {
        //yatay ve dikey ok tuşlarına basılıp basılmadığını anlamamız için aşağıyı yazıyoruz
        //böylece topun hareket edip etmediğini anlayacağız
        float yatay = Input.GetAxisRaw("Horizontal"); 
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey); //hangi eksende hareket olduğunu belirtir
        //top x ve z yönünde hareket etmeli. yukarı aşağı yanı y ekseninde hareket etmesine gerek yok

        fizik.AddForce(vec*hiz); //topa hiz değişkenine göre güç uygulatır
	}
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject); ---> temas edilen objeyi yok et. bu pek sağlıklı bir yöntem değil.
        //eğer sahnede başka trigger lar varsa onlar da yok olabilir. bunu engellemek için objelere "Engel" diye etiket verdik
        //bu etikete sahip olan objelerin görünürlüğünün kapatılmasını sağlıyoruz
        if (other.gameObject.tag == "Engel")
        {
            other.gameObject.SetActive(false);
            sayac++;
            /*System.Random rnd = new System.Random();
            int r = rnd.Next(0,255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            yerMateryal.color = new Color(r, g, b);*/
            sayacText.text = "Sayac = " + sayac;
            if (sayac == toplanacakObjeSayisi)
            {
                oyunBittiText.text = "OYUN BİTTİ!";
                /*yeniOyunButon.gameObject.SetActive(true);
                cikisButon.gameObject.SetActive(true);

                yeniOyunButon.onClick.AddListener(YeniOyun);
                cikisButon.onClick.AddListener(Cikis);
                */
            }
        }
    }
    /*OnTriggerEnter top objelere değince bir defa çalışır 
     *OnTriggerStay top objelere değdiği sürece çalışır
     *OntriggerExit top objelere değmeyi buraktığında çalışır
  */
  /*
    void YeniOyun()
    {
        SceneManager.LoadScene("level1");
    }
    void Cikis()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    */    
}
