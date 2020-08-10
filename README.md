# List library

This repository contains the library of linked lists collection classes.

## Description

Library contains 2 implementation of linked lists for string values:
- SingleLinkedList represents the collection of string nodes where each node has a reference to the next node.
- DoubleLinkedList represents the collection of string nodes where each node has a reference to both the next and previous nodes.

Collection classes implements the interface ILinkedList with the following methods:
- Add - adds new node with the given string value to the list;
- Find - finds the node with the given string value;
- Remove - removes the given node from the list;
- ToArray - returns the array of all string values of the list;

## Tests

ListLibrary.Tests project