using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionView : NovoxElement {

void Start(){app.controller.DetectSuctionElements(); }
void Update(){app.controller.Suction(); }
void OntriggerEnter(){app.controller.DetectInside(); }
void OnTriggerExit(){app.controller.DetectExitInside(); }
}
