using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

[AddComponentMenu("Async/CoercionExample")]
public class CoercionExample : MonoBehaviour
{
    public float loopAmount = 1000;

    [SerializeField, HideInInspector]
    public string myName;

    private string yourName = "Name";

    [Header("Example variables")]
    [SerializeField]
    private string bing;
    [SerializeField]
    private int bong;
    [SerializeField]
    private Person foo;
    [SerializeField, Space(20)]
    private Color bar;

    void Start()
    {
        NullCoercion();
    }

    public struct Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetOld()
        {
            age++;
            Debug.Log(age);
        }
    }

    public void NullCoercion()
    {
        Person? vasko = null; // Keep in mind struct cannot be null by default

        vasko?.GetOld(); // Nothing happens

        var minko = vasko ?? new Person("Minko", 30); // Person {name: "Minko", age: 30}

        vasko ??= new Person("Vasil", 21); // Person {name: "Vasil", age: 21}

        vasko?.GetOld(); // Actually getting older

        //Debug.Log(vasko ?? 5); // Has to be same type 

        Dictionary<int, string> num2string = new Dictionary<int, string>();

        num2string.Add(8, "str");

        num2string = null;

        Debug.Log(num2string?[3]);
    }
}