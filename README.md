# Harif

## Abstract

<p align="justify"> Each university in Iran provides a list of available classes for the coming semester weeks before the start of that semester. Then each student must choose some classes satisfying all rules obliged by the ministry of science and the university. Different students might have different preferences or tend to adopt different strategies for their educational careers. With this respect, each student must manually check available classes and select some according to his goals. However, this process usually is a time-consuming and laborious task due to several options and rules the students have to consider. Unfortunately, a student might want to pick a class. However, the class capacity will suddenly be filled due to the real-time nature of the course-selection process, in which several students are selecting classes simultaneously. In this case, the student must adjust his decisions as soon as possible and select other available classes. To tackle all of the mentioned challenges, we propose an automatic course-selection system that can suggest classes to take, considering all rules and student preferences. </p>

## Overview

<p align="justify">
In Harif, we create a directed graph in which each node represents a course, and each edge represents a set of rules or constraints that must be satisfied if the student wants to take it. Additionally, in this graph, we make a list of other constraints. In particular, for each class, characteristics such as the available capacity of the class, its dates and times, final exam date and time, etc. are added to the list of constraints that must be satisfied. Also, we consider three types of student preferences: Must, MustNot, and Preferred. We add the Must and MustNot preferences of the student to the list of constrained that must be satisfied. Afterwards, Harif searches for satisfactory solutions (i.e., each solution is a set of courses to pick for that semester) in a predefined time. Each solution is scored and sorted according to the Preferred preferences of the student. Finally,  when the student selects one of the suggested solutions, Harif adopts the topological sort to give the student an acceptable permutation of the classes he wishes to pick in the coming semester.
</p>
