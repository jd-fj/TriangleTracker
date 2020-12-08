
Is it a triangle
Equilateal 
isosceles
scalene

if side1 > (side2 + side3) || (side2 > (side1 + side3)) || side 3 > (side1 + side2) // then it's not a triangle

Equal: all sides equal side1 == side2 == side3

(1, 2, 3) // IS a triangle 

-----------------------------------
Describe IsTriangle | (1,2,3) | is a triangle

Equilateral | (2, 2, 2) | is Equilateral

Isosceles: Exactly two sides are equal. side1 == side2 || side2 == side3 || side1 == side3

UI: Build out
Create constructor for new Triangle

User prompted to enter 3 separate lengths

Lengths are applied to side values

side values are instanciated into a new Triangle

newTriangle is passed through IsTriangle

If not Triangle, Program Writes "The Values you entered do not create a triangle, sorry :("

If newTriangle is a Triangle it will be passed through IsEquilateral, IsIsosceles and IsScalene. 

Program Writes in console which form of triangle is created from inputted values. 