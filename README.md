# Harif

## Tutorial

This YouTube tutorial provides a brief overview of how to use Harif. You can watch it here: [Harif Tutorial](https://www.youtube.com/watch?v=lsiGuLEkKgM)

## Problem definition

<p align="justify"> Each university in Iran provides a list of available classes for the coming semester weeks before the start of that semester. Then each student must choose some classes satisfying all rules obliged by the ministry of science and the university. Different students might have different preferences or tend to adopt different strategies for their educational careers. With this respect, each student must manually check available classes and select some according to his goals. However, this process usually is a time-consuming and laborious task due to several options and rules the students have to consider. Unfortunately, a student might want to pick a class. However, the class capacity will suddenly be filled due to the real-time nature of the course-selection process, in which several students are selecting classes simultaneously. In this case, the student must adjust his decisions as soon as possible and select other available classes. </p>

## What we did

<p align="justify">
To tackle all of the mentioned challenges, we propose an automatic course-selection system that can suggest classes to take, considering all rules and student preferences. In Harif, we create a directed graph in which each node represents a course, and each edge represents a set of constraints (e.g., requisite/prerequisite relationship between courses, some features from the student history, etc.) that must be satisfied if the student wants to take it. Additionally, in Harif, we make a list of other constraints. In particular, for each class, characteristics such as the available capacity of the class, its dates and times, the date and time of the final exam, etc., are added to the list of constraints that must be satisfied. Also, we consider three types of student preferences: Must, MustNot, and Preferred. We add the Must and MustNot preferences of the student to the list of constraints that must be satisfied. Afterwards, Harif searches for satisfactory solutions (i.e., each solution is a set of classes to pick for that semester satisfying all the specified constraints) in a predefined time. Each solution is scored and sorted according to the Preferred preferences of the student. Finally,  when the student selects one of the suggested solutions, Harif adopts the topological sort to give the student an acceptable permutation of the classes he wishes to pick in the coming semester.
</p>

## Some Statistics

Analysis and proposing method: 1 month

Implementation and evaluation: 1 month

Documentation: 1 month
