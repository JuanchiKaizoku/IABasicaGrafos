using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Edge
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public Node startNode;
public Node endNode;

public Edge(Node from, Node to){
    startNode = from;
    endNode = to;
}
}
