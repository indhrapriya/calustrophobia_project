using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Xml;
using System.Xml.Linq;

public class RoomConfig : MonoBehaviour {
	private string width;
	private string height;
	private string length;
	private string people;

	public void setWidth(string width){
		//this.width = int.Parse(width);
		this.width = width;
		Debug.Log(width.ToString());
	}
	public void setHeight(string height){
		//this.width = int.Parse(width);
		this.height = height;
		Debug.Log(height.ToString());
	}
	public void setLength(string length){
		//this.width = int.Parse(width);
		this.length = length;
		Debug.Log(length.ToString());
	}
	public void setPeople(string people){
		//this.width = int.Parse(width);
		this.people = people;
		Debug.Log(people.ToString());
	}

	public void config(){
		Debug.Log("width: "+width+" height: "+height+" length: "+length+" people:"+people );
		//XmlWriterSettings settings = new XmlWriterSettings();
		//settings.Indent = true;
		//XmlWriter writer = XmlWriter.Create("roomConfig.xml", settings);

		/*XmlDocument doc = new XmlDocument();
		doc.Load("config.xml");
		XmlNode root = doc.DocumentElement;
		XmlNode myNode = root.SelectSingleNode("scaleX");
		myNode.InnerText = width;
		Debug.Log ("myNode.InnerText = "+myNode.InnerText);
		doc.Save("config.xml");*/
		XElement doc = XElement.Load("config.xml");
		Debug.Log("config: "
		          +doc.Element ("scaleX").Value
		          +" scaleY: "+doc.Element ("scaleY").Value
		          +" scaleZ: "+doc.Element ("scaleZ").Value
		          );
		doc.Element ("scaleX").Value = width;
		doc.Element ("scaleY").Value = height;
		doc.Element ("scaleZ").Value = length;
		//doc.Element ("count").Value = people;
		doc.Save("config.xml");
		Application.LoadLevel ("main_scene");
	}
}
