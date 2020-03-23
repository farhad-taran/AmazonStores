Amazon plans to open Amazon Go stores downtown in the city of Techlandia. Downtown Techlandia consists of city blocks, represented as a grid of M*N blocks. Each block represents either building denoted by 1 or open land area denoted by 0.
Adjacent blocks with value 1 are considered clusters of buildings. Diagonal blocks with value 1 are not considered part of the same cluster. Amazon plans to have an Amazon Go store in each cluster of buildings.

Write an algorithm to find the number of stores that Amazon can open in downtown Techlandia.
Input
The input to the function/method consists of three arguments:-
rows, an integer representing the number of rows in the grid;
column, an integer representing the number of columns in the grid;
grid, a two-dimensional integer array representing downtown Techlandia.

Output
Returns an integer representing the number of Amazon Go stores that Amazon could build in downtown Techlandia.
```
Example
Input:
rows = 5
column = 4
grid =
1 1 0 0
0 0 1 0
0 0 0 0
1 0 1 1
1 1 1 1

Output:
3
```
Explanation:
The first cluster is the two adjacent 1's in row one.
The second cluster is the 1 on row two, which is not adjacent to any other 1's (diagonal blocks are not considered part of the same cluster).
The third cluster is the set of seven adjacent 1's in rows four and five.
The total number of clusters of buildings in downtown Techlandia = 3.
```
Testcase 1:
Input:
4, 4, 
[[1, 1, 0, 0], 
 [0, 0, 0, 0], 
 [0, 0, 1, 1], 
 [0, 0, 0, 0]]

Expected Return Value:
2
```
```
Testcase 2:
Input:
7, 7,
[[1, 0, 0, 0, 0, 0, 0],
 [0, 1, 0, 0, 0, 0, 0],
 [0, 0, 1, 0, 0, 0, 0],
 [0, 0, 0, 1, 0, 0, 0],
 [0, 0, 0, 0, 1, 0, 0],
 [0, 0, 0, 0, 0, 1, 0],
 [0, 0, 0, 0, 0, 0, 1]]

Expected Return Value:
7
```
